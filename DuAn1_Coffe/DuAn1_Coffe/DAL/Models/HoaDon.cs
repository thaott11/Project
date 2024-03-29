﻿using System;
using System.Collections.Generic;

namespace DuAn1_Coffe.DAL.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public int IdHd { get; set; }
        public string MaHd { get; set; } = null!;
        public DateTime NgayMuaHang { get; set; }
        public string? TrangThai { get; set; }
        public string? NguoiTao { get; set; }
        public int? IdKhachHang { get; set; }
        public int? IdNhanVien { get; set; }

        public virtual KhachHang? IdKhachHangNavigation { get; set; }
        public virtual NhanVien? IdNhanVienNavigation { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
