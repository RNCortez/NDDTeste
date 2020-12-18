function alterarEstadoRobo(idAlteracao, valor) {
    if (valor == parseInt($('#' + idAlteracao).val()) - 1 || valor == parseInt($('#' + idAlteracao).val()) + 1) {
        $('#' + idAlteracao).val(valor);

        $('.' + idAlteracao).removeClass('btn-primary');
        $('.' + idAlteracao).removeClass('btn-success');
        $('.' + idAlteracao).addClass('btn-primary');

        $('#' + idAlteracao + valor).removeClass('btn-primary');
        $('#' + idAlteracao + valor).addClass('btn-success');

        $('#submitRobo').click()
    }
    else {
        alert("Não foi possível realizar a ação, a progressão do movimento dever seguir uma ordem crescente ou decrescente")
    }
}