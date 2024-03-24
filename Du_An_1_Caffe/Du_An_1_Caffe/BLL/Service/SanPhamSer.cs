
using Du_An_1_Caffe.DAL.Models;
using Du_An_1_Caffe.DAL.Repstory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_1_Caffe.BLL.Service
{
    public class SanPhamSer
    {
        SanPhamRep _ser = new SanPhamRep();
        public List<SanPham> Allsanpham()
        {
            return _ser.GetSanPham();
        }

        public string Them(SanPham sanPham)
        {
            if (_ser.GetThem(sanPham))
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
            if (_ser.GetSua(id, sanPham))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

        public List<SanPham> Timkiem(string name)
        {
            return _ser.FindName(name);
        }
        public SanPham Findid(int id)
        {
            return _ser.Findid(id);
        }

        public List<SanPham> Loc(string trangthai)
        {
            return _ser.Loc(trangthai);
        }
    }
}
