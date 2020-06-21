Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("san")>
Partial Public Class san
    Public Sub New()
        doibongs = New HashSet(Of doibong)()
    End Sub

    <Key>
    <StringLength(20)>
    Public Property MaSan As String

    <StringLength(20)>
    Public Property TenSan As String

    <StringLength(30)>
    Public Property Diachi As String

    Public Overridable Property doibongs As ICollection(Of doibong)
End Class
