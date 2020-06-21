Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class Model1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Model1")
    End Sub

    Public Overridable Property banthangs As DbSet(Of banthang)
    Public Overridable Property bxh_doi As DbSet(Of bxh_doi)
    Public Overridable Property cauthus As DbSet(Of cauthu)
    Public Overridable Property cauthu_ghiban As DbSet(Of cauthu_ghiban)
    Public Overridable Property cauthu_rasan As DbSet(Of cauthu_rasan)
    Public Overridable Property doibongs As DbSet(Of doibong)
    Public Overridable Property loaicauthus As DbSet(Of loaicauthu)
    Public Overridable Property muagiais As DbSet(Of muagiai)
    Public Overridable Property sans As DbSet(Of san)
    Public Overridable Property thamsoes As DbSet(Of thamso)
    Public Overridable Property trandaus As DbSet(Of trandau)
    Public Overridable Property trongtais As DbSet(Of trongtai)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of banthang)() _
            .Property(Function(e) e.MaLoaiBanThang) _
            .IsUnicode(False)

        modelBuilder.Entity(Of banthang)() _
            .Property(Function(e) e.BanThang1) _
            .IsUnicode(False)

        modelBuilder.Entity(Of banthang)() _
            .HasMany(Function(e) e.cauthu_ghiban) _
            .WithRequired(Function(e) e.banthang) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of bxh_doi)() _
            .Property(Function(e) e.MaDoi) _
            .IsUnicode(False)

        modelBuilder.Entity(Of bxh_doi)() _
            .Property(Function(e) e.MaMua) _
            .IsUnicode(False)

        modelBuilder.Entity(Of cauthu)() _
            .Property(Function(e) e.MaCauThu) _
            .IsUnicode(False)

        modelBuilder.Entity(Of cauthu)() _
            .Property(Function(e) e.MaDoi) _
            .IsUnicode(False)

        modelBuilder.Entity(Of cauthu)() _
            .Property(Function(e) e.TenCauThu) _
            .IsUnicode(False)

        modelBuilder.Entity(Of cauthu)() _
            .Property(Function(e) e.MaLoaiCauThu) _
            .IsUnicode(False)

        modelBuilder.Entity(Of cauthu)() _
            .Property(Function(e) e.QuocTich) _
            .IsUnicode(False)

        modelBuilder.Entity(Of cauthu)() _
            .Property(Function(e) e.GhiChu) _
            .IsUnicode(False)

        modelBuilder.Entity(Of cauthu)() _
            .Property(Function(e) e.HinhAnh) _
            .IsUnicode(False)

        modelBuilder.Entity(Of cauthu_ghiban)() _
            .Property(Function(e) e.MaTranDau) _
            .IsUnicode(False)

        modelBuilder.Entity(Of cauthu_ghiban)() _
            .Property(Function(e) e.MaCauThu) _
            .IsUnicode(False)

        modelBuilder.Entity(Of cauthu_ghiban)() _
            .Property(Function(e) e.ThoiDiem) _
            .IsUnicode(False)

        modelBuilder.Entity(Of cauthu_ghiban)() _
            .Property(Function(e) e.MaLoaiBanThang) _
            .IsUnicode(False)

        modelBuilder.Entity(Of cauthu_rasan)() _
            .Property(Function(e) e.MaTranDau) _
            .IsUnicode(False)

        modelBuilder.Entity(Of cauthu_rasan)() _
            .Property(Function(e) e.MaCauThu) _
            .IsUnicode(False)

        modelBuilder.Entity(Of cauthu_rasan)() _
            .Property(Function(e) e.MaDoi) _
            .IsUnicode(False)

        modelBuilder.Entity(Of cauthu_rasan)() _
            .Property(Function(e) e.ViTri) _
            .IsUnicode(False)

        modelBuilder.Entity(Of doibong)() _
            .Property(Function(e) e.MaDoi) _
            .IsUnicode(False)

        modelBuilder.Entity(Of doibong)() _
            .Property(Function(e) e.TenDoi) _
            .IsUnicode(False)

        modelBuilder.Entity(Of doibong)() _
            .Property(Function(e) e.MaSan) _
            .IsUnicode(False)

        modelBuilder.Entity(Of doibong)() _
            .HasMany(Function(e) e.cauthus) _
            .WithRequired(Function(e) e.doibong) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of doibong)() _
            .HasMany(Function(e) e.cauthu_rasan) _
            .WithRequired(Function(e) e.doibong) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of loaicauthu)() _
            .Property(Function(e) e.MaLoaiCauThu) _
            .IsUnicode(False)

        modelBuilder.Entity(Of loaicauthu)() _
            .Property(Function(e) e.LoaiCauThu1) _
            .IsUnicode(False)

        modelBuilder.Entity(Of muagiai)() _
            .Property(Function(e) e.MaMua) _
            .IsUnicode(False)

        modelBuilder.Entity(Of muagiai)() _
            .Property(Function(e) e.TenMua) _
            .IsUnicode(False)

        modelBuilder.Entity(Of muagiai)() _
            .HasMany(Function(e) e.trandaus) _
            .WithRequired(Function(e) e.muagiai) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of san)() _
            .Property(Function(e) e.MaSan) _
            .IsUnicode(False)

        modelBuilder.Entity(Of san)() _
            .Property(Function(e) e.TenSan) _
            .IsUnicode(False)

        modelBuilder.Entity(Of san)() _
            .Property(Function(e) e.Diachi) _
            .IsUnicode(False)

        modelBuilder.Entity(Of san)() _
            .HasMany(Function(e) e.doibongs) _
            .WithRequired(Function(e) e.san) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of thamso)() _
            .Property(Function(e) e.MaTS) _
            .IsUnicode(False)

        modelBuilder.Entity(Of trandau)() _
            .Property(Function(e) e.MaTranDau) _
            .IsUnicode(False)

        modelBuilder.Entity(Of trandau)() _
            .Property(Function(e) e.MaMua) _
            .IsUnicode(False)

        modelBuilder.Entity(Of trandau)() _
            .Property(Function(e) e.MaDoi1) _
            .IsUnicode(False)

        modelBuilder.Entity(Of trandau)() _
            .Property(Function(e) e.MaDoi2) _
            .IsUnicode(False)

        modelBuilder.Entity(Of trandau)() _
            .Property(Function(e) e.Luot) _
            .IsUnicode(False)

        modelBuilder.Entity(Of trandau)() _
            .Property(Function(e) e.MaSan) _
            .IsUnicode(False)

        modelBuilder.Entity(Of trandau)() _
            .Property(Function(e) e.MaTrongTai) _
            .IsUnicode(False)

        modelBuilder.Entity(Of trongtai)() _
            .Property(Function(e) e.MaTrongTai) _
            .IsUnicode(False)

        modelBuilder.Entity(Of trongtai)() _
            .Property(Function(e) e.TenTrongTai) _
            .IsUnicode(False)

        modelBuilder.Entity(Of trongtai)() _
            .Property(Function(e) e.QuocTich) _
            .IsUnicode(False)

        modelBuilder.Entity(Of trongtai)() _
            .HasMany(Function(e) e.trandaus) _
            .WithRequired(Function(e) e.trongtai) _
            .WillCascadeOnDelete(False)
    End Sub
End Class
