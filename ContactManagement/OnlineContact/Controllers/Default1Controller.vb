Imports System.Data.Entity

Namespace MvcOnlineContact
    Public Class Default1Controller
        Inherits System.Web.Mvc.Controller

        Private db As New OnlineContactEntities

        '
        ' GET: /Default1/

        Function Index() As ActionResult
            Return View(db.Profiles.ToList())
        End Function

        '
        ' GET: /Default1/Details/5

        Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim profile As Profile = db.Profiles.Single(Function(p) p.ID = id)
            If IsNothing(profile) Then
                Return HttpNotFound()
            End If
            Return View(profile)
        End Function

        '
        ' GET: /Default1/Create

        Function Create() As ActionResult
            Return View()
        End Function

        '
        ' POST: /Default1/Create

        <HttpPost()> _
        Function Create(ByVal profile As Profile) As ActionResult
            If ModelState.IsValid Then
                db.Profiles.AddObject(profile)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(profile)
        End Function

        '
        ' GET: /Default1/Edit/5

        Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim profile As Profile = db.Profiles.Single(Function(p) p.ID = id)
            If IsNothing(profile) Then
                Return HttpNotFound()
            End If
            Return View(profile)
        End Function

        '
        ' POST: /Default1/Edit/5

        <HttpPost()> _
        Function Edit(ByVal profile As Profile) As ActionResult
            If ModelState.IsValid Then
                db.Profiles.Attach(profile)
                db.ObjectStateManager.ChangeObjectState(profile, EntityState.Modified)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(profile)
        End Function

        '
        ' GET: /Default1/Delete/5

        Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim profile As Profile = db.Profiles.Single(Function(p) p.ID = id)
            If IsNothing(profile) Then
                Return HttpNotFound()
            End If
            Return View(profile)
        End Function

        '
        ' POST: /Default1/Delete/5

        <HttpPost()> _
        <ActionName("Delete")> _
        Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
            Dim profile As Profile = db.Profiles.Single(Function(p) p.ID = id)
            db.Profiles.DeleteObject(profile)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            db.Dispose()
            MyBase.Dispose(disposing)
        End Sub

    End Class
End Namespace