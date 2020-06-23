@ModelType Web_Quan_Li_Giai_Bong_Da.SAN
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h3>Delete</h3>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>SAN</h4>
    <hr />
    <dl class="dl-horizontal">
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
