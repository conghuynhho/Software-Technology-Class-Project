@ModelType IEnumerable(Of Web_Quan_Li_Giai_Bong_Da.THAMSO)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.MaTS)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TuoiTT)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TuoiTD)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SoCauThuTT)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SoCauThuTD)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SoCauThuNgoaiTD)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ThoiDiemTT)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ThoiDiemTD)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DiemThang)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DiemHoa)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DiemThua)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
             @Html.DisplayFor(Function(modelItem) item.MaTS)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TuoiTT)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TuoiTD)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SoCauThuTT)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SoCauThuTD)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SoCauThuNgoaiTD)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ThoiDiemTT)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ThoiDiemTD)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DiemThang)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DiemHoa)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DiemThua)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.MaTS }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.MaTS }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.MaTS })
        </td>
    </tr>
Next

</table>
