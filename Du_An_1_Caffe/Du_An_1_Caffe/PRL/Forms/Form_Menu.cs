using Du_An_1_Caffe.BLL.Service;
using Du_An_1_Caffe.DAL.Models;
using Microsoft.EntityFrameworkCore.ValueGeneration;
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
    public partial class Form_Menu : Form
    {
        HoaDonSer _ser = new HoaDonSer();

        // khai báo cho tự tăng
        int stt = 0;
        private int idhd = -1;
        // tạo biến toàn cục
        private double tongTien = 0;

        public Form_Menu()
        {
            InitializeComponent();
            LoatSanPham();
            LoatNhanVien();
            loatkhachhang();
        }

        // hiển thị khách hàng lên com bô box
        public void loatkhachhang()
        {
            cbbkhachhang.DataSource = _ser.GetAllKH();
            cbbkhachhang.ValueMember = "Id";
            cbbkhachhang.DisplayMember = "Id";
        }
        public void LoatNhanVien()
        {
            cbbnhanvien.DataSource = _ser.GetAllNV();
            cbbnhanvien.ValueMember = "Id";
            cbbnhanvien.DisplayMember = "Id";
        }
        // loat sản phẩm lên data grit view để lấy sản phẩm thêm vào hóa đơn
        public void LoatSanPham()
        {
            int stt = 1;
            dgvsanpham.Columns.Clear();
            dgvsanpham.ColumnCount = 9;
            dgvsanpham.Columns[0].Name = "stt";
            dgvsanpham.Columns[1].Name = "Id";
            dgvsanpham.Columns[2].Name = "MaSP";
            dgvsanpham.Columns[3].Name = "tên";
            dgvsanpham.Columns[4].Name = "Giá Bán";
            dgvsanpham.Columns[5].Name = "Số Lượng";
            dgvsanpham.Columns[6].Name = "Trang Thái";
            dgvsanpham.Columns[7].Name = "Mô Tả";
            dgvsanpham.Columns[8].Name = "Hình Ảnh";
            //dgvsanpham.Columns[1].Visible = false;

            foreach (var item in _ser.GetAllSP())
            {
                dgvsanpham.Rows.Add(stt++, item.Id, item.MaSp,
                    item.TenSanPham, item.DonGia, item.SoLuong,
                    item.TrangThai, item.MoTa, item.HinhAnh);
            }
        }
        private void dgvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvsanpham.Rows[e.RowIndex];
                // Lấy dữ liệu từ hàng đã chọn trong dgvsanpham
                string MaHD = txtmahoadon.Text;
                int idSP = int.Parse(selectedRow.Cells["Id"].Value.ToString());
                string maSP = selectedRow.Cells["MaSP"].Value.ToString();
                string tenSP = selectedRow.Cells["tên"].Value.ToString();
                // hiển thị chọn số lượng
                // cái này không biết tra chatgpt
                // không biết giải thích
                string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập số lượng:", "Nhập số lượng", "1");
                int soLuong;
                if (!int.TryParse(input, out soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0");
                    return;
                }
                double giaBan = double.Parse(selectedRow.Cells["Giá Bán"].Value.ToString());

                ////
                /// lấy ra id hóa đơn vừa tạo (mới nhất )
                var allHoaDon = _ser.GetAllHoaDon();
                int maxId = allHoaDon.Max(hd => hd.IdHd);


                double thanhTien = giaBan  * soLuong;
                // thêm cột 
                dgvgiohang.ColumnCount = 9;
                dgvgiohang.Columns[0].Name = "stt";
                dgvgiohang.Columns[1].Name = "Id Hóa Đơn";
                dgvgiohang.Columns[2].Name = "Id San phẩm";
                dgvgiohang.Columns[3].Name = "MaHD";
                dgvgiohang.Columns[4].Name = "MaSP";
                dgvgiohang.Columns[5].Name = "tên SP";
                dgvgiohang.Columns[6].Name = "Sô Lượng";
                dgvgiohang.Columns[7].Name = "Giá";
                dgvgiohang.Columns[8].Name = "Thành Tiền";
                dgvgiohang.Rows.Add(stt++, maxId, idSP, MaHD, maSP, tenSP, soLuong, giaBan, thanhTien);
            }
        }
        private void Form_Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_taohoadon_Click(object sender, EventArgs e)
        {
            // tạo cột trong data grit view hóa đơn
            List<string[]> rows = new List<string[]>();
            dgvhoadonchitiet.ColumnCount = 5;
            dgvhoadonchitiet.Columns[0].Name = "stt";
            dgvhoadonchitiet.Columns[1].Name = "Id";
            dgvhoadonchitiet.Columns[2].Name = "MaHD";
            dgvhoadonchitiet.Columns[3].Name = "Ngay Mua";
            dgvhoadonchitiet.Columns[4].Name = "Trang Thai";
            dgvhoadonchitiet.Columns[1].Visible = false;
            //Tạo mã hóa đơn tự động tự tăng dần
            string maHD;
            var allHoaDon = _ser.GetAllHoaDon();
            int count = allHoaDon.Count + 1;
            maHD = "HĐ" + count;
            while (allHoaDon.Any(x => x.MaHd == maHD))
            {
                count++;
                maHD = "HĐ" + count;
            }
            // gán vào bảng hóa đơn khi ấn tạo hóa đơn
            txtmahoadon.Text = maHD;

            // thêm vào data grit view dữ liệu khi ấn vào tạo hóa đơn
            string[] rowData = new string[6];
            rowData[0] = stt.ToString();
            rowData[1] = "".ToString();
            rowData[2] = maHD.ToString();
            rowData[3] = DateTime.Now.ToString();
            
            rowData[4] = "Đang chờ";
            rows.Add(rowData);
            // Hiển thị dữ liệu trên DataGridView
            foreach (string[] row in rows)
            {
                dgvhoadonchitiet.Rows.Add(row);
            }
            //thêm hóa đơn chờ vào db
            // Thêm hóa đơn chờ vào cơ sở dữ liệu
            HoaDon hd = new HoaDon();
            hd.MaHd = maHD;
            hd.NgayMuaHang = DateTime.Now;
            hd.TrangThai = "Đang Chờ";
            // cái này là bị ép buộc làm.
            hd.IdKhachHang = int.Parse(cbbkhachhang.SelectedValue.ToString());
            hd.IdNhanVien = int.Parse(cbbnhanvien.SelectedValue.ToString());
            //hd.IdKhachHang = 
            _ser.AddHD(hd);

            MessageBox.Show("Thêm hóa đơn thành công");

        }
        // Giải quyết phần tiền thừa cho nhân viên đỡ ăn gian kkk

        // chỗ này chưa giải quết được. mai rồi tính tiếp
        private void txttienthua_TextChanged(object sender, EventArgs e)
        {
            Tienthua();
        }
        // tính tiền thừa cho nhân viên trả lại
        public void Tienthua()
        {
            double kt = Convert.ToDouble(txtTienKhachTra.Text);
            double tt = Convert.ToDouble(txttongtien.Text);
            double tienthua = kt - tt;
            txttienthua.Text = tienthua.ToString();

        }

        // xóa sản phẩm đã chọn khi dã thêm vào giỏ hàng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgvgiohang.SelectedCells.Count > 0)
            {
                // Lấy ra dòng đang được chọn
                DataGridViewRow selectedRow = dgvgiohang.Rows[dgvgiohang.SelectedCells[0].RowIndex];
                DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Thông Báo", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    dgvgiohang.Rows.Remove(selectedRow);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK);
            }
        }
        // tính tổng tiền loat lên tex box
        private void TinhTongTien()
        {
            double tongTien = 0;
            foreach (DataGridViewRow row in dgvgiohang.Rows)
            {
                double thanhTien;
                if (row.Cells["Thành Tiền"].Value != null && double.TryParse(row.Cells["Thành Tiền"].Value.ToString(), out thanhTien))
                {
                    tongTien += thanhTien;
                }
            }
            txttongtien.Text = tongTien.ToString();
        }
        private void dgvgiohang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvgiohang.Columns["Thành Tiền"].Index)
            {
                TinhTongTien();
            }
        }
        // lấy ra số lượng 


        // thêm hóa đơn, khách hàng, hóa đơn chi tiết (thêm 3 liên tiếp )

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            // Lấy ra id hóa đơn vừa tạo (mới nhất)
            var allHoaDon = _ser.GetAllHoaDon();
            int maxId = allHoaDon.Max(hd => hd.IdHd);

            // Sửa trạng thái của hóa đơn vừa tạo
            HoaDon hd = new HoaDon();
            hd.TrangThai = "Đã thanh toán";
            _ser.UpdateHD(maxId, hd);

            // Thêm hóa đơn chi tiết
            foreach (DataGridViewRow row in dgvgiohang.Rows)
            {
                string tenSP = row.Cells["tên SP"].Value.ToString();
                int soLuong = Convert.ToInt32(row.Cells["Sô Lượng"].Value);
                double gia = Convert.ToDouble(row.Cells["Giá"].Value);
                string maHoaDon = row.Cells["MaHD"].Value.ToString();
                string maSP = row.Cells["MaSP"].Value.ToString();
                int idSanPham = Convert.ToInt32(row.Cells["Id San phẩm"].Value);
                int idHoaDon = Convert.ToInt32(row.Cells["Id Hóa Đơn"].Value);

                // Tạo đối tượng HoaDonChiTiet
                HoaDonChiTiet hdct = new HoaDonChiTiet();
                hdct.MaHoaDon = maHoaDon;
                hdct.TenSanPham = tenSP;
                hdct.SoLuong = soLuong;
                hdct.TongGia = gia;
                hdct.IdSanPham = idSanPham;
                hdct.IdHoaDon = idHoaDon;

                // Thực hiện thêm hóa đơn chi tiết vào cơ sở dữ liệu
                try
                {
                    _ser.AddHDChiTiet(hdct);
                    MessageBox.Show("Thêm thành công hóa đơn chi tiết!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm hóa đơn chi tiết: " + ex.Message);
                }
            }
        }

    }
}

