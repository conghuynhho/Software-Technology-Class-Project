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
    Public Class BanThangController
        Inherits System.Web.Mvc.Controller

        Private db As New Model1

        ' GET: BanThang
        Function Index() As ActionResult
            Return View(db.BANTHANGs.ToList())
        End Function

        ' GET: BanThang/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim bANTHANG As BANTHANG = db.BANTHANGs.Find(id)
            If IsNothing(bANTHANG) Then
                Return HttpNotFound()
            End If
            Return View(bANTHANG)
        End Function

        ' GET: BanThang/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: BanThang/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="MaLoaiBanThang,BanThang1")> ByVal bANTHANG As BANTHANG) As ActionResult
            If ModelState.IsValid Then
                db.BANTHANGs.Add(bANTHANG)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(bANTHANG)
        End Function

        ' GET: BanThang/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim bANTHANG As BANTHANG = db.BANTHANGs.Find(id)
            If IsNothing(bANTHANG) Then
                Return HttpNotFound()
            End If
            Return View(bANTHANG)
        End Function

        ' POST: BanThang/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="MaLoaiBanThang,BanThang1")> ByVal bANTHANG As BANTHANG) As ActionResult
            If ModelState.IsValid Then
                db.Entry(bANTHANG).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(bANTHANG)
        End Function

        ' GET: BanThang/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim bANTHANG As BANTHANG = db.BANTHANGs.Find(id)
            If IsNothing(bANTHANG) Then
                Return HttpNotFound()
            End If
            Return View(bANTHANG)
        End Function

        ' POST: BanThang/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim bANTHANG As BANTHANG = db.BANTHANGs.Find(id)
            db.BANTHANGs.Remove(bANTHANG)
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
