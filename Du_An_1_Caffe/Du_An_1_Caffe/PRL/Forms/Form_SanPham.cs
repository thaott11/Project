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
    public partial class Form_SanPham : Form
    {
        public Form_SanPham()
        {
            InitializeComponent();
        }
        SanPhamSer SanPhamservice;
        string pathimg;
        int idWhenclick = new int();
        public void LoadData()
        {
            int stt = 1;
            dgvsanpham.ColumnCount = 9;
            dgvsanpham.Rows.Clear();
            dgvsanpham.Columns[0].Name = "Id";
            dgvsanpham.Columns[1].Name = "Stt";
            dgvsanpham.Columns[2].Name = "Mã SP";
            dgvsanpham.Columns[3].Name = "Tên SP";
            dgvsanpham.Columns[4].Name = "Giá Bán"; 
            dgvsanpham.Columns[5].Name = "Số Lượng";
            dgvsanpham.Columns[6].Name = "Trạng Thái";
            dgvsanpham.Columns[7].Name = "Mô Tả";
            dgvsanpham.Columns[8].Name = "Hình Ảnh";
            dgvsanpham.Columns[0].Visible = false;
            foreach (var item in SanPhamservice.Allsanpham())
            {
                dgvsanpham.Rows.Add(item.Id, stt++, item.MaSp, item.TenSanPham, item.DonGia, item.SoLuong, item.TrangThai, item.MoTa, item.HinhAnh);
            }
        }




        public void TimKiem(string name)
        {
            int stt = 1;
            dgvsanpham.ColumnCount = 9;
            dgvsanpham.Rows.Clear();
            dgvsanpham.Columns[0].Name = "Id";
            dgvsanpham.Columns[1].Name = "Stt";
            dgvsanpham.Columns[2].Name = "Mã SP";
            dgvsanpham.Columns[3].Name = "Tên SP";
            dgvsanpham.Columns[4].Name = "Giá Bán";
            
            dgvsanpham.Columns[5].Name = "Số Lượng";
            dgvsanpham.Columns[6].Name = "Trạng Thái";
            dgvsanpham.Columns[7].Name = "Mô Tả";
            dgvsanpham.Columns[8].Name = "Hình Ảnh";
            dgvsanpham.Columns[0].Visible = false;
            foreach (var item in SanPhamservice.Timkiem(name))
            {
                dgvsanpham.Rows.Add(item.Id, stt++, item.MaSp, item.TenSanPham, item.DonGia, item.SoLuong, item.TrangThai, item.MoTa, item.HinhAnh);
            }
        }
        private void txttimkimdouong_TextChanged(object sender, EventArgs e)
        {
            TimKiem(txttimkimdouong.Text);
        }
        public void Locc(string trangthai)
        {
            int stt = 1;
            dgvsanpham.ColumnCount = 9;
            dgvsanpham.Rows.Clear();
            dgvsanpham.Columns[0].Name = "Id";
            dgvsanpham.Columns[1].Name = "Stt";
            dgvsanpham.Columns[2].Name = "Mã SP";
            dgvsanpham.Columns[3].Name = "Tên SP";
            dgvsanpham.Columns[4].Name = "Giá Bán";
            
            dgvsanpham.Columns[5].Name = "Số Lượng";
            dgvsanpham.Columns[6].Name = "Trạng Thái";
            dgvsanpham.Columns[7].Name = "Mô Tả";
            dgvsanpham.Columns[8].Name = "Hình Ảnh";
            dgvsanpham.Columns[0].Visible = false;
            foreach (var item in SanPhamservice.Loc(trangthai))
            {
                dgvsanpham.Rows.Add(item.Id, stt++, item.MaSp, item.TenSanPham, item.DonGia, item.SoLuong, item.TrangThai, item.MoTa, item.HinhAnh);
            }
        }
        private void cbolocDU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbolocDU.SelectedIndex == 1)
            {
                Locc("Đang bán");
            }
            else
            {
                Locc("Ngừng bán");
            }

        }

        private void btn_LoadDU_Click(object sender, EventArgs e)
        {
            LoadData();
        }



        private void btn_themDU_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pathimg))
            {
                bool check = SanPhamservice.Allsanpham().Any(x => x.MaSp == txtmasp.Text);
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
                        SanPham sanPham = new SanPham();
                        sanPham.MaSp = txtmasp.Text;
                        sanPham.TenSanPham = txttensp.Text;
                        sanPham.DonGia = Convert.ToInt32(txtGiaban.Text);                       
                        sanPham.SoLuong = Convert.ToInt32(txtsoluong.Text);
                        sanPham.MoTa = txtmotaDU.Text;
                        sanPham.TrangThai = rbtdangbanDU.Checked ? "Đang Bán" : "Ngừng Bán";
                        sanPham.HinhAnh = imageBytes;
                        MessageBox.Show(SanPhamservice.Them(sanPham));
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hình ảnh trước khi thêm sản phẩm.", "Thông báo");
            }
        }

        private void dgvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            idWhenclick = int.Parse(dgvsanpham.Rows[d].Cells[0].Value.ToString());
            txtmasp.Text = dgvsanpham.Rows[d].Cells[2].Value.ToString();
            txttensp.Text = dgvsanpham.Rows[d].Cells[3].Value.ToString();
            txtGiaban.Text = dgvsanpham.Rows[d].Cells[4].Value.ToString();
            
            txtsoluong.Text = dgvsanpham.Rows[d].Cells[5].Value.ToString();
            txtmotaDU.Text = dgvsanpham.Rows[d].Cells[7].Value.ToString();
            if (dgvsanpham.Rows[d].Cells[6].Value.ToString().Equals("Đang Bán"))
            {
                rbtdangbanDU.Checked = true;
            }
            else
            {
                rbtngungbanDU.Checked = true;
            }
            var s = SanPhamservice.Findid(idWhenclick);
            object img = s.HinhAnh;

            byte[] imageData = (byte[])img;
            Image image;
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                image = Image.FromStream(ms);
            }
            pbhinhanh.Image = image;
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

        private void btn_suaDU_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn Sửa không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dr == DialogResult.Yes)
            {
                byte[] imageBytes = File.ReadAllBytes(pathimg);
                SanPham sanPham = new SanPham();
                sanPham.MaSp = txtmasp.Text;
                sanPham.TenSanPham = txttensp.Text;
                sanPham.DonGia = Convert.ToInt32(txtGiaban.Text);
                
                sanPham.SoLuong = Convert.ToInt32(txtsoluong.Text);
                sanPham.MoTa = txtmotaDU.Text;
                sanPham.TrangThai = rbtdangbanDU.Checked ? "Đang Bán" : "Ngừng Bán";
                sanPham.HinhAnh = imageBytes;
                MessageBox.Show(SanPhamservice.Sua(idWhenclick, sanPham));
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hình ảnh trước khi thêm sản phẩm.", "Thông báo");
            }
        }

        private void btn_LoadDU_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click_1(object sender, EventArgs e)
        {
            txtmasp.ResetText();
            txttensp.ResetText();
            txtGiaban.ResetText();
           
            txtsoluong.ResetText();
            rbtdangbanDU.Checked = false;
            rbtngungbanDU.Checked = false;
            pbhinhanh.Image = null;
        }

        private void Form_SanPham_Load(object sender, EventArgs e)
        {
            SanPhamservice = new SanPhamSer();
            LoadData();
        }

        private void lbDU_Click(object sender, EventArgs e)
        {

        }
    }
}
