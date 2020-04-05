$("#Cep").change(function () {
    let cep = $("#Cep").val();
    if (cep != "") {
        $.ajax({
            type: 'GET',
            cache: false,
            url: '/CorreiosCEP/BuscarEnderecoApi',
            dataType: 'json',
            data: { cep: cep },
            error: function () {
            },
            success: function (result) {
                if (result.success) {
                    $("#Rua").val(result.data.Rua);
                    $("#Bairro").val(result.data.Bairro);
                    $("#Cidade").val(result.data.Cidade);
                    $("#Estado").val(result.data.UF);
                } else{
                    alert(result.data);
                    limparCampos();
                }
            },
        });
    } else {
        alert("Informe o CEP!")
    }
});

function limparCampos() {
    $("#Cep").val("");
    $("#Rua").val("");
    $("#Bairro").val("");
    $("#Cidade").val("");
    $("#Estado").val("");
    $("#Cep").focus();
}