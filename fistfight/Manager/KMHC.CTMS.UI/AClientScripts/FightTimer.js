$(function () {
    //Set the hubs URL for the connection
    debugger;
    var url = "ws://192.168.0.111:2017?token=";
    var ws = null;
    var fullUrl = url + $('#currentToken').val();
    if ("WebSocket" in window) {
        ws = new WebSocket(fullUrl);
    }
    else if ("MozWebSocket" in window) {
        ws = new MozWebSocket(fullUrl);
    } else if (window.WebSocket == undefined) {
        $('#message_output').html("浏览器不支持WebSocket");
    }

    ws.onopen = function () {
        $('#message_output').html("连接服务器成功" + "<br/>");
    }
    ws.onclose = function () {
        $('#message_output').html("与服务器断开连接" + "<br/>");
    }

    ws.onerror = function () {
        $('#message_output').html("通信发生错误" + "<br/>");
    }
    ws.onmessage = function (message) {
        //document.getElementById("message_output").innerHTML += msg.data + "<br/>";
        //var encodedName = $('<div />').text(name).html();
        //var encodedMsg = $('<div />').text(message).html();
        // Add the message to the page.
        debugger;
        
        var obj = JSON.parse(message.data);
        if (obj.IsSuccess == "1") {
            debugger;
            //如果是战斗信息
            if (obj.DataType == "batinfo") {
                var userView = obj.Data;
                var array = userView.Task.SpiritsList;
                for (var k = 0, length = array.length; k < length; k++) {
                    if (array[k]["SpiritLife"] <= 0) {
                        $('#' + array[k]["SpiritID"] + '').html("已死亡");
                    } else {
                        $('#' + array[k]["SpiritID"] + '').html("生命：" + array[k]["SpiritLife"]);
                    }
                }
                if (userView.Task.IsClear == "1")//任务完成
                {
                    var array = userView.Task.SpiritsList;
                    $('#discussionBoard').append('<li><strong>' + msginfo + '</strong></li>');
                }

                //显示战斗实时信息
                $('#batinfoBoard').append('<li><strong>' + obj.MessageInfo + '</strong></li>');
            }
            //如果是聊天信息
            if (obj.DataType == "msginfo") {
                var msginfo = obj.Data
                $('#discussionBoard').append('<li><strong>' + msginfo + '</strong></li>');
            }
        }else
        {
            //接口信息错误，显示错误信息
            $('#discussionBoard').append('<li><strong>' + obj.ErrMsg + '</strong></li>');
        }
    };
    $('#startFight').click(function () {
        debugger;
        // Call the Send method on the hub.
        if (ws) { ws.send("skill1"); }
        //接口信息错误，显示错误信息
        // Clear text box and reset focus for next comment.
        $('#startFight').focus();
    });
    // Start the connection.
    //function StartFight() {
    //    $('body').everyTime('5s', 'A', function () {
    //        if (ws) { ws.send("fight") }
    //    });
    //};
    $('#sendmessage').click(function () {
        // Call the Send method on the hub.
        if (ws) { ws.send($('#message').val()); }
        // Clear text box and reset focus for next comment.
        $('#message').val('').focus();
    });
});