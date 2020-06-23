Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("LOAICAUTHU")>
Partial Public Class LOAICAUTHU
    Public Sub New()
        CAUTHUs = New HashSet(Of CAUTHU)()
    End Sub

    <Key>
    <StringLength(20)>
    Public Property MaLoaiCauThu As String

    <Column("LoaiCauThu")>
    <StringLength(30)>
    Public Property LoaiCauThu As String

    Public Overridable Property CAUTHUs As ICollection(Of CAUTHU)
End Class
