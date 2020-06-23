@ModelType IEnumerable(Of Web_Quan_Li_Giai_Bong_Da.LOAICAUTHU)
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
            @Html.DisplayNameFor(Function(model) model.MaLoaiCauThu)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LoaiCauThu)
        </th>

    </tr>

@For Each item In Model
    @<tr>
         <td>
             @Html.DisplayFor(Function(modelItem) item.MaLoaiCauThu)
         </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LoaiCauThu)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.MaLoaiCauThu}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.MaLoaiCauThu}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.MaLoaiCauThu})
        </td>
    </tr>
Next

</table>
