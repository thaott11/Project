
using Du_An_1_Caffe.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_1_Caffe.DAL.Repstory
{
    public class SanPhamRep
    {
        DB_QuanLy_CaffeeContext db = new DB_QuanLy_CaffeeContext();

        public List<SanPham> GetSanPham()
        {
            return db.SanPhams.ToList();
        }

        public bool GetThem(SanPham sanPham)
        {
            db.SanPhams.Add(sanPham);
            db.SaveChanges();
            return true;
        }

        public bool GetSua(int? id, SanPham sanPham)
        {
            var sua = db.SanPhams.FirstOrDefault(x => x.Id == id);
            sua.MaSp = sanPham.MaSp;
            sua.TenSanPham = sanPham.TenSanPham;
            sua.DonGia = sanPham.DonGia;
            sua.DonGia = sanPham.DonGia;
            sua.SoLuong = sanPham.SoLuong;
            sua.MoTa = sanPham.MoTa;
            sua.TrangThai = sanPham.TrangThai;
            sua.HinhAnh = sanPham.HinhAnh;
            db.SanPhams.Update(sua);
            db.SaveChanges();
            return true;
        }

        public List<SanPham> FindName(string name)
        {
            return db.SanPhams.Where(x => x.TenSanPham.ToLower().Contains(name.ToLower())).ToList();
        }
        public SanPham Findid(int id)
        {
            return db.SanPhams.FirstOrDefault(x => x.Id == id);
        }

        public List<SanPham> Loc(string trangthai)
        {
            return db.SanPhams.Where(x => x.TrangThai == trangthai).ToList();
        }
    }
}
