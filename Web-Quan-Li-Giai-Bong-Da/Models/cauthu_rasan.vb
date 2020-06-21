Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class cauthu_rasan
    <Key>
    <Column(Order:=0)>
    <StringLength(20)>
    Public Property MaTranDau As String

    <Key>
    <Column(Order:=1)>
    <StringLength(20)>
    Public Property MaCauThu As String

    <Required>
    <StringLength(20)>
    Public Property MaDoi As String

    Public Property SoAo As Integer?

    <StringLength(20)>
    Public Property ViTri As String

    Public Overridable Property doibong As doibong
End Class
