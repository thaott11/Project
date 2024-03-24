using Du_An_1_Caffe.BLL.Service;
using Du_An_1_Caffe.DAL.Models;
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
    public partial class Form_NhanVien : Form
    {
        public Form_NhanVien()
        {
            InitializeComponent();
        }
        NhanVienSer NhanVienService;

        string pathimg;
        int idwhenclick = new int();
        dynamic imgLoad;
        private void Form_NhanVien_Load(object sender, EventArgs e)
        {
            NhanVienService = new NhanVienSer();
            LoadData();
        }

        public void LoadData()
        {
            int stt = 1;
            dgvnhanvien.ColumnCount = 14;
            dgvnhanvien.Rows.Clear();
            dgvnhanvien.Columns[0].Name = "Id";
            dgvnhanvien.Columns[1].Name = "Stt";
            dgvnhanvien.Columns[2].Name = "Mã NV";
            dgvnhanvien.Columns[3].Name = "Tên NV";
            dgvnhanvien.Columns[4].Name = "Giới tính";
            dgvnhanvien.Columns[5].Name = "Sđt";
            dgvnhanvien.Columns[6].Name = "Địa Chỉ";
            dgvnhanvien.Columns[7].Name = "Số CMND";
            dgvnhanvien.Columns[8].Name = "Vai trò";
            dgvnhanvien.Columns[9].Name = "Tên TK";
            dgvnhanvien.Columns[10].Name = "Mật khẩu";
            dgvnhanvien.Columns[11].Name = "Ngày Vào Làm";
            dgvnhanvien.Columns[12].Name = "Trạng Thái";
            dgvnhanvien.Columns[13].Name = "Hình Ảnh";
            dgvnhanvien.Columns[0].Visible = false;
            foreach (var item in NhanVienService.AllNhanVien())
            {
                ;
                dgvnhanvien.Rows.Add(item.Id, stt++, item.MaNv, item.TenNv, item.GioiTinh, item.Sdt, item.DiaChi, item.Cccd, item.VaiTro, item.TenTaiKhoan, item.MatKhau, item.NgayVaoLam, item.TrangThai, item.HinhAnh);
            }
        }
        

        private void btn_anh_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *.png; *.gif";
            openFileDialog.Title = "Chọn ảnh";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    Image image = Image.FromFile(openFileDialog.FileName);


                    pbhinhanh.Image = image;

                    pathimg = openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải hình ảnh: " + ex.Message);
                }
            }
        }
        private void btn_themNV_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pathimg))
            {
                bool check = NhanVienService.AllNhanVien().Any(x => x.MaNv == txtmanv.Text);
                if (check)
                {
                    MessageBox.Show("Mã đã tồn tại");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn thêm không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dr == DialogResult.Yes)
                    {
                        byte[] imageBytes = File.ReadAllBytes(pathimg);
                        NhanVien nhanVien = new NhanVien();
                        nhanVien.MaNv = txtmanv.Text;
                        nhanVien.TenNv = txttenNV.Text;
                        nhanVien.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
                        nhanVien.Sdt = txtSDT.Text;
                        nhanVien.DiaChi = txtdiachi.Text;
                        nhanVien.Cccd = txtCccd.Text;
                        nhanVien.VaiTro = rdoNhanvien.Checked ? "Nhân viên" : "Quản lý";
                        nhanVien.TenTaiKhoan = txttentk.Text;
                        nhanVien.MatKhau = txtmatkhau.Text;
                        nhanVien.NgayVaoLam = DateTime.ParseExact(dtpNgayvaolam.Text.Trim(), "dd/MM/yyyy", null);
                        nhanVien.TrangThai = rdoDangLam.Checked ? "Đang làm" : "Nghỉ làm";
                        if (pathimg == null) nhanVien.HinhAnh = imgLoad;
                        nhanVien.HinhAnh = imageBytes;
                        MessageBox.Show(NhanVienService.Them(nhanVien));
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hình ảnh trước khi thêm sản phẩm.", "Thông báo");
            }
        }

        private void btn_suaNV_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn sửa không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {

                    NhanVien nhanVien = new NhanVien();
                    if (pathimg != null)
                    {
                        byte[] imageBytes = File.ReadAllBytes(pathimg);
                        nhanVien.HinhAnh = imageBytes;
                    }
                    else nhanVien.HinhAnh = imgLoad;
                    nhanVien.MaNv = txtmanv.Text;
                    nhanVien.TenNv = txttenNV.Text;
                    nhanVien.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
                    nhanVien.Sdt = txtSDT.Text;
                    nhanVien.DiaChi = txtdiachi.Text;
                    nhanVien.Cccd = txtCccd.Text;
                    nhanVien.VaiTro = rdoNhanvien.Checked ? "Nhân viên" : "Quản lý";
                    nhanVien.TenTaiKhoan = txttentk.Text;
                    nhanVien.MatKhau = txtmatkhau.Text;
                    nhanVien.NgayVaoLam = DateTime.ParseExact(dtpNgayvaolam.Text.Trim(), "dd/MM/yyyy", null);
                    nhanVien.TrangThai = rdoDangLam.Checked ? "Đang làm" : "Nghỉ làm";

                    MessageBox.Show(NhanVienService.Sua(idwhenclick, nhanVien));
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi rồi" + ex.Message);
            }
        }

        private void dgvnhanvien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            idwhenclick = int.Parse(dgvnhanvien.Rows[d].Cells[0].Value.ToString());
            txtmanv.Text = dgvnhanvien.Rows[d].Cells[2].Value.ToString();
            txttenNV.Text = dgvnhanvien.Rows[d].Cells[3].Value.ToString();

            if (dgvnhanvien.Rows[d].Cells[4].Value.ToString().Equals("Nam"))
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdonu.Checked = true;
            }
            txtSDT.Text = dgvnhanvien.Rows[d].Cells[5].Value.ToString();
            txtdiachi.Text = dgvnhanvien.Rows[d].Cells[6].Value.ToString();
            txtCccd.Text = dgvnhanvien.Rows[d].Cells[7].Value.ToString();
            if (dgvnhanvien.Rows[d].Cells[8].Value.ToString().Equals("Quản Lý", StringComparison.OrdinalIgnoreCase))
            {

                rdoquanly.Checked = true;
            }
            else
            {
                rdoNhanvien.Checked = true;
            }
            txttentk.Text = dgvnhanvien.Rows[d].Cells[9].Value.ToString();
            txtmatkhau.Text = dgvnhanvien.Rows[d].Cells[10].Value.ToString();
            dtpNgayvaolam.Text = dgvnhanvien.Rows[d].Cells[11].Value.ToString();
            if (dgvnhanvien.Rows[d].Cells[12].Value.ToString().Equals("Đang Làm", StringComparison.OrdinalIgnoreCase))
            {
                rdoDangLam.Checked = true;
            }
            else
            {
                rdoNghilam.Checked = true;
            }
            var s = NhanVienService.Findid(idwhenclick);
            object img = s.HinhAnh;
            imgLoad = s.HinhAnh;
            byte[] imageData = (byte[])img;
            Image image;
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                image = Image.FromStream(ms);
            }
            pbhinhanh.Image = image;
        }

        public void Timkiem(string name)
        {
            int stt = 1;
            dgvnhanvien.ColumnCount = 14;
            dgvnhanvien.Rows.Clear();
            dgvnhanvien.Columns[0].Name = "Id";
            dgvnhanvien.Columns[1].Name = "Stt";
            dgvnhanvien.Columns[2].Name = "Mã NV";
            dgvnhanvien.Columns[3].Name = "Tên NV";
            dgvnhanvien.Columns[4].Name = "Giới tính";
            dgvnhanvien.Columns[5].Name = "Sđt";
            dgvnhanvien.Columns[6].Name = "Địa Chỉ";
            dgvnhanvien.Columns[7].Name = "Số CMND";
            dgvnhanvien.Columns[8].Name = "Vai trò";
            dgvnhanvien.Columns[9].Name = "Tên TK";
            dgvnhanvien.Columns[10].Name = "Mật khẩu";
            dgvnhanvien.Columns[11].Name = "Ngày Vào Làm";
            dgvnhanvien.Columns[12].Name = "Trạng Thái";
            dgvnhanvien.Columns[13].Name = "Hình Ảnh";
            dgvnhanvien.Columns[0].Visible = false;
            foreach (var item in NhanVienService.Timkiem(name))
            {

                dgvnhanvien.Rows.Add(item.Id, stt++, item.MaNv, item.TenNv, item.GioiTinh, item.Sdt, item.DiaChi, item.Cccd, item.VaiTro, item.TenTaiKhoan, item.MatKhau, item.NgayVaoLam, item.TrangThai, item.HinhAnh);
            }
        }
        private void txttimkiem_TextChanged_1(object sender, EventArgs e)
        {
            Timkiem(txttimkiem.Text);
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtmanv.ResetText();
            txttenNV.ResetText();
            txtSDT.ResetText();
            txtdiachi.ResetText();
            txtCccd.ResetText();
            rdoNam.Checked = false;
            rdonu.Checked = false;
            rdoquanly.Checked = false;
            rdoNhanvien.Checked = false;
            rdoDangLam.Checked = false;
            rdoNghilam.Checked = false;
            txttentk.ResetText();
            txtmatkhau.ResetText();
            dtpNgayvaolam.ResetText();
            pbhinhanh.Image = null;
        }

        private void btn_LoadDGV_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void Locc(string Vaitro)
        {
            int stt = 1;
            dgvnhanvien.ColumnCount = 14;
            dgvnhanvien.Rows.Clear();
            dgvnhanvien.Columns[0].Name = "Id";
            dgvnhanvien.Columns[1].Name = "Stt";
            dgvnhanvien.Columns[2].Name = "Mã NV";
            dgvnhanvien.Columns[3].Name = "Tên NV";
            dgvnhanvien.Columns[4].Name = "Giới tính";
            dgvnhanvien.Columns[5].Name = "Sđt";
            dgvnhanvien.Columns[6].Name = "Địa Chỉ";
            dgvnhanvien.Columns[7].Name = "Số CMND";
            dgvnhanvien.Columns[8].Name = "Vai trò";
            dgvnhanvien.Columns[9].Name = "Tên TK";
            dgvnhanvien.Columns[10].Name = "Mật khẩu";
            dgvnhanvien.Columns[11].Name = "Ngày Vào Làm";
            dgvnhanvien.Columns[12].Name = "Trạng Thái";
            dgvnhanvien.Columns[13].Name = "Hình Ảnh";
            dgvnhanvien.Columns[0].Visible = false;
            foreach (var item in NhanVienService.Loc(Vaitro))
            {

                dgvnhanvien.Rows.Add(item.Id, stt++, item.MaNv, item.TenNv, item.GioiTinh, item.Sdt, item.DiaChi, item.Cccd, item.VaiTro, item.TenTaiKhoan, item.MatKhau, item.NgayVaoLam, item.TrangThai, item.HinhAnh);
            }
        }
        private void cbolocDU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbolocDU.SelectedIndex == 1)
            {
                Locc("Quản Lý");
            }
            else
            {
                Locc("Nhân Viên");
            }
        }

        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
