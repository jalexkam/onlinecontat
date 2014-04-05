@ModelType OnlineContact.userdetail

@Code
    ViewData("Title") = "CreateUserDetails"
    Dim currentUser As MembershipUser = Membership.GetUser()
End Code

<h2>CreateUserDetails</h2>

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

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
End Using


@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
