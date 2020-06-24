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
    Public Class DoiBongController
        Inherits System.Web.Mvc.Controller

        Private db As New Model1

        ' GET: DoiBong
        Function Index() As ActionResult
            Dim dOIBONGs = db.DOIBONGs.Include(Function(d) d.SAN)
            Return View(dOIBONGs.ToList())
        End Function

        ' GET: DoiBong/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim dOIBONG As DOIBONG = db.DOIBONGs.Find(id)
            If IsNothing(dOIBONG) Then
                Return HttpNotFound()
            End If
            Return View(dOIBONG)
        End Function

        ' GET: DoiBong/Create
        Function Create() As ActionResult
            ViewBag.MaSan = New SelectList(db.SANs, "MaSan", "TenSan")
            Return View()
        End Function

        ' POST: DoiBong/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="MaDoi,TenDoi,MaSan,NgayThanhLap")> ByVal dOIBONG As DOIBONG) As ActionResult
            If ModelState.IsValid Then
                db.DOIBONGs.Add(dOIBONG)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.MaSan = New SelectList(db.SANs, "MaSan", "TenSan", dOIBONG.MaSan)
            Return View(dOIBONG)
        End Function

        ' GET: DoiBong/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim dOIBONG As DOIBONG = db.DOIBONGs.Find(id)
            If IsNothing(dOIBONG) Then
                Return HttpNotFound()
            End If
            ViewBag.MaSan = New SelectList(db.SANs, "MaSan", "TenSan", dOIBONG.MaSan)
            Return View(dOIBONG)
        End Function

        ' POST: DoiBong/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="MaDoi,TenDoi,MaSan,NgayThanhLap")> ByVal dOIBONG As DOIBONG) As ActionResult
            If ModelState.IsValid Then
                db.Entry(dOIBONG).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.MaSan = New SelectList(db.SANs, "MaSan", "TenSan", dOIBONG.MaSan)
            Return View(dOIBONG)
        End Function

        ' GET: DoiBong/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim dOIBONG As DOIBONG = db.DOIBONGs.Find(id)
            If IsNothing(dOIBONG) Then
                Return HttpNotFound()
            End If
            Return View(dOIBONG)
        End Function

        ' POST: DoiBong/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim dOIBONG As DOIBONG = db.DOIBONGs.Find(id)
            db.DOIBONGs.Remove(dOIBONG)
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
