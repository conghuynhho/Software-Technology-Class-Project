﻿@Code
    ViewData("Title") = "Trang Chủ"
    Layout = "~/Views/Shared/_Layout.vbhtml"
    @Styles.Render("~/Content/css")
    @Styles.Render("~/Content/assets/layout.css")
End Code

<h2 class="header"> GIẢI VÔ ĐỊCH BÓNG ĐÁ QUỐC GIA</h2>
<div class="center">
    <a class=" btn btn-primary button " href="MuaGiai/Index">Mùa giải</a>
    <a class=" btn btn-warning button" href="DoiBong/Index">Hồ sơ đội bóng</a>
    <a class="btn btn-success button" href="TraCuu/Index">Tra cứu cầu thủ</a>
    <a class="btn btn-danger button" href="TranDau/Index">Trận đấu</a>
    <a class="btn btn-info button" href="BXH/Index">Bảng xếp hạng</a>
</div>

