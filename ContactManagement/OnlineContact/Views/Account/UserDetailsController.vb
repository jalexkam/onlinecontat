Imports System.Data.Entity

Namespace Controller
    Public Class UserDetailsController
        Inherits System.Web.Mvc.Controller

        Private db As New OnlineContact

        '
        ' GET: /UserDetails/

        Function Index() As ActionResult
            Dim userdetails = db.userdetails.Include("aspnetusers")
            Return View(userdetails.ToList())
        End Function

        '
        ' GET: /UserDetails/Details/5

        Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim userdetail As userdetail = db.userdetails.Single(Function(u) u.ID = id)
            If IsNothing(userdetail) Then
                Return HttpNotFound()
            End If
            Return View(userdetail)
        End Function

        '
        ' GET: /UserDetails/Create

        Function Create() As ActionResult
            ViewBag.FKUserID = New SelectList(db.aspnetusers, "id", "name")
            Return View()
        End Function

        '
        ' POST: /UserDetails/Create

        <HttpPost()> _
        Function Create(ByVal userdetail As userdetail) As ActionResult
            If ModelState.IsValid Then
                db.userdetails.AddObject(userdetail)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            ViewBag.FKUserID = New SelectList(db.aspnetusers, "id", "name", userdetail.FKUserID)
            Return View(userdetail)
        End Function

        '
        ' GET: /UserDetails/Edit/5

        Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim userdetail As userdetail = db.userdetails.Single(Function(u) u.ID = id)
            If IsNothing(userdetail) Then
                Return HttpNotFound()
            End If
            ViewBag.FKUserID = New SelectList(db.aspnetusers, "id", "name", userdetail.FKUserID)
            Return View(userdetail)
        End Function

        '
        ' POST: /UserDetails/Edit/5

        <HttpPost()> _
        Function Edit(ByVal userdetail As userdetail) As ActionResult
            If ModelState.IsValid Then
                db.userdetails.Attach(userdetail)
                db.ObjectStateManager.ChangeObjectState(userdetail, EntityState.Modified)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            ViewBag.FKUserID = New SelectList(db.aspnetusers, "id", "name", userdetail.FKUserID)
            Return View(userdetail)
        End Function

        '
        ' GET: /UserDetails/Delete/5

        Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim userdetail As userdetail = db.userdetails.Single(Function(u) u.ID = id)
            If IsNothing(userdetail) Then
                Return HttpNotFound()
            End If
            Return View(userdetail)
        End Function

        '
        ' POST: /UserDetails/Delete/5

        <HttpPost()> _
        <ActionName("Delete")> _
        Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
            Dim userdetail As userdetail = db.userdetails.Single(Function(u) u.ID = id)
            db.userdetails.DeleteObject(userdetail)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            db.Dispose()
            MyBase.Dispose(disposing)
        End Sub

    End Class
End Namespace