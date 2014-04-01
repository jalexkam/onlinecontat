﻿
Imports OnlineContact.Models

Namespace Controllers
    <Authorize()>
    Public Class HomeController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Home
        ReadOnly _onlineContactDB As OnlineContact = New OnlineContact()

        Function Index() As ActionResult

            Dim userInfo As userdetail = New userdetail

            If User.Identity.IsAuthenticated Then
                Dim userName = User.Identity.Name
                userInfo = _onlineContactDB.userdetails.Single(Function(c) c.FKUserID = 1)
            Else
                RedirectToAction("LogOn", "Account")
            End If
            ViewBag.UserInfo = userInfo

            Dim profilesList As List(Of profile) = New List(Of profile)
            profilesList = _onlineContactDB.profiles.Where(Function(c) c.FKUserDetailsID = userInfo.ID).ToList()
            ViewBag.Profiles = profilesList

           
            ''pass delete profile error message to the view 
            If Not TempData("DeleteProfileError") Is Nothing Then
                Dim errorDeleteProfile As DeleteProfileErrorMessage = CType(TempData("DeleteProfileError"), DeleteProfileErrorMessage)
                ViewBag.ErrorDeleteProfile = errorDeleteProfile
            End If

            ''pass delete profile successful message to the view 
            If Not TempData("DeleteProfileSuccess") Is Nothing Then
                Dim successDeleteProfile As DeleteProfileSuccessMessage = CType(TempData("DeleteProfileSuccess"), DeleteProfileSuccessMessage)
                ViewBag.SuccessDeleteProfile = successDeleteProfile
            End If

            ''pass create profile successful message to the view 
            If Not TempData("CreateProfileSuccess") Is Nothing Then
                Dim successCreateProfile As CreateProfileSuccessMessage = CType(TempData("CreateProfileSuccess"), CreateProfileSuccessMessage)
                ViewBag.SuccessCreateProfile = successCreateProfile
            End If

            ''''pass edit profile error message to the view 
            If Not TempData("EditProfileSuccess") Is Nothing Then
                Dim successEditProfile As EditProfileSuccessMessage = CType(TempData("EditProfileSuccess"), EditProfileSuccessMessage)
                ViewBag.SuccessEditProfile = successEditProfile
            End If


            Return View()
        End Function

    End Class
End Namespace