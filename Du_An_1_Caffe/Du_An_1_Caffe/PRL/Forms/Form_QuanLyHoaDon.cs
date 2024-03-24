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
    public partial class Form_QuanLyHoaDon : Form

    {
        HoaDonSer _ser = new HoaDonSer();
        public Form_QuanLyHoaDon()
        {
            InitializeComponent();
            LoadDataHoaDon(_ser.GetAllHoaDon());
        }

        public void LoadDataHoaDon(List<HoaDon> data)
        {
            int stt = 1;
            dgvhoadon.ColumnCount = 6;
            dgvhoadon.Rows.Clear();
            dgvhoadon.Columns[0].Name = "Id";
            dgvhoadon.Columns[1].Name = "Stt";
            dgvhoadon.Columns[2].Name = "Ma HD";
            dgvhoadon.Columns[3].Name = "Ngày Mua Hàng";
            dgvhoadon.Columns[4].Name = "Nhân Viên";
            dgvhoadon.Columns[5].Name = "Trạng thái";
            dgvhoadon.Columns[0].Visible = false;
            foreach (var item in _ser.GetAllHoaDon())
            {
                dgvhoadon.Rows.Add(item.IdNhanVien, stt++, item.MaHd, item.NgayMuaHang);
            }
        }

        public void LoatInHoaDon()
        {
            int stt = 1;
            dgvhoadon.ColumnCount = 6;
            dgvhoadon.Rows.Clear();
            dgvhoadon.Columns[0].Name = "Id";
            dgvhoadon.Columns[1].Name = "MaHD";
            dgvhoadon.Columns[3].Name = "Ngày Mua Hàng";
            dgvhoadon.Columns[4].Name = "Nhân Viên";
            dgvhoadon.Columns[5].Name = "Trạng thái";
            dgvhoadon.Columns[1].Name = "GiaTien";
            dgvhoadon.Columns[2].Name = "Ma HD";
            dgvhoadon.Columns[3].Name = "Ngày Mua Hàng";
            dgvhoadon.Columns[4].Name = "Nhân Viên";
            dgvhoadon.Columns[5].Name = "Trạng thái";
            dgvhoadon.Columns[0].Visible = false;
        }
        private void btn_timNgay_Click(object sender, EventArgs e)
        {
            DateTime ngayTu = dtpTu.Value.Date;
            DateTime ngayDen = dtpDen.Value.Date.AddDays(1).AddSeconds(-1);
            // Gọi hóa đơn và lấy ra ngày đã chọn
            List<HoaDon> SeachNgay = _ser.GetAllHoaDon().Where(hd => hd.NgayMuaHang >= ngayTu && hd.NgayMuaHang <= ngayDen).ToList();
            LoadDataHoaDon(SeachNgay);
        }

        // tìm kiếm theo mã
        private void txttimkiemmahoadon_TextChanged(object sender, EventArgs e)
        {
            LoadDataHoaDon(_ser.SeachMa(txttimkiemmahoadon.Text));
        }

        // tìm kiếm theo người tạo
        private void txttimkiemnguoitao_TextChanged(object sender, EventArgs e)
        {
            LoadDataHoaDon(_ser.SeachNguoiTao((txttimkiemnguoitao.Text)));
        }

        private void dgvhoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int d = e.RowIndex;
            txttimkiemmahoadon.Text = dgvhoadon.Rows[d].Cells[0].Value.ToString();
            dtpTu.Text = dgvhoadon.Rows[d].Cells[3].Value.ToString();
            txttimkiemnguoitao.Text = dgvhoadon.Rows[d].Cells[4].Value.ToString();
            cbolochoadon.Text = dgvhoadon.Rows[d].Cells[5].Value.ToString();
        }

        private void btn_suaKH_Click(object sender, EventArgs e)
        {

        }
    }
}
