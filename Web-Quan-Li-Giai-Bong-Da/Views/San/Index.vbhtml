@ModelType IEnumerable(Of Web_Quan_Li_Giai_Bong_Da.SAN)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h3>Index</h3>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.MaSan)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TenSan)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Diachi)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MaSan)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TenSan)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Diachi)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.MaSan }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.MaSan }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.MaSan })
        </td>
    </tr>
Next

</table>
