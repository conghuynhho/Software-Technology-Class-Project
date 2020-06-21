Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("doibong")>
Partial Public Class doibong
    Public Sub New()
        cauthus = New HashSet(Of cauthu)()
        cauthu_rasan = New HashSet(Of cauthu_rasan)()
    End Sub

    <Key>
    <StringLength(20)>
    Public Property MaDoi As String

    <StringLength(100)>
    Public Property TenDoi As String

    <Required>
    <StringLength(20)>
    Public Property MaSan As String

    <Column(TypeName:="date")>
    Public Property NgayThanhLap As Date?

    Public Overridable Property cauthus As ICollection(Of cauthu)

    Public Overridable Property cauthu_rasan As ICollection(Of cauthu_rasan)

    Public Overridable Property san As san
End Class
