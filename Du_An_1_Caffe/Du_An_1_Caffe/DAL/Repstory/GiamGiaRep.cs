
using Du_An_1_Caffe.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_1_Caffe.DAL.Repstory
{
    public class GiamGiaRep
    {
        DB_QuanLy_CaffeeContext db = new DB_QuanLy_CaffeeContext();

        public List<KhuyenMai> GetAllGiamGia()
        {
            return db.KhuyenMais.ToList();
        }

        public List<KhuyenMai> SeachTen(string ten)
        {
            return db.KhuyenMais.Where(x => x.TenKm.Trim().ToLower().Contains(ten.ToLower())).ToList();
        }

        // lấy ra tât cả sản phẩm 
        public List<SanPham> GetAllSanPham()
        {
            return db.SanPhams.ToList();
        }

        // tìm kiếm theo tên sản sản phẩm
        public List<SanPham> SeachSanPham(string ten)
        {
            return db.SanPhams.Where(x => x.TenSanPham.Trim().ToLower().Contains(ten.ToLower())).ToList();
        }
        public bool AddGiamGia(KhuyenMai gg)
        {
            db.KhuyenMais.Add(gg);
            db.SaveChanges();
            return true;
        }

        // cập nhập mã giảm giá
        public bool UpdateGiamGia(int id, KhuyenMai gg)
        {
            var update = db.KhuyenMais.FirstOrDefault(x => x.Id == id);
            update.MaKm = gg.MaKm;
            update.TenKm = gg.TenKm;
            update.GiaGiam = gg.GiaGiam;
            update.NgayBatDau = gg.NgayBatDau;
            update.NgayKetThuc = gg.NgayKetThuc;
            update.TrangThai = gg.TrangThai;
            db.KhuyenMais.Update(update);
            db.SaveChanges();
            return true;
        }
    }
}
