using DuAn1_Coffe.BLL.Service;
using DuAn1_Coffe.DAL.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1_Coffe.PRL.Forms
{
    public partial class Form_QuanLyHoaDon : Form
    {
        HoaDonSer HoaDonService = new HoaDonSer();
        HoaDonChiTietSer HoaDonchitietService = new HoaDonChiTietSer();
        NhanVienSer NhanVienService = new NhanVienSer();
        KhachHangSer KhachHangService = new KhachHangSer();
        SanPhamSer SanPhamService = new SanPhamSer();
        public Form_QuanLyHoaDon()
        {
            InitializeComponent();
            LoadDataHoaDon(HoaDonService.GetAllHD());
            LoatLocHoaDon();
        }

        public void LoadDataHoaDon(List<HoaDon> data)
        {
            int stt = 1;
            dgvhoadon.ColumnCount = 7;
            dgvhoadon.Rows.Clear();
            dgvhoadon.Columns[0].Name = "Id";
            dgvhoadon.Columns[1].Name = "Stt";
            dgvhoadon.Columns[2].Name = "MaHD";
            dgvhoadon.Columns[3].Name = "Ngày Mua Hàng";
            dgvhoadon.Columns[4].Name = "Nhân Viên";
            dgvhoadon.Columns[5].Name = "khách hàng";
            dgvhoadon.Columns[6].Name = "Trạng thái";
            dgvhoadon.Columns[0].Visible = false;
            foreach (var item in HoaDonService.GetAllHD())
            {
                var nv = NhanVienService.AllNhanVien().FirstOrDefault(x => x.Id == item.IdNhanVien);
                var kh = KhachHangService.AllKhachHang().FirstOrDefault(x => x.Id == item.IdKhachHang);
                dgvhoadon.Rows.Add(item.IdHd, stt++, item.MaHd, item.NgayMuaHang, nv.TenNv, kh.TenKh, item.TrangThai);
            }
        }

        private void btn_timNgay_Click(object sender, EventArgs e)
        {
            DateTime ngayTu = dtpTu.Value.Date;
            DateTime ngayDen = dtpDen.Value.Date.AddDays(1).AddSeconds(-1);
            // Gọi hóa đơn và lấy ra ngày đã chọn
            List<HoaDon> SeachNgay = HoaDonService.GetAllHD().Where(hd => hd.NgayMuaHang >= ngayTu && hd.NgayMuaHang <= ngayDen).ToList();
            LoadDataHoaDon(SeachNgay);
        }


        public void TimkiemMaHD(string ma)
        {
            int stt = 1;
            dgvhoadon.ColumnCount = 7;
            dgvhoadon.Rows.Clear();
            dgvhoadon.Columns[0].Name = "Id";
            dgvhoadon.Columns[1].Name = "Stt";
            dgvhoadon.Columns[2].Name = "MaHD";
            dgvhoadon.Columns[3].Name = "Ngày Mua Hàng";
            dgvhoadon.Columns[4].Name = "Nhân Viên";
            dgvhoadon.Columns[5].Name = "khách hàng";
            dgvhoadon.Columns[6].Name = "Trạng thái";
            dgvhoadon.Columns[0].Visible = false;
            foreach (var item in HoaDonService.SeachMa(ma))
            {
                var nv = NhanVienService.AllNhanVien().FirstOrDefault(x => x.Id == item.IdNhanVien);
                var kh = KhachHangService.AllKhachHang().FirstOrDefault(x => x.Id == item.IdKhachHang);
                dgvhoadon.Rows.Add(item.IdHd, stt++, item.MaHd, item.NgayMuaHang, nv.TenNv, kh.TenKh, item.TrangThai);
            }
        }
        private void txttimkiemmahoadon_TextChanged(object sender, EventArgs e)
        {
            TimkiemMaHD(txttimkiemmahoadon.Text);
        }

        private void txttimkiemnguoitao_TextChanged(object sender, EventArgs e)
        {
            LoadDataHoaDon(HoaDonService.SeachMa(txttimkiemnguoitao.Text));
        }


        public void LoatHoaDonChiTiet(string ma)
        {
            dgvhoadonchitiet.Rows.Clear();
            dgvhoadonchitiet.ColumnCount = 9;
            dgvhoadonchitiet.Columns[0].Name = "stt";
            dgvhoadonchitiet.Columns[1].Name = "Id Hóa Đơn CT";
            dgvhoadonchitiet.Columns[2].Name = "MaHD";
            dgvhoadonchitiet.Columns[3].Name = "tên SP";
            dgvhoadonchitiet.Columns[4].Name = "Sô Lượng";
            dgvhoadonchitiet.Columns[5].Name = "Giá";
            dgvhoadonchitiet.Columns[6].Name = "Id San phẩm";
            dgvhoadonchitiet.Columns[7].Name = "Id Hoa Đơn";
            dgvhoadonchitiet.Columns[8].Name = "Id Giam gia";
            dgvhoadonchitiet.Columns[8].Visible = false;
            dgvhoadonchitiet.Columns[1].Visible = false;
            // Lấy danh sách hóa đơn chi tiết từ db trên mã hóa đơn
            List<HoaDonChiTiet> hdctList = HoaDonService.SeachMaHDCT(ma);
            int stt = 1;
            foreach (var x in hdctList)
            {
                dgvhoadonchitiet.Rows.Add(stt++, x.IdHoaDon, x.MaHoaDon, x.TenSanPham,
                    x.SoLuong, x.TongGia, x.IdSanPham, x.IdHoaDon1, x.IdGiamGia);
            }
        }
        public void LoatLocHoaDon()
        {
            cbolochoadon.DataSource = HoaDonService.GetAllHD();
            cbolochoadon.ValueMember = "Id";
            cbolochoadon.DisplayMember = "TrangThai";
        }

        public void LoatTongtien()
        {
            double tongTien = 0;
            foreach (DataGridViewRow row in dgvhoadonchitiet.Rows)
            {
                double thanhTien;
                if (row.Cells["Giá"].Value != null && double.TryParse(row.Cells["Giá"].Value.ToString(), out thanhTien))
                {
                    tongTien += thanhTien;
                }
            }

            lbtonggia.Text = tongTien + "VND".ToString();
        }
        private void dgvhoadon_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maHoaDon = dgvhoadon.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();

                LoatHoaDonChiTiet(maHoaDon);
                LoatTongtien();
            }
        }

        private void cbolochoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbolochoadon.SelectedItem != null)
            {
                string trangThai = cbolochoadon.Text;

                // Lọc danh sách hóa đơn theo trạng thái đã chọn
                List<HoaDon> hoaDonList = HoaDonService.GetAllHD().Where(hd => hd.TrangThai == trangThai).ToList();

                // Hiển thị danh sách hóa đơn lên DataGridView hoặc ListBox hoặc bất kỳ điều khiển nào bạn muốn
                // Ví dụ: hiển thị lên DataGridView
                dgvhoadon.DataSource = hoaDonList;
            }
        }
    }
}
