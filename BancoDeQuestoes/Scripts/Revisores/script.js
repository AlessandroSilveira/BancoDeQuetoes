$(document).ready(function() {
	$("#DESC_CEP").focusout(function() {
		getEndereco();
	});

});

function getEndereco() {

    var cep;
	cep = $("#DESC_CEP").val();

    if (cep != "") {
        $.getScript("http://cep.republicavirtual.com.br/web_cep.php?cep=" + cep + "&formato=javascript&amp", function () {
            if (resultadoCEP["tipo_logradouro"] != '') {

                if (resultadoCEP["resultado"]) {
                    $("#DESC_ENDERECO").val(unescape(resultadoCEP["logradouro"]));
                    $("#DESC_BAIRRO").val(unescape(resultadoCEP["bairro"]));
                    $("#DESC_CIDADE").val(unescape(resultadoCEP["cidade"]));
                    $("#DESC_ESTADO").val(unescape(resultadoCEP["uf"]));
                    $("#DESC_NUMERO").focus();
                }
            }
        });
    }

}