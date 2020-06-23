@ModelType Web_Quan_Li_Giai_Bong_Da.MUAGIAI
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
