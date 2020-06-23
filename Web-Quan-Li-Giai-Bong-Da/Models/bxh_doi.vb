Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class BXH_DOI
    <Key>
    <Column(Order:=0)>
    <StringLength(20)>
    Public Property MaDoi As String

    <Key>
    <Column(Order:=1)>
    <StringLength(20)>
    Public Property MaMua As String

    Public Property TongSoBanThang As Integer?

    Public Property TongSoBanThua As Integer?

    Public Property Thang As Integer?

    Public Property Hoa As Integer?

    Public Property Thua As Integer?
End Class
