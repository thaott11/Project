using Du_An_1_Caffe.BLL.Service;
using Du_An_1_Caffe.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Du_An_1_Caffe.PRL.Forms
{
    public partial class Form_QuanLyKhachHang : Form
    {
        public Form_QuanLyKhachHang()
        {
            InitializeComponent();
            KhachHangService = new KhachHangSer();
            LoadData();
        }
        KhachHangSer KhachHangService;
        int? idWhenclick = new int?();
        private void QuanLykhachhang_Load(object sender, EventArgs e)
        {
           
        }

        public void LoadData()
        {
            int stt = 1;
            dgvkhachhang.ColumnCount = 7;
            dgvkhachhang.Rows.Clear();
            dgvkhachhang.Columns[0].Name = "Id";
            dgvkhachhang.Columns[1].Name = "Stt";
            dgvkhachhang.Columns[2].Name = "Mã khách hàng";
            dgvkhachhang.Columns[3].Name = "Tên khách hàng";
            dgvkhachhang.Columns[4].Name = "Sđt";
            dgvkhachhang.Columns[5].Name = "Địa chỉ";
            dgvkhachhang.Columns[6].Name = "Giới tính";
            dgvkhachhang.Columns[0].Visible = false;

            foreach (var item in KhachHangService.AllKhachHang())
            {
                dgvkhachhang.Rows.Add(item.Id, stt++, item.MaKh, item.TenKh, item.Sdt, item.Diachi, item.GioiTinh);
            }
        }

        public bool chechMa(string mess)
        {
            return Regex.IsMatch(mess, @"^[a-zA-Z0-9_-]+$");
        }
        private void btn_themKH_Click_1(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.MaKh = txtmakh.Text;
            khachHang.TenKh = txttenkh.Text;
            khachHang.Sdt = txtsdt.Text;
            khachHang.Diachi = txtdiachi.Text;
            khachHang.GioiTinh = rbtNam.Checked ? "Nam" : "Nữ";

            DialogResult dr = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                KhachHangService.Them(khachHang);
                LoadData();
            }
        }


        private void btn_suaKH_Click_1(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.MaKh = txtmakh.Text;
            khachHang.TenKh = txttenkh.Text;
            khachHang.Sdt = txtsdt.Text;
            khachHang.Diachi = txtdiachi.Text;
            khachHang.GioiTinh = rbtNam.Checked ? "Nam" : "Nữ";
            DialogResult dr = MessageBox.Show("Bạn có muốn Sửa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dr == DialogResult.Yes)
            {
                KhachHangService.Sua(idWhenclick, khachHang);
                LoadData();
            }
        }

        private void dgvkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            idWhenclick = int.Parse(dgvkhachhang.Rows[d].Cells[0].Value.ToString());
            txtmakh.Text = dgvkhachhang.Rows[d].Cells[2].Value.ToString();
            txttenkh.Text = dgvkhachhang.Rows[d].Cells[3].Value.ToString();
            txtsdt.Text = dgvkhachhang.Rows[d].Cells[4].Value.ToString();
            txtdiachi.Text = dgvkhachhang.Rows[d].Cells[5].Value.ToString();
            if (dgvkhachhang.Rows[d].Cells[6].Value.ToString().Equals("Nam"))
            {
                rbtNam.Checked = true;
            }
            else
            {
                rbtNu.Checked = true;
            }
        }

        public void Timkiem(string name)
        {
            int stt = 1;
            dgvkhachhang.ColumnCount = 7;
            dgvkhachhang.Rows.Clear();
            dgvkhachhang.Columns[0].Name = "Id";
            dgvkhachhang.Columns[1].Name = "Stt";
            dgvkhachhang.Columns[2].Name = "Mã khách hàng";
            dgvkhachhang.Columns[3].Name = "Tên khách hàng";
            dgvkhachhang.Columns[4].Name = "Sđt";
            dgvkhachhang.Columns[5].Name = "Địa chỉ";
            dgvkhachhang.Columns[6].Name = "Giới tính";
            dgvkhachhang.Columns[0].Visible = false;

            foreach (var item in KhachHangService.Timkiem(name))
            {
                dgvkhachhang.Rows.Add(item.Id, stt++, item.MaKh, item.TenKh, item.Sdt, item.Diachi, item.GioiTinh);
            }
        }

        private void Form_QuanLyKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void txttimkiemkhachhang_TextChanged_1(object sender, EventArgs e)
        {
            Timkiem(txttimkiemkhachhang.Text);
        }

        private void btn_Load_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtmakh.ResetText();
            txttenkh.ResetText();
            txtsdt.ResetText();
            txtdiachi.ResetText();
            rbtNam.Checked = false;
            rbtNu.Checked = false;
        }
    }
}
