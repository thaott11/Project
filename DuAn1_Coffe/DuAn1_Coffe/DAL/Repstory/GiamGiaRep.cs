using DuAn1_Coffe.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_Coffe.DAL.Repstory
{
    internal class GiamGiaRep
    {
        DB_QuanLy_CaffeeContext db = new DB_QuanLy_CaffeeContext();

        public List<GiamGium> Getgiamgia()
        {
            return db.GiamGia.ToList();
        }

        public bool GetThem(GiamGium giamGia)
        {
            db.GiamGia.Add(giamGia);
            db.SaveChanges();
            return true;
        }
        public bool GetSua(int? id, GiamGium giamGia)
        {
            var sua = db.GiamGia.FirstOrDefault(x => x.Id == id);
            sua.MaGiamGia = giamGia.MaGiamGia;
            sua.NgayBatDau = giamGia.NgayBatDau;
            sua.TiLeGiam = giamGia.TiLeGiam;
            sua.DonHangToiThieu = giamGia.DonHangToiThieu;
            sua.GiamToiDa = giamGia.GiamToiDa;
            sua.SoLuong = giamGia.SoLuong;
            db.GiamGia.Update(sua);
            db.SaveChanges();
            return true;
        }

        public List<GiamGium> FindMa(string ma)
        {
            return db.GiamGia.Where(x => x.MaGiamGia.ToLower().Contains(ma.ToLower())).ToList();
        }
    }
}
