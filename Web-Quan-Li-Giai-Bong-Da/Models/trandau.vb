Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("trandau")>
Partial Public Class trandau
    <Key>
    <StringLength(20)>
    Public Property MaTranDau As String

    <Required>
    <StringLength(20)>
    Public Property MaMua As String

    <Required>
    <StringLength(20)>
    Public Property MaDoi1 As String

    <Required>
    <StringLength(20)>
    Public Property MaDoi2 As String

    <StringLength(10)>
    Public Property Luot As String

    <StringLength(10)>
    Public Property MaSan As String

    <Required>
    <StringLength(20)>
    Public Property MaTrongTai As String

    <Column(TypeName:="date")>
    Public Property Ngay As Date?

    Public Property gio As TimeSpan?

    Public Property SoBanThangDoi1 As Integer?

    Public Property SoBanThangDoi2 As Integer?

    Public Overridable Property muagiai As muagiai

    Public Overridable Property trongtai As trongtai
End Class
