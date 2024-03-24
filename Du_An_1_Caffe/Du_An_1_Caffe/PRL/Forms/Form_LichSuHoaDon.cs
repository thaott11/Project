using Du_An_1_Caffe.BLL.Service;
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
    public partial class Form_LichSuHoaDon : Form
    {
        HoaDonSer _ser = new HoaDonSer();
        public Form_LichSuHoaDon()
        {
            InitializeComponent();
            LoadHoaDon();
        }

        public void LoadHoaDon()
        {

            dgvhoadon.ColumnCount = 6;
            dgvhoadon.Columns[0].Name = "STT";
            dgvhoadon.Columns[1].Name = "Id";
            dgvhoadon.Columns[2].Name = "Mã Hóa Đơn";
            dgvhoadon.Columns[3].Name = "Ngày Mua";
            dgvhoadon.Columns[4].Name = "Người Tạo";
            dgvhoadon.Columns[5].Name = "Trạng Thái";
            dgvhoadon.Columns[1].Visible = false;

            int stt = 1;

            var result = from n in _ser.GetAllHoaDon()
                         join m in _ser.GetAllNV()
                         on n.IdNhanVien equals m.Id
                         select new
                         {
                             stt = stt++,
                             Id = n.IdHd,
                             Ma = n.MaHd,
                             NgayMua = n.NgayMuaHang,
                             NguoiTao = m.TenNv,
                             TrangThai = n.TrangThai,
                         };

            foreach (var item in result)
            {
                dgvhoadon.Rows.Add(stt++, item.Id, item.Ma, item.NgayMua, item.NguoiTao, item.TrangThai);
            }
        }

        private void dgvhoadonchitiet_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
