@ModelType Web_Quan_Li_Giai_Bong_Da.BANTHANG
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>BANTHANG</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.MaLoaiBanThang)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MaLoaiBanThang)
        </dd>
        <dt>
            @Html.DisplayNameFor(Function(model) model.BanThang)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.BanThang)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.MaLoaiBanThang }) |
    @Html.ActionLink("Back to List", "Index")
</p>
