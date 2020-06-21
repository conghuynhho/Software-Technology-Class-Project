Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("trongtai")>
Partial Public Class trongtai
    Public Sub New()
        trandaus = New HashSet(Of trandau)()
    End Sub

    <Key>
    <StringLength(20)>
    Public Property MaTrongTai As String

    <StringLength(20)>
    Public Property TenTrongTai As String

    <StringLength(20)>
    Public Property QuocTich As String

    Public Overridable Property trandaus As ICollection(Of trandau)
End Class
