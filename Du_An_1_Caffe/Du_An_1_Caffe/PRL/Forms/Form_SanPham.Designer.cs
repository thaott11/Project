namespace Du_An_1_Caffe.PRL.Forms
{
    partial class Form_SanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SanPham));
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            lbDU = new Label();
            cbolocDU = new ComboBox();
            txttensp = new TextBox();
            label3 = new Label();
            txtsoluong = new TextBox();
            label2 = new Label();
            btn_LoadDU = new Button();
            btn_Reset = new Button();
            txtmasp = new TextBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            btn_anh = new Button();
            pbhinhanh = new PictureBox();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            dgvsanpham = new DataGridView();
            btn_suaDU = new Button();
            btn_themDU = new Button();
            rbtngungbanDU = new RadioButton();
            lbtrangthai = new Label();
            txtmotaDU = new TextBox();
            lbmota = new Label();
            txtGiaban = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txttimkimdouong = new TextBox();
            rbtdangbanDU = new RadioButton();
            panel1 = new Panel();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbhinhanh).BeginInit();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsanpham).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 718);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(2564, 10);
            panel2.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Lavender;
            groupBox2.Controls.Add(lbDU);
            groupBox2.Controls.Add(cbolocDU);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(2564, 27);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // lbDU
            // 
            lbDU.AutoSize = true;
            lbDU.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbDU.Location = new Point(1693, 8);
            lbDU.Margin = new Padding(5, 0, 5, 0);
            lbDU.Name = "lbDU";
            lbDU.Size = new Size(185, 50);
            lbDU.TabIndex = 107;
            lbDU.Text = "Trạng thái";
            lbDU.Click += lbDU_Click;
            // 
            // cbolocDU
            // 
            cbolocDU.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbolocDU.FormattingEnabled = true;
            cbolocDU.Items.AddRange(new object[] { "Tất cả", "Đang bán", "Ngừng bán" });
            cbolocDU.Location = new Point(1915, -2);
            cbolocDU.Margin = new Padding(5);
            cbolocDU.Name = "cbolocDU";
            cbolocDU.Size = new Size(456, 58);
            cbolocDU.TabIndex = 106;
            // 
            // txttensp
            // 
            txttensp.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttensp.Location = new Point(273, 259);
            txttensp.Margin = new Padding(5);
            txttensp.Name = "txttensp";
            txttensp.Size = new Size(597, 56);
            txttensp.TabIndex = 120;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(83, 268);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 50);
            label3.TabIndex = 119;
            label3.Text = "Tên SP";
            // 
            // txtsoluong
            // 
            txtsoluong.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtsoluong.Location = new Point(1155, 130);
            txtsoluong.Margin = new Padding(5);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(597, 56);
            txtsoluong.TabIndex = 118;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(966, 143);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 50);
            label2.TabIndex = 117;
            label2.Text = "Số lượng";
            // 
            // btn_LoadDU
            // 
            btn_LoadDU.BackColor = SystemColors.ControlLightLight;
            btn_LoadDU.BackgroundImage = (Image)resources.GetObject("btn_LoadDU.BackgroundImage");
            btn_LoadDU.BackgroundImageLayout = ImageLayout.Stretch;
            btn_LoadDU.Location = new Point(2190, 549);
            btn_LoadDU.Margin = new Padding(5, 6, 5, 6);
            btn_LoadDU.Name = "btn_LoadDU";
            btn_LoadDU.Size = new Size(128, 107);
            btn_LoadDU.TabIndex = 116;
            btn_LoadDU.UseVisualStyleBackColor = false;
            btn_LoadDU.Click += btn_LoadDU_Click_1;
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(2190, 413);
            btn_Reset.Margin = new Padding(5);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(128, 93);
            btn_Reset.TabIndex = 126;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click_1;
            // 
            // txtmasp
            // 
            txtmasp.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtmasp.Location = new Point(273, 109);
            txtmasp.Margin = new Padding(5);
            txtmasp.Name = "txtmasp";
            txtmasp.Size = new Size(597, 56);
            txtmasp.TabIndex = 123;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(83, 117);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 50);
            label4.TabIndex = 122;
            label4.Text = "Mã SP";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_anh);
            groupBox4.Controls.Add(pbhinhanh);
            groupBox4.Location = new Point(1800, 130);
            groupBox4.Margin = new Padding(5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(5);
            groupBox4.Size = new Size(338, 429);
            groupBox4.TabIndex = 121;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hình ảnh";
            // 
            // btn_anh
            // 
            btn_anh.BackColor = Color.DarkOrange;
            btn_anh.Location = new Point(102, 355);
            btn_anh.Margin = new Padding(5);
            btn_anh.Name = "btn_anh";
            btn_anh.Size = new Size(153, 62);
            btn_anh.TabIndex = 1;
            btn_anh.Text = "Ảnh";
            btn_anh.UseVisualStyleBackColor = false;
            btn_anh.Click += btn_anh_Click_1;
            // 
            // pbhinhanh
            // 
            pbhinhanh.BackColor = SystemColors.ActiveCaptionText;
            pbhinhanh.Location = new Point(39, 46);
            pbhinhanh.Margin = new Padding(5);
            pbhinhanh.Name = "pbhinhanh";
            pbhinhanh.Size = new Size(266, 293);
            pbhinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbhinhanh.TabIndex = 0;
            pbhinhanh.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 718);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(2564, 840);
            panel3.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvsanpham);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(2564, 840);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin sản phẩm";
            // 
            // dgvsanpham
            // 
            dgvsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsanpham.Dock = DockStyle.Fill;
            dgvsanpham.Location = new Point(5, 37);
            dgvsanpham.Margin = new Padding(5);
            dgvsanpham.Name = "dgvsanpham";
            dgvsanpham.RowHeadersWidth = 51;
            dgvsanpham.Size = new Size(2554, 798);
            dgvsanpham.TabIndex = 0;
            dgvsanpham.CellContentClick += dgvsanpham_CellContentClick;
            // 
            // btn_suaDU
            // 
            btn_suaDU.BackgroundImage = (Image)resources.GetObject("btn_suaDU.BackgroundImage");
            btn_suaDU.BackgroundImageLayout = ImageLayout.Stretch;
            btn_suaDU.Location = new Point(2190, 275);
            btn_suaDU.Margin = new Padding(5, 6, 5, 6);
            btn_suaDU.Name = "btn_suaDU";
            btn_suaDU.Size = new Size(128, 107);
            btn_suaDU.TabIndex = 115;
            btn_suaDU.UseVisualStyleBackColor = true;
            btn_suaDU.Click += btn_suaDU_Click_1;
            // 
            // btn_themDU
            // 
            btn_themDU.BackgroundImage = (Image)resources.GetObject("btn_themDU.BackgroundImage");
            btn_themDU.BackgroundImageLayout = ImageLayout.Stretch;
            btn_themDU.Location = new Point(2190, 141);
            btn_themDU.Margin = new Padding(5, 6, 5, 6);
            btn_themDU.Name = "btn_themDU";
            btn_themDU.Size = new Size(128, 106);
            btn_themDU.TabIndex = 114;
            btn_themDU.UseVisualStyleBackColor = true;
            btn_themDU.Click += btn_themDU_Click_1;
            // 
            // rbtngungbanDU
            // 
            rbtngungbanDU.AutoSize = true;
            rbtngungbanDU.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtngungbanDU.Location = new Point(1492, 512);
            rbtngungbanDU.Margin = new Padding(5);
            rbtngungbanDU.Name = "rbtngungbanDU";
            rbtngungbanDU.Size = new Size(240, 54);
            rbtngungbanDU.TabIndex = 113;
            rbtngungbanDU.TabStop = true;
            rbtngungbanDU.Text = "Ngừng bán";
            rbtngungbanDU.UseVisualStyleBackColor = true;
            // 
            // lbtrangthai
            // 
            lbtrangthai.AutoSize = true;
            lbtrangthai.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbtrangthai.Location = new Point(966, 516);
            lbtrangthai.Margin = new Padding(5, 0, 5, 0);
            lbtrangthai.Name = "lbtrangthai";
            lbtrangthai.Size = new Size(185, 50);
            lbtrangthai.TabIndex = 111;
            lbtrangthai.Text = "Trạng thái";
            // 
            // txtmotaDU
            // 
            txtmotaDU.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtmotaDU.Location = new Point(1170, 322);
            txtmotaDU.Margin = new Padding(5);
            txtmotaDU.Name = "txtmotaDU";
            txtmotaDU.Size = new Size(582, 56);
            txtmotaDU.TabIndex = 110;
            // 
            // lbmota
            // 
            lbmota.AutoSize = true;
            lbmota.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbmota.Location = new Point(962, 328);
            lbmota.Margin = new Padding(5, 0, 5, 0);
            lbmota.Name = "lbmota";
            lbmota.Size = new Size(119, 50);
            lbmota.TabIndex = 109;
            lbmota.Text = "Mô tả";
            // 
            // txtGiaban
            // 
            txtGiaban.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtGiaban.Location = new Point(273, 413);
            txtGiaban.Margin = new Padding(5);
            txtGiaban.Name = "txtGiaban";
            txtGiaban.Size = new Size(597, 56);
            txtGiaban.TabIndex = 108;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(83, 421);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 50);
            label1.TabIndex = 107;
            label1.Text = "Giá Bán";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Lavender;
            groupBox1.Controls.Add(btn_Reset);
            groupBox1.Controls.Add(txttimkimdouong);
            groupBox1.Controls.Add(txtmasp);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(txttensp);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtsoluong);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btn_LoadDU);
            groupBox1.Controls.Add(btn_suaDU);
            groupBox1.Controls.Add(btn_themDU);
            groupBox1.Controls.Add(rbtngungbanDU);
            groupBox1.Controls.Add(rbtdangbanDU);
            groupBox1.Controls.Add(lbtrangthai);
            groupBox1.Controls.Add(txtmotaDU);
            groupBox1.Controls.Add(lbmota);
            groupBox1.Controls.Add(txtGiaban);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(2564, 718);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản Phẩm";
            // 
            // txttimkimdouong
            // 
            txttimkimdouong.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttimkimdouong.Location = new Point(208, 652);
            txttimkimdouong.Margin = new Padding(5);
            txttimkimdouong.Name = "txttimkimdouong";
            txttimkimdouong.PlaceholderText = "Tìm kiếm";
            txttimkimdouong.Size = new Size(466, 56);
            txttimkimdouong.TabIndex = 105;
            // 
            // rbtdangbanDU
            // 
            rbtdangbanDU.AutoSize = true;
            rbtdangbanDU.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtdangbanDU.Location = new Point(1190, 512);
            rbtdangbanDU.Margin = new Padding(5);
            rbtdangbanDU.Name = "rbtdangbanDU";
            rbtdangbanDU.Size = new Size(213, 54);
            rbtdangbanDU.TabIndex = 112;
            rbtdangbanDU.TabStop = true;
            rbtdangbanDU.Text = "Đang bán";
            rbtdangbanDU.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2564, 718);
            panel1.TabIndex = 3;
            // 
            // Form_SanPham
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2564, 1558);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form_SanPham";
            Text = "Form_SanPham";
            Load += Form_SanPham_Load;
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbhinhanh).EndInit();
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvsanpham).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private GroupBox groupBox2;
        private Label lbDU;
        private ComboBox cbolocDU;
        private TextBox txttensp;
        private Label label3;
        private TextBox txtsoluong;
        private Label label2;
        private Button btn_LoadDU;
        private Button btn_Reset;
        private TextBox txtmasp;
        private Label label4;
        private GroupBox groupBox4;
        private Button btn_anh;
        private PictureBox pbhinhanh;
        private Panel panel3;
        private GroupBox groupBox3;
        private DataGridView dgvsanpham;
        private Button btn_suaDU;
        private Button btn_themDU;
        private RadioButton rbtngungbanDU;
        private Label lbtrangthai;
        private TextBox txtmotaDU;
        private Label lbmota;
        private TextBox txtGiaban;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbtdangbanDU;
        private Panel panel1;
        private TextBox txttimkimdouong;
    }
}