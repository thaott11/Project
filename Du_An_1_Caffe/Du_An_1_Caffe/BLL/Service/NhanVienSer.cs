
using Du_An_1_Caffe.DAL.Models;
using Du_An_1_Caffe.DAL.Repstory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_1_Caffe.BLL.Service
{
    public class NhanVienSer
    {
        NhanVienRep _ser = new NhanVienRep();
        public List<NhanVien> AllNhanVien()
        {
            return _ser.GetNhanVien();
        }

        public string Them(NhanVien nhanVien)
        {
            if (_ser.GetThem(nhanVien))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string Sua(int? id, NhanVien nhanVien)
        {
            if (_ser.GetSua(id, nhanVien))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

        public List<NhanVien> Timkiem(string name)
        {
            return _ser.FindName(name);
        }
        public NhanVien Findid(int id)
        {
            return _ser.Findid(id);
        }
        public List<NhanVien> Loc(string Vaitro)
        {
            return _ser.Locc(Vaitro);
        }
    }
}
