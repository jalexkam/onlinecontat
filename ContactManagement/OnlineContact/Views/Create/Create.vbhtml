@ModelType OnlineContact.profile

@Code
    ViewData("Title") = "Add New Contact"
End Code

<h2>Add New Contact</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>Profile</legend>

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
            @Html.LabelFor(Function(model) model.Email)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Email)
            @Html.ValidationMessageFor(Function(model) model.Email)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.NickName)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.NickName)
            @Html.ValidationMessageFor(Function(model) model.NickName)
        </div>

        <p>
            <input type="submit" value="Create"  class="btn btn-success"/>
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to Contacts List", "Index", "Home", DBNull.Value, New With {.class = "btn btn-info"})

</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
