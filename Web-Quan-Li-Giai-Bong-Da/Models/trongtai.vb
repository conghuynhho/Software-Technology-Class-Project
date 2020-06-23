Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("TRONGTAI")>
Partial Public Class TRONGTAI
    Public Sub New()
        TRAUDAUs = New HashSet(Of TRAUDAU)()
    End Sub

    <Key>
    <StringLength(20)>
    Public Property MaTrongTai As String

    <StringLength(20)>
    Public Property TenTrongTai As String

    <StringLength(20)>
    Public Property QuocTich As String

    Public Overridable Property TRAUDAUs As ICollection(Of TRAUDAU)
End Class
