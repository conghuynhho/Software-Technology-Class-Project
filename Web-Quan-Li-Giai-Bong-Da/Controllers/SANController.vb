Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Web_Quan_Li_Giai_Bong_Da

Namespace Controllers
    Public Class SANController
        Inherits System.Web.Mvc.Controller

        Private db As New Model1

        ' GET: SAN
        Function Index() As ActionResult
            Return View(db.SANs.ToList())
        End Function

        ' GET: SAN/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sAN As SAN = db.SANs.Find(id)
            If IsNothing(sAN) Then
                Return HttpNotFound()
            End If
            Return View(sAN)
        End Function

        ' GET: SAN/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: SAN/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="MaSan,TenSan,Diachi")> ByVal sAN As SAN) As ActionResult
            If ModelState.IsValid Then
                db.SANs.Add(sAN)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(sAN)
        End Function

        ' GET: SAN/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sAN As SAN = db.SANs.Find(id)
            If IsNothing(sAN) Then
                Return HttpNotFound()
            End If
            Return View(sAN)
        End Function

        ' POST: SAN/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="MaSan,TenSan,Diachi")> ByVal sAN As SAN) As ActionResult
            If ModelState.IsValid Then
                db.Entry(sAN).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(sAN)
        End Function

        ' GET: SAN/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sAN As SAN = db.SANs.Find(id)
            If IsNothing(sAN) Then
                Return HttpNotFound()
            End If
            Return View(sAN)
        End Function

        ' POST: SAN/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim sAN As SAN = db.SANs.Find(id)
            db.SANs.Remove(sAN)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
