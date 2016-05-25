$(document).ready(function () {
    $("#status").hide();
    $("#botao-entrar").click(function () {
        $.ajax({
            url: "/AutenticaUsuario/AutenticacaoUsuario",
            data: { Login: $("#txtLogin").val(), Senha: $("#txtSenha").val() },
            dataType: "json",
            type: "GET",
            async: true,
            beforeSend: function () {
                $("#status").html("Autenticando usuário...");
                $("#status").show();
            },
            success: function (dados) {
                if (dados.OK) {
                    $("#status").html(dados.Mensagem)
                    setTimeout(function () { window.location.href = "/Home" }, 3000);
                    $("#status").show();
                } else {
                    $("#status").html(dados.Mensagem);
                    $("#status").show();
                }
            },
            error: function () {
                $("#status").html(dados.Mensagem);
                $("#status").show();
            }
        });
    });
});
