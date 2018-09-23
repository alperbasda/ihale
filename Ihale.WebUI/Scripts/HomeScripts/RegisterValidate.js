$('.policya').click(function () {
    if (validateAll()) {
        $('#register').removeClass('disabled');
    } else {
        if (!$('#register').hasClass('disabled')) {

            $('#register').addClass('disabled');
        }
    }
});

$('#input-password, #input-confirm').keyup(function () {

    if (validateAll()) {
        $('#register').removeClass('disabled');
    } else {
        if (!$('#register').hasClass('disabled')) {
            $('#register').addClass('disabled');
        }
    }
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

var bool = true;
$('.form-control1').keyup(function () {
    if (validateAll()) {
        $('#register').removeClass('disabled');
    } else {
        if (!$('#register').hasClass('disabled')) {
            $('#register').addClass('disabled');
        }
    }

});
function validateItems() {
    bool = true;
    $.each($('.form-control1'),
        function (index, item) {
            if ($(item).val() == "") {
                bool = false;
            }
        });
    return bool;
}

function policy() {

    if ($('.policya').prop('checked') == true) {
        return true;
    }
    return false;
}

function validateAll() {

    if (validatePass() && policy() && validateItems()) {
        return true;
    }

    return false;
}