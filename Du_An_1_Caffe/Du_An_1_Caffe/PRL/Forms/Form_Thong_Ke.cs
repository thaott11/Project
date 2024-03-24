using Du_An_1_Caffe.BLL.Service;
using Du_An_1_Caffe.DAL.Models;
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

namespace Du_An_1_Caffe.PRL.Forms
{
    public partial class Form_Thong_Ke : Form
    {
        ThongKeSer _ser = new ThongKeSer();
        public Form_Thong_Ke()
        {
            InitializeComponent();
            LoatTop5SanPham();
            loatSanPhamSapHet();
        }

        // lấy ra  top 5 sản phẩm 
        public void LoatTop5SanPham()
        {
            int stt = 1;
            List<SanPham> top5SanPham = _ser.GetAllSP().OrderByDescending(sp => sp.SoLuong).Take(5).ToList();
            dgvsanphambanchay.Columns.Clear();
            dgvsanphambanchay.ColumnCount = 9;
            dgvsanphambanchay.Columns[0].Name = "stt";
            dgvsanphambanchay.Columns[1].Name = "Id";
            dgvsanphambanchay.Columns[2].Name = "MaSP";
            dgvsanphambanchay.Columns[3].Name = "tên";
            dgvsanphambanchay.Columns[4].Name = "Giá Bán";
           
            dgvsanphambanchay.Columns[5].Name = "Số Lượng";
            dgvsanphambanchay.Columns[6].Name = "Trang Thái";
            dgvsanphambanchay.Columns[7].Name = "Mô Tả";
            dgvsanphambanchay.Columns[8].Name = "Hình Ảnh";
            dgvsanphambanchay.Columns[1].Visible = false;

            foreach (var item in top5SanPham)
            {
                dgvsanphambanchay.Rows.Add(stt++, item.Id, item.MaSp,
                    item.TenSanPham, item.DonGia, item.SoLuong,
                    item.TrangThai, item.MoTa, item.HinhAnh);
            }
        }

        public void loatSanPhamSapHet()
        {
            int stt = 1;
            List<SanPham> sanPhamSapHetHang = _ser.GetAllSP().Where(sp => sp.SoLuong < 10).ToList();
            dgvsanphamhethang.Columns.Clear();
            dgvsanphamhethang.ColumnCount = 10;
            dgvsanphamhethang.Columns[0].Name = "stt";
            dgvsanphamhethang.Columns[1].Name = "Id";
            dgvsanphamhethang.Columns[2].Name = "MaSP";
            dgvsanphamhethang.Columns[3].Name = "tên";
            dgvsanphamhethang.Columns[4].Name = "Giá Bán";
           
            dgvsanphamhethang.Columns[6].Name = "Số Lượng";
            dgvsanphamhethang.Columns[7].Name = "Trang Thái";
            dgvsanphamhethang.Columns[8].Name = "Mô Tả";
            dgvsanphamhethang.Columns[9].Name = "Hình Ảnh";
            dgvsanphamhethang.Columns[1].Visible = false;

            foreach (var item in sanPhamSapHetHang)
            {
                dgvsanphamhethang.Rows.Add(stt++, item.Id, item.MaSp,
                    item.TenSanPham, item.DonGia, item.SoLuong,
                    item.TrangThai, item.MoTa, item.HinhAnh);
            }
        }

        public void Doanhthu(string doanhthu)
        {

        }
        private void dgvsanphambanchay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnldoanhthu_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue); // Màu của cột biểu đồ
            int[,] doanhThuTheoNgay = (int[,])pnldoanhthu.Tag; // Lấy dữ liệu doanh thu từ Tag của biểu đồ
            // Dữ liệu doanh thu (ví dụ)
            int[] doanhThu = { 100, 200, 300, 400, 500 };
            int barWidth = 30; // Độ rộng của mỗi cột
            int spacing = 10; // Khoảng cách giữa các cột
            int startX = 50; // Tọa độ X của điểm bắt đầu vẽ
            int startY = pnldoanhthu.Height - 50; // Tọa độ Y của điểm bắt đầu vẽ
            int maxValue = doanhThu.Max(); // Giá trị lớn nhất trong dữ liệu doanh thu
            for (int i = 0; i < doanhThu.Length; i++)
            {
                int barHeight = (int)(((double)doanhThu[i] / maxValue) * (pnldoanhthu.Height - 100)); // Chiều cao của cột biểu đồ
                Rectangle bar = new Rectangle(startX + i * (barWidth + spacing), startY - barHeight, barWidth, barHeight);
                g.FillRectangle(Brushes.Blue, bar);
                g.DrawRectangle(pen, bar);
            }
        }

        private void btn_timthongke_Click(object sender, EventArgs e)
        {
            //DateTime ngayBatDau = dtpthongketu.Value.Date; // Lấy ngày bắt đầu 
            //DateTime ngayKetThuc = dtpThongkeDen.Value.Date; // Lấy ngày kết thúc 

            //Lấy dữ liệu từ ngày bắt đầu đến ngày kết thúc
            //int[,] doanhThuTheoNgay = _ser.GetDoanhThuTrongKhoangThoiGian(ngayBatDau, ngayKetThuc);
            //Cập nhật dữ liệu
            //pnldoanhthu.Tag = doanhThuTheoNgay;
            //pnldoanhthu.Invalidate();
        }
    }
}
