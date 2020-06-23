Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class Model1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Model1")
    End Sub

    Public Overridable Property BANTHANGs As DbSet(Of BANTHANG)
    Public Overridable Property BXH_DOI As DbSet(Of BXH_DOI)
    Public Overridable Property CAUTHUs As DbSet(Of CAUTHU)
    Public Overridable Property CAUTHU_GHIBAN As DbSet(Of CAUTHU_GHIBAN)
    Public Overridable Property CAUTHU_RASAN As DbSet(Of CAUTHU_RASAN)
    Public Overridable Property DOIBONGs As DbSet(Of DOIBONG)
    Public Overridable Property LOAICAUTHUs As DbSet(Of LOAICAUTHU)
    Public Overridable Property MUAGIAIs As DbSet(Of MUAGIAI)
    Public Overridable Property SANs As DbSet(Of SAN)
    Public Overridable Property THAMSOes As DbSet(Of THAMSO)
    Public Overridable Property TRAUDAUs As DbSet(Of TRAUDAU)
    Public Overridable Property TRONGTAIs As DbSet(Of TRONGTAI)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of BANTHANG)() _
            .Property(Function(e) e.MaLoaiBanThang) _
            .IsUnicode(False)

        modelBuilder.Entity(Of BANTHANG)() _
            .Property(Function(e) e.BanThang) _
            .IsUnicode(False)

        modelBuilder.Entity(Of BANTHANG)() _
            .HasMany(Function(e) e.CAUTHU_GHIBAN) _
            .WithRequired(Function(e) e.BANTHANG) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of BXH_DOI)() _
            .Property(Function(e) e.MaDoi) _
            .IsUnicode(False)

        modelBuilder.Entity(Of BXH_DOI)() _
            .Property(Function(e) e.MaMua) _
            .IsUnicode(False)

        modelBuilder.Entity(Of CAUTHU)() _
            .Property(Function(e) e.MaCauThu) _
            .IsUnicode(False)

        modelBuilder.Entity(Of CAUTHU)() _
            .Property(Function(e) e.MaDoi) _
            .IsUnicode(False)

        modelBuilder.Entity(Of CAUTHU)() _
            .Property(Function(e) e.MaLoaiCauThu) _
            .IsUnicode(False)

        modelBuilder.Entity(Of CAUTHU)() _
            .Property(Function(e) e.QuocTich) _
            .IsUnicode(False)

        modelBuilder.Entity(Of CAUTHU)() _
            .Property(Function(e) e.HinhAnh) _
            .IsUnicode(False)

        modelBuilder.Entity(Of CAUTHU_GHIBAN)() _
            .Property(Function(e) e.MaTranDau) _
            .IsUnicode(False)

        modelBuilder.Entity(Of CAUTHU_GHIBAN)() _
            .Property(Function(e) e.MaCauThu) _
            .IsUnicode(False)

        modelBuilder.Entity(Of CAUTHU_GHIBAN)() _
            .Property(Function(e) e.ThoiDiem) _
            .IsUnicode(False)

        modelBuilder.Entity(Of CAUTHU_GHIBAN)() _
            .Property(Function(e) e.MaLoaiBanThang) _
            .IsUnicode(False)

        modelBuilder.Entity(Of CAUTHU_RASAN)() _
            .Property(Function(e) e.MaTranDau) _
            .IsUnicode(False)

        modelBuilder.Entity(Of CAUTHU_RASAN)() _
            .Property(Function(e) e.MaCauThu) _
            .IsUnicode(False)

        modelBuilder.Entity(Of CAUTHU_RASAN)() _
            .Property(Function(e) e.MaDoi) _
            .IsUnicode(False)

        modelBuilder.Entity(Of DOIBONG)() _
            .Property(Function(e) e.MaDoi) _
            .IsUnicode(False)

        modelBuilder.Entity(Of DOIBONG)() _
            .Property(Function(e) e.MaSan) _
            .IsUnicode(False)

        modelBuilder.Entity(Of DOIBONG)() _
            .HasMany(Function(e) e.CAUTHUs) _
            .WithRequired(Function(e) e.DOIBONG) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of DOIBONG)() _
            .HasMany(Function(e) e.CAUTHU_RASAN) _
            .WithRequired(Function(e) e.DOIBONG) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of LOAICAUTHU)() _
            .Property(Function(e) e.MaLoaiCauThu) _
            .IsUnicode(False)

        modelBuilder.Entity(Of MUAGIAI)() _
            .Property(Function(e) e.MaMua) _
            .IsUnicode(False)

        modelBuilder.Entity(Of MUAGIAI)() _
            .Property(Function(e) e.TenMua) _
            .IsUnicode(False)

        modelBuilder.Entity(Of MUAGIAI)() _
            .HasMany(Function(e) e.TRAUDAUs) _
            .WithRequired(Function(e) e.MUAGIAI) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of SAN)() _
            .Property(Function(e) e.MaSan) _
            .IsUnicode(False)

        modelBuilder.Entity(Of SAN)() _
            .HasMany(Function(e) e.DOIBONGs) _
            .WithRequired(Function(e) e.SAN) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of THAMSO)() _
            .Property(Function(e) e.MaTS) _
            .IsUnicode(False)

        modelBuilder.Entity(Of TRAUDAU)() _
            .Property(Function(e) e.MaTranDau) _
            .IsUnicode(False)

        modelBuilder.Entity(Of TRAUDAU)() _
            .Property(Function(e) e.MaMua) _
            .IsUnicode(False)

        modelBuilder.Entity(Of TRAUDAU)() _
            .Property(Function(e) e.MaDoi1) _
            .IsUnicode(False)

        modelBuilder.Entity(Of TRAUDAU)() _
            .Property(Function(e) e.MaDoi2) _
            .IsUnicode(False)

        modelBuilder.Entity(Of TRAUDAU)() _
            .Property(Function(e) e.Luot) _
            .IsUnicode(False)

        modelBuilder.Entity(Of TRAUDAU)() _
            .Property(Function(e) e.MaSan) _
            .IsUnicode(False)

        modelBuilder.Entity(Of TRAUDAU)() _
            .Property(Function(e) e.MaTrongTai) _
            .IsUnicode(False)

        modelBuilder.Entity(Of TRONGTAI)() _
            .Property(Function(e) e.MaTrongTai) _
            .IsUnicode(False)

        modelBuilder.Entity(Of TRONGTAI)() _
            .HasMany(Function(e) e.TRAUDAUs) _
            .WithRequired(Function(e) e.TRONGTAI) _
            .WillCascadeOnDelete(False)
    End Sub
End Class
