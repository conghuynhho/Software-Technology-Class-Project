Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("CAUTHU")>
Partial Public Class CAUTHU
    <Key>
    <StringLength(20)>
    Public Property MaCauThu As String

    <Required>
    <StringLength(20)>
    Public Property MaDoi As String

    <Required>
    <StringLength(20)>
    Public Property TenCauThu As String

    <Column(TypeName:="date")>
    Public Property NgaySinh As Date?

    <StringLength(20)>
    Public Property MaLoaiCauThu As String

    <StringLength(10)>
    Public Property QuocTich As String

    <StringLength(20)>
    Public Property GhiChu As String

    <StringLength(1000)>
    Public Property HinhAnh As String

    Public Overridable Property DOIBONG As DOIBONG

    Public Overridable Property LOAICAUTHU As LOAICAUTHU
End Class
