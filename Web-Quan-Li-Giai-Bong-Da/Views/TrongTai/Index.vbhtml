@ModelType IEnumerable(Of Web_Quan_Li_Giai_Bong_Da.TRONGTAI)
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
            @Html.ActionLink("Edit", "Edit", New With {.id = item.MaTrongTai }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.MaTrongTai }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.MaTrongTai })
        </td>
    </tr>
Next

</table>
