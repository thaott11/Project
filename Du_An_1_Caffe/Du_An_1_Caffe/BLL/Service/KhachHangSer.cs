
using Du_An_1_Caffe.DAL.Models;
using Du_An_1_Caffe.DAL.Repstory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_1_Caffe.BLL.Service
{
    public class KhachHangSer
    {
        KhachHangRep _ser = new KhachHangRep();
        public List<KhachHang> AllKhachHang()
        {
            return _ser.GetKhachHangs();
        }


        public string Them(KhachHang khachHang)
        {
            if (_ser.GetThem(khachHang))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string Sua(int? id, KhachHang khachHang)
        {
            if (_ser.GetSua(id, khachHang))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

        public List<KhachHang> Timkiem(string name)
        {
            return _ser.FindName(name);
        }
    }
}
