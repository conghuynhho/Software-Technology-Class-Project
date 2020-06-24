@ModelType Web_Quan_Li_Giai_Bong_Da.MUAGIAI
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>MUAGIAI</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.TenMua)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TenMua)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NgayBatDau)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NgayBatDau)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NgayKetThuc)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NgayKetThuc)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.MaMua }) |
    @Html.ActionLink("Back to List", "Index")
</p>
