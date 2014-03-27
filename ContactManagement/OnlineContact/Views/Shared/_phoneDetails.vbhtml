@ModelType MvcOnlineContact.PhoneNumber

@code
    
    Dim phoneNumbersType As List(Of MvcOnlineContact.PhoneType) = CType(ViewData("Numberstype"), List(Of MvcOnlineContact.PhoneType))   
End Code

<tr>
    <td>
        <select name="FKPhoneTypeID">
            <option value="0">Please select Phone type</option>
            @For Each phoneType As MvcOnlineContact.PhoneType In phoneNumbersType
                Dim seletedPhoneType As Boolean = (Model.FKPhoneTypeID = phoneType.ID)
                           
                If seletedPhoneType Then
                    @<option value = "@phoneType.ID" selected="selected">@phoneType.Name</option>                        
                Else
                    @<option value = "@phoneType.ID">@phoneType.Name</option>                                                 
                End If
            Next
        </select>
    </td>
    <td class="text-right">
        <div class="pull-right">
            <input class="input-large" value="@Model.Number" placeholder="Number" />
            @Using Html.BeginForm("Delete", "Telephone", New With {.id = Model.ID}, FormMethod.Post, DBNull.Value)
                @<a class="btn btn-small btn-danger deletePhone-modal" href="#deletePhone-@Model.ID" data-toggle="modal"><i
                    class="icon icon-remove icon-white"></i></a>
                @<div class="modal hide fade"  id="deletePhone-@Model.ID">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                            &times;</button>
                        <h3 class="warning">
                            Delete Phone number Confirmation</h3>
                    </div>
                    <div class="modal-body">
                        <p>
                            The <strong>@Model.PhoneType.Name</strong> with the ID of @Model.ID
                            is linked to @Model.Profile.FirstName @Model.Profile.LastName<br />
                            Are you sure you want to delete it?</p>
                    </div>
                    <div class="modal-footer">
                        <button class="btn" data-dismiss="modal" aria-hidden="true">
                            NO</button>
                        <button class="btn btn-success confirm-delete" type="submit">
                            Yes</button>
                    </div>
                </div>                    
            End Using
        </div>
    </td>
</tr>
