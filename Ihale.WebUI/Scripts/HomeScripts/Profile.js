$('.radio-inline').children('input').click(function () {

    $.ajax({
        dataType: 'JSON',
        type: 'Get',
        url: '../Account/SetNewsteller',
        data: { value: $(this).val() },
        contentType: 'application/json;',
        success: function (response) {
            if (response == 1) {
                addProductNotice('Mail Bildirimleri', 'Mail bildirim ayarlarınız güncellendi.', 'Başarılı');
            } else {
                addProductNotice('Mail Bildirimleri', 'Mail bildirim ayarlarınız güncellenemedi.', 'Hata');
            }

        }

    });

});

function validatePass() {
    if ($('#input-password').val() == $('#input-confirm').val()) {
        $('#input-password').removeClass('validate-border');
        $('#input-confirm').removeClass('validate-border');
        return true;
    }
    $('#input-password').addClass('validate-border');
    $('#input-confirm').addClass('validate-border');
    return false;
}

$('#input-password, #input-confirm').keyup(function () {
    if ($('#input-password').val() != "") {
        if (validatePass()) {
            $('#register').removeClass('disabled');
        } else {
            if (!$('#register').hasClass('disabled')) {
                $('#register').addClass('disabled');
            }
        }
    }
});

