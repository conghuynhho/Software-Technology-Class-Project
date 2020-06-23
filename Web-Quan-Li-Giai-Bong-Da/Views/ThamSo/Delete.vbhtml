@ModelType Web_Quan_Li_Giai_Bong_Da.THAMSO
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>THAMSO</h4>
    <hr />
    <dl class="dl-horizontal">
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
