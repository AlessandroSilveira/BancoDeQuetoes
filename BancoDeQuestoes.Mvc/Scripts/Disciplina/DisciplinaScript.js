$(document).ready(function() {
	$("#envia_selecionados").click(function () {
	    var disciplinas = new Array;
	    $("#disc").html("");
		$("input[name=DisciplinaId]").each(function () {
            
		    if (this.checked === true) {
		        $.ajax({
		            async: true,
		            type: 'post',
		            url: '../Disciplina/ObterNomeDisciplina',
		            data: "{ 'Id': '" + $(this).val() + "' }",
		            contentType: 'application/json',
		            success: function (result) {
		                $("#disc").append(result+"<br/>");
		            }
		        });
				disciplinas.push($(this).val());
			}
			$("#Disciplinas_selecionadas").val(disciplinas);
		});
	});
});
