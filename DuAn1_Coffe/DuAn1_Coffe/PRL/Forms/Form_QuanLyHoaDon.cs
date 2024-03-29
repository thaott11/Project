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

            LoadHD();
        }
        public void LoadHD()
        {
            int stt = 1;
            dgvhoadon.ColumnCount = 8;
            dgvhoadon.Rows.Clear();
            dgvhoadon.Columns[0].Name = "Id";
            dgvhoadon.Columns[1].Name = "Stt";
            dgvhoadon.Columns[2].Name = "MaHD";
            dgvhoadon.Columns[3].Name = "Ngày Mua Hàng";
            dgvhoadon.Columns[4].Name = "Nhân Viên";
            dgvhoadon.Columns[5].Name = "khách hàng";
            dgvhoadon.Columns[6].Name = "Trạng thái";
            dgvhoadon.Columns[7].Name = "MaKH";
            dgvhoadon.Columns[0].Visible = false;
            dgvhoadon.Columns[7].Visible = false;

            foreach (var item in HoaDonService.GetAllHD())
            {
                //var kh = KhachHangService.AllKhachHang().FirstOrDefault(x => x.Id == item.IdKhachHang);
                //var nv = NhanVienService.AllNhanVien().FirstOrDefault(x => x.Id == item.IdNhanVien);
                dgvhoadon.Rows.Add(item.IdHd, stt++, item.MaHd, item.NgayMuaHang, /*nv.TenNv, kh.TenKh*/ item.TrangThai /*kh.MaKh*/);
            }

        }
        public void LoadHD(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            int stt = 1;
            dgvhoadon.ColumnCount = 8;
            dgvhoadon.Rows.Clear();
            dgvhoadon.Columns[0].Name = "Id";
            dgvhoadon.Columns[1].Name = "Stt";
            dgvhoadon.Columns[2].Name = "MaHD";
            dgvhoadon.Columns[3].Name = "Ngày Mua Hàng";
            dgvhoadon.Columns[4].Name = "Nhân Viên";
            dgvhoadon.Columns[5].Name = "khách hàng";
            dgvhoadon.Columns[6].Name = "Trạng thái";
            dgvhoadon.Columns[7].Name = "MaKH";
            dgvhoadon.Columns[0].Visible = false;
            dgvhoadon.Columns[7].Visible = false;

            var result = from hd in HoaDonService.GetAllHD()
                         join kh in KhachHangService.AllKhachHang() on hd.IdKhachHang equals kh.Id
                         join nv in NhanVienService.AllNhanVien() on hd.IdNhanVien equals nv.Id
                         where hd.TrangThai == "Đã thanh toán" && hd.NgayMuaHang >= ngayBatDau && hd.NgayMuaHang <= ngayKetThuc
                         select
                         new
                         {
                             hd.IdHd,
                             Stt = stt++,
                             hd.MaHd,
                             hd.NgayMuaHang,
                             nv.TenNv,
                             kh.TenKh,
                             hd.TrangThai,
                             kh.MaKh
                         };
            foreach (var item in result)
            {
                dgvhoadon.Rows.Add(item.IdHd, stt++, item.MaHd, item.NgayMuaHang, item.TenNv, item.TenNv, item.TrangThai, item.MaKh);
            }
        }

        private void btn_timNgay_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dtpTu.Value.Date;
            DateTime ngayKetThuc = dtpTu.Value.Date.AddDays(1).AddSeconds(-1);
            LoadHD(ngayBatDau, ngayKetThuc);
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
        private void dgvhoadon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Rows = e.RowIndex;
            if (Rows >= 0)
            {
                int index = 0;
                var selectedHoaDonId = int.Parse(dgvhoadon.Rows[Rows].Cells[0].Value.ToString());
                var result = from hdct in HoaDonchitietService.AllHoadonchitiet()
                             join hd in HoaDonService.GetAllHD() on hdct.IdHoaDon equals hd.IdHd
                             where hdct.IdHoaDon == selectedHoaDonId
                             select
                             new
                             {
                                 hdct.IdHoaDon,
                                 Stt = ++index,
                                 hdct.MaHoaDon,
                                 hdct.TenSanPham,
                                 hdct.SoLuong,
                                 hdct.TongGia,
                                 hdct.IdHoaDon1,
                             };
                dgvhoadonchitiet.DataSource = result.ToList();

                dgvhoadonchitiet.Columns[0].HeaderText = "Id";
                dgvhoadonchitiet.Columns[1].HeaderText = "Stt";
                dgvhoadonchitiet.Columns[2].HeaderText = "MaHD";
                dgvhoadonchitiet.Columns[3].HeaderText = "TenSP";
                dgvhoadonchitiet.Columns[4].HeaderText = "Số Lượng";
                dgvhoadonchitiet.Columns[5].HeaderText = "Thành Tiền";
                dgvhoadonchitiet.Columns[6].HeaderText = "IdHD";
                dgvhoadonchitiet.Columns[0].Visible = false;
                dgvhoadonchitiet.Columns[6].Visible = false;
            }
        }
        private void cbolochoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void txttimkiemmahoadon_TextChanged(object sender, EventArgs e)
        {
            TimkiemMaHD(txttimkiemmahoadon.Text);
        }

        private void txttimkiemnguoitao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadHD();
        }
        int idwhenclick = new int();
        private void button1_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            HoaDonService.Xoa(idwhenclick, hoaDon);
            LoadHD();
        }
    }
}
