﻿<!DOCTYPE html>
<html>

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>@ViewBag.Title</title>
    @Styles.Render("~/Content/css")
    @Styles.Render("~/Content/assets/demo.css")
    @Styles.Render("~/Content/assets/header-fixed.css")
    @Scripts.Render("~/bundles/modernizr")


</head>

<body>

    <header class="header-fixed">

        <div class="header-limiter">

            <h1><a href="#">Quản lí Giải <span>Bóng Đá </span> Quốc Gia</a></h1>

            <nav>
                <ul>
                    <li>@Html.ActionLink("Trang Chủ", "Index", "Home")</li>
                    <li class="my-dropdown">
                        @Html.ActionLink("Mùa Giải", "", "") <!-- this is <a> tag-->
                        <div class="dropdown-content">
                            <a href="#">Bảng Xếp Hạng</a>

                        </div>
                    </li>
                    <li class="my-dropdown">
                        @Html.ActionLink("Đội Bóng", "", "")
                        <div class="dropdown-content">
                            <a href="#">Sân</a>
                        </div>
                    </li>
                    <li class="my-dropdown">
                        @Html.ActionLink("Cầu Thủ", "", "")
                        <div class="dropdown-content">
                            <a href="#">Loại Cầu Thủ</a>
                            <a href="#">Tra Cứu Cầu Thủ</a>
                        </div>
                    </li>
                    <li class="my-dropdown">
                        @Html.ActionLink("Lịch Thi Đấu", "", "")
                        <div class="dropdown-content">
                            <a href="#">Trọng Tài</a>
                        </div>
                    </li>
                    <li class="my-dropdown">
                        @Html.ActionLink("Kết Quả", "", "")
                        <div class="dropdown-content">
                            <a href="#">Cầu Thủ Ra Sân</a>
                        </div>
                    </li>
                    <li>@Html.ActionLink("Quy Định", "", "")</li>
                    @*<li>@Html.ActionLink("Liên Hệ", "", "")</li>*@
                    <li>@Html.ActionLink("Giới Thiệu", "About", "Home")</li>

                </ul>

            </nav>

        </div>

    </header>

    <!-- You need this element to prevent the content of the page from jumping up -->
    <div class="header-fixed-placeholder"></div>

    <!-- The content of your page would go here. -->

    <div class="main-content">
        @RenderBody()




        <br />
        <br />
        <br />
        <div class="footer">
            <p>&copy; @DateTime.Now.Year - Huynh,Vi,Khai,Kham,Dac</p>
        </div>
    </div>





    <script src="http://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
    <script>

        $(document).ready(function () {

            var showHeaderAt = 150;

            var win = $(window),
                body = $('body');

            // Show the fixed header only on larger screen devices

            if (win.width() > 600) {

                // When we scroll more than 150px down, we set the
                // "fixed" class on the body element.

                win.on('scroll', function (e) {

                    if (win.scrollTop() > showHeaderAt) {
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




    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)

</body>

</html>