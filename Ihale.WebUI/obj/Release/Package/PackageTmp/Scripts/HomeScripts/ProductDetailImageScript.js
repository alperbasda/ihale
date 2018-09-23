
        $(document).ready(function () {
            var zoomCollection = '.large-image img';
            $(zoomCollection).elevateZoom({
                zoomType: "inner",
                lensSize: "200",
                easing: true,
                gallery: 'thumb-slider-vertical',
                cursor: 'pointer',
                galleryActiveClass: "active"
            });
            $('.large-image').magnificPopup({
                items: [
                    { src: 'image/demo/shop/product/J9.jpg' },
                    { src: 'image/demo/shop/product/J6.jpg' },
                    { src: 'image/demo/shop/product/J5.jpg' },
                    { src: 'image/demo/shop/product/J4.jpg' },
                ],
                gallery: { enabled: true, preload: [0, 2] },
                type: 'image',
                mainClass: 'mfp-fade',
                callbacks: {
                    open: function () {

                        var activeIndex = parseInt($('#thumb-slider-vertical .img.active').attr('data-index'));
                        var magnificPopup = $.magnificPopup.instance;
                        magnificPopup.goTo(activeIndex);
                    }
                }
            });
            $("#thumb-slider-vertical .owl2-item").each(function () {
                $(this).find("[data-index='0']").addClass('active');
            });


            $(".thumb-vertical-outer .next-thumb").click(function () {
                $(".thumb-vertical-outer .lSNext").trigger("click");
            });

            $(".thumb-vertical-outer .prev-thumb").click(function () {
                $(".thumb-vertical-outer .lSPrev").trigger("click");
            });


            // Product detial reviews button
            $(".reviews_button,.write_review_button").click(function () {
                var tabTop = $(".producttab").offset().top;
                $("html, body").animate({ scrollTop: tabTop }, 1000);
            });
        });
