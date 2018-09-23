$(document).ready(function () {
    $('[data-countdown]').each(function() {
        var $this = $(this), finalDate = $(this).data('countdown');
        $this.countdown(finalDate,
            function(event) {
                $this.html(event.strftime(
                    '<div class="time-item time-day"><div class="num-time">%D</div><div class="name-time">Gün </div></div><div class="time-item time-hour"><div class="num-time">%H</div><div class="name-time">Saat </div></div><div class="time-item time-min"><div class="num-time">%M</div><div class="name-time">Dakika </div></div><div class="time-item time-sec"><div class="num-time">%S</div><div class="name-time">Saniye </div></div>'));
            }).on('finish.countdown',
            function() {
                $(this).parent('div').children('.title').html('Sona Erdi');
                var buttonsDiv = $(this).parent('div').parent('div').parent('div').parent('div')
                    .children('.right-block')
                    .children('.button-group');
                $(buttonsDiv).children('button').remove();
                $(buttonsDiv)
                    .append(
                        '<button class="addToCart" type="button" data-toggle="tooltip" title="Banada Lazım"><i class="fa fa-recycle"></i><span> Banada Lazım</span></button>');
            });
    });
});