﻿
using Du_An_1_Caffe.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_1_Caffe.DAL.Repstory
{
    public class NhanVienRep
    {
        DB_QuanLy_CaffeeContext db = new DB_QuanLy_CaffeeContext();

        public List<NhanVien> GetNhanVien()
        {
            return db.NhanViens.ToList();
        }
        public bool GetThem(NhanVien nhanVien)
        {
            db.NhanViens.Add(nhanVien);
            db.SaveChanges();
            return true;
        }
        public bool GetSua(int? id, NhanVien nhanVien)
        {
            var sua = db.NhanViens.FirstOrDefault(x => x.Id == id);
            sua.MaNv = nhanVien.MaNv;
            sua.TenNv = nhanVien.TenNv;
            sua.GioiTinh = nhanVien.GioiTinh;
            sua.Sdt = nhanVien.Sdt;
            sua.DiaChi = nhanVien.DiaChi;
            sua.Cccd = nhanVien.Cccd;
            sua.TenTaiKhoan = nhanVien.TenTaiKhoan;
            sua.VaiTro = nhanVien.VaiTro;
            sua.MatKhau = nhanVien.MatKhau;
            sua.NgayVaoLam = nhanVien.NgayVaoLam;
            sua.TrangThai = nhanVien.TrangThai;
            sua.HinhAnh = nhanVien.HinhAnh;
            db.NhanViens.Update(sua);
            db.SaveChanges();
            return true;
        }

        public List<NhanVien> FindName(string name)
        {
            return db.NhanViens.Where(x => x.TenNv.ToLower().Contains(name.ToLower())).ToList();
        }
        public NhanVien Findid(int id)
        {
            return db.NhanViens.FirstOrDefault(x => x.Id == id);
        }
        public List<NhanVien> Locc(string vaitro)
        {
            return db.NhanViens.Where(x => x.VaiTro == vaitro).ToList();
        }
    }
}
