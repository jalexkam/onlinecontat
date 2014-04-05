Namespace Controllers
    <Authorize()>
    Public Class UserDetailsController
        Inherits System.Web.Mvc.Controller

        Dim db As OnlineContact = New OnlineContact()

        '
        ' GET: /UserDetails

        Function Index() As ActionResult
            Return View()
        End Function


        ' GET: /UserDetails/Create

        Function CreateUserDetails() As ActionResult
            ViewBag.FKUserID = New SelectList(db.aspnetusers, "id", "name")
            Return View()
        End Function

        '
        ' POST: /UserDetails/Create

        <HttpPost()> _
        Function CreateUserDetails(ByVal userdetail As userdetail) As ActionResult
            If ModelState.IsValid Then
                db.userdetails.AddObject(userdetail)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            ViewBag.FKUserID = New SelectList(db.aspnetusers, "id", "name", userdetail.FKUserID)
            Return View(userdetail)
        End Function




    End Class
End Namespace