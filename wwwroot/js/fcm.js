import firebase from "firebase/app";
import "firebase/messaging";
var vapidKey = 'BMTF1ghAyW9uU5zPKFzgSpZ8sjG0u38mnXDEVU-tKmCGeHCm1oC42PU2TW4e3rVs3rh_FD9EgbrJjKq8FrZC96s';
var currentToken = '';

var firebaseConfig = {
    apiKey: "AIzaSyDtWWNQOi9MAzujXMzcrr41UFN309OyhxU",
    authDomain: "jmm-erp.firebaseapp.com",
    projectId: "jmm-erp",
    storageBucket: "jmm-erp.appspot.com",
    messagingSenderId: "2306434052",
    appId: "1:2306434052:web:828aaccdea7318f31f8151",
    measurementId: "G-7DPH45X3NT"
};
// Initialize Firebase
firebase.initializeApp(firebaseConfig);
firebase.analytics();

function getMessagingObject() {
    const messaging = firebase.messaging();
}

function receiveMessage() {
    const messaging = firebase.messaging();

    messaging.onMessage((payload) => {
        console.log('Message received. ', payload);
        // ...
    });
}

function getToken() {
    const messaging = firebase.messaging();

    messaging.getToken({ vapidKey: vapidKey }).then((currentToken) => {
        if (currentToken) {
            // Send the token to your server and update the UI if necessary
            // ...
        } else {
          
            console.log('No registration token available. Request permission to generate one.');
         
        }
    }).catch((err) => {
        console.log('An error occurred while retrieving token. ', err);

    });
    // [END messaging_get_token]
}

function requestPermission() {

    Notification.requestPermission().then((permission) => {
        if (permission === 'granted') {
            console.log('Notification permission granted.');

        } else {
            console.log('Unable to get permission to notify.');
        }
    });
}

function deleteToken() {
    const messaging = firebase.messaging();
                 
    messaging.deleteToken().then(() => {
        console.log('Token deleted.');
    }).catch((err) => {
        console.log('Unable to delete token. ', err);
    });
}