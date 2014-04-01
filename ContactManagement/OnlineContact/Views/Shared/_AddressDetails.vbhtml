@ModelType OnlineContact.Address

@Using Html.BeginForm("Delete", "Address", New With {.id = Model.ID}, FormMethod.Post, DBNull.Value)
    
    @<div class="row-fluid address">
        <div class="span4">
            <input class="input-large" value="@Model.AddressLine1" placeholder="Address Line1" />
            <p style="padding-top: 5px;">
                <input class="input-large" value="@Model.County" placeholder="county" />
            </p>
        </div>
        <div class="span4">
            <input class="input-large" value="@Model.AddressLine2" placeholder="Address Line2" />
            <p style="padding-top: 5px;">
                <input class="input-large" value = "@Model.Country" placeholder="Country" />
            </p>
        </div>
        <div class="span4">
            <input class="input-large remove" value="@Model.City" placeholder="City" />
            <p style="padding-top: 5px;">
                <input class="input-large" value="@Model.PostCode" placeholder="Zip Code" />
            </p>
            <div class="m-button">
                 <button type="submit" class="btn btn-danger btn-small submit"  >
                <i class="icon-remove icon-white"></i>
            </button>

              <a  class="btn btn-info btn-small submit" href="@Url.Action("Edit", "Address", New With {.id = Model.ID})" >
                <i class="icon-edit icon-white"></i>
            </a>
            </div>
           
        </div>
        @*<hr class="span8 offset2" />*@
    </div>  
    
   @<div class="modal hide fade deleteAddress" id="deleteAddress">
    <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-hidden="true"> &times;</button>
        <h3 class="warning">Delete Address Confirmation</h3>
    </div>
    <div class="modal-body">
        <p>Are you sure You want to delete the Address ID @Model.ID link to @Model.Profile.FirstName @Model.Profile.LastName</p>
    </div>
    <div class="modal-footer">
         <button class="btn" data-dismiss="modal" aria-hidden="true">NO</button>
        <button class="btn btn-success confirm-delete">Yes</button>
    </div>
</div>

End Using


@*
<script type="text/javascript">

    $(document).ready(function () {

        // position the delete button of the address correctly
        var lastSpanWidth = $(".address div.span4:nth-child(3) input.remove").outerWidth();
        $(".address div.span4:nth-child(3) button[type='submit']").css({ left: (lastSpanWidth + 5) + 'px' });


        //add modal to confirm the delete of an address
        $("button[type='submit'].submit").click(function (event) {
            event.preventDefault();
            $('#deleteAddress').modal('show');
        });

        // delete the address
        $(".confirm-delete").click(function () {
            $('.confirm-delete').closest("Form").submit();
        });
    });
   
</script>
*@