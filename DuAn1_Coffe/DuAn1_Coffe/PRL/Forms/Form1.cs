using DuAn1_Coffe.BLL.Service;
using DuAn1_Coffe.DAL.Models;
using DuAn1_Coffe.PRL.Forms;

namespace DuAn1_Coffe
{
    public partial class Form1 : Form
    {
        AccSer AccountService = new AccSer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taikhoan = tb_tk.Text;
            string matkhau = tb_mk.Text;
            NhanVien user;
            if (AccountService.Taikhoans(taikhoan, matkhau, out user))
            {
                if (user.VaiTro == "Qu?n l�")
                {
                    // M? form d�nh cho qu?n l�
                    Form_TrangChu trangchu = new Form_TrangChu();
                    trangchu.Show();
                }
                else
                {
                    // M? form d�nh cho nh�n vi�n
                    Form_NhanVien trang_NhanVien = new Form_NhanVien();
                    trang_NhanVien.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("T�n ??ng nh?p ho?c m?t kh?u kh�ng ?�ng!", "L?i ??ng nh?p", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
