@ModelType Web_Quan_Li_Giai_Bong_Da.MUAGIAI
@Code
    ViewData("Title") = "Edit"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Sửa</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Mùa giải</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        @Html.HiddenFor(Function(model) model.MaMua)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.TenMua, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.TenMua, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.TenMua, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NgayBatDau, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                <p>Ngày bắt đầu</p>
                @Html.EditorFor(Function(model) model.NgayBatDau, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.NgayBatDau, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-10">
                <p>Ngày kết thúc</p>
                @Html.EditorFor(Function(model) model.NgayKetThuc, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.NgayKetThuc, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Lưu" class="btn btn-info" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Quay lại danh sách", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
