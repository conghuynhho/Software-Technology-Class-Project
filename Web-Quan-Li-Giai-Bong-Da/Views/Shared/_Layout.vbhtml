﻿<!DOCTYPE html>
<html>

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>@ViewBag.Title</title>
    @Styles.Render("~/Content/assets/demo.css")
    @Styles.Render("~/Content/assets/header-fixed.css")

</head>

<body>

    <header class="header-fixed">

        <div class="header-limiter">

            <h1><a href="#">Quản lí Giải <span>Bóng Đá </span> Quốc Gia</a></h1>

            <nav>
                <ul>
                    <li>@Html.ActionLink("Trang Chủ", "Index", "Home")</li>
                    <li>@Html.ActionLink("Giới Thiệu", "About", "Home")</li>
                    <li>@Html.ActionLink("Liên Hệ", "Contact", "Home")</li>
                </ul>
                
            </nav>

        </div>

    </header>

    <!-- You need this element to prevent the content of the page from jumping up -->
    <div class="header-fixed-placeholder"></div>

    <!-- The content of your page would go here. -->

    <div class="main-content">
        @RenderBody()
    </div>



    <script src="http://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
    <script>

	$(document).ready(function(){

		var showHeaderAt = 150;

		var win = $(window),
				body = $('body');

		// Show the fixed header only on larger screen devices

		if(win.width() > 600){

			// When we scroll more than 150px down, we set the
			// "fixed" class on the body element.

			win.on('scroll', function(e){

				if(win.scrollTop() > showHeaderAt) {
					body.addClass('fixed');
				}
				else {
					body.removeClass('fixed');
				}
			});

		}

	});

    </script>


    <!-- Demo ads. Please ignore and remove. -->
    <!-- <script src="http://cdn.tutorialzine.com/misc/enhance/v3.js" async></script> -->


</body>

</html>