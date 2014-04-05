@ModelType IEnumerable(Of OnlineContact.userdetail)

@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table>
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.FirstName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LastName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.AddressLine1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.AddressLine2)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.City)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PostCode)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Country)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FKUserName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.aspnetusers.name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.tbluserdetailscol)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.FirstName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.LastName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.AddressLine1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.AddressLine2)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.City)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.PostCode)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Country)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.FKUserName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.aspnetusers.name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.tbluserdetailscol)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = currentItem.ID}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.ID}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.ID})
        </td>
    </tr>
Next

</table>
