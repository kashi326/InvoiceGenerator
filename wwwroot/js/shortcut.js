$(function () {
    $(".open_reminder").click(function () {
        $(".reminder_screen1").css("display", "flex");
        $(this).closest('.add_btns').css('display', 'none')
    })
    $(".create_reminder_btn1").click(function () {
        $(".reminder_screen1").css("display", "none");
        $(".reminder_screen2").css("display", "flex");
    })
    $("#save_reminder").click(function () {
        $(".reminder_screen1").css("display", "none");
        $(".reminder_screen2").css("display", "none");
        $(".reminder_screen3").css("display", "flex");
    })

    $(".creatrmb").click(function () {
        $(".reminder_screen2").css("display", "flex");
        $(".reminder_screen1").css("display", "none");
        $(".reminder_screen3").css("display", "none");
    })
    $('.note_parent').click(function () {
        $('.add_btns').css("display", 'block');
    })
    $(".open_note").click(function () {
        $(".add_note1").css("display", "flex");
        $(this).closest('.add_btns').css('display', 'none')
    })
    $(".addbtn1").click(function () {
        $(".add_note1").css("display", "none");
        $(".add_note3").css("display", "flex");
    })
    $(".addbtn2").click(function () {

        $(".add_note3").css("display", "none");
        $(".add_note5").css("display", "flex");
    })
    $(".addbtn3").click(function () {

        $(".add_note3").css("display", "flex");
        $(".add_note5").css("display", "none");
    })
    $("#move_back").click(function () {
        $(".add_note1").css("display", "flex");
        $(".add_note3").css("display", "none");
    })
    //$('.icon').hover(function () {
    //    setTimeout(() => { $('.onhover_display').css('display', 'inline'); }, 100);
    //},
    //    function () {
    //        var e = document.querySelectorAll(".onhover_display");
    //        for (var i = 0; i < e.length; i++) {
    //            e[i].style.display = 'none';
    //        }
    //    })
    //$(".supplier").click(function () {
    //    if (!$(this).hasClass('toggle')) {
    //        if ($(this).hasClass('offclass'))
    //            $(this).removeClass('offclass')

    //        $(this).addClass('toggle')
    //        if ($(".customer").hasClass('toggle'))
    //            $(".customer").removeClass('toggle')

    //        $(".customer").addClass('offclass')

    //    }


    //})
    //$(".customer").click(function () {
    //    if (!$(this).hasClass('toggle')) {
    //        if ($(this).hasClass('offclass'))
    //            $(this).removeClass('offclass')
    //        $(this).addClass('toggle')

    //        if ($(".supplier").hasClass('toggle'))
    //            $(".supplier").removeClass('toggle')
    //    }
    //})

    $(".close_screen").click(function () {
        $(this).parent().css("display", "none")
        $('.reminder_note').css('display', 'none');
        $('div[class*=add_note]').css('display', 'none');
    })
    $('#shortcutCreateProject').click(function(){
        $('#SelectCustomerShortcut').modal('toggle')
    })
    $('#minusAmount').click(function () {
        var value = $('#targetAmountInput').val();
        intValue = parseFloat(value);
        if (intValue > 0)
            $('#targetAmountInput').val(intValue - 1)
    });
    $('#plusAmount').click(function () {
        var value = $('#targetAmountInput').val();
        intValue = parseFloat(value);
        $('#targetAmountInput').val(intValue + 1)
    });
})
let keys = {
    UP: 38,
    DOWN: 40,
    ENTER: 13,
};
let presetTimes = [
    {
        name: 'Morning',
        time: '08:00'
    },
    {
        name: 'Afternoon',
        time: '13:00'
    },
    {
        name: 'Evening',
        time: '18:00'
    }
];
const picker = document.querySelector('.picker');

const input = document.querySelector('.picker__input');
let list = document.querySelector('.picker__list');

let items = document.querySelectorAll('.picker__list li');
items = [...items];

let incrementButtons = document.querySelectorAll('.picker__increment');
incrementButtons = [...incrementButtons];

let presetRow = document.querySelector('.picker__presets');

/**
* Create markup for preset buttons
*/
presetTimes.forEach(item => {
    let html = `<button type="button" class="picker__period" data-time="${item.time}" aria-pressed="false" aria-label="Select '${item.name}' at ${item.time}" title="${item.name} (${item.time})">${item.name}</button>`;
    presetRow.insertAdjacentHTML('beforeend', html);
})

let presetButtons = document.querySelectorAll('.picker__period');
presetButtons = [...presetButtons];

/**
* Open the time dropdown
*/
const openDropdown = () => {
    list.classList.add('is-open');
    input.setAttribute('aria-expanded', 'true');
}

/**
* Close the time dropdown
*/
const closeDropdown = () => {
    list.classList.remove('is-open');
    input.setAttribute('aria-expanded', 'false');
}

/**
 * Traverses previous siblings until it finds one with matching class or null
 */
const prevUntil = (el, className) => {
    console.log('prevuntil', el, className);
    while (el.previousElementSibling && !el.previousElementSibling.classList.contains(className)) {
        el = el.previousElementSibling;
    }
    return el.previousElementSibling;
}

/**
 * Traverses next siblings until it finds one with matching class or null
 */
const nextUntil = (el, className) => {
    console.log('nextUntil', el, className);
    while (el.nextElementSibling && !el.nextElementSibling.classList.contains(className)) {
        el = el.nextElementSibling;
    }
    return el.nextElementSibling;
}

/**
 * Traverse the dropdown list in a given direction
 */
const traverseList = (direction = 'next') => {
    let item = list.querySelector('.picker__item.is-highlighted');
    if (item) {
        item.classList.remove('is-highlighted');
        item.setAttribute('tabindex', -1);

        if (direction == 'prev') {
            item = prevUntil(item, 'picker__item');

            if (item == null) {
                item = list.lastElementChild;
            }
        } else {
            item = nextUntil(item, 'picker__item');

            if (item == null) {
                item = list.firstElementChild;
            }
        }

        item.focus();
        item.setAttribute('tabindex', 0);
        item.classList.add('is-highlighted');
    }
}

/**
 * Traverse dropdown list if using arrow keys
 * @param  {[type]} e [description]
 */
const handleKeyNavigation = (e) => {
    if (!e) e = window.event;
    let keyCode = e.keyCode || e.which;

    if (keyCode == keys.UP || keyCode == keys.DOWN) {
        e.preventDefault();
        e.stopPropagation();
    }

    if (keyCode == keys.UP) {
        traverseList('prev');
    }

    if (keyCode == keys.DOWN) {
        traverseList('next');
    }

    if (keyCode == keys.ENTER) {
        if (e.target.matches('li')) {
            deativateAllPreset();
            selectDropDownTime(e.target);

            e.stopPropagation();
        }
    }

    return false;
}

/**
 * Key event listeners for input and the dropdown
 */
input.addEventListener('keydown', (e) => {
    handleKeyNavigation(e);
});
list.addEventListener('keydown', (e) => {
    handleKeyNavigation(e);
});

/**
* Find a list item with a similar time
*/
const findDropDownTime = (time) => {
    let parts = time.split(':');
    let minutes = parseInt(parts[1]);

    if (minutes < 30) {
        minutes = '00';
    } else if (minutes > 30) {
        minutes = '30';
    }

    time = `${parts[0]}:${minutes}`;

    return items.find(item => item.innerText == time);
}

/**
* Suggest a time from the dropdown when opening it
*/
const suggestDropDownTime = (time) => {
    let item = findDropDownTime(time);
    item.classList.add('is-highlighted');
    item.scrollIntoView();
}

/**
* Selects a time from the dropdown
*/
const selectDropDownTime = (item) => {
    let time = item.innerText;
    setTime(time);

    item.setAttribute('aria-selected', 'true');
    list.setAttribute('aria-activedescendant', item.id);

    closeDropdown();
}

/**
* List / List items event listeners
*/
list.addEventListener('click', (e) => {
    console.log('list click', e.target);

    if (e.target.matches('li')) {
        deativateAllPreset();
        selectDropDownTime(e.target);

        e.stopPropagation();
        e.preventDefault(); // Needed to prevent refocus

        return false;
    }
});

/**
* Input field main event listener
*/
input.addEventListener('focusin', () => {
    openDropdown();
    suggestDropDownTime(input.value);
});

/**
* Preset buttons event listeners
*/
presetButtons.forEach(button => {
    button.addEventListener('click', () => {
        togglePreset(button);
        setTime(button.getAttribute('data-time'));
    });

    button.addEventListener('focusin', () => {
        closeDropdown();
    });
})

/**
* Activate a preset button
*/
const activatePreset = (button) => {
    button.setAttribute('aria-pressed', 'true');
    button.classList.add('is-pressed');

    presetRow.classList.add('has-preset');
}

/**
* Deactivate a single preset button
*/
const deactivatePreset = (button) => {
    button.setAttribute('aria-pressed', 'false');
    button.classList.remove('is-pressed');
}

/**
* Deactivate all preset buttons
*/
const deativateAllPreset = () => {
    if (presetRow.classList.contains('has-preset')) {
        presetRow.classList.remove('has-preset');

        presetButtons.forEach(button => {
            deactivatePreset(button);
        })
    }
}

/**
* Activate a preset button, deactivate siblings
*/
const togglePreset = (button) => {
    deativateAllPreset();
    activatePreset(button);
}

/**
* Set the time in the input to a set time, or by increment '+00:05' / '-00:05';
*/
const setTime = (time) => {
    let operation;
    let operator;

    // Clear previously active dropdown items, remember to activate after if relevant
    list.setAttribute('aria-activedescendant', '');
    items.forEach(item => {
        item.classList.remove('is-highlighted');
        item.setAttribute('aria-selected', 'false');
    })

    if (time.includes('+')) {
        operator = '+';
        operation = (a, b) => a + b;
    } else if (time.includes('-')) {
        operator = '-';
        operation = (a, b) => a - b;
    }

    if (operation) {
        time = time.replace(operator, '');
        let partsNew = time.split(':');
        let partsOld = input.value.split(':');
        let minutes = operation(parseInt(partsOld[1]), parseInt(partsNew[1]));
        let hours = operation(parseInt(partsOld[0]), parseInt(partsNew[0]));

        if (minutes > 59) {
            hours += 1;
            minutes = minutes - 60;
        } else if (minutes < 0) {
            hours -= 1;
            minutes = 60 + minutes;
        }

        if (hours > 23) {
            hours = 0;
        } else if (hours < 0) {
            hours = 23;
        }

        time = `${hours.toString().padStart(2, '0')}:${minutes.toString().padStart(2, '0')}`;
    }

    // Toggle a preset button if the new time matches a preset
    let matchingPreset = document.querySelector(`.picker__period[data-time="${time}"]`);
    if (matchingPreset) {
        togglePreset(matchingPreset);
    }

    input.value = time;
}

/**
* Increment buttons event listeners
*/
incrementButtons.forEach(button => {
    button.addEventListener('click', () => {
        deativateAllPreset();
        setTime(button.getAttribute('data-time'));
    });
    button.addEventListener('focusin', () => {
        closeDropdown();
    });
})

/**
* Close the dropdown only if clicking outside it
* @consideration also close if something other than its children gets focus? 
*/
document.addEventListener('click', (e) => {
    if (!picker.contains(e.target) || e.target == picker) {
        closeDropdown();
    }
})

// Start off the demo
togglePreset(document.querySelector(`.picker__period[data-time="${input.value}"]`));
