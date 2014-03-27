@Code
    
    ViewData("Title") = "Index"
    Dim profiles As List(Of OnlineContact.Profile) = ViewBag.profiles
    
    'Delete error message
    Dim errorDeleteProfile As OnlineContact.Models.DeleteProfileErrorMessage = Nothing
    If Not ViewBag.ErrorDeleteProfile Is Nothing Then
        errorDeleteProfile = CType(ViewBag.ErrorDeleteProfile, OnlineContact.Models.DeleteProfileErrorMessage)        
    End If
    
    'Delete success message
    Dim successDeleteProfile As OnlineContact.Models.DeleteProfileSuccessMessage = Nothing
    If Not ViewBag.SuccessDeleteProfile Is Nothing Then
        successDeleteProfile = CType(ViewBag.SuccessDeleteProfile, OnlineContact.Models.DeleteProfileSuccessMessage)
    End If
    
    'Create contact success message
    Dim successCreateProfile As OnlineContact.Models.CreateProfileSuccessMessage = Nothing
    If Not ViewBag.SuccessCreateProfile Is Nothing Then
        successCreateProfile = CType(ViewBag.SuccessCreateProfile, OnlineContact.Models.CreateProfileSuccessMessage)
    End If
    
    'Edit profile success message
    Dim successEditProfile As OnlineContact.Models.EditProfileSuccessMessage = Nothing
    If Not ViewBag.SuccessEditProfile Is Nothing Then
        successEditProfile = CType(ViewBag.SuccessEditProfile, OnlineContact.Models.EditProfileSuccessMessage)
    End If
    
    
End Code
<div class="row-fluid">
    @If Not errorDeleteProfile Is Nothing Then
        @<div class="span12">
            <h4 class="error">@errorDeleteProfile.ErrorMessage</h4>
        </div>
    End If

    @If Not successDeleteProfile Is Nothing Then
        @<div class="span12">
            <h4 class="success">@successDeleteProfile.SuccessMessage</h4>
        </div>
    End If

    
    @If Not successCreateProfile Is Nothing Then
        @<div class="span12">
            <h4 class="success">@successCreateProfile.SuccessMessage</h4>
        </div>
    End If

    
    @If Not successEditProfile Is Nothing Then
        @<div class="span12">
            <h4 class="success">@successEditProfile.SuccessMessage</h4>
        </div>
    End If


    <div class="row-fluid">
       <div class="span9">
            <h3>Alexandre Online Contact</h3>
        </div>
        <div class="span3">
            @Html.ActionLink("Add New Contact", "Create", "Profile", DBNull.Value, New With {.class = "btn btn-primary pull-right", .style = "margin-top: 20px"})
        </div>
    </div>
 
    <div class="row-fluid">
        <table class="table table-bordered table-striped table-hover table-vcenter">
            <thead style="background-color: Blue; color: White;">
                <tr>
                    <th>
                        First Name
                    </th>
                    <th>
                        Last Name
                    </th>
                    <th>
                        NickName
                    </th>
                    <th>
                        Email Address
                    </th>
                    <th>
                    </th>
                </tr>
            </thead>
            <tbody>
                @For Each item As OnlineContact.profile In profiles
                    @Using Html.BeginForm("Delete", "Profile", New With {.id = item.ID}, FormMethod.Post, DBNull.Value)

                        @<tr> <td> @item.FirstName</td> <td>@item.LastName
                        </td> <td>@item.NickName
                        </td> <td>@item.Email
                        </td> <td><a class="btn btn-info btn-small" href="@Url.Action("Edit", "Profile", New With {.id = item.ID})" title="Edit @item.FirstName @item.LastName details"><i class="icon-edit icon-white"></i></a>
                         @* <a class="btn btn-danger btn-small" href="@Url.Action("Delete", "Profile", New With {.id = item.ID})"  onclick="return confirm('Are you sure You want to delete the profile ID @item.ID');"><i class="icon-remove icon-white"></i></a>*@ 
@*                         <button type="submit" class="btn btn-danger btn-small" onclick="return confirm('Are you sure You want to delete @item.FirstName @item.LastName profile from your Contacts list');"><i class="icon-remove icon-white"></i></button> 
*@                         
                            <a class="btn btn-danger btn-small" href="#deleteProfile-@item.ID" data-toggle="modal" title="Delete @item.FirstName @item.LastName profile"><i class="icon-remove icon-white" ></i></a>                              
                             <div class="modal hide fade"  id="deleteProfile-@item.ID">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                                        &times;</button>
                                    <h3 class="warning">
                                        Delete Contact Profile Confirmation</h3>
                                </div>
                                <div class="modal-body">
                                    <p>Are you sure You want to delete @item.FirstName @item.LastName from your contact list</p>
                                </div>
                                
                                <div class="modal-footer">
                                    <button class="btn" data-dismiss="modal" aria-hidden="true">
                                        NO</button>
                                    <button class="btn btn-success confirm-delete" type="submit">
                                        Yes</button>
                                </div>
                            
                            </div> 
                            

                            <div class="pull-right">
                                <a class="btn btn-small btn-info" href="@Url.Action("index", "Address", New With {.id = item.ID})" title="View @item.FirstName @item.LastName address(es)"><i class="icon-home icon-white"></i></a>
                                <a class="btn btn-small btn-info" href="@Url.Action("index", "Telephone", New With {.id = item.ID})" title = "View @item.FirstName @item.LastName phone number(s)"><i class="icon-envelope icon-white"></i></a>
                            </div>                   
                         </td>
                          </tr>
                    End Using
                Next
            </tbody>
        </table>
    </div>
    <div class="row-fluid">
        <div class="span12">
        </div>
    </div>
</div>
<script type="text/javascript">
    function someFunction() {
        alert('some function called');
    }
</script>
