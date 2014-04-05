@ModelType OnlineContact.Address

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>Address</legend>

        @Html.HiddenFor(Function(model) model.ID)

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
            @Html.LabelFor(Function(model) model.PostCode)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.PostCode)
            @Html.ValidationMessageFor(Function(model) model.PostCode)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.County)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.County)
            @Html.ValidationMessageFor(Function(model) model.County)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.City)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.City)
            @Html.ValidationMessageFor(Function(model) model.City)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Country)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Country)
            @Html.ValidationMessageFor(Function(model) model.Country)
        </div>

         @Html.Hidden("FKProfileID", Model.FKProfileID)
         @Html.Hidden("ID", Model.ID)

        <p>
            <input type="submit" value="Save" class="btn btn-success" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to address List", "Index", "Address", New With {.id = Model.FKProfileID}, New With {.class = "btn btn-info"})
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
