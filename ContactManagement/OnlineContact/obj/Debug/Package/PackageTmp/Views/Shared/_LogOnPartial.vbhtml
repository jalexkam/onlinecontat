@If Request.IsAuthenticated Then
    @<text>Welcome <b>@Context.User.Identity.Name</b>!
   <li> @Html.ActionLink("Log Off", "LogOff", "Account") </li> </text>
Else
    @:<li>@Html.ActionLink("Log On", "LogOn", "Account")</li>
End If
