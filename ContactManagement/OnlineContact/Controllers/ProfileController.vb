Imports System.Data.Entity
Imports OnlineContact.Models

Namespace Controllers
    Public Class ProfileController
        Inherits System.Web.Mvc.Controller
        ReadOnly db As OnlineContact = New OnlineContact()

        Function Create() As ActionResult
            Dim createProfile As Profile = New Profile()
            Return View(createProfile)
        End Function
        '
        ' POST: Home/Create

        <HttpPost()> _
        Function Create(ByVal profile As Profile) As ActionResult
            If ModelState.IsValid Then
                db.Profiles.AddObject(profile)
                db.SaveChanges()

                'generate the success message after a new contact(profile) has been created
                Dim successCreateProfile As CreateProfileSuccessMessage = New CreateProfileSuccessMessage()
                successCreateProfile.SuccessMessage = profile.FirstName & " " & profile.LastName & " successfully added to contact list"
                successCreateProfile.OriginalProfile = profile

                TempData("CreateProfileSuccess") = successCreateProfile

                Return RedirectToAction("Index", "Home")
            End If

            Return View(profile)
        End Function


        Function Edit(ByVal id As Integer) As ActionResult
            Dim editProfile As Profile = db.Profiles.Single(Function(p) p.ID = id)

            Return View(editProfile)
        End Function

        <HttpPost()> _
        Function Edit(ByVal profile As Profile) As ActionResult
            If ModelState.IsValid Then

                'db.Profiles.Attach(profile)
                'db.ObjectStateManager.ChangeObjectState(profile, EntityState.Modified)
                'db.SaveChanges()
                ''Dim editProfile As Profile = New Profile()


                '' when editing it is good practice to the details from the object from the DB and the updated the details to be changed
                ''from the object passed and then save it

                Dim editProfile = db.Profiles.Single(Function(p) p.ID = profile.ID)
                editProfile.FirstName = profile.FirstName
                editProfile.LastName = profile.LastName
                editProfile.Email = profile.Email
                editProfile.NickName = profile.NickName
                db.SaveChanges()

                'generate the success message after a new contact(profile) has been created and add it to the tempdata
                Dim successEditProfile As EditProfileSuccessMessage = New EditProfileSuccessMessage()
                successEditProfile.SuccessMessage = editProfile.FirstName & " " & editProfile.LastName & " details successfully updated"
                successEditProfile.OriginalProfile = editProfile

                TempData("EditProfileSuccess") = successEditProfile

                Return RedirectToAction("Index", "Home")
            End If

            Return View(profile)
        End Function


        'Function Delete(ByVal id As Integer) As ActionResult

        '    '@Html.ActionLink("Delete", "Your-Action", new { id = item.id },
        '    '     new { onclick="return confirm('Are you sure?');"})


        '    Dim editProfile As Profile = db.Profiles.Single(Function(p) p.ID = id)
        '    Return View(editProfile)
        'End Function

        <HttpPost()> _
        Function Delete(ByVal eprofile As Profile) As ActionResult

            Dim editProfile As Profile = db.Profiles.Single(Function(p) p.ID = eprofile.ID)

            If Not editProfile Is Nothing Then
                Try
                    db.Profiles.DeleteObject(editProfile)
                    db.SaveChanges()

                    Dim deleteSuccess As DeleteProfileSuccessMessage = New DeleteProfileSuccessMessage()
                    deleteSuccess.SuccessMessage = editProfile.FirstName & " " & editProfile.LastName & " has beeen successfully delete from your contact list"
                    deleteSuccess.OriginalProfile = editProfile

                    TempData("DeleteProfileSuccess") = deleteSuccess

                Catch ex As Exception
                    Dim deleteError As DeleteProfileErrorMessage = New DeleteProfileErrorMessage()
                    deleteError.ErrorMessage = "The record you are try to delete has address or phone number associated to it"
                    deleteError.OriginalProfile = editProfile

                    TempData("DeleteProfileError") = deleteError

                End Try
            End If
            Return RedirectToAction("Index", "Home")

        End Function
    End Class
End Namespace