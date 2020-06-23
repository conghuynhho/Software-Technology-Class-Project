Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("THAMSO")>
Partial Public Class THAMSO
    <Key>
    <StringLength(16)>
    Public Property MaTS As String

    Public Property TuoiTT As Integer?

    Public Property TuoiTD As Integer?

    Public Property SoCauThuTT As Integer?

    Public Property SoCauThuTD As Integer?

    Public Property SoCauThuNgoaiTD As Integer?

    Public Property ThoiDiemTT As Integer?

    Public Property ThoiDiemTD As Integer?

    Public Property DiemThang As Integer?

    Public Property DiemHoa As Integer?

    Public Property DiemThua As Integer?
End Class
