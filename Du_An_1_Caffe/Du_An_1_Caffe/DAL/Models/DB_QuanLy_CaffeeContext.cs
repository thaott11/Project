using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Du_An_1_Caffe.DAL.Models
{
    public partial class DB_QuanLy_CaffeeContext : DbContext
    {
        public DB_QuanLy_CaffeeContext()
        {
        }

        public DB_QuanLy_CaffeeContext(DbContextOptions<DB_QuanLy_CaffeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server= MYDESTOP\\SQLEXPRESS01;Database=DB_QuanLy_Caffee;Trusted_Connection=True; TrustServerCertificate =True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.IdHd)
                    .HasName("PK__HoaDon__16EC3947C6A3DAE8");

                entity.ToTable("HoaDon");

                entity.Property(e => e.IdHd).HasColumnName("Id_HD");

                entity.Property(e => e.IdKhachHang).HasColumnName("id_KhachHang");

                entity.Property(e => e.IdNhanVien).HasColumnName("id_NhanVien");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(20)
                    .HasColumnName("MaHD");

                entity.Property(e => e.NgayMuaHang).HasColumnType("date");

                entity.Property(e => e.NguoiTao).HasMaxLength(50);

                entity.Property(e => e.TrangThai).HasMaxLength(50);

                entity.HasOne(d => d.IdKhachHangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__id_Khach__52593CB8");

                entity.HasOne(d => d.IdNhanVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdNhanVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__id_NhanV__534D60F1");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => e.IdHoaDon)
                    .HasName("PK__HoaDonCh__4DD461C8BDAF600A");

                entity.ToTable("HoaDonChiTiet");

                entity.Property(e => e.Ghichu).HasColumnType("text");

                entity.Property(e => e.IdHoaDon1).HasColumnName("id_HoaDon");

                entity.Property(e => e.IdSanPham).HasColumnName("id_SanPham");

                entity.Property(e => e.MaHoaDon).HasMaxLength(10);

                entity.Property(e => e.TenSanPham).HasMaxLength(50);

                entity.HasOne(d => d.IdHoaDon1Navigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdHoaDon1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChi__id_Ho__571DF1D5");

                entity.HasOne(d => d.IdSanPhamNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChi__id_Sa__5629CD9C");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.ToTable("KhachHang");

                entity.Property(e => e.Diachi).HasMaxLength(255);

                entity.Property(e => e.GioiTinh).HasMaxLength(5);

                entity.Property(e => e.MaKh)
                    .HasMaxLength(50)
                    .HasColumnName("MaKH");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenKh)
                    .HasMaxLength(100)
                    .HasColumnName("TenKH");
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.ToTable("KhuyenMai");

                entity.Property(e => e.MaKm)
                    .HasMaxLength(50)
                    .HasColumnName("MaKM");

                entity.Property(e => e.NgayBatDau).HasColumnType("date");

                entity.Property(e => e.NgayKetThuc).HasColumnType("date");

                entity.Property(e => e.TenKm)
                    .HasMaxLength(100)
                    .HasColumnName("TenKM");

                entity.Property(e => e.TrangThai).HasMaxLength(20);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.ToTable("NhanVien");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(20)
                    .HasColumnName("CCCD");

                entity.Property(e => e.DiaChi).HasMaxLength(255);

                entity.Property(e => e.GioiTinh).HasMaxLength(10);

                entity.Property(e => e.MaNv)
                    .HasMaxLength(50)
                    .HasColumnName("MaNV");

                entity.Property(e => e.MatKhau).HasMaxLength(255);

                entity.Property(e => e.NgayVaoLam).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenNv)
                    .HasMaxLength(100)
                    .HasColumnName("TenNV");

                entity.Property(e => e.TenTaiKhoan).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasMaxLength(20);

                entity.Property(e => e.VaiTro).HasMaxLength(30);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.ToTable("SanPham");

                entity.Property(e => e.IdKhuyenMai).HasColumnName("id_khuyenMai");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(10)
                    .HasColumnName("MaSP");

                entity.Property(e => e.MoTa).HasColumnType("text");

                entity.Property(e => e.TenSanPham).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasMaxLength(20);

                entity.HasOne(d => d.IdKhuyenMaiNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.IdKhuyenMai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SanPham__id_khuy__4F7CD00D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
