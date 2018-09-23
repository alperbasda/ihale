$(window).on("load", function() {
    responsiveLayout();
});

// responsiveLayout Menu
var responsiveflagMenu = false;
function responsiveLayout(element, eclass) {
    $('.login').hide();
	var $header = $("header"),
    offset_top = $header.offset().top;
    $(window).scroll(function(event){
		processScroll($header, "navbar-compact", offset_top);
	});
	responsiveflagMenu = true;
	
}

// processScroll Menu
function processScroll(element, eclass, offset_top) {
    var scrollTop = $(window).scrollTop();
    if($(element).height()< $(window).height()){
        if (scrollTop > offset_top) {
            //fix secondary navigation
            $(element).addClass(eclass);
			
        } else if (scrollTop <= offset_top) {
            $(element).removeClass(eclass);
        }

    }
}

$(window).load(function() {
    $(window).scroll(function (event) {
        $header = $("header");
		var scrTop = $(window).scrollTop();
		if( scrTop > 300 ) {
			if($header.hasClass('navbar-compact')) {
			    $('.megamenu').append();
			    $('.header-center').attr('hidden', 'hidden');
			    $('.login').show();
			}
		} else {
			if($header.hasClass('navbar-compact')) {
			    
			    $('.header-center').removeAttr('hidden');
			    $('.login').hide();
			}
		}
		
    });
    
});
