using QRCoder;
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
    public partial class Form_QRCode : Form
    {
        public Form_QRCode()
        {
            InitializeComponent();
        }

        private void btn_tạo_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrGenernator = new QRCodeGenerator();
            QRCodeData qrCodedata = qrGenernator.CreateQrCode(textBox1.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrCodedata);
            Bitmap qrcodeImg = qrcode.GetGraphic(20);
            pictureBox1.Image = qrcodeImg;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog savefliedialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (savefliedialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(savefliedialog.FileName);
                    MessageBox.Show("Tệp đã lưu");
                }
            }
        }
    }
}
