
using Du_An_1_Caffe.DAL.Models;
using Du_An_1_Caffe.DAL.Repstory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_1_Caffe.BLL.Service
{
    public class GiamGiaSer
    {

        GiamGiaRep _rep = new GiamGiaRep();

        public List<KhuyenMai> GetAll()
        {
            return _rep.GetAllGiamGia();
        }

        public List<KhuyenMai> Seachten(string ten)
        {
            return _rep.SeachTen(ten);
        }
        // lấy ra sản all sản phẩm 
        public List<SanPham> GetAllSP()
        {
            return _rep.GetAllSanPham();
        }

        // tìm kiếm theo tên san phẩm
        public List<SanPham> SeachTenSanPham(string ten)
        {
            return _rep.SeachSanPham(ten);
        }
        public string Add(KhuyenMai gg)
        {
            if (_rep.AddGiamGia(gg))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Update(int id, KhuyenMai gg)
        {
            if (_rep.UpdateGiamGia(id, gg))
            {
                return "sua thanh cong";
            }
            return "sua that bai";
        }
    }
}
