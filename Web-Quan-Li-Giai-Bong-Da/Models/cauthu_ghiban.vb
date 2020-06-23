Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class CAUTHU_GHIBAN
    <Key>
    <Column(Order:=0)>
    <StringLength(20)>
    Public Property MaTranDau As String

    <Key>
    <Column(Order:=1)>
    <StringLength(20)>
    Public Property MaCauThu As String

    <Key>
    <Column(Order:=2)>
    <StringLength(10)>
    Public Property ThoiDiem As String

    <Required>
    <StringLength(20)>
    Public Property MaLoaiBanThang As String

    Public Overridable Property BANTHANG As BANTHANG
End Class
