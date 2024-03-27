using DuAn1_Coffe.BLL.Service;
using DuAn1_Coffe.DAL.Models;
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
    public partial class Form_DanhSachKH : Form
    {
        KhachHangSer KhachHangService = new KhachHangSer();

        public Form_DanhSachKH()
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

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            Timkiem(txttimkiem.Text);
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            //if (Application.OpenForms["Menu"] != null)
            //{
            //    Menu banHangForm = (Menu)Application.OpenForms["Menu"];
            //    int id = int.Parse(dgvkhachhang.CurrentRow.Cells[0].Value.ToString());
            //    string maKhachHang = dgvkhachhang.CurrentRow.Cells[2].Value.ToString();
            //    string tenKhachHang = dgvkhachhang.CurrentRow.Cells[3].Value.ToString();

            //    banHangForm.(maKhachHang, tenKhachHang, id);
            //}
            //else
            //{
            //    Menu banHangForm = new Menu();

            //    string maKhachHang = dgvkhachhang.CurrentRow.Cells[2].Value.ToString();
            //    string tenKhachHang = dgvkhachhang.CurrentRow.Cells[3].Value.ToString();
            //    int id = int.Parse(dgvkhachhang.CurrentRow.Cells[0].Value.ToString());


            //    banHangForm.CapNhatThongTinKhachHang(maKhachHang, tenKhachHang, id);
            //}
            //this.Close();
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
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
            }
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
