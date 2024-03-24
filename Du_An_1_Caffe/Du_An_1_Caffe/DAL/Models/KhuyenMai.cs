using System;
using System.Collections.Generic;

namespace Du_An_1_Caffe.DAL.Models
{
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int Id { get; set; }
        public string MaKm { get; set; } = null!;
        public string TenKm { get; set; } = null!;
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public double? GiaGiam { get; set; }
        public string? TrangThai { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
