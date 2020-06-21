Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("loaicauthu")>
Partial Public Class loaicauthu
    Public Sub New()
        cauthus = New HashSet(Of cauthu)()
    End Sub

    <Key>
    <StringLength(20)>
    Public Property MaLoaiCauThu As String

    <Column("LoaiCauThu")>
    <StringLength(30)>
    Public Property LoaiCauThu1 As String

    Public Overridable Property cauthus As ICollection(Of cauthu)
End Class
