console.log("Login javascript loaded..");

$(document).ready(function () {
    Page.Init();
});

let Page = {
    Init: function () {
        Page.Handler();
        Page.Clear();
    },
    Handler: function () {
        $(document).on("click", "#btn_cancel", function (e) {
            history.back();
        });
        $(document).on("click", "#btn_clear", function (e) {
            Page.Clear();
        });
        $(document).on("click", "#btn_save", function (e) {
            User.Login();
        });
    },
    Clear: function () {
        $("body :input").val("");
        $("#input_name").focus();
    }
}

let User = {
    Login: function () {
        let userLogin = {
            Username: $("#input_username").val(),
            Password: $("#input_password").val()
        };

        $.ajax({
            type: "POST",
            data: JSON.stringify(userLogin),
            url: "/user/login",
            contentType: "application/json",
            async: true
        }).done(function (res) {
            Utility.WriteLog(res);
            res == true ? Utility.WriteInfo("Login başarılı", true) : Utility.WriteInfo("Tekrar deneyin".false)
        })
    }
}


let Utility = {
    WriteLog: function (str) {
        console.log(str);
    },
    WriteInfo: function (info) {
        document.getElementById("span_warning").innerHTML = info;
        /*$("#span_warning").html(info);*/
    }
}


