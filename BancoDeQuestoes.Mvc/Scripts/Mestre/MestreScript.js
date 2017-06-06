$(document).ready(function() {
   
    $(".valor").each(function() {

        var valorFormatado = $(this).val();
        $(".valor_formatado").html("R$ " + valorFormatado);
    });

    $("#enviar").click(function() {
        var a = true;
        var b = true;

        if ($("input:radio[name='tipo_nota'][value='Emissão de Nota']").is(":checked") === false &&
            $("input:radio[name='tipo_nota'][value='R.P.A']").is(":checked") === false) {

            b = false;
        }

        var listaIds = new Array();
        var listaAceite = new Array();

        $(".aceite").each(function() {

            var id = $(this).find(":radio").attr("id");
            listaIds.push(id);

            if ($("input:radio[name='" + id + "'][value='1']").is(":checked") === true) {
                listaAceite.push("1");
            }

            if ($("input:radio[name='" + id + "'][value='0']").is(":checked") === true) {
                listaAceite.push("0");
            }

            $("#listaIds").val(listaIds);
            $("#listaAceite").val(listaAceite);
        });


        if (a===true) {
            $("#decisao").val(listaAceite);
            $("#form").submit();
        }

        //if (b === false) {
        //    alert("Deve-se escolher se aceita o convite para elaboração de questão.");
        //    return false;
        //}
        //return false;
    });


    $("#nao_aceito").click(function() {

        var listaIds = new Array();
        var listaAceite = new Array();

        $(".aceite").each(function() {
            var id = $(this).find(":radio").attr("id");
            listaIds.push(id);
            listaAceite.push("0");
        });

        $("#listaIds").val(listaIds);
        $("#listaAceite").val(listaAceite);
        $("#decisao").val("0");
       // $("#form").submit();
    });
})