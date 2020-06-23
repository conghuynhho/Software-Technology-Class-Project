Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("MUAGIAI")>
Partial Public Class MUAGIAI
    Public Sub New()
        TRAUDAUs = New HashSet(Of TRAUDAU)()
    End Sub

    <Key>
    <StringLength(20)>
    Public Property MaMua As String

    <Required>
    <StringLength(10)>
    Public Property TenMua As String

    <Column(TypeName:="date")>
    Public Property NgayBatDau As Date?

    <Column(TypeName:="date")>
    Public Property NgayKetThuc As Date?

    Public Overridable Property TRAUDAUs As ICollection(Of TRAUDAU)
End Class
