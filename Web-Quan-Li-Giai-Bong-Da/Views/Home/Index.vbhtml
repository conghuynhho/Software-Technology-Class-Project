@Code
    ViewData("Title") = "Trang Chủ"
    Layout = "~/Views/Shared/_Layout.vbhtml"
    @Styles.Render("~/Content/css")
    @Styles.Render("~/Content/assets/layout.css")
End Code

<h2>Giải vô địch bóng đá Quốc Gia</h2>
<div class="center">
    <button type="button" class="btn btn-primary button">Mùa giải</button><br />
    <button type="button" class="btn btn-warning button">Hồ sơ đội bóng</button><br />
    <button type="button" class="btn btn-success button">Tra cứu cầu thủ</button><br />
    <button type="button" class="btn btn-danger button">Trận đấu</button><br />
    <button type="button" class="btn btn-info button">Bảng xếp hạng</button><br />
</div>

