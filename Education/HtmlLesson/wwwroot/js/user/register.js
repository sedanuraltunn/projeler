﻿//console.log("Register js loaded.");

//$(document).ready(function () {
//    Page.Init();
//});

//let Page = {
//    Init: function () {
//        Page.Handler();
//        Page.Clear();
//    },
//    Handler: function () {
//        $(document).on("click", "#btn_cancel", function (e) {
//            history.back();
//        });
//        $(document).on("click", "#btn_clear", function (e) {
//            Page.Clear();
//        });
//        $(document).on("click", "#btn_save", function (e) {
//            User.Register();
//        });
//    },
//    Clear: function () {
//        //document.getElementsByClassName("Form-control").val = "";
//        //document.getElementById("input-surname").val = "";
//        $("body :input").val("");
//        $("#input_name").focus();
//    }

//}

//let User = {
//    Register: function () {
//        let user = {
//            Name: $("#input_name").val(),
//            Lastname: $("#input_surname").val(),
//            Username: $("#input_username").val(),
//            Phone: $("#input_phone").val(),
//            Birthday: $("#input_birthday").val(),
//            Email: $("#input_email").val(),
//            Address: $("#input_address").val(),
//            Password: $("#input_password").val()
//        };
//        Utility.WriteLog(user);

//        $.ajax({ //istemci ile sunucu arasındaki iletişimi javascript vasıtasıyla sağlar
//            type: "POST",
//            data: JSON.stringify(user),
//            url: "/user/register",
//            contentType: "application/json",
//            async: true
//        }).done(function (res) {
//            Utility.WriteLog(res);
//        })
//    }
//}

//let Utility = {
//    WriteLog: function (log) {
//        console.log(log);
//    }
//}


console.log("Register javascript loaded..");

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
            User.Register();
        });
    },
    Clear: function () {
        $("body :input").val("");
        $("#input_name").focus();
    }
}

let User = {
    Register: function () {
        let user = {
            Name: $("#input_name").val(),
            Lastname: $("#input_lastname").val(),
            Username: $("#input_username").val(),
            Phone: $("#input_phone").val(),
            Birthday: $("#input_birthday").val(),
            Email: $("#input_email").val(),
            Password: $("#input_password").val(),
            Address: $("#input_address").val()
        };
        Utility.WriteLog(user);


        $.ajax({
            type: "POST",
            data: JSON.stringify(user),
            url: "/user/register",
            contentType: "application/json",
            async: true
        }).done(function (res) {
            Utility.WriteLog(res);
            $("#input_name").val(res.name);
        })
    }
}


let Utility = {
    WriteLog: function (str) {
        console.log(str);
    }
}
