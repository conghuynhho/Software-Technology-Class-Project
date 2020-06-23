@ModelType Web_Quan_Li_Giai_Bong_Da.TRONGTAI
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>TRONGTAI</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.MaTrongTai)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MaTrongTai)
        </dd>
        <dt>
            @Html.DisplayNameFor(Function(model) model.TenTrongTai)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TenTrongTai)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.QuocTich)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.QuocTich)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.MaTrongTai }) |
    @Html.ActionLink("Back to List", "Index")
</p>
