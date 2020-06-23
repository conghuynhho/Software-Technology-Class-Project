@ModelType Web_Quan_Li_Giai_Bong_Da.THAMSO
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>THAMSO</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.MaTS)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MaTS)
        </dd>
        <dt>
            @Html.DisplayNameFor(Function(model) model.TuoiTT)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TuoiTT)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TuoiTD)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TuoiTD)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SoCauThuTT)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SoCauThuTT)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SoCauThuTD)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SoCauThuTD)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SoCauThuNgoaiTD)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SoCauThuNgoaiTD)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ThoiDiemTT)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ThoiDiemTT)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ThoiDiemTD)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ThoiDiemTD)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DiemThang)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DiemThang)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DiemHoa)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DiemHoa)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DiemThua)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DiemThua)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.MaTS }) |
    @Html.ActionLink("Back to List", "Index")
</p>
