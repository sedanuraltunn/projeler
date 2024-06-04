console.log("Register javascript loaded..");
let validation = -1;

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
    },
    ClearValidation: function () {
        $("body :input").css("border-color", "#ced4da");
        $("div").css("border-color", "#ced4da");
    }
}


let User = {
    Validate: function () {
        Page.ClearValidation();
        if ($("#input_username").val() == "") validation = 1;
        else if ($("#input_phone").val() == "") validation = 2;
        else if ($("#input_password").val() == "") validation = 3;
        else if ($("#input_password").val() != $("#input_cpassword").val()) validation = 4;
        Utility.WriteInfo(validation);
        return validation == -1 ? false : true;
    },
    Register: function () {

        if (User.Validate()) {
            Utility.WriteError();
            validation = -1;
            return false;
        }



        let user = {
            Name: $("#input_name").val(),
            Lastname: $("#input_lastname").val(),
            Username: $("#input_username").val(),
            Phone: $("#input_phone").val(),
            Birthday: $("#input_birthday").val(),
            Email: $("#input_email").val(),
            Password: $("#input_password").val(),
            Address: $("#input_address").val()
        }
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
    },
    WriteInfo: function (info) {
        //document.getElementById("span_warning").innerHTML = info;
        $("#span_warning").html(info).css("color", "#000");
    },
    WriteError: function (info = null) {
        switch (validation) {
            case 1:
                info = "Username is required";
                Utility.MakeRed([$("#div_username"), $("#input_username")]);

                break;
            case 2:
                info = "Phone is required";
                Utility.MakeRed([$("#div_phone"), $("#input_phone")]);
                break;
            case 3:
                info = "Password is required";
                Utility.MakeRed([$("#div_password"), $("#input_password")]);
                break;
            case 4:
                info = "Password confirmation is not same";
                Utility.MakeRed([$("#div_password"), $("#input_password"), $("#div_cpassword"), $("#input_cpassword"),]);
                break;
            default:
                break;
        }
        //document.getElementById("span_warning").innerHTML = info;
        $("#span_warning").html(info).css("color", "#F00");
    },
    MakeRed: function ($elem) {
        $.each($elem, function (index, $elem) {
            console.log($elem);
            $elem.css("border", "1px solid #f00");
            if (index == 1) $elem.focus();
        });
    }
}


