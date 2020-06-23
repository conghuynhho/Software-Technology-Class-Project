@ModelType Web_Quan_Li_Giai_Bong_Da.SAN
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h3>Details</h3>

<div>
    <h4>SAN</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.MaSan)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MaSan)
        </dd>
        <dt>
            @Html.DisplayNameFor(Function(model) model.TenSan)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TenSan)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Diachi)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Diachi)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.MaSan }) |
    @Html.ActionLink("Back to List", "Index")
</p>
