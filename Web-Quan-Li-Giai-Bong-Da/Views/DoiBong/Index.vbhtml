@ModelType IEnumerable(Of Web_Quan_Li_Giai_Bong_Da.DOIBONG)
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
            @Html.DisplayNameFor(Function(model) model.SAN.TenSan)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TenDoi)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.NgayThanhLap)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SAN.TenSan)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TenDoi)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NgayThanhLap)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.MaDoi }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.MaDoi }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.MaDoi })
        </td>
    </tr>
Next

</table>
