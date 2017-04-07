
function getEndereco() {
	var cep = $("#DESC_CEP").val();

	if (cep !== "") {
        $.getScript("http://cep.republicavirtual.com.br/web_cep.php?cep=" + cep + "&formato=javascript&amp", function () {
            if (window.resultadoCEP["tipo_logradouro"] !== "") {

                if (window.resultadoCEP["resultado"]) {
                    $("#DESC_ENDERECO").val(unescape(window.resultadoCEP["logradouro"]));
                    $("#DESC_BAIRRO").val(unescape(window.resultadoCEP["bairro"]));
                    $("#DESC_CIDADE").val(unescape(window.resultadoCEP["cidade"]));
                    $("#DESC_ESTADO").val(unescape(window.resultadoCEP["uf"]));
                    $("#DESC_NUMERO").focus();
                }
            }
        });
    }
}