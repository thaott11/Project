using DuAn1_Coffe.BLL.Service;
using DuAn1_Coffe.DAL.Models;
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

namespace DuAn1_Coffe.PRL.Forms
{
    public partial class Form_QuanLyKH : Form
    {
        KhachHangSer KhachHangService = new KhachHangSer();
        int? idWhenclick = new int?();

        public Form_QuanLyKH()
        {
            InitializeComponent();
            LoadData();
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
        public bool Checksdt(string mess)
        {
            return Regex.IsMatch(mess, @"^\d{10}$");
        }

        private void btn_themKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtmakh.Text))
                {
                    MessageBox.Show("Không được để trống mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool check = KhachHangService.AllKhachHang().Any(x => x.MaKh == txtmakh.Text);
                    if (check)
                    {
                        MessageBox.Show("Mã đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        KhachHang khachHang = new KhachHang();
                        khachHang.MaKh = txtmakh.Text;
                        khachHang.TenKh = txttenkh.Text;
                        khachHang.Sdt = txtsdt.Text;
                        khachHang.Diachi = txtdiachi.Text;
                        khachHang.GioiTinh = rbtNam.Checked ? "Nam" : "Nữ";
                        DialogResult dr = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (dr == DialogResult.Yes)
                        {
                            KhachHangService.Them(khachHang);
                            LoadData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi rồi" + ex);
            }

        }

        private void btn_suaKH_Click(object sender, EventArgs e)
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi rồi" + ex);
            }
        }

        private void dgvkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Timkiem(string ma)
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

            foreach (var item in KhachHangService.Timkiem(ma))
            {
                dgvkhachhang.Rows.Add(item.Id, stt++, item.MaKh, item.TenKh, item.Sdt, item.Diachi, item.GioiTinh);
            }
        }

        private void txttimkiemkhachhang_TextChanged(object sender, EventArgs e)
        {
            Timkiem(txttimkiemkhachhang.Text);
        }

        private void btn_Load_Click(object sender, EventArgs e)
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

        private void dgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            idWhenclick = int.Parse(dgvkhachhang.Rows[d].Cells[0].Value.ToString());
            txtmakh.Text = dgvkhachhang.Rows[d].Cells[2].Value.ToString();
            txttenkh.Text = dgvkhachhang.Rows[d].Cells[3].Value.ToString();
            txtsdt.Text = dgvkhachhang.Rows[d].Cells[4].Value.ToString();
            txtdiachi.Text = dgvkhachhang.Rows[d].Cells[5].Value.ToString();
            var cell = dgvkhachhang.Rows[d].Cells[6].Value?.ToString(); // trả về null nếu ko có giá trị
                                                                        // Kiểm tra nếu ô đó không có giá trị
            if (cell == null || cell.ToString() == "")
            {
                rbtNam.Checked = false;
                rbtNu.Checked = false;
            }
            else if (cell == "Nam")
            {
                rbtNam.Checked = true;
            }
            else
            {
                rbtNu.Checked = true;
            }
        }


        private void Form_QuanLyKH_Load(object sender, EventArgs e)
        {

        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
