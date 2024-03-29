using DuAn1_Coffe.BLL.Service;
using DuAn1_Coffe.DAL.Models;
using OfficeOpenXml.Style;
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
    public partial class Form_ThongKe : Form
    {
        SanPhamSer SanPhamService = new SanPhamSer();
        HoaDonChiTietSer HoaDonChiTietSer = new HoaDonChiTietSer();
        KhachHangSer KhachHangSer = new KhachHangSer();
        HoaDonSer HoaDonSer = new HoaDonSer();
        public Form_ThongKe()
        {
            InitializeComponent();
        }

        private void Form_ThongKe_Load(object sender, EventArgs e)
        {
            LoadDoanhthuSp();
        }
        public void LoadDoanhthuSp()
        {
            int stt = 1;
            dgvdoanhthusp.ColumnCount = 7;
            dgvdoanhthusp.Rows.Clear();
            dgvdoanhthusp.Columns[0].Name = "Id";
            dgvdoanhthusp.Columns[1].Name = "Stt";
            dgvdoanhthusp.Columns[2].Name = "MaHD";
            dgvdoanhthusp.Columns[3].Name = "Tên SP";
            dgvdoanhthusp.Columns[4].Name = "Số Lượng";
            dgvdoanhthusp.Columns[5].Name = "Tổng Giá";
            dgvdoanhthusp.Columns[6].Name = "Ghi chú";
            dgvdoanhthusp.Columns[0].Visible = false;

            foreach (var item in HoaDonChiTietSer.AllHoadonchitiet())
            {

                var hd = HoaDonSer.GetAllHD().FirstOrDefault(x => x.IdHd == item.IdHoaDon);
                dgvdoanhthusp.Rows.Add(item.IdHoaDon, stt++, item.MaHoaDon, item.TenSanPham, item.SoLuong, item.TongGia, item.Ghichu);
            }
            lbdoanhthu.Text = HoaDonChiTietSer.AllHoadonchitiet().Sum(x => x.TongGia).ToString();
        }
        public void ThongKeSanPhamBanChay(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            int index = 0;
            var thongkesanpham = (from hct in HoaDonChiTietSer.AllHoadonchitiet()
                                  join hd in HoaDonSer.GetAllHD() on hct.IdHoaDon equals hd.IdHd
                                  where hd.NgayMuaHang >= ngayBatDau && hd.NgayMuaHang <= ngayKetThuc
                                  group hct by hct.IdSanPham into g
                                  select new
                                  {
                                      Masanpham = g.Key,
                                      TenSP = g.Select(x => x.TenSanPham).FirstOrDefault(),
                                      GiaBan = g.Select(x => x.TongGia).FirstOrDefault(),
                                      SoLuotMua = g.Sum(x => x.SoLuong),
                                      TongTien = g.Sum(x => x.SoLuong * x.TongGia),
                                  }).OrderByDescending(x => x.SoLuotMua).ToList();
            dgvspbanchay.DataSource = thongkesanpham;
            dgvspbanchay.Columns[0].HeaderText = "Mã Sp";
            dgvspbanchay.Columns[1].HeaderText = "Tên SP";
            dgvspbanchay.Columns[2].HeaderText = "Giá bán";
            dgvspbanchay.Columns[3].HeaderText = "Số lượt mua";
            dgvspbanchay.Columns[4].HeaderText = "Tổng tiền";
            // Tạo một DataGridViewImageColumn

        }
        public void ThongKeSanPhamSapHetHang(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            try
            {
                int index = 0;
                var result = from sp in SanPhamService.Allsanpham()
                             where sp.SoLuong < 10
                             select new
                             {
                                 sp.Id,
                                 stt = ++index,
                                 sp.MaSp,
                                 sp.TenSanPham,
                                 sp.DonGia,
                                 sp.SoLuong,
                                 sp.TrangThai,
                                 sp.MoTa,
                                 sp.HinhAnh
                             };
                dgvsphethang.DataSource = result.ToList();
                dgvsphethang.Columns[0].Visible = false;
                dgvsphethang.Columns[1].HeaderText = "STT";
                dgvsphethang.Columns[2].HeaderText = "Mã Sp";
                dgvsphethang.Columns[3].HeaderText = "Tên sản phẩm";
                dgvsphethang.Columns[4].HeaderText = "Đơn giá";
                dgvsphethang.Columns[5].HeaderText = "Số lượng";
                dgvsphethang.Columns[6].HeaderText = "Trạng thái";
                dgvsphethang.Columns[7].HeaderText = "Mô tả";
                dgvsphethang.Columns[8].HeaderText = "Hình ảnh";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dtptungay.Value.Date; // Lấy chỉ ngày, loại bỏ thông tin về giờ, phút và giây
            DateTime ngayKetThuc = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1); // Lấy ngày kết thúc và đặt giờ, phút và giây về 23:59:59

            //Tổng sản phẩm
            var tongsanpham = (from hct in HoaDonChiTietSer.AllHoadonchitiet()
                               join hd in HoaDonSer.GetAllHD() on hct.IdHoaDon equals hd.IdHd
                               where hd.NgayMuaHang >= ngayBatDau && hd.NgayMuaHang <= ngayKetThuc
                               select hct.SoLuong).Sum();

            //Tổng số đơn hàng 
            var tongSoDonh = (from hd in HoaDonSer.GetAllHD()
                              where hd.NgayMuaHang >= ngayBatDau && hd.NgayMuaHang <= ngayKetThuc
                              select hd).Count();

            //Hiển thị lên lable

            lbspban.Text = tongsanpham.ToString();
            lbtongdonhang.Text = tongSoDonh.ToString();
            ThongKeSanPhamBanChay(ngayBatDau, ngayKetThuc);
            ThongKeSanPhamSapHetHang(ngayBatDau, ngayKetThuc);
        }
    }
}
