@ModelType IEnumerable(Of Web_Quan_Li_Giai_Bong_Da.MUAGIAI)
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
            @Html.DisplayNameFor(Function(model) model.MaMua)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TenMua)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.NgayBatDau)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.NgayKetThuc)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MaMua)
        </td>
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
            @Html.ActionLink("Edit", "Edit", New With {.id = item.MaMua }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.MaMua }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.MaMua })
        </td>
    </tr>
Next

</table>
