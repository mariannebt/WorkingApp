function signin() {
    //var userid = document.getElementById("idlogin").value;
    //var password = document.getElementById("pwd").value;
    //alert(login + password);

    var login = {
        Login: document.getElementById("idlogin").value,
        Password: document.getElementById("pwd").value
    };

    alert(login);

    $.ajax({
        type: "POST",
        url: "/Person/SignIn",
        data: login,
        success: function() {

        },
        error: function (e) {
            alert("User Name or Password incorrect");
        }
    });
}

    