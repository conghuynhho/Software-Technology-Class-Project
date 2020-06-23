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
    Public Class ThamSoController
        Inherits System.Web.Mvc.Controller

        Private db As New Model1

        ' GET: ThamSo
        Function Index() As ActionResult
            Return View(db.THAMSOes.ToList())
        End Function

        ' GET: ThamSo/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tHAMSO As THAMSO = db.THAMSOes.Find(id)
            If IsNothing(tHAMSO) Then
                Return HttpNotFound()
            End If
            Return View(tHAMSO)
        End Function

        ' GET: ThamSo/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: ThamSo/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="MaTS,TuoiTT,TuoiTD,SoCauThuTT,SoCauThuTD,SoCauThuNgoaiTD,ThoiDiemTT,ThoiDiemTD,DiemThang,DiemHoa,DiemThua")> ByVal tHAMSO As THAMSO) As ActionResult
            If ModelState.IsValid Then
                db.THAMSOes.Add(tHAMSO)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tHAMSO)
        End Function

        ' GET: ThamSo/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tHAMSO As THAMSO = db.THAMSOes.Find(id)
            If IsNothing(tHAMSO) Then
                Return HttpNotFound()
            End If
            Return View(tHAMSO)
        End Function

        ' POST: ThamSo/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="MaTS,TuoiTT,TuoiTD,SoCauThuTT,SoCauThuTD,SoCauThuNgoaiTD,ThoiDiemTT,ThoiDiemTD,DiemThang,DiemHoa,DiemThua")> ByVal tHAMSO As THAMSO) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tHAMSO).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tHAMSO)
        End Function

        ' GET: ThamSo/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tHAMSO As THAMSO = db.THAMSOes.Find(id)
            If IsNothing(tHAMSO) Then
                Return HttpNotFound()
            End If
            Return View(tHAMSO)
        End Function

        ' POST: ThamSo/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim tHAMSO As THAMSO = db.THAMSOes.Find(id)
            db.THAMSOes.Remove(tHAMSO)
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
