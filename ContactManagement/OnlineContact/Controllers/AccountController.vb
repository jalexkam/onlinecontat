Imports System.Diagnostics.CodeAnalysis
Imports System.Security.Principal
Imports System.Web.Routing

Public Class AccountController
    Inherits System.Web.Mvc.Controller
    Dim db As OnlineContact = New OnlineContact()

    Private formsServiceValue As IFormsAuthenticationService
    Private membershipServiceValue As IMembershipService

    Public Property FormsService() As IFormsAuthenticationService
        Get
            Return formsServiceValue
        End Get
        Set(ByVal value As IFormsAuthenticationService)
            formsServiceValue = value
        End Set
    End Property

    Public Property MembershipService() As IMembershipService
        Get
            Return membershipServiceValue
        End Get
        Set(ByVal value As IMembershipService)
            membershipServiceValue = value
        End Set
    End Property

    Protected Overrides Sub Initialize(ByVal requestContext As RequestContext)
        If FormsService Is Nothing Then FormsService = New FormsAuthenticationService()
        If MembershipService Is Nothing Then MembershipService = New AccountMembershipService()

        MyBase.Initialize(requestContext)
    End Sub

    ' **************************************
    ' URL: /Account/LogOn
    ' **************************************

    Public Function LogOn() As ActionResult
        Return View()
    End Function

    <HttpPost()> _
    Public Function LogOn(ByVal model As LogOnModel, ByVal returnUrl As String) As ActionResult
        If ModelState.IsValid Then
            If MembershipService.ValidateUser(model.UserName, model.Password) Then
                FormsService.SignIn(model.UserName, model.RememberMe)
                If Not String.IsNullOrEmpty(returnUrl) AndAlso Url.IsLocalUrl(returnUrl) Then
                    Return Redirect(returnUrl)
                Else
                    Return RedirectToAction("Index", "Home")
                End If
            Else
                ModelState.AddModelError("", "The user name or password provided is incorrect.")
            End If
        End If

        ' If we got this far, something failed, redisplay form
        Return View(model)
    End Function

    ' **************************************
    ' URL: /Account/LogOff
    ' **************************************

    Public Function LogOff() As ActionResult
        FormsService.SignOut()

        Return RedirectToAction("Index", "Home")
    End Function

    ' **************************************
    ' URL: /Account/Register
    ' **************************************

    Public Function Register() As ActionResult
        ViewData("PasswordLength") = MembershipService.MinPasswordLength
        Return View()
    End Function

    <HttpPost()> _
    Public Function Register(ByVal model As RegisterModel) As ActionResult
        If ModelState.IsValid Then
            ' Attempt to register the user
            Dim createStatus As MembershipCreateStatus = MembershipService.CreateUser(model.UserName, model.Password, model.Email)

            If createStatus = MembershipCreateStatus.Success Then
                FormsService.SignIn(model.UserName, False)

                'Return View("CreateUserDetails")

               return RedirectToAction("CreateUserDetails", "Account")
            Else
                ModelState.AddModelError("", AccountValidation.ErrorCodeToString(createStatus))
            End If
        End If

        ' If we got this far, something failed, redisplay form
        ViewData("PasswordLength") = MembershipService.MinPasswordLength
        Return View(model)
    End Function

    ' **************************************
    ' URL: /Account/ChangePassword
    ' **************************************

    <Authorize()> _
    Public Function ChangePassword() As ActionResult
        ViewData("PasswordLength") = MembershipService.MinPasswordLength
        Return View()
    End Function

    <Authorize()> _
    <HttpPost()> _
    Public Function ChangePassword(ByVal model As ChangePasswordModel) As ActionResult
        If ModelState.IsValid Then
            If MembershipService.ChangePassword(User.Identity.Name, model.OldPassword, model.NewPassword) Then
                Return RedirectToAction("ChangePasswordSuccess")
            Else
                ModelState.AddModelError("", "The current password is incorrect or the new password is invalid.")
            End If
        End If

        ' If we got this far, something failed, redisplay form
        ViewData("PasswordLength") = MembershipService.MinPasswordLength
        Return View(model)
    End Function
    <Authorize()> _
    <HttpGet()> _
    Function CreateUserDetails() As ActionResult
        ViewBag.FKUserID = New SelectList(db.aspnetusers, "id", "name")
        Return View()
    End Function

    '
    ' POST: /UserDetails/Create
    <Authorize()> _
    <HttpPost()> _
    Function CreateUserDetails(ByVal userdetail As userdetail) As ActionResult
        If ModelState.IsValid Then

            'add the user membership id and username
            Dim currentUser As MembershipUser = Membership.GetUser()
            userdetail.FKUserID = CType(currentUser.ProviderUserKey, Integer)
            userdetail.FKUserName = currentUser.UserName

            db.userdetails.AddObject(userdetail)
            db.SaveChanges()
            Return RedirectToAction("Index", "Home")
        End If

        ViewBag.FKUserID = New SelectList(db.aspnetusers, "id", "name", userdetail.FKUserID)

        Return View(userdetail)
    End Function

    ' **************************************
    ' URL: /Account/ChangePasswordSuccess
    ' **************************************

    Public Function ChangePasswordSuccess() As ActionResult
        Return View()
    End Function
End Class
