using AForge.Video.DirectShow;
using DuAn1_Coffe.BLL.Service;
using DuAn1_Coffe.DAL.Models;
using Microsoft.Data.SqlClient;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace DuAn1_Coffe.PRL.Forms
{
    public partial class Form_Menu : Form
    {
        HoaDonSer _ser = new HoaDonSer();
        int stt = 0;
        public Form_Menu()
        {
            InitializeComponent();
            LoatSanPham();
            LoatNhanVien();
            loatkhachhang();
            LoatnguoiTao();
            LoatGiamGia();
            LoadDanhSachHoaDon();
        }

        public void loatkhachhang()
        {
            cboid.DataSource = _ser.GetAllKH();
            cboid.ValueMember = "Id";
            cboid.DisplayMember = "Id";
        }
        public void LoatNhanVien()
        {
            cbbnhanvien.DataSource = _ser.GetAllNV();
            cbbnhanvien.ValueMember = "Id";
            cbbnhanvien.DisplayMember = "Id";
        }

        public void LoatnguoiTao()
        {
            cbbnguoitao.DataSource = _ser.GetAllNV();
            cbbnguoitao.ValueMember = "Id";
            cbbnguoitao.DisplayMember = "TenNv";
        }

        // sử lý phần giảm giá 
        public void LoatGiamGia()
        {
            int tongTien;
            if (!int.TryParse(txttongtien.Text, out tongTien))
            {
                return;
            }

            var danhSachKM = _ser.GetAllKM();
            cbbgiamgia.Items.Clear();
            DateTime ngayHienTai = DateTime.Now;
            // Duyệt qua từng chương trình giảm giá
            foreach (var km in danhSachKM)
            {
                if (tongTien >= km.DonHangToiThieu && ngayHienTai < km.NgayKetThuc)
                {
                    cbbgiamgia.Items.Add(km);
                }
            }
            if (cbbgiamgia.Items.Count > 0)
            {
                cbbgiamgia.SelectedIndex = 0;
            }
        }
        // sử lý tiếp giảm giá
        private void cbbgiamgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbgiamgia.SelectedItem != null)
            {
                string magiam = cbbgiamgia.SelectedItem.ToString();
                int giamToiDa = 0;
                var giamGia = _ser.GetAllKM().FirstOrDefault(x => x.MaGiamGia == magiam);

                if (giamGia != null)
                {
                    giamToiDa = giamGia.GiamToiDa;
                    // Tính toán giá sau khi giảm giá
                    double tongTien;
                    if (double.TryParse(txttongtien.Text, out tongTien))
                    {
                        double sauGiam = tongTien - giamToiDa;
                        txtsaugiamgia.Text = sauGiam.ToString();
                    }
                }
            }
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

        // loat từ data grit view san phẩm lên data grit view giỏ hàng

        private void dgvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvsanpham.Rows[e.RowIndex];
                string maHoaDon = txtmahoadon.Text;

                // Sửa số lượng trong db sản phẩm 
                string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập số lượng:", "Nhập số lượng");
                int soLuong;
                if (!int.TryParse(input, out soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0");
                    return;
                }
                int soLuongTrongKho = int.Parse(selectedRow.Cells["Số Lượng"].Value.ToString());
                if (soLuong > soLuongTrongKho)
                {
                    MessageBox.Show("Số lượng không đủ trong kho");
                    return;
                }
                int IdSp = int.Parse(selectedRow.Cells["Id"].Value.ToString());
                int sl = soLuongTrongKho - soLuong;
                SanPham sp = new SanPham();
                sp.SoLuong = sl;
                var success = _ser.UpdateSP(IdSp, sp);
                if (success != null)
                {
                    selectedRow.Cells["Số Lượng"].Value = sl;
                }

                // Xóa dữ liệu cũ trong danh sách hdcts
                hdcts.Clear();

                // Tạo ra hóa đơn chi tiết mới
                HoaDonChiTiet hdct = new HoaDonChiTiet();
                hdct.MaHoaDon = txtmahoadon.Text;
                hdct.TenSanPham = selectedRow.Cells["tên"].Value.ToString();
                hdct.SoLuong = soLuong;
                hdct.TongGia = double.Parse(selectedRow.Cells["Giá Bán"].Value.ToString()) * soLuong;
                hdct.IdSanPham = int.Parse(selectedRow.Cells["Id"].Value.ToString());
                hdct.IdHoaDon1 = Convert.ToInt32(txtIdHoaDon.Text);
                hdcts.Add(hdct);
                _ser.AddHDChiTiet(hdct);
                LoatHoaDonCt();
                LoatTinhTongTien();
                LoatGiamGia();

            }
        }

        // tính tổng tiền lên tex box
        public void LoatTinhTongTien()
        {
            double tongTien = 0;
            foreach (DataGridViewRow row in dgvhoadonct.Rows)
            {
                double thanhTien;
                if (row.Cells["Giá"].Value != null && double.TryParse(row.Cells["Giá"].Value.ToString(), out thanhTien))
                {
                    tongTien += thanhTien;
                }
            }

            txttongtien.Text = tongTien.ToString();
        }

        List<HoaDonChiTiet> hdcts = new List<HoaDonChiTiet>();
        public void LoatHoaDonCt()
        {
            dgvhoadonct.ColumnCount = 8;
            dgvhoadonct.Columns[0].Name = "stt";
            dgvhoadonct.Columns[1].Name = "Id Hóa Đơn CT";
            dgvhoadonct.Columns[2].Name = "MaHD";
            dgvhoadonct.Columns[3].Name = "tên SP";
            dgvhoadonct.Columns[4].Name = "Sô Lượng";
            dgvhoadonct.Columns[5].Name = "Giá";
            dgvhoadonct.Columns[6].Name = "Id San phẩm";
            dgvhoadonct.Columns[7].Name = "Id Hoa Đơn";

            // lấy ra lis hóa đơn chi tiết vừa tạo
            foreach (var x in hdcts)
            {
                dgvhoadonct.Rows.Add(stt++, x.IdHoaDon, x.MaHoaDon, x.TenSanPham,
                    x.SoLuong, x.TongGia, x.IdSanPham, x.IdHoaDon1);
            }
        }

        private void btn_taohoadon_Click(object sender, EventArgs e)
        {
            // tạo cột trong data grit view hóa đơn
            List<string[]> rows = new List<string[]>();
            dgvdanhsachhoadon.ColumnCount = 7;
            dgvdanhsachhoadon.Columns[0].Name = "stt";
            dgvdanhsachhoadon.Columns[1].Name = "Id";
            dgvdanhsachhoadon.Columns[2].Name = "MaHD";
            dgvdanhsachhoadon.Columns[3].Name = "Ngay Mua";
            dgvdanhsachhoadon.Columns[4].Name = "Trang Thai";
            dgvdanhsachhoadon.Columns[5].Name = "Người Tạo";
            dgvdanhsachhoadon.Columns[6].Name = "Khách Hàng";
            dgvdanhsachhoadon.Columns[1].Visible = false;
            //Tạo mã hóa đơn tự động tự tăng dần
            string maHD;
            var allHoaDon = _ser.GetAllHD();
            int count = allHoaDon.Count + 1;
            maHD = "HĐ" + count;
            while (allHoaDon.Any(x => x.MaHd == maHD))
            {
                count++;
                maHD = "HĐ" + count;
            }
            txtmahoadon.Text = maHD;
            // thêm vào data grit view dữ liệu khi ấn vào tạo hóa đơn
            string[] rowData = new string[6];
            rowData[0] = stt.ToString();
            rowData[1] = "".ToString();
            rowData[2] = maHD.ToString();
            rowData[3] = DateTime.Now.ToString();
            rowData[4] = "Đang chờ";
            rowData[5] = cbbnguoitao.SelectedValue.ToString();
            rowData[5] = "";
            rows.Add(rowData);
            // Hiển thị dữ liệu trên DataGridView
            foreach (string[] row in rows)
            {
                dgvdanhsachhoadon.Rows.Add(row);
            }
            //thêm hóa đơn chờ vào db
            // Thêm hóa đơn chờ vào cơ sở dữ liệu
            HoaDon hd = new HoaDon();
            hd.MaHd = maHD;
            hd.NgayMuaHang = DateTime.Now;
            hd.TrangThai = "Đang Chờ";
            hd.NguoiTao = cbbnguoitao.SelectedValue.ToString();
            // cái này là bị ép buộc làm.
            hd.IdKhachHang = int.Parse(cboid.SelectedValue.ToString());
            hd.IdNhanVien = int.Parse(cbbnhanvien.SelectedValue.ToString());
            //hd.IdKhachHang = 
            _ser.AddHD(hd);
            // lấy id hiện lên txt
            txtIdHoaDon.Text = hd.IdHd.ToString();
            MessageBox.Show("Thêm hóa đơn thành công");
        }

        private void txttienthua_TextChanged(object sender, EventArgs e)
        {
            Tienthua();
        }

        // tính tiền thừa cho nhân viên trả lại
        public void Tienthua()
        {
            double kt = Convert.ToDouble(txttienkhachtra.Text);
            double tt = Convert.ToDouble(txttongtien.Text);
            double tienthua = kt - tt;
            txttienthua.Text = tienthua.ToString();
        }

        // thêm và sửa 2 em liên tiếp(khách hàng, hóa đơn)
        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdHoaDon.Text);
            // Sửa trạng thái của hóa đơn vừa tạo
            HoaDon hd = new HoaDon();
            hd.TrangThai = "Đã thanh toán";
            _ser.UpdateHD(id, hd);          

            // thêm khách hàng
            string ma;
            var makh = _ser.GetAllKH();
            int count = makh.Count + 1;
            ma = "KH" + count;
            while (makh.Any(x => x.MaKh == ma))
            {
                count++;
                ma = "KH" + count;
            }
            // check khách hàng nếu không rõ thông tin
            KhachHang khs = new KhachHang();
            khs.MaKh = ma;
            khs.TenKh = txttenKH.Text == "" ? "không có" : txttenKH.Text;
            khs.Sdt = txtSDT.Text == "" ? "không rõ" : txtSDT.Text;
            khs.Diachi = txtdiachi.Text == "" ? "Không rõ" : txtdiachi.Text;
            _ser.AddKH(khs);

            // cập nhập ghi chú cho hóa đơn 
            string mahd = txtmahoadon.Text;
            string ghichu = txtGhiChu.Text;
            // Lấy danh sách các hóa đơn có cùng mã
            var listHoaDon = _ser.GetAllHoadonChiTiet().Where(hd => hd.MaHoaDon == mahd).ToList();
            // Cập nhật thông tin cho từng hóa đơn
            foreach (var hoaDon in listHoaDon)
            {
                hoaDon.Ghichu = ghichu;
                _ser.UpdateHDCT(hoaDon); 
            }
            MessageBox.Show("Thành công");
        }

        private void txttienkhachtra_TextChanged(object sender, EventArgs e)
        {
            double kt = Convert.ToDouble(txttienkhachtra.Text);
            double tt = Convert.ToDouble(txttongtien.Text);
            if (kt >= tt)
            {
                double tienthua = kt - tt;
                txttienthua.Text = tienthua.ToString();
            }
            else
            {
                txttienthua.Text = "0";
            }
        }

        private void btn_huydon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hủy đơn thành công");
        }

        private void btn_suaKH_Click(object sender, EventArgs e)
        {
            List<HoaDonChiTiet> listHoaDonChiTiet = new List<HoaDonChiTiet>();

            // Code ở đây để lấy dữ liệu từ nguồn nào đó và thêm vào listHoaDonChiTiet

            string filePath = "D:\\DuAn1\\Hoa_don"; // Đường dẫn của tệp Excel mà bạn muốn lưu

            ExportToExcel(listHoaDonChiTiet, filePath);
        }
        public void ExportToExcel(List<HoaDonChiTiet> listHoaDonChiTiet, string filePath)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo một worksheet mới
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("HoaDonChiTiet");

                // Đặt tiêu đề cho các cột
                worksheet.Cells[1, 1].Value = "Id Hóa Đơn CT";
                worksheet.Cells[1, 2].Value = "Tên Sản Phẩm";
                worksheet.Cells[1, 3].Value = "Số Lượng";
                worksheet.Cells[1, 4].Value = "Giá";
                // Tiếp tục đặt tiêu đề cho các cột khác nếu cần

                // Đặt dữ liệu cho từng dòng trong worksheet
                int rowIndex = 2; // Bắt đầu từ dòng thứ 2
                foreach (var hoaDonChiTiet in listHoaDonChiTiet)
                {
                    worksheet.Cells[rowIndex, 1].Value = hoaDonChiTiet.MaHoaDon;
                    worksheet.Cells[rowIndex, 2].Value = hoaDonChiTiet.TenSanPham;
                    worksheet.Cells[rowIndex, 3].Value = hoaDonChiTiet.SoLuong;
                    worksheet.Cells[rowIndex, 4].Value = hoaDonChiTiet.TongGia;
                    // Tiếp tục đặt dữ liệu cho các cột khác nếu cần

                    rowIndex++;
                }

                // Lưu workbook vào một tệp Excel
                FileInfo excelFile = new FileInfo(filePath);
                excelPackage.SaveAs(excelFile);
            }
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            //lấy danh sách các thiết bị view đang được kết nối với máy tính
            //camCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //foreach (FilterInfo item in camCollection)
            //{
            //    cbo_Cam.Items.Add(item.Name);
            //}
            //cbo_Cam.SelectedIndex = 0;// chọn thiết bị có chỉ số đầu tiên trong danh sách
        }

        //FilterInfoCollection camCollection; // danh sách các cam của máy
        //VideoCaptureDevice videoCaptureDevice;
        //int done = 0; // kiểm tra khi quét thành công


        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            ////ptb_Image.Image = (Bitmap)eventArgs.Frame.Clone();
            //Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            //BarcodeReader barcodeReader = new BarcodeReader(); // tạo đối tượng dọc
            //var result = barcodeReader.Decode(bitmap); // đọc QR code từ hình ảnh
            //if (barcodeReader != null)
            //{
            //    txt_DocMaQR.Invoke(new MethodInvoker(delegate ()
            //    {
            //        txt_DocMaQR.Text = result.ToString(); // hiển thị kết quả lên textbox
            //    }
            //    ));
            //}
            //ptb_Image.Image = bitmap; // hiển thị hình ảnh lên picturebox

        }

        private void btn_batcam_Click(object sender, EventArgs e)
        {
            // Cho phép load tất cả các cam có thể lên trên Combobox
            //videoCaptureDevice = new VideoCaptureDevice(camCollection[cbo_Cam.SelectedIndex].MonikerString);
            //videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            //videoCaptureDevice.Start(); // Khởi chạy
            //// Đọc QR code
            //timer1.Start();
            //if (done == 1)
            //{
            //    timer1.Stop();
            //}
        }

        private void btn_tatcam_Click(object sender, EventArgs e)
        {
            //if (videoCaptureDevice! == null)
            //{
            //    if (videoCaptureDevice.IsRunning)
            //    {
            //        videoCaptureDevice.Stop();
            //        ptb_Image.Image = null;
            //    }
            //}
        }

        private void Form_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //videoCaptureDevice.SignalToStop();
            //videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
            //videoCaptureDevice = null;
            ////if (videoCaptureDevice! == null)
            ////{
            ////    if (videoCaptureDevice.IsRunning)
            ////    {
            ////        videoCaptureDevice.Stop();
            ////        ptb_Image.Image = null;
            ////    }
            ////}
        }


        // xóa sản phẩm đã chọn khi dã thêm vào giỏ hàng
        private void btn_Xoasp_Click(object sender, EventArgs e)
        {
            if (dgvhoadonct.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không ?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow dt = dgvhoadonct.SelectedRows[0];
                    int idhdct = int.Parse(dt.Cells["Id Hóa Đơn CT"].Value.ToString());

                    // Gọi phương thức xóa từ service
                    bool delete = _ser.RemoveHDCT(idhdct);

                    if (delete)
                    {
                        // Cập nhật lại số lượng của sản phẩm trong dgvsanpham
                        int IdSp = int.Parse(dt.Cells["Id San phẩm"].Value.ToString());
                        int soLuong = int.Parse(dt.Cells["Sô Lượng"].Value.ToString());
                        DataGridViewRow row = dgvsanpham.Rows.Cast<DataGridViewRow>().First(r => int.Parse(r.Cells["Id"].Value.ToString()) == IdSp);
                        int soluongmoi = int.Parse(row.Cells["Số Lượng"].Value.ToString()) + soLuong;
                        row.Cells["Số Lượng"].Value = soluongmoi;

                        // Xóa dòng khỏi dgvhoadonct
                        int index = dgvhoadonct.SelectedRows[0].Index;
                        dgvhoadonct.Rows.RemoveAt(index);
                        LoatTinhTongTien();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (ptb_Image.Image != null)
            //{
            //    var reader = new BarcodeReader();
            //    // Anhr trên máy
            //    var image = Image.FromFile(@"C:\Users\Acer\Desktop\bao.png");
            //    var result = reader.Decode((Bitmap)ptb_Image.Image);
            //    // Lấy ảnh từ picturebox
            //    if (result != null)
            //    {
            //        MessageBox.Show(result.ToString());
            //        done = 1;
            //        //ptb_Image = null;
            //        videoCaptureDevice.SignalToStop();
            //        videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
            //        videoCaptureDevice = null;
            //    }
            //}
        }

        // lấy ra sản phẩm chưa thanh toán
        private void LoadDanhSachHoaDon()
        {
            dgvdanhsachhoadon.Columns.Clear();
            dgvdanhsachhoadon.ColumnCount = 6;
            dgvdanhsachhoadon.Columns[0].Name = "stt";
            dgvdanhsachhoadon.Columns[1].Name = "Id";
            dgvdanhsachhoadon.Columns[2].Name = "MaHD";
            dgvdanhsachhoadon.Columns[3].Name = "Ngày Mua hàng";
            dgvdanhsachhoadon.Columns[4].Name = "Trạng Thái";
            dgvdanhsachhoadon.Columns[5].Name = "Người tạo";
            var danhSachHoaDon = _ser.GetAllHD();
            // Lọc và sắp xếp danh sách hóa đơn
            var danhSachHoaDonLoc = danhSachHoaDon.Where(hd => hd.TrangThai == "Đang Chờ").OrderBy(hd => hd.NgayMuaHang);
            int stt = 1;
            // Thêm các hóa đơn thỏa điều kiện vào DataGridView
            foreach (var item in danhSachHoaDonLoc)
            {
                dgvdanhsachhoadon.Rows.Add(stt++, item.IdHd, item.MaHd, item.NgayMuaHang, item.TrangThai, item.NguoiTao);
            }
        }

        public void Loathdct(string mahd)
        {
            dgvhoadonct.Rows.Clear();
            dgvhoadonct.ColumnCount = 9;
            dgvhoadonct.Columns[0].Name = "stt";
            dgvhoadonct.Columns[1].Name = "Id Hóa Đơn CT";
            dgvhoadonct.Columns[2].Name = "MaHD";
            dgvhoadonct.Columns[3].Name = "tên SP";
            dgvhoadonct.Columns[4].Name = "Sô Lượng";
            dgvhoadonct.Columns[5].Name = "Giá";
            dgvhoadonct.Columns[6].Name = "Id San phẩm";
            dgvhoadonct.Columns[7].Name = "Id Hoa Đơn";
            dgvhoadonct.Columns[8].Name = "Id Giam gia";
            // Lấy danh sách hóa đơn chi tiết từ db trên mã hóa đơn
            List<HoaDonChiTiet> hdctList = _ser.SeachMaHDCT(mahd);
            int stt = 1;
            foreach (var x in hdctList)
            {
                dgvhoadonct.Rows.Add(stt++, x.IdHoaDon, x.MaHoaDon, x.TenSanPham,
                    x.SoLuong, x.TongGia, x.IdSanPham, x.IdHoaDon1, x.IdGiamGia);
            }
        }

        private void dgvdanhsachhoadon_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maHoaDon = dgvdanhsachhoadon.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();
                txtmahoadon.Text = maHoaDon;
                string idHoaDon = dgvdanhsachhoadon.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtIdHoaDon.Text = idHoaDon;
                Loathdct(maHoaDon);
            }
        }
    }
}
