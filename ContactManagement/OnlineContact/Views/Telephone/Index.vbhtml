@ModelType IEnumerable(Of MvcOnlineContact.PhoneNumber)
@Code
    Dim phoneProfile As MvcOnlineContact.Profile = CType(ViewBag.PhoneProfile, MvcOnlineContact.Profile)
    
    ViewData("Title") = phoneProfile.FirstName & " " & phoneProfile.LastName & "Phone Numbers List"
    
    Dim phoneNumbersType As List(Of MvcOnlineContact.PhoneType) = New List(Of MvcOnlineContact.PhoneType)   
    phoneNumbersType = CType(ViewBag.phoneNumbersType, List(Of MvcOnlineContact.PhoneType))
    
    ''pass the phone numbers type to the partial view  
    Dim viewDataDictionaryNumbersType As ViewDataDictionary = New ViewDataDictionary()
    Dim key As String = "NumbersType"
    Dim value As List(Of MvcOnlineContact.PhoneType) = phoneNumbersType
    viewDataDictionaryNumbersType.Add(key, value)
      
End Code


@If Not Model.Count > 0 Then
    
    @<h4 class="info">There is no Phone Number associated with @phoneProfile.FirstName @phoneProfile.LastName</h4> 
    Else
    
     @<div class="span6 offset3">

    <h3>@phoneProfile.FirstName @phoneProfile.LastName Contact
        Numbers</h3>
    <table class="table table-striped phone-number table-vcenter">
        <thead>
            <tr>
                <th class="span6">
                    @Html.DisplayNameFor(Function(model) model.FKPhoneTypeID)
                </th>
                <th class="span6">
                    @Html.DisplayNameFor(Function(model) model.Number)
                </th>
            </tr>
        </thead>
        <tbody>
            @For Each item In Model
                               
                @Html.Partial("_phoneDetails", item, viewDataDictionaryNumbersType)           
            Next
        </tbody>
    </table>
</div>
    End If
    <div class"row-fluid">
    <p  class="span6 offset3">
        @Html.ActionLink("Add  new Phone Number", "Create", New With {.id = phoneProfile.ID}, New With {.class = "btn btn-success"})
        @Html.ActionLink("Back to contacts list", "Index", "Home", DBNull.Value, New With {.class = "btn btn-info"})  

    </p>
    </div>

@*<script>
    $(document).ready(function () {
        $(".deletePhone-modal").click(function (event) {
            event.preventDefault();
            console.log("modal called");
            $("#deletePhone").modal('show');
        });
       
    });
</script>*@