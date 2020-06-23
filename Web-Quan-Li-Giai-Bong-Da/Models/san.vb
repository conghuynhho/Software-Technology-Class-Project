Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("SAN")>
Partial Public Class SAN
    Public Sub New()
        DOIBONGs = New HashSet(Of DOIBONG)()
    End Sub

    <Key>
    <StringLength(20)>
    Public Property MaSan As String

    <StringLength(20)>
    Public Property TenSan As String

    <StringLength(30)>
    Public Property Diachi As String

    Public Overridable Property DOIBONGs As ICollection(Of DOIBONG)
End Class
