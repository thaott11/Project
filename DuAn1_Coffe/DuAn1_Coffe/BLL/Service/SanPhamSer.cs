using DuAn1_Coffe.DAL.Models;
using DuAn1_Coffe.DAL.Repstory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_Coffe.BLL.Service
{
    internal class SanPhamSer
    {
        SanPhamRep SanPhamRepositori = new SanPhamRep();

        public List<SanPham> Allsanpham()
        {
            return SanPhamRepositori.GetSanPham();
        }

        public string Them(SanPham sanPham)
        {
            if (SanPhamRepositori.GetThem(sanPham))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
        public string Sua(int? id, SanPham sanPham)
        {
            if (SanPhamRepositori.GetSua(id, sanPham))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

        public List<SanPham> Timkiem(string ma)
        {
            return SanPhamRepositori.FindName(ma);
        }
        public SanPham Findid(int id)
        {
            return SanPhamRepositori.Findid(id);
        }

        public List<SanPham> Loc(string trangthai)
        {
            return SanPhamRepositori.Loc(trangthai);
        }
    }
}
