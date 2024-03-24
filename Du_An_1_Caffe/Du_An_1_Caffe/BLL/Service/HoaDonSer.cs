
using Du_An_1_Caffe.DAL.Models;
using Du_An_1_Caffe.DAL.Repstory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_1_Caffe.BLL.Service
{
    public class HoaDonSer
    {
        HoaDonRep _ser = new HoaDonRep();

        // lấy ra tất cả hóa đơn
        public List<HoaDon> GetAllHoaDon()
        {
            return _ser.GetallHoaDon();
        }

        // seach mã hóa đơn
        public List<HoaDon> SeachMa(string ma)
        {
            return _ser.SeachMaHoaDon(ma);
        }
        //lấy ra hóa đơn chi tiết
        public List<HoaDonChiTiet> GetAllHoadonChiTiet()
        {
            return _ser.GetAllHoadonChiTiet();
        }
        // lấy ra tất cả sản phẩm
        public List<SanPham> GetAllSP()
        {
            return _ser.GetAllSanPham();
        }

        // update san phẩm 
        public string UpadateSP(SanPham sp)
        {
            if (_ser.UpdateSanPham(sp))
            {
                return "thanh cong";
            }
            return "that bai";
        }

        //Lấy ra tất cả nhân viên

        public List<NhanVien> GetAllNV()
        {
            return _ser.GetAllNhanVien();
        }
        // lấy ra tất cả khách hàng
        public List<KhachHang> GetAllKH()
        {
            return _ser.GetAllKhachHang();
        }

        // lấy ra id san phẩm
        public List<SanPham> SeachIdSP(int id)
        {
            return _ser.SeachSanPham(id);
        }


        // thêm hóa đơn chi tiết

        public string AddHDChiTiet(HoaDonChiTiet hdct)
        {
            if (_ser.AddHoaDonChiTiet(hdct))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }
        // lấy ra id sản phẩm
        public List<HoaDonChiTiet> seachIdSp(int id)
        {
            return _ser.Seachidsanpham(id);
        }

        // update trạng thái hóa đơn
        public string UpdateHD(int id, HoaDon hd)
        {
            if (_ser.UpdateHoaDon(id, hd))
            {
                return "thành cong";
            }
            return "That bai";
        }
        public List<HoaDon> SeachNgay(DateTime ngay)
        {
            return _ser.SeachNgayHoaDon(ngay);
        }
        public List<HoaDon> SeachTrangThai(string trangthai)
        {
            return _ser.SeachTrangThaiHoaDon(trangthai);
        }

        public List<HoaDon> SeachNguoiTao(string nguoiTao)
        {
            return _ser.SeachNguoiTaoHoaDon(nguoiTao);
        }


        // thêm hóa đơn
        public string AddHD(HoaDon hd)
        {
            if (_ser.AddHoaDon(hd))
            {
                return "Them thanh cong";
            }
            return "them That Bai";
        }


        // thêm khách hàng
        public string AddKH(KhachHang kh)
        {
            if (_ser.AddKhachHang(kh))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

    }
}
