$(window).scroll(function () {
    var hT = $('.products-list').offset().top,
        wS = $(this).scrollTop();
    if (wS > 200) {
        $('#column-left').css('margin-top', hT - 40).animate('fast');
    } else {
        $('#column-left').css('margin-top', '0').animate('fast');
    }
});

$(document).ready(function () {
    $('.grid').click();
});

$(document).ready(function () {

    if ($(window).width() <= 765) {
        $.each($('#bottomfixed').children('.row').children('div'),
            function (index, item) {

                $(item).removeClass('col-xs-4');
                $(item).addClass('col-xs-3');
            });
        $('#bottomfixed').children('.row')
            .append(
                '<div class="col-xs-3"><a id="filtersBtn" data-toggle="modal" data-target="#filters"><i class="fa fa-filter"></i></a></div>');
        $('#filters').children('.modal-dialog').children('.modal-content').children('.modal-body').children().remove();
        $('#filters').children('.modal-dialog').children('.modal-content').children('.modal-body').append($('.filterModule'));

    }
});

