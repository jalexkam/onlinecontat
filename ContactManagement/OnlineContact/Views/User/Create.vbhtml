@ModelType OnlineContact.userdetail

@Code
    ViewData("Title") = "Create User"
End Code

<h2>Create User</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>userdetail</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.FirstName)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.FirstName)
            @Html.ValidationMessageFor(Function(model) model.FirstName)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.LastName)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.LastName)
            @Html.ValidationMessageFor(Function(model) model.LastName)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.AddressLine1)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.AddressLine1)
            @Html.ValidationMessageFor(Function(model) model.AddressLine1)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.AddressLine2)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.AddressLine2)
            @Html.ValidationMessageFor(Function(model) model.AddressLine2)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.City)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.City)
            @Html.ValidationMessageFor(Function(model) model.City)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.PostCode)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.PostCode)
            @Html.ValidationMessageFor(Function(model) model.PostCode)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Country)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Country)
            @Html.ValidationMessageFor(Function(model) model.Country)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.FKUserName)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.FKUserName)
            @Html.ValidationMessageFor(Function(model) model.FKUserName)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.FKUserID)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.FKUserID)
            @Html.ValidationMessageFor(Function(model) model.FKUserID)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.tbluserdetailscol)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.tbluserdetailscol)
            @Html.ValidationMessageFor(Function(model) model.tbluserdetailscol)
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
