using Du_An_1_Caffe.PRL.Forms;

namespace Du_An_1_Caffe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_dn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_TrangChu trang = new Form_TrangChu();
            trang.Closed += (s, args) => this.Close();
            trang.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMK.Checked)
            {
                tb_mk.PasswordChar = '\0';
            }
            else tb_mk.PasswordChar = '*';
        }
    }
}
