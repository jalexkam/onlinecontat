@ModelType OnlineContact.Address

@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>Address</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.AddressLine1)
        </div>
        <div class="editor-field">
          @*  @Html.EditorFor(Function(model) model.AddressLine1)*@
            <input type="text" name="AddressLine1" placeholder="AddressLine1" />
            @Html.ValidationMessageFor(Function(model) model.AddressLine1)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.AddressLine2)
        </div>
        <div class="editor-field">
           @* @Html.EditorFor(Function(model) model.AddressLine2)*@
           <input type="text" name="AddressLine2" placeholder="AddressLine2" />
            @Html.ValidationMessageFor(Function(model) model.AddressLine2)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.PostCode)
        </div>
        <div class="editor-field">
            @*@Html.EditorFor(Function(model) model.PostCode)*@
            <input type="text" name="PostCode" placeholder="PostCode" />
            @Html.ValidationMessageFor(Function(model) model.PostCode)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.County)
        </div>
        <div class="editor-field">
           @* @Html.EditorFor(Function(model) model.County)*@
           <input type="text" name="County" placeholder="County" />
            @Html.ValidationMessageFor(Function(model) model.County)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.City)
        </div>
        <div class="editor-field">
           @* @Html.EditorFor(Function(model) model.City)*@
           <input type="text" name="City" placeholder="City" />
            @Html.ValidationMessageFor(Function(model) model.City)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Country)
        </div>
        <div class="editor-field">
           @* @Html.EditorFor(Function(model) model.Country)*@
           <input type="text" name="Country" placeholder="Country" />
            @Html.ValidationMessageFor(Function(model) model.Country)
        </div>

        @*<div class="editor-label">
            @Html.LabelFor(Function(model) model.FKProfileID)
        </div>*@
        <div class="editor-field">
           @* @Html.EditorFor(Function(model) model.FKProfileID)*@
           <input type="hidden" name="FKProfileID" value="@CType(ViewBag.createProfileId, Integer)"/>

            @Html.ValidationMessageFor(Function(model) model.FKProfileID)
        </div>

        <p>
            <button class="btn btn-success" type="submit">Create Address</button>
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to addresses list", "Index", "address", New With {.id = ViewBag.createProfileId}, New With {.class = "btn btn-info"})
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
