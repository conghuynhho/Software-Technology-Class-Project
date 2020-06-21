Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("muagiai")>
Partial Public Class muagiai
    Public Sub New()
        trandaus = New HashSet(Of trandau)()
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

    Public Overridable Property trandaus As ICollection(Of trandau)
End Class
