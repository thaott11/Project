namespace Du_An_1_Caffe.PRL.Forms
{
    partial class Form_QuanLyKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyKhachHang));
            txttimkiemkhachhang = new TextBox();
            dgvkhachhang = new DataGridView();
            btn_Reset = new Button();
            btn_Load = new Button();
            rbtNu = new RadioButton();
            rbtNam = new RadioButton();
            lbtrangthaii = new Label();
            btn_suaKH = new Button();
            btn_themKH = new Button();
            lbdiachi = new Label();
            groupBox3 = new GroupBox();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            txtdiachi = new TextBox();
            lbsdt = new Label();
            label2 = new Label();
            txttenkh = new TextBox();
            lbmakh = new Label();
            txtmakh = new TextBox();
            groupBox1 = new GroupBox();
            txtsdt = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvkhachhang).BeginInit();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txttimkiemkhachhang
            // 
            txttimkiemkhachhang.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttimkiemkhachhang.Location = new Point(193, 21);
            txttimkiemkhachhang.Margin = new Padding(5);
            txttimkiemkhachhang.Name = "txttimkiemkhachhang";
            txttimkiemkhachhang.PlaceholderText = "Tìm kiếm";
            txttimkiemkhachhang.Size = new Size(594, 56);
            txttimkiemkhachhang.TabIndex = 67;
            txttimkiemkhachhang.TextChanged += txttimkiemkhachhang_TextChanged_1;
            // 
            // dgvkhachhang
            // 
            dgvkhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvkhachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvkhachhang.Dock = DockStyle.Fill;
            dgvkhachhang.Location = new Point(5, 42);
            dgvkhachhang.Margin = new Padding(5);
            dgvkhachhang.Name = "dgvkhachhang";
            dgvkhachhang.RowHeadersWidth = 51;
            dgvkhachhang.Size = new Size(2554, 813);
            dgvkhachhang.TabIndex = 0;
            dgvkhachhang.CellContentClick += dgvkhachhang_CellContentClick;
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(2207, 474);
            btn_Reset.Margin = new Padding(5);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(119, 98);
            btn_Reset.TabIndex = 80;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_Load
            // 
            btn_Load.Location = new Point(2204, 336);
            btn_Load.Margin = new Padding(5);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(122, 104);
            btn_Load.TabIndex = 79;
            btn_Load.Text = "Load";
            btn_Load.UseVisualStyleBackColor = true;
            btn_Load.Click += btn_Load_Click_1;
            // 
            // rbtNu
            // 
            rbtNu.AutoSize = true;
            rbtNu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtNu.Location = new Point(1817, 402);
            rbtNu.Margin = new Padding(5);
            rbtNu.Name = "rbtNu";
            rbtNu.Size = new Size(103, 54);
            rbtNu.TabIndex = 78;
            rbtNu.TabStop = true;
            rbtNu.Text = "Nữ";
            rbtNu.UseVisualStyleBackColor = true;
            // 
            // rbtNam
            // 
            rbtNam.AutoSize = true;
            rbtNam.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtNam.Location = new Point(1471, 405);
            rbtNam.Margin = new Padding(5);
            rbtNam.Name = "rbtNam";
            rbtNam.Size = new Size(132, 54);
            rbtNam.TabIndex = 77;
            rbtNam.TabStop = true;
            rbtNam.Text = "Nam";
            rbtNam.UseVisualStyleBackColor = true;
            // 
            // lbtrangthaii
            // 
            lbtrangthaii.AutoSize = true;
            lbtrangthaii.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbtrangthaii.Location = new Point(1162, 408);
            lbtrangthaii.Margin = new Padding(5, 0, 5, 0);
            lbtrangthaii.Name = "lbtrangthaii";
            lbtrangthaii.Size = new Size(161, 50);
            lbtrangthaii.TabIndex = 76;
            lbtrangthaii.Text = "Giới tính";
            // 
            // btn_suaKH
            // 
            btn_suaKH.BackgroundImage = (Image)resources.GetObject("btn_suaKH.BackgroundImage");
            btn_suaKH.BackgroundImageLayout = ImageLayout.Stretch;
            btn_suaKH.Location = new Point(2204, 181);
            btn_suaKH.Margin = new Padding(5, 6, 5, 6);
            btn_suaKH.Name = "btn_suaKH";
            btn_suaKH.Size = new Size(115, 107);
            btn_suaKH.TabIndex = 66;
            btn_suaKH.UseVisualStyleBackColor = true;
            btn_suaKH.Click += btn_suaKH_Click_1;
            // 
            // btn_themKH
            // 
            btn_themKH.BackgroundImage = (Image)resources.GetObject("btn_themKH.BackgroundImage");
            btn_themKH.BackgroundImageLayout = ImageLayout.Stretch;
            btn_themKH.Location = new Point(2204, 48);
            btn_themKH.Margin = new Padding(5, 6, 5, 6);
            btn_themKH.Name = "btn_themKH";
            btn_themKH.Size = new Size(115, 96);
            btn_themKH.TabIndex = 65;
            btn_themKH.UseVisualStyleBackColor = true;
            btn_themKH.Click += btn_themKH_Click_1;
            // 
            // lbdiachi
            // 
            lbdiachi.AutoSize = true;
            lbdiachi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbdiachi.Location = new Point(1162, 247);
            lbdiachi.Margin = new Padding(5, 0, 5, 0);
            lbdiachi.Name = "lbdiachi";
            lbdiachi.Size = new Size(133, 50);
            lbdiachi.TabIndex = 64;
            lbdiachi.Text = "Địa chỉ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvkhachhang);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 91);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(2564, 860);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin khách hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 608);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(2564, 951);
            panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Thistle;
            groupBox2.Controls.Add(txttimkiemkhachhang);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(2564, 91);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // txtdiachi
            // 
            txtdiachi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtdiachi.Location = new Point(1372, 238);
            txtdiachi.Margin = new Padding(5);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(594, 56);
            txtdiachi.TabIndex = 63;
            // 
            // lbsdt
            // 
            lbsdt.AutoSize = true;
            lbsdt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbsdt.Location = new Point(1162, 92);
            lbsdt.Margin = new Padding(5, 0, 5, 0);
            lbsdt.Name = "lbsdt";
            lbsdt.Size = new Size(87, 50);
            lbsdt.TabIndex = 62;
            lbsdt.Text = "SĐT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(152, 240);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 50);
            label2.TabIndex = 60;
            label2.Text = "Tên KH";
            // 
            // txttenkh
            // 
            txttenkh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttenkh.Location = new Point(361, 232);
            txttenkh.Margin = new Padding(5);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(597, 56);
            txttenkh.TabIndex = 59;
            // 
            // lbmakh
            // 
            lbmakh.AutoSize = true;
            lbmakh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbmakh.Location = new Point(152, 92);
            lbmakh.Margin = new Padding(5, 0, 5, 0);
            lbmakh.Name = "lbmakh";
            lbmakh.Size = new Size(131, 50);
            lbmakh.TabIndex = 58;
            lbmakh.Text = "Mã KH";
            // 
            // txtmakh
            // 
            txtmakh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtmakh.Location = new Point(361, 83);
            txtmakh.Margin = new Padding(5);
            txtmakh.Name = "txtmakh";
            txtmakh.Size = new Size(597, 56);
            txtmakh.TabIndex = 57;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Thistle;
            groupBox1.Controls.Add(btn_Reset);
            groupBox1.Controls.Add(btn_Load);
            groupBox1.Controls.Add(rbtNu);
            groupBox1.Controls.Add(rbtNam);
            groupBox1.Controls.Add(lbtrangthaii);
            groupBox1.Controls.Add(btn_suaKH);
            groupBox1.Controls.Add(btn_themKH);
            groupBox1.Controls.Add(lbdiachi);
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(lbsdt);
            groupBox1.Controls.Add(txtsdt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txttenkh);
            groupBox1.Controls.Add(lbmakh);
            groupBox1.Controls.Add(txtmakh);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(2564, 603);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Khách hàng";
            // 
            // txtsdt
            // 
            txtsdt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtsdt.Location = new Point(1372, 83);
            txtsdt.Margin = new Padding(5);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(594, 56);
            txtsdt.TabIndex = 61;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2564, 608);
            panel1.TabIndex = 2;
            // 
            // Form_QuanLyKhachHang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2564, 1559);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form_QuanLyKhachHang";
            Text = "Form_QuanLyKhachHang";
            Load += Form_QuanLyKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvkhachhang).EndInit();
            groupBox3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txttimkiemkhachhang;
        private DataGridView dgvkhachhang;
        private Button btn_Reset;
        private Button btn_Load;
        private RadioButton rbtNu;
        private RadioButton rbtNam;
        private Label lbtrangthaii;
        private Button btn_suaKH;
        private Button btn_themKH;
        private Label lbdiachi;
        private GroupBox groupBox3;
        private Panel panel2;
        private GroupBox groupBox2;
        private TextBox txtdiachi;
        private Label lbsdt;
        private Label label2;
        private TextBox txttenkh;
        private Label lbmakh;
        private TextBox txtmakh;
        private GroupBox groupBox1;
        private TextBox txtsdt;
        private Panel panel1;
    }
}