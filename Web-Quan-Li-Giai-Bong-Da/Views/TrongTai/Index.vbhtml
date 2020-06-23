@ModelType IEnumerable(Of Web_Quan_Li_Giai_Bong_Da.TRONGTAI)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Danh sách trọng tài</h2>

<p>
    @Html.ActionLink("Thêm trọng tài mới", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.MaTrongTai)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TenTrongTai)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.QuocTich)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MaTrongTai)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TenTrongTai)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.QuocTich)
        </td>
        <td>
            @Html.ActionLink("Sửa", "Edit", New With {.id = item.MaTrongTai}) |
            @Html.ActionLink("Chi tiết", "Details", New With {.id = item.MaTrongTai}) |
            @Html.ActionLink("Xóa", "Delete", New With {.id = item.MaTrongTai})
        </td>
    </tr>
Next

</table>
