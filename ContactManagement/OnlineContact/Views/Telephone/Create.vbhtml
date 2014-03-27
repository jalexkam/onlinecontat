@ModelType MvcOnlineContact.PhoneNumber

@Code
    Dim profile As MvcOnlineContact.Profile = CType(ViewBag.createProfile, MvcOnlineContact.Profile)
    ViewData("Title") = "Add Phone number to" & profile.FirstName & profile.LastName
End Code

<h3>Add number to @profile.FirstName @profile.LastName's Contact</h3>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>PhoneNumber</legend>

        @*<div class="editor-label">
            @Html.LabelFor(Function(model) model.Number) 

                  
        </div>*@

         <div class="editor-label">        
            @Html.DisplayNameFor(Function(model) model.Number)  
        </div>
        <div class="editor-field">
           @* <input type ="text" class="input-large" name="Number" placeholder="number" />*@
           @Html.TextBoxFor(Function(p) p.Number, New With {.class="input-large", .placeholder = "number"})
            @Html.ValidationMessageFor(Function(model) model.Number)
        </div>

        <div class="editor-label">        
            @Html.DisplayNameFor(Function(model) model.FKPhoneTypeID)  
        </div>
        <div class="editor-field">
             @* @Html.DropDownList("FKPhoneTypeID", CType(ViewBag.phoneNumbersTypeList, SelectList),"Select Phone Type" )*@
            @Html.DropDownListFor(Function(model) model.FKPhoneTypeID, CType(ViewBag.phoneNumbersTypeList, SelectList), "--Select Phone Type--")
            @Html.ValidationMessageFor(Function(model) model.FKPhoneTypeID)
        </div>

        <div class="editor-field">
             <input type ="hidden" name="FKProfileID" value="@profile.ID"  />
            @Html.ValidationMessageFor(Function(model) model.FKProfileID)
        </div>

        <p>
            <input type="submit" value="Create" class="btn btn-success"/>
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to Phone Number List", "Index", New With {.profileId = profile.ID}, New With {.class = "btn btn-info"})
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
