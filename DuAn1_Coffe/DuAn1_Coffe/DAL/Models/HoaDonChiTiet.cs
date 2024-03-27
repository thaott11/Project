using System;
using System.Collections.Generic;

namespace DuAn1_Coffe.DAL.Models
{
    public partial class HoaDonChiTiet
    {
        public int IdHoaDon { get; set; }
        public string MaHoaDon { get; set; } = null!;
        public string? TenSanPham { get; set; }
        public int? SoLuong { get; set; }
        public double? TongGia { get; set; }
        public string? Ghichu { get; set; }
        public int? IdSanPham { get; set; }
        public int? IdHoaDon1 { get; set; }
        public int? IdGiamGia { get; set; }

        public virtual GiamGium? IdGiamGiaNavigation { get; set; }
        public virtual HoaDon? IdHoaDon1Navigation { get; set; }
        public virtual SanPham? IdSanPhamNavigation { get; set; }
    }
}
