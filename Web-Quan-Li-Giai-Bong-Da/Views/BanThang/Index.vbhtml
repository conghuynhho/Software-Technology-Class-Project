@ModelType IEnumerable(Of Web_Quan_Li_Giai_Bong_Da.BANTHANG)
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
            @Html.DisplayNameFor(Function(model) model.MaLoaiBanThang)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.BanThang)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MaLoaiBanThang)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.BanThang)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.MaLoaiBanThang }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.MaLoaiBanThang }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.MaLoaiBanThang })
        </td>
    </tr>
Next

</table>
