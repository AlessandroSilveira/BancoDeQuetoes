$(document).ready(function() {
	$("#envia_selecionados").click(function () {
		var disciplinas = new Array;
		$("input[name=DisciplinaId]").each(function () {
			if (this.checked === true) {
				disciplinas.push($(this).val());
			}
			//alert(disciplinas);
			$("#Disciplinas_selecionadas").val(disciplinas);
			$("#disc").html(disciplinas);
		});

		
	});
	

});
