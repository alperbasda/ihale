/* -------------------------------------------------------------------------------- /
	
	Magentech jQuery
	Created by Magentech
	v1.0 - 20.9.2016
	All rights reserved.
	
/ -------------------------------------------------------------------------------- */






// Cart add remove alert functions
var cart = {
    'add': function (item) {
        addProductNotice('Ürün Eklendi', '<img src="../' + $(item).parents('div').parents('div').data('img') + '"/>', '<h3><a href="../Product/ProductDetail/' + $(item).parents('div').parents('div').data('product') + '">' + $(item).parents('div').parents('div').data('name') + '</a> Sepete eklendi!!!', 'Başarılı');

    }
}

var wishlist = {
    'add': function (item) {
        addProductNotice('Favori', '<img src="../' + $(item).parents('div').parents('div').data('img') + '"/>', '<h3><a href="../Product/ProductDetail/' + $(item).parents('div').parents('div').data('product') + '">' + $(item).parents('div').parents('div').data('name') + '</a> Favorilerinize Eklendi!</h3>', 'Başarılı');
    }
}
var compare = {
    'add': function (item) {
        addProductNotice('Karşılaştır', '<img src="../' + $(item).parents('div').parents('div').data('img') + '"/>', '<h3><a href="../Product/ProductDetail/' + $(item).parents('div').parents('div').data('product') + '" >' + $(item).parents('div').parents('div').data('name') + '</a> Karşılaştırma Listesine Eklendi!</h3>', 'Başarılı');
    }
}

/* ---------------------------------------------------
    jGrowl – jQuery alerts and message box
-------------------------------------------------- */
function addProductNotice(title, thumb, text, type) {

    $.jGrowl.defaults.closer = false;
    //Stop jGrowl
    //$.jGrowl.defaults.sticky = true;
    var tpl = thumb + '<h3>' + text + '</h3>';
    $.jGrowl(tpl, {
        life: 4000,
        header: title,
        speed: 'slow',
        theme: type
    });
}
