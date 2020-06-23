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
    Public Class MuaGiaiController
        Inherits System.Web.Mvc.Controller

        Private db As New Model1

        ' GET: MuaGiai
        Function Index() As ActionResult
            Return View(db.MUAGIAIs.ToList())
        End Function

        ' GET: MuaGiai/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim mUAGIAI As MUAGIAI = db.MUAGIAIs.Find(id)
            If IsNothing(mUAGIAI) Then
                Return HttpNotFound()
            End If
            Return View(mUAGIAI)
        End Function

        ' GET: MuaGiai/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: MuaGiai/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="MaMua,TenMua,NgayBatDau,NgayKetThuc")> ByVal mUAGIAI As MUAGIAI) As ActionResult
            If ModelState.IsValid Then
                db.MUAGIAIs.Add(mUAGIAI)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(mUAGIAI)
        End Function

        ' GET: MuaGiai/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim mUAGIAI As MUAGIAI = db.MUAGIAIs.Find(id)
            If IsNothing(mUAGIAI) Then
                Return HttpNotFound()
            End If
            Return View(mUAGIAI)
        End Function

        ' POST: MuaGiai/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="MaMua,TenMua,NgayBatDau,NgayKetThuc")> ByVal mUAGIAI As MUAGIAI) As ActionResult
            If ModelState.IsValid Then
                db.Entry(mUAGIAI).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(mUAGIAI)
        End Function

        ' GET: MuaGiai/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim mUAGIAI As MUAGIAI = db.MUAGIAIs.Find(id)
            If IsNothing(mUAGIAI) Then
                Return HttpNotFound()
            End If
            Return View(mUAGIAI)
        End Function

        ' POST: MuaGiai/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim mUAGIAI As MUAGIAI = db.MUAGIAIs.Find(id)
            db.MUAGIAIs.Remove(mUAGIAI)
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
