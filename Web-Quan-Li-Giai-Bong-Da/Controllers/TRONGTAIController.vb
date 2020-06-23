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
    Public Class TRONGTAIController
        Inherits System.Web.Mvc.Controller

        Private db As New Model1

        ' GET: TRONGTAI
        Function Index() As ActionResult
            Return View(db.TRONGTAIs.ToList())
        End Function

        ' GET: TRONGTAI/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tRONGTAI As TRONGTAI = db.TRONGTAIs.Find(id)
            If IsNothing(tRONGTAI) Then
                Return HttpNotFound()
            End If
            Return View(tRONGTAI)
        End Function

        ' GET: TRONGTAI/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: TRONGTAI/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="MaTrongTai,TenTrongTai,QuocTich")> ByVal tRONGTAI As TRONGTAI) As ActionResult
            If ModelState.IsValid Then
                db.TRONGTAIs.Add(tRONGTAI)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tRONGTAI)
        End Function

        ' GET: TRONGTAI/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tRONGTAI As TRONGTAI = db.TRONGTAIs.Find(id)
            If IsNothing(tRONGTAI) Then
                Return HttpNotFound()
            End If
            Return View(tRONGTAI)
        End Function

        ' POST: TRONGTAI/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="MaTrongTai,TenTrongTai,QuocTich")> ByVal tRONGTAI As TRONGTAI) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tRONGTAI).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tRONGTAI)
        End Function

        ' GET: TRONGTAI/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tRONGTAI As TRONGTAI = db.TRONGTAIs.Find(id)
            If IsNothing(tRONGTAI) Then
                Return HttpNotFound()
            End If
            Return View(tRONGTAI)
        End Function

        ' POST: TRONGTAI/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim tRONGTAI As TRONGTAI = db.TRONGTAIs.Find(id)
            db.TRONGTAIs.Remove(tRONGTAI)
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
