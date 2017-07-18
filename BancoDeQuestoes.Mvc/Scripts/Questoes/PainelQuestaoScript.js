
	//tinymce.init({
 //       selector: "textarea",
 //       themes: "modern"
	//	//theme: "modern",
	//	//plugins: [
	//	//	"advlist autolink lists  charmap print preview anchor searchreplace visualblocks code ",
	//	//	"",
	//	//	"textcolor insertdatetime  table contextmenu paste moxiemanager"
	//	//],
	//	//toolbar1:
	//	//	"insertfile undo redo | styleselect | bold italic | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | link image",
	//	//toolbar2: "print preview media | forecolor backcolor emoticons",
	//	//image_advtab: true,
	//	//templates: [
	//	//	{ title: 'Test template 1', content: 'Test 1' },
	//	//	{ title: 'Test template 2', content: 'Test 2' }
	//	//]
	//});

function retira_acentos(palavra) {
	var comAcento = "áàãâäéèêëíìîïóòõôöúùûüçÁÀÃÂÄÉÈÊËÍÌÎÏÓÒÕÖÔÚÙÛÜÇ";
	var semAcento = "aaaaaeeeeiiiiooooouuuucAAAAAEEEEIIIIOOOOOUUUUC";
	var nova = "";
	for (var i = 0; i < palavra.length; i++) {
		if (comAcento.search(palavra.substr(i, 1)) >= 0) {
			nova += semAcento.substr(comAcento.search(palavra.substr(i, 1)), 1);
		} else {
			nova += palavra.substr(i, 1);
		}
	}
	return nova;
}


function replace_all(string, encontrar, substituir) {
	while (string.indexOf(encontrar) >= 0)
		string = string.replace(encontrar, substituir);
	return string;
}

$(document).ready(function () {
	

	//$("#data_entrega").datepicker({
	//	dateFormat: 'dd/mm/yy',
	//	dayNames: ['Domingo', 'Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta', 'Sábado'],
	//	dayNamesMin: ['D', 'S', 'T', 'Q', 'Q', 'S', 'S', 'D'],
	//	dayNamesShort: ['Dom', 'Seg', 'Ter', 'Qua', 'Qui', 'Sex', 'Sáb', 'Dom'],
	//	monthNames: [
	//		'Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro',
	//		'Dezembro'
	//	],
	//	monthNamesShort: ['Jan', 'Fev', 'Mar', 'Abr', 'Mai', 'Jun', 'Jul', 'Ago', 'Set', 'Out', 'Nov', 'Dez'],
	//	nextText: 'Próximo',
	//	prevText: 'Anterior'

	//});

	$("#enviarFinalizar").click(function() {

		var questaoId = $("#QuestaoId").val();
        var questao = $("#descricao").val();

        var obj = {
            QuestaoId: questaoId,
            Questao: questao
        }

		$.ajax({
			type: "post",
            contentType: "application/json",
            data: JSON.stringify(obj),
			dataType: "json",
			url: "../SalvarQuestaoElaborada"
        })
            .done(function (result) {
                if (result) {
	                $(".resposta").each(function() {
		                var i = 1;

		                var resposta = $("#resposta_" + i + "").val();
		                var justificativa = $("#justificativa_" + i + "").val();

		                var obj = {
			                QuestaoId: questaoId,
			                Resposta: resposta,
			                Justificativa: justificativa
		                }
		                $.ajax({
			                type: "post",
			                contentType: "application/json",
			                data: JSON.stringify(obj),
			                dataType: "json",
			                url: "../SalvarRespostasEJustificativasElaboradas"
		                });

                    });
                    alert("Dados salvos com sucesso.");
	                window.location.href = "../../Mestre/ListaQuestoes";
	                return false;
                }
                else {
                    alert("Erro ao salvar dados");
	                return false;
                }
			});

		


			


		//$("#finalizar").val(1);
		//var extensao;
		//var arquivo;
		//if ($("input[name*='arquivoQuestao']").val() !== "") {
  //          arquivo = $("input[name*='arquivoQuestao']").val();
		//	extensao = arquivo.split(".");
		//	if (extensao[1] !== "jpg") {
		//		alert("Arquivo inválido");
		//		return false;
		//	}
		//}

     //   var respostas = [];
	    //var justificativas = [];

     //   $(".justificativa").each(function () {
	    //    if ($(this).val() !== "") {
     //           justificativas.push($(this).val());
     //       }
     //       else {
     //           alert("Preencha o campo Justificativa");
	    //        return false;
     //       }
     //   });


     //   $(".resposta").each(function () {
		   // if ($(this).val() !== "") {
     //           respostas.push($(this).val());
		   // }
		   // else {
			  //  alert("Preencha o campo Resposta");
			  //  return false;
		   // }
	    //});

     //   $("#todas_respostas").val(respostas);
     //   $("#todas_justificativas").val(justificativas);

		//if ($("input[name*='arquivo_respostaA']").val() !== "") {
		//	arquivo = $("input[name*='arquivo_respostaA']").val();
		//	extensao = arquivo.split('.');
		//	if (extensao[1] !== "jpg") {
		//		alert("Arquivo inválido");
		//		return false;
		//	}
		//}
        
		//$("#form").submit();
		return false;
	});
	$("#enviar_aprovar").click(function () {

		$("#finalizar").val(5);
		var extensao;
		var arquivo;
		if ($("input[name*='arquivo_questao']").val() !== "") {
			arquivo = $("input[name*='arquivo_questao']").val();
			extensao = arquivo.split('.');
			if (extensao[1] !== "jpg") {

				alert("Arquivo inválido");
				return false;
			}
		}

		if ($("input[name*='arquivo_respostaA']").val() !== "") {
			arquivo = $("input[name*='arquivo_respostaA']").val();
			extensao = arquivo.split('.');
			if (extensao[1] !== "jpg") {

				alert("Arquivo inválido");
				return false;
			}
		}

		if ($("input[name*='arquivo_respostaB']").val() !== "") {
			arquivo = $("input[name*='arquivo_respostaB']").val();
			extensao = arquivo.split('.');
			if (extensao[1] !== "jpg") {

				alert("Arquivo inválido");
				return false;
			}
		}

		if ($("input[name*='arquivo_respostaC']").val() !== "") {
			arquivo = $("input[name*='arquivo_respostaC']").val();
			extensao = arquivo.split('.');
			if (extensao[1] !== "jpg") {

				alert("Arquivo inválido");
				return false;
			}
		}

		if ($("input[name*='arquivo_respostaD']").val() !== "") {
			arquivo = $("input[name*='arquivo_respostaD']").val();
			extensao = arquivo.split('.');
			if (extensao[1] !== "jpg") {

				alert("Arquivo inválido");
				return false;
			}
		}

		if ($("input[name*='arquivo_respostaE']").val() !== "") {
			arquivo = $("input[name*='arquivo_respostaE']").val();
			extensao = arquivo.split('.');
			if (extensao[1] !== "jpg") {

				alert("Arquivo inválido");
				return false;
			}
		}

		$("#form").submit();
		return false;
	});
});