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
    public partial class Form_GiamGia : Form
    {
        // lấy dữ liệu ở lớp service
        GiamGiaSer _ser = new GiamGiaSer();
        int _id = -1;
        public Form_GiamGia()
        {
            InitializeComponent();
            LoatData(_ser.GetAll());
            LoatSanPham(_ser.GetAllSP());
        }


        // loat lên datagrit view
        public void LoatData(List<KhuyenMai> data)
        {
            int stt = 1;
            dgvgiamgia.Columns.Clear();
            dgvgiamgia.ColumnCount = 8;
            dgvgiamgia.Columns[0].Name = "Stt";
            dgvgiamgia.Columns[1].Name = "Id";
            dgvgiamgia.Columns[2].Name = "Ma";
            dgvgiamgia.Columns[3].Name = "Ten";
            dgvgiamgia.Columns[4].Name = "Gia Tri";
            dgvgiamgia.Columns[5].Name = "Ngay Bat Dau";
            dgvgiamgia.Columns[6].Name = "Ngay Ket Thuc";
            dgvgiamgia.Columns[7].Name = "Trang Thai";
            dgvgiamgia.Columns[1].Visible = false;
            foreach (var x in _ser.GetAll())
            {
                dgvgiamgia.Rows.Add(stt++, x.Id, x.MaKm, x.TenKm, x.GiaGiam,
                    x.NgayBatDau, x.NgayKetThuc, x.TrangThai);
            }
        }
        // them khuyến mãi khi ế hàng
        private void btn_themKM_Click(object sender, EventArgs e)
        {
            // toán tử 3 ngôi để cho code ngắn hơn (no if else)
            string tt = (rbtDangApdung.Checked == true) ? "Đang áp dụng" : "Ngưng áp dụng";
            //try
            //{
            KhuyenMai gg = new KhuyenMai();
            gg.MaKm = txtMaKM.Text;
            gg.TenKm = txttenkm.Text;
            gg.GiaGiam = Convert.ToDouble(txtgiatrigiam.Text);
            gg.NgayBatDau = DateTime.ParseExact(dtpngaybatdau.Text.Trim(), "dd/MM/yyyy", null);
            gg.NgayKetThuc = DateTime.ParseExact(dtpNgayketthuc.Text.Trim(), "dd/MM/yyyy", null);
            gg.TrangThai = tt;
            _ser.Add(gg);
            LoatData(null);
            MessageBox.Show("Them thanh cong");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Them that bai", ex.Message);
            //}
        }


        // gọi sự kiện khi click vào data grit view
        private void dgvgiamgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            _id = Convert.ToInt32(dgvgiamgia.Rows[d].Cells[1].Value);
            txtMaKM.Text = dgvgiamgia.Rows[d].Cells[2].Value.ToString();
            txttenkm.Text = dgvgiamgia.Rows[d].Cells[3].Value.ToString();
            txtgiatrigiam.Text = dgvgiamgia.Rows[d].Cells[4].Value.ToString();
            dtpngaybatdau.Text = dgvgiamgia.Rows[d].Cells[5].Value.ToString();
            dtpNgayketthuc.Text = dgvgiamgia.Rows[d].Cells[6].Value.ToString();
            string nbd = dgvgiamgia.Rows[d].Cells[7].Value.ToString();
            if (nbd == "Đang áp dụng")
            {
                rbtDangApdung.Checked = true;
            }
            else
            {
                rbtNgungApDung.Checked = true;
            }
        }

        // không thích thì sửa
        private void btn_suaKH_Click(object sender, EventArgs e)
        {
            try
            {
                // nút xác nhân thêm hay không
                DialogResult re = MessageBox.Show("Ban co muon sua không? ", "Thông báo", MessageBoxButtons.OKCancel);
                if (re == DialogResult.OK)
                {
                    string tt = (rbtDangApdung.Checked == true) ? "Đang áp dụng" : "Ngưng áp dụng";
                    KhuyenMai gg = new KhuyenMai();
                    gg.MaKm = txtMaKM.Text;
                    gg.TenKm = txttenkm.Text;
                    gg.GiaGiam = Convert.ToDouble(txtgiatrigiam.Text);
                    gg.NgayBatDau = DateTime.ParseExact(dtpngaybatdau.Text.Trim(), "dd/MM/yyyy", null);
                    gg.NgayKetThuc = DateTime.ParseExact(dtpNgayketthuc.Text.Trim(), "dd/MM/yyyy", null);
                    gg.TrangThai = tt;
                    _ser.Update(_id, gg);
                    LoatData(null);
                    MessageBox.Show("Sua thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sưa That bai", ex.Message);
            }
        }

        // vứt đấy mai tính tiếp 

        // // nếu không thấy thì tìm kiếm       
        private void txttimkiemKM_TextChanged(object sender, EventArgs e)
        {
            LoatData(_ser.Seachten(txttimkiemKM.Text));
        }

        // loat dữ liệu của sản phẩm lên data grit view
        public void LoatSanPham(List<SanPham> data)
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

            foreach (var item in _ser.GetAllSP())
            {
                dgvsanpham.Rows.Add(stt++, item.Id, item.MaSp,
                    item.TenSanPham, item.DonGia, item.SoLuong,
                    item.TrangThai, item.MoTa, item.HinhAnh);
            }
        }
        // tìm kiếm sản phẩm
        private void txttimkiemSP_TextChanged(object sender, EventArgs e)
        {
            LoatSanPham(_ser.SeachTenSanPham(txttimkiemSP.Text));
        }
    }
}
