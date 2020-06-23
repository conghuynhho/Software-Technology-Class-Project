Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("DOIBONG")>
Partial Public Class DOIBONG
    Public Sub New()
        CAUTHUs = New HashSet(Of CAUTHU)()
        CAUTHU_RASAN = New HashSet(Of CAUTHU_RASAN)()
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

    Public Overridable Property CAUTHUs As ICollection(Of CAUTHU)

    Public Overridable Property CAUTHU_RASAN As ICollection(Of CAUTHU_RASAN)

    Public Overridable Property SAN As SAN
End Class
