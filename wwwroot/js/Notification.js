

"use strict";
var connection = new signalR.HubConnectionBuilder()
    .withUrl("/notificationHub")
    .configureLogging(signalR.LogLevel.Information)
    .build();


async function start() {
    try {

       
        await connection.start();
        sessionStorage.setItem('singalr_connection_id', connection.connectionId);
       

       

          
      
       
    } catch (err) {
        console.log(err);
    }
}
async function checkAndRestart() {
    if (connection.connectionState == "Connected") {
       
        //Do Nothing
      
      
    }
    else if (connection.connectionState == "Disconnected") {
        await start();
    }
}

connection.on("ReceiveNotification", (message) => {
   
    var notification = JSON.parse(message);
    console.log("Receive Notification");
    console.log(notification);
    




    //testing to implement circle
    var count = Number(notification.Id) || 0
    localStorage.setItem("Countings", count);
    


    localStorage.setItem("Counting", count + 1);
   
    var getCount = localStorage.getItem("Counting");
    var bell = document.querySelector('#Circle');
    var span = document.querySelector("#Count");
    if (count < getCount) {
        
     
        /* bell.classList.add('.count')*/

        span.classList.add('count')
        bell.classList.add('circle')
    }
    else {

       
       /* bell.classList.remove('.count')*/
    }


   
    var element = `<a id="${notification.Id}" href="${notification.ActionLink}">

<img src="/Image/${notification.Path}"  alt="img">
                                                <div class="text">
                                                    <h4>${notification.Title}</h4>
                                                    <p>${notification.Description}</p>
                                                    
                                                </div>
                                            </a>`;
   
    if ($(`#${notification.Id}`).length == 0) {
       
        $('#notificationList').prepend(element);
     
       

    }
    
});
connection.on("ReceiveReminder", (reminder) => {

    var _reminder = JSON.parse(reminder);
    console.log("Receive Reminder");
    console.log(_reminder);
   
    var element = `<a href="#"><img src="https://img.icons8.com/flat_round/64/000000/vote-badge.png" alt="img">
                                                <div class="text">
                                                    <h4>${_reminder.NameEnglish}</h4>
                                                    <p>${_reminder.ReminderName}</p>
                                                </div>
                                            </a>`;
    $('#notificationList').prepend(element);
});
start();
setTimeout(checkAndRestart, 10000);









