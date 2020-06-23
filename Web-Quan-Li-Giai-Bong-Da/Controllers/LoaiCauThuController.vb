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
    Public Class LoaiCauThuController
        Inherits System.Web.Mvc.Controller

        Private db As New Model1

        ' GET: LoaiCauThu
        Function Index() As ActionResult
            Return View(db.LOAICAUTHUs.ToList())
        End Function

        ' GET: LoaiCauThu/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim lOAICAUTHU As LOAICAUTHU = db.LOAICAUTHUs.Find(id)
            If IsNothing(lOAICAUTHU) Then
                Return HttpNotFound()
            End If
            Return View(lOAICAUTHU)
        End Function

        ' GET: LoaiCauThu/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: LoaiCauThu/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="MaLoaiCauThu,LoaiCauThu1")> ByVal lOAICAUTHU As LOAICAUTHU) As ActionResult
            If ModelState.IsValid Then
                db.LOAICAUTHUs.Add(lOAICAUTHU)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(lOAICAUTHU)
        End Function

        ' GET: LoaiCauThu/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim lOAICAUTHU As LOAICAUTHU = db.LOAICAUTHUs.Find(id)
            If IsNothing(lOAICAUTHU) Then
                Return HttpNotFound()
            End If
            Return View(lOAICAUTHU)
        End Function

        ' POST: LoaiCauThu/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="MaLoaiCauThu,LoaiCauThu1")> ByVal lOAICAUTHU As LOAICAUTHU) As ActionResult
            If ModelState.IsValid Then
                db.Entry(lOAICAUTHU).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(lOAICAUTHU)
        End Function

        ' GET: LoaiCauThu/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim lOAICAUTHU As LOAICAUTHU = db.LOAICAUTHUs.Find(id)
            If IsNothing(lOAICAUTHU) Then
                Return HttpNotFound()
            End If
            Return View(lOAICAUTHU)
        End Function

        ' POST: LoaiCauThu/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim lOAICAUTHU As LOAICAUTHU = db.LOAICAUTHUs.Find(id)
            db.LOAICAUTHUs.Remove(lOAICAUTHU)
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
