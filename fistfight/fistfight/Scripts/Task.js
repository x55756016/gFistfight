$(function () {
    //Set the hubs URL for the connection
    var url = "ws://localhost:2015";
    var ws = null;
    var fullUrl = url;

    if ("WebSocket" in window) {
        ws = new WebSocket(fullUrl);
    }
    else if ("MozWebSocket" in window) {
        ws = new MozWebSocket(fullUrl);
    } else {
        document.getElementById("message_output").innerHTML = "浏览器不支持WebSocket";
    }

    ws.onopen = function () {
        //document.getElementById("message_output").innerHTML += "连接服务器成功" + "<br/>";
        //changeElementEnabled(true);
    }
    ws.onclose = function () {
        //document.getElementById("message_output").innerHTML += "与服务器断开连接" + "<br/>";
        //changeElementEnabled(false);
    }

    ws.onerror = function () {
        //document.getElementById("message_output").innerHTML += "通信发生错误" + "<br/>";
    }
    ws.onmessage = function (message) {
        //document.getElementById("message_output").innerHTML += msg.data + "<br/>";
        //var encodedName = $('<div />').text(name).html();
        //var encodedMsg = $('<div />').text(message).html();
        // Add the message to the page.
        $('#discussionBoard').append('<li><strong>' + message.data + '</strong></li>');
    }
    // Get the user name and store it to prepend to messages.           
    // Set initial focus to message input box.
    $('#message').focus();
    // Start the connection.
    $('#sendmessage').click(function () {
        // Call the Send method on the hub.
        if (ws) { ws.send($('#displayname').val() + '/' + $('#message').val()); }
        // Clear text box and reset focus for next comment.
        $('#message').val('').focus();
    });
});