Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("BANTHANG")>
Partial Public Class BANTHANG
    Public Sub New()
        CAUTHU_GHIBAN = New HashSet(Of CAUTHU_GHIBAN)()
    End Sub

    <Key>
    <StringLength(20)>
    Public Property MaLoaiBanThang As String

    <Column("BanThang")>
    <StringLength(20)>
    Public Property BanThang As String

    Public Overridable Property CAUTHU_GHIBAN As ICollection(Of CAUTHU_GHIBAN)
End Class
