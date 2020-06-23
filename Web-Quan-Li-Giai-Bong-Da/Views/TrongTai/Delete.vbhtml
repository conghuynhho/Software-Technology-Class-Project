@ModelType Web_Quan_Li_Giai_Bong_Da.TRONGTAI
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>TRONGTAI</h4>
    <hr />
    <dl class="dl-horizontal">
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
