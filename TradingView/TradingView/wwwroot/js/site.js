$(document).ready(function () {
    var EmailRegEx = /@/;



    var connection = new WebSocketManager.Connection("ws://localhost:49912/Chat/chatservice");
    connection.enableLogging = true;

    connection.connectionMethods.onConnected = () => {

    }

    connection.connectionMethods.onDisconnected = () => {

    }


    connection.clientMethods["pingMessage"] = (socketId, message) => {
         
        var messageText = socketId + ': ' + message;
        $('#messages').append('<li>' + messageText + '</li>');
        $('#messages').scrollTop($('#messages').prop('scrollHeight'));
    }

    connection.start();

    var nickname = $('#profile').text();

    var $messagecontent = $('#message-content');
    $messagecontent.keyup(function (e) {
        if (e.keyCode == 13) {
            var message = $messagecontent.val();
            if (message.length == 0) {
                return false;
            }

            connection.invoke("SendMessage", nickname, message);
            $messagecontent.val('');
        }
    });

});