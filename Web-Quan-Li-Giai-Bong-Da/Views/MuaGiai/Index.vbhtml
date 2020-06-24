@ModelType IEnumerable(Of Web_Quan_Li_Giai_Bong_Da.MUAGIAI)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Danh sách mùa giải</h2>

<p>
    @Html.ActionLink("Thêm Mùa giải mới", "Create")
</p>
<table class="table">
    <tr>
        <th>Tên mùa giải</th>
        <th>Ngày bắt đầu</th>
        <th>Ngày kết thúc</th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TenMua)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NgayBatDau)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NgayKetThuc)
        </td>
        <td>
            @Html.ActionLink("Sửa", "Edit", New With {.id = item.MaMua}) |
            @Html.ActionLink("Chi tiết", "Details", New With {.id = item.MaMua}) |
            @Html.ActionLink("Xóa", "Delete", New With {.id = item.MaMua})
        </td>
    </tr>
Next

</table>
