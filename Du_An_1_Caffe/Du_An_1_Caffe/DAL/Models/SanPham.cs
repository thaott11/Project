using System;
using System.Collections.Generic;

namespace Du_An_1_Caffe.DAL.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public int Id { get; set; }
        public string MaSp { get; set; } = null!;
        public string TenSanPham { get; set; } = null!;
        public double? DonGia { get; set; }
        public int? SoLuong { get; set; }
        public string? TrangThai { get; set; }
        public string? MoTa { get; set; }
        public byte[]? HinhAnh { get; set; }
        public int IdKhuyenMai { get; set; }

        public virtual KhuyenMai IdKhuyenMaiNavigation { get; set; } = null!;
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
