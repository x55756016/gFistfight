function getUserInfo() {
    $.ajax({
        type: "post",
        dataType: "html",
        url: 'api/xy_sp_userspirit/GetByUserID',
        data: V_tm_pm_userinfo,
        success: function (data) {
            if (data != "") {
                location.href = "/Personal";
            }
        }
    });
}