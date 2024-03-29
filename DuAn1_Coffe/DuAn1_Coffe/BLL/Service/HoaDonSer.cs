using DuAn1_Coffe.DAL.Models;
using DuAn1_Coffe.DAL.Repstory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_Coffe.BLL.Service
{
    internal class HoaDonSer
    {
        HoaDonRep _ser = new HoaDonRep();

        // lấy ra tất cả hóa đơn
        public List<HoaDon> GetAllHD()
        {
            return _ser.GetallHoaDon();
        }
         public string Xoa(int id, HoaDon hoaDon)
        {
            if (_ser.Xoa(id, hoaDon))
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất công";
            }
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

        // lấy ra mã hóa đơn chi tiết

        public List<HoaDonChiTiet> SeachMaHDCT(string ma)
        {
            return _ser.SeachMaHoaDonChiTiet(ma);
        }
        // lấy ra tất cả sản phẩm
        public List<SanPham> GetAllSP()
        {
            return _ser.GetAllSanPham();
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

        // update số lượng sản phẩm khi cho vào hóa đơn chi tiết

        public string UpdateSP(int id, SanPham sp)
        {
            if (_ser.UpdateSanPham(id, sp))
            {
                return "thanh cong";
            }
            return "That bai";
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
        // Update hóa đơn chi tiết

        public string UpdateHDCT(HoaDonChiTiet hdct)
        {
            if (_ser.UpdateHoaDonChiTiet(hdct))
            {
                return "thanh cong";
            }
            return "that bai";
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

        public List<GiamGium> GetAllKM()
        {
            return _ser.GetAllGiamGia();
        }

        // remove Hóa đơn chi tiết

        public bool RemoveHDCT(int id)
        {
            if (_ser.RemoveHoaDonChiTiet(id))
            {
                return true;
            }
            return false;
        }
    }
}
