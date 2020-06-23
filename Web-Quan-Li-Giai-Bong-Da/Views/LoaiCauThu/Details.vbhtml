@ModelType Web_Quan_Li_Giai_Bong_Da.LOAICAUTHU
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>LOAICAUTHU</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.MaLoaiCauThu)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MaLoaiCauThu)
        </dd>
        <dt>
            @Html.DisplayNameFor(Function(model) model.LoaiCauThu)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LoaiCauThu)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.MaLoaiCauThu }) |
    @Html.ActionLink("Back to List", "Index")
</p>
