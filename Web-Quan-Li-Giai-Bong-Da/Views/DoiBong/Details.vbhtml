@ModelType Web_Quan_Li_Giai_Bong_Da.DOIBONG
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>DOIBONG</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.SAN.TenSan)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SAN.TenSan)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TenDoi)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TenDoi)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NgayThanhLap)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NgayThanhLap)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.MaDoi }) |
    @Html.ActionLink("Back to List", "Index")
</p>
