function initAutoComplete() {
    Vue.component('autocomplete', {
        // props: ['list'],
        data() {
            return {
                input: null,
                list: null,
            }
        },
        template: `<div>
   <input  v-model="input"  @@input="search" type="text"  class="form-control search-bar-ltr" placeholder="@Localizer["Search"]" />
    <div class="autocomplete-suggestion autocomplete-selected" v-if="input">
                <div v-for="(item, i) in list" :key="i" @@click="onItemSelect(item)"  class="card p-2">
                    <div class="d-flex justify-content-between">
                        <p class="text-main mb-0 mt-0">ID: {{item.ItemID}}</p>
                        <p class=" mb-0 mt-0">Cost Price: {{item.CostPrice}}</p>
                    </div>
                    <div class="d-flex justify-content-between">
                        <p class=" mb-0 mt-0">Category: {{item.Category}} </p>
                    </div>
                    <div class="d-flex justify-content-between">
                        <p class=" mb-0 mt-0">@Localizer["Reserve"]: {{item.ReserveQuantity}}</p>
                        <p class="ml-1  mb-0 mt-0">@Localizer["On Hand Quantity"]: {{item.OnhandQuantity}}</p>
                        <p class=" mb-0 mt-0 text-main" v-if="item.OnhandQuantity > 0">@Localizer["In Stock"]</p>
                        <p class=" mb-0 mt-0 text-danger" v-if="item.OnhandQuantity <= 0">@Localizer["Out of Stock"]</p>
                    </div>
                </div>
    </div>
</div>`,
        methods: {
            onItemSelect(item) {
                this.$emit('onitemselect', item);
                this.input = null;
            },
            search(e) {

                this.searchInput = e.target.value;
                if (this.searchInput && this.searchInput !== "") {
                    fetch(`/api/Items/?query=${this.searchInput}`,
                        {
                            method: 'get',
                        })
                        .then(response => {
                            response.json()
                                .then(data => {
                                    var mappedData = $.map(data, function (dataItem) {
                                        return {
                                            value: dataItem.value,
                                            ItemID: dataItem.ItemID,
                                            SrNo: dataItem.SrNo,
                                            SellPrice: dataItem.SellPrice,
                                            CostPrice: dataItem.CostPrice,
                                            Discount: dataItem.Discount,
                                            Quantity: dataItem.Quantity <= 0 ? 0 : 1,
                                            Category: dataItem.Category,
                                            Location: dataItem.Location,
                                            ShelfNo: dataItem.ShelfNo,
                                            UnitID: dataItem.Units,
                                            StartQuantity: dataItem.Quantity,
                                            OnhandQuantity: dataItem.OnHand,
                                            ReserveQuantity: dataItem.Reserved
                                        }
                                    });
                                    this.list = mappedData;
                                })
                                .catch(err => {
                                    console.log(err);
                                });
                        })
                        .catch(err => {
                            console.log(err);
                        })
                }
            },
        }
    })
}
function initVue() {
    vueApp = new Vue({
        el: '#invoice-app',
        data: {
            taxRate: 15,
            discountRate: 0,
            items: [],
            referenceNumber: null,
            errors: [
                {
                    description: '',
                    quantity: '',
                    price: '',
                    vat_percentage: '',
                    discount_percentage: '',
                    discount_amount: '',
                    location: '',
                    shelfNumber: '',
                },
            ],
        },
        methods: {
            addNewItem: function (item) {
                var alreadyAdded = this.items.filter((value) => {
                    return value.itemID === item.ItemID;
                }).length > 0;

                if (alreadyAdded) {
                    alert("Item Already Added");
                    return;
                }

                if (item.OnhandQuantity == 0 && item.ReserveQuantity == 0) {
                    alert("No Quantity Available Cannot Add");
                }
                else if (item.OnhandQuantity == 0 && item.ReserveQuantity != 0) {
                    alert("No On Hand Quantity Available for this Item are you sure to add this?");
                }

                var itemToAdd = {
                    itemID: item.ItemID,
                    fullName: item.value,
                    costPrice: item.CostPrice,
                    sellPrice: item.SellPrice,
                    discountPercentage: 0,
                    discountAmount: 0,
                    onHandQuantity: item.OnhandQuantity,
                    reservedQuantity: item.ReserveQuantity,
                    inputQuantity: 0,
                    location: item.Location,
                    shelfNumber: item.ShelfNo,
                    units: item.UnitID,
                    UnitID: null,
                    totalVat: 0,
                    subTotalExclVat: 0,
                    subTotalInclVat: 0,
                }

                this.items.push(itemToAdd);
                this.errors.push(
                    {
                        itemID: '',
                        fullName: '',
                        costPrice: '',
                        discountPercentage: '',
                        discountAmount: '',
                        inputQuantity: '',
                        location: '',
                        shelfNumber: '',
                        units: '',
                    });
            },
            deleteItem: function (index) {
                this.items.splice(index, 1)
            },
            decimalDigits: function (value) {
                return value.toFixed(2);
            },
            printInvoice: function () {
                window.print();
            },
            onItemSelect(e) {
                this.addNewItem(e)

            },
            handleInput(e) {
                this.searchInput = e
            },
            removeItem: function (index) {
                this.items = this.items.filter((value, i) => {
                    return i != index;
                });

                this.errors = this.errors.filter((value, i) => {
                    return i != index;
                });
            },
            proceed: function () {
                if (this.items.length == 0) {
                    $('#emptyListWarning').modal('toggle');
                } else if (!$('#ReferenceNumber').val()) {

                    $('#ReferenceNumberWarning').modal('toggle');
                } else if (!$('#SupplierName').val()) {
                    $('#SelectSupplierWarning').modal('toggle');
                } else if (this.items.length > 0) {
                    $('#invoice').css('display', 'block');
                }
            }
        },
        computed: {
            subTotal: function () {
                var total = this.items.reduce(function (accumulator, item) {
                    return accumulator + (item.price * item.quantity);
                }, 0)
                return total;
            },
            discountTotal: function () {
                var total = this.subTotal * (this.discountRate / 100);
                return total;
            },
            taxTotal: function () {
                var total = (this.subTotal - this.discountTotal) * (this.taxRate / 100);
                return total;
            },
            grandTotal: function () {
                var total = (this.subTotal - this.discountTotal) + this.taxTotal;
                return total;
            },
        },
    });
}
function initRowComponent() {
    Vue.component('itemrow', {
        props: ['vaterate', 'item'],
        template: `<tr>
            <td style='width:80px'>{{item.itemID}}</td>
            <td style='width:180px'>{{item.fullName}}</td>
            <td style="width:150px"><input type='number' name="CostPrice" @@input="validatePrice($event,item)" v-model="item.costPrice"  class="form-control"/></td>
            <td style="width:150px"><input type='number' name='Quantity'  @@input="validateQuantity($event,item)" class='form-control' min='0' :max="item.onHandQuantity + item.reservedQuantity" v-model="item.inputQuantity"/></td>
            <td><input class='form-control valid border-0 text-right'  type='number' name='VATPercentage' v-model="vaterate" disabled/></td>
            <td  style="width:150px"><input name='DiscountPercentage' type='number' class='form-control text-right' id='DiscountPercentage' v-model="item.discountPercentage" @@change="onDiscountPercentageChange($event,item)" :disabled="item.discountAmount != ''  && !isNaN(item.discountAmount)"/></td>
            <td style="width:150px"><input name='DiscountAmount' type='number' class='form-control text-right' id='DiscountAmount' v-model="item.discountAmount" @@change="onDiscountAmountChange($event,item)" :disabled="item.discountPercentage != ''  && !isNaN(item.discountPercentage)"></td>
            <td>
                <select name='Location'    class='browser-default custom-select location w-75 form-control text-dark valid' v-model="item.location">
                    <option value='1' selected="item.locaiton == 1"> Warehouse </option>
                    <option value='0' selected="item.location == 0"> Shop </option>
                </select>
            </td>
            <td style='width: 150px'>
                <input type='text' class='form-control' v-if="item.location == 0" v-model="item.shelfNumber"  />
            </td>
            <td>
                <select name='UnitID'  class='browser-default custom-select form-control' v-model="item.UnitID" >
                    <option selected value="-1">Please select a unit</option>
                    <option v-for="option in item.units" v-bind:value="option.id" > {{option.unit}} </option>
                </select>
            </td>
            <td class='text-right'>{{totalVat}}</td>
            <td class='text-right'>{{subTotalExclVat}}</td>
            <td class='text-right'>{{subTotalInclVat}}</td>
            <td style="width:100px"><a class="btn btn-outline-danger btn-sm" @@click="$emit('removeitem')">Remove</a></td>
            </tr>`,
        methods: {
            onItemSelect(item) {
                this.$emit('onitemselect', item);
            },
            search(e) {
                this.searchInput = e.target.value;
                if (this.searchInput && this.searchInput !== "") {
                    fetch(`/api/Items/?query=${this.searchInput}`,
                        {
                            method: 'get',
                        })
                        .then(response => {
                            response.json()
                                .then(data => {
                                    var mappedData = $.map(data, function (dataItem) {
                                        return {
                                            value: dataItem.value,
                                            ItemID: dataItem.ItemID,
                                            SrNo: dataItem.SrNo,
                                            SellPrice: dataItem.SellPrice,
                                            CostPrice: dataItem.CostPrice,
                                            Discount: dataItem.Discount,
                                            Quantity: dataItem.Quantity <= 0 ? 0 : 1,
                                            Category: dataItem.Category,
                                            Location: dataItem.Location,
                                            ShelfNo: dataItem.ShelfNo,
                                            UnitID: dataItem.Units,
                                            StartQuantity: dataItem.Quantity,
                                            OnhandQuantity: dataItem.OnHand,
                                            ReserveQuantity: dataItem.Reserved
                                        }
                                    });
                                    this.list = mappedData;
                                })
                                .catch(err => {
                                    console.log(err);
                                });
                        })
                        .catch(err => {
                            console.log(err);
                        })
                }
            },
            onDiscountPercentageChange($event, item) {

                if (item) {
                    var currentValue = item.discountPercentage;
                    if (isNaN(currentValue)) {
                        $event.target.setCustomValidity("Invalid Value");
                        $event.target.reportValidity();
                    } else {
                        if (currentValue > 100) {
                            $event.target.setCustomValidity("Discount % Cannot be Greater than 100");
                            $event.target.reportValidity();
                        }

                    }
                }

            },
            onDiscountAmountChange($event, item) {
                if (item) {
                    var _discount_amount = item.discountAmount;
                    var _current_price = item.costPrice;
                    var _current_quantity = item.inputQuantity;

                    if (_discount_amount > _current_quantity * _current_price) {
                        $event.target.setCustomValidity("Discount Amount Cannot be Greater than Total Amount");
                        $event.target.reportValidity();
                    }
                } else {
                    console.log("Invalid Array Index");
                }
            },
            decimalDigits: function (value) {
                var floatNum = parseFloat(value);
                return parseFloat(floatNum.toPrecision(2));
            },
            validateQuantity: function (event, item) {
                if (isNaN(item.inputQuantity)) {
                    event.target.setCustomValidity("Required");
                    event.target.reportValidity();
                } else if (item.inputQuantity > item.onHandQuantity + item.reservedQuantity) {
                    event.target.setCustomValidity("Not Enough Quantity Available");
                    event.target.reportValidity();
                }
            },
            validatePrice: function (event, item) {
                if (isNaN(item.costPrice)) {
                    event.target.setCustomValidity("Required");
                    event.target.reportValidity();
                } else if (item.costPrice <= 0) {
                    event.target.setCustomValidity("Cost Price Cannot be Zero");
                    event.target.reportValidity();
                }
            }

        },
        computed: {
            totalVat: function () {
                return (this.item.inputQuantity * this.item.costPrice) * this.vaterate / 100;
            },
            subTotalExclVat: function () {
                return (this.item.costPrice * this.item.inputQuantity);
            },
            subTotalInclVat: function () {
                return (this.subTotalExclVat + this.totalVat);
            }
        }
    })
}
