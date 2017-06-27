
$(document).ready(function () {
    $("#BtnGameLogin").click(function () {
        var V_tm_pm_userinfo = new Object;
        V_tm_pm_userinfo.LOGINNAME = $("#txtUserName").val();
        V_tm_pm_userinfo.LOGINPWD = $("#txtPassword").val();

        $.ajax({
            type: "post",
            dataType: "html",
            url: '/User/UserLogin',
            data: V_tm_pm_userinfo,
            success: function (data) {
                debugger;
                if (data != "") {
                    location.href = "/Personal";
                }
            }
        });

    });
})