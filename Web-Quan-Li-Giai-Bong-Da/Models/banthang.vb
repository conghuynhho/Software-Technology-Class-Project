Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("banthang")>
Partial Public Class banthang
    Public Sub New()
        cauthu_ghiban = New HashSet(Of cauthu_ghiban)()
    End Sub

    <Key>
    <StringLength(20)>
    Public Property MaLoaiBanThang As String

    <Column("BanThang")>
    <StringLength(20)>
    Public Property BanThang1 As String

    Public Overridable Property cauthu_ghiban As ICollection(Of cauthu_ghiban)
End Class
