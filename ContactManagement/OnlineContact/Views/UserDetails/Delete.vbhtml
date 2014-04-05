@ModelType OnlineContact.userdetail

@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>userdetail</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.FirstName)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.FirstName)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.LastName)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.LastName)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.AddressLine1)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.AddressLine1)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.AddressLine2)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.AddressLine2)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.City)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.City)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.PostCode)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.PostCode)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Country)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Country)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.FKUserName)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.FKUserName)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.aspnetusers.name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.aspnetusers.name)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.tbluserdetailscol)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.tbluserdetailscol)
    </div>
</fieldset>
@Using Html.BeginForm()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
