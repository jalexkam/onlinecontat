@ModelType IEnumerable(Of MvcOnlineContact.Address)

@Code
    
    Dim AddressProfile As MvcOnlineContact.Profile = CType(ViewBag.AddressProfile, MvcOnlineContact.Profile)
    ViewData("Title") = AddressProfile.FirstName & " " & AddressProfile.LastName
    
 
    'Delete error message
    Dim errorDeleteAddress As MvcOnlineContact.Models.DeleteAddressErrorMessage = Nothing
    If Not ViewBag.ErrorDeleteAddress Is Nothing Then
        errorDeleteAddress = CType(ViewBag.ErrorDeleteAddress, MvcOnlineContact.Models.DeleteAddressErrorMessage)
    End If
    
    'Delete success message
    Dim successDeleteAddress As MvcOnlineContact.Models.DeleteAddressSuccessMessage = Nothing
    If Not ViewBag.SuccessDeleteAddress Is Nothing Then
        successDeleteAddress = CType(ViewBag.SuccessDeleteAddress, MvcOnlineContact.Models.DeleteAddressSuccessMessage)
    End If
    
    'Create contact success message
    Dim successCreateAddress As MvcOnlineContact.Models.CreateAddressSuccessMessage = Nothing
    If Not ViewBag.SuccessCreateAddress Is Nothing Then
        successCreateAddress = CType(ViewBag.SuccessCreateAddress, MvcOnlineContact.Models.CreateAddressSuccessMessage)
    End If
    
    'Edit Address success message
    Dim successEditAddress As MvcOnlineContact.Models.EditAddressSuccessMessage = Nothing
    If Not ViewBag.SuccessEditAddress Is Nothing Then
        successEditAddress = CType(ViewBag.SuccessEditAddress, MvcOnlineContact.Models.EditAddressSuccessMessage)
    End If
    
End Code

    @If Not errorDeleteAddress Is Nothing Then
        @<div class="span12">
            <h4 class="error">@errorDeleteAddress.ErrorMessage</h4>
        </div>
    End If

    @If Not successDeleteAddress Is Nothing Then
        @<div class="span12">
            <h4 class="success">@successDeleteAddress.SuccessMessage</h4>
        </div>
    End If

    
    @If Not successCreateAddress Is Nothing Then
        @<div class="span12">
            <h4 class="success">@successCreateAddress.SuccessMessage</h4>
        </div>
    End If

    
    @If Not successEditAddress Is Nothing Then
        @<div class="span12">
            <h4 class="success">@successEditAddress.SuccessMessage</h4>
        </div>
    End If


@If Not Model.Count > 0 Then
    @<h4 class="info">There is no address associated with @AddressProfile.FirstName @AddressProfile.LastName</h4> 
    
Else
    @<h3>@AddressProfile.FirstName  @AddressProfile.LastName addresses</h3>
    For Each item In Model
        @Html.Partial("_AddressDetails", item)         
    Next
End If

  <p>
         @Html.ActionLink("Add New Address", "Create", "Address", New With {.id = AddressProfile.ID}, New With {.class = "btn btn-success"})
         @Html.ActionLink("Back to contacts list", "Index", "Home", DBNull.Value, New With {.class = "btn btn-info"})  
   </p>


   
<script type="text/javascript">

    $(document).ready(function () {

        // position the delete button of the address correctly
        var lastSpanWidth = $(".address div.span4:nth-child(3) input.remove").outerWidth();
        $(".address div.span4:nth-child(3) div.m-button").css({ left: (lastSpanWidth + 5) + 'px'});


        //add modal to confirm the delete of an address
        $("button[type='submit'].submit").click(function (event) {
            event.preventDefault();
            var button = event.target;
            var form = $(button).closest("Form");
//            $(form).css({"margin-bottom": "0px", "border":"5px solid black"});
            $(form).find(".deleteAddress").modal('show');

        });

        // delete the address
        $(".confirm-delete").click(function () {
            $('.confirm-delete').closest("Form").submit();
        });
    });
   
</script>
