Namespace Controllers
    Public Class CreateController
        Inherits System.Web.Mvc.Controller

        ReadOnly db As OnlineContact = New OnlineContact()
        '
        ' GET: Home/Create

        Function Create() As ActionResult
            Return View()
        End Function
        '
        ' POST: Home/Create

        <HttpPost()> _
        Function Create(ByVal profile As Profile) As ActionResult
            If ModelState.IsValid Then
                db.Profiles.AddObject(profile)
                db.SaveChanges()
                Return RedirectToAction("Index", "Home")
            End If

            Return View(profile)
        End Function
    End Class
End Namespace