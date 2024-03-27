namespace DuAn1_Coffe.PRL.Forms
{
    partial class Form_QuanLyNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyNV));
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            dgvnhanvien = new DataGridView();
            groupBox2 = new GroupBox();
            cbolocDU = new ComboBox();
            txttimkiem = new TextBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            rbtnghilam = new RadioButton();
            rbtdanglam = new RadioButton();
            label4 = new Label();
            btn_Reset = new Button();
            groupBox7 = new GroupBox();
            rdonu = new RadioButton();
            rdoNam = new RadioButton();
            label9 = new Label();
            groupBox6 = new GroupBox();
            rdoquanly = new RadioButton();
            rdoNhanvien = new RadioButton();
            label10 = new Label();
            groupBox3 = new GroupBox();
            btn_anh = new Button();
            pbhinhanh = new PictureBox();
            btn_LoadDGV = new Button();
            btn_suaNV = new Button();
            btn_themNV = new Button();
            dtpNgayvaolam = new DateTimePicker();
            label1 = new Label();
            lbmk = new Label();
            txtmatkhau = new TextBox();
            lbtentk = new Label();
            txttentk = new TextBox();
            lbcccd = new Label();
            txtCccd = new TextBox();
            lbdiachi = new Label();
            txtdiachi = new TextBox();
            label3 = new Label();
            txtSDT = new TextBox();
            label2 = new Label();
            txttenNV = new TextBox();
            lbmanv = new Label();
            txtmanv = new TextBox();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvnhanvien).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbhinhanh).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 714);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(2564, 845);
            panel2.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvnhanvien);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(0, 86);
            groupBox4.Margin = new Padding(5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(5);
            groupBox4.Size = new Size(2564, 759);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin nhân viên";
            // 
            // dgvnhanvien
            // 
            dgvnhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvnhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvnhanvien.Dock = DockStyle.Fill;
            dgvnhanvien.Location = new Point(5, 42);
            dgvnhanvien.Margin = new Padding(5);
            dgvnhanvien.Name = "dgvnhanvien";
            dgvnhanvien.RowHeadersWidth = 51;
            dgvnhanvien.Size = new Size(2554, 712);
            dgvnhanvien.TabIndex = 0;
            dgvnhanvien.CellContentClick += dgvnhanvien_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.PowderBlue;
            groupBox2.Controls.Add(cbolocDU);
            groupBox2.Controls.Add(txttimkiem);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(2564, 86);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // cbolocDU
            // 
            cbolocDU.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbolocDU.FormattingEnabled = true;
            cbolocDU.Items.AddRange(new object[] { "Nhân Viên", "Quản Lý" });
            cbolocDU.Location = new Point(2207, 27);
            cbolocDU.Margin = new Padding(5);
            cbolocDU.Name = "cbolocDU";
            cbolocDU.Size = new Size(329, 45);
            cbolocDU.TabIndex = 107;
            cbolocDU.Text = "Lọc";
            cbolocDU.SelectedIndexChanged += cbolocDU_SelectedIndexChanged;
            // 
            // txttimkiem
            // 
            txttimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttimkiem.Location = new Point(288, 22);
            txttimkiem.Margin = new Padding(5);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.PlaceholderText = "Tìm kiếm";
            txttimkiem.Size = new Size(620, 50);
            txttimkiem.TabIndex = 84;
            txttimkiem.TextChanged += txttimkiem_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2564, 714);
            panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(rbtnghilam);
            groupBox1.Controls.Add(rbtdanglam);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btn_Reset);
            groupBox1.Controls.Add(groupBox7);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(btn_LoadDGV);
            groupBox1.Controls.Add(btn_suaNV);
            groupBox1.Controls.Add(btn_themNV);
            groupBox1.Controls.Add(dtpNgayvaolam);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbmk);
            groupBox1.Controls.Add(txtmatkhau);
            groupBox1.Controls.Add(lbtentk);
            groupBox1.Controls.Add(txttentk);
            groupBox1.Controls.Add(lbcccd);
            groupBox1.Controls.Add(txtCccd);
            groupBox1.Controls.Add(lbdiachi);
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txttenNV);
            groupBox1.Controls.Add(lbmanv);
            groupBox1.Controls.Add(txtmanv);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(2564, 714);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhân Viên";
            // 
            // rbtnghilam
            // 
            rbtnghilam.AutoSize = true;
            rbtnghilam.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnghilam.Location = new Point(1653, 599);
            rbtnghilam.Margin = new Padding(5);
            rbtnghilam.Name = "rbtnghilam";
            rbtnghilam.Size = new Size(194, 45);
            rbtnghilam.TabIndex = 96;
            rbtnghilam.TabStop = true;
            rbtnghilam.Text = "Nghỉ Làm";
            rbtnghilam.UseVisualStyleBackColor = true;
            // 
            // rbtdanglam
            // 
            rbtdanglam.AutoSize = true;
            rbtdanglam.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            rbtdanglam.Location = new Point(1242, 599);
            rbtdanglam.Margin = new Padding(5);
            rbtdanglam.Name = "rbtdanglam";
            rbtdanglam.Size = new Size(199, 45);
            rbtdanglam.TabIndex = 95;
            rbtdanglam.TabStop = true;
            rbtdanglam.Text = "Đang Làm";
            rbtdanglam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(933, 604);
            label4.Name = "label4";
            label4.Size = new Size(186, 42);
            label4.TabIndex = 94;
            label4.Text = "Trạng thái :";
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(2361, 390);
            btn_Reset.Margin = new Padding(5);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(115, 85);
            btn_Reset.TabIndex = 93;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(rdonu);
            groupBox7.Controls.Add(rdoNam);
            groupBox7.Controls.Add(label9);
            groupBox7.Location = new Point(10, 554);
            groupBox7.Margin = new Padding(5);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(5);
            groupBox7.Size = new Size(840, 131);
            groupBox7.TabIndex = 91;
            groupBox7.TabStop = false;
            // 
            // rdonu
            // 
            rdonu.AutoSize = true;
            rdonu.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdonu.Location = new Point(654, 50);
            rdonu.Name = "rdonu";
            rdonu.Size = new Size(96, 46);
            rdonu.TabIndex = 92;
            rdonu.TabStop = true;
            rdonu.Text = "Nữ";
            rdonu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdoNam.Location = new Point(221, 50);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(121, 46);
            rdoNam.TabIndex = 91;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(10, 50);
            label9.Name = "label9";
            label9.Size = new Size(178, 42);
            label9.TabIndex = 90;
            label9.Text = "Giới Tính :";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rdoquanly);
            groupBox6.Controls.Add(rdoNhanvien);
            groupBox6.Controls.Add(label10);
            groupBox6.Location = new Point(916, 46);
            groupBox6.Margin = new Padding(5);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(5);
            groupBox6.Size = new Size(949, 126);
            groupBox6.TabIndex = 91;
            groupBox6.TabStop = false;
            // 
            // rdoquanly
            // 
            rdoquanly.AutoSize = true;
            rdoquanly.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdoquanly.Location = new Point(750, 44);
            rdoquanly.Name = "rdoquanly";
            rdoquanly.Size = new Size(178, 46);
            rdoquanly.TabIndex = 89;
            rdoquanly.TabStop = true;
            rdoquanly.Text = "Quản Lý";
            rdoquanly.UseVisualStyleBackColor = true;
            // 
            // rdoNhanvien
            // 
            rdoNhanvien.AutoSize = true;
            rdoNhanvien.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdoNhanvien.Location = new Point(325, 48);
            rdoNhanvien.Name = "rdoNhanvien";
            rdoNhanvien.Size = new Size(207, 46);
            rdoNhanvien.TabIndex = 88;
            rdoNhanvien.TabStop = true;
            rdoNhanvien.Text = "Nhân Viên";
            rdoNhanvien.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(17, 48);
            label10.Name = "label10";
            label10.Size = new Size(144, 42);
            label10.TabIndex = 87;
            label10.Text = "Vai Trò :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_anh);
            groupBox3.Controls.Add(pbhinhanh);
            groupBox3.Location = new Point(1927, 122);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(344, 474);
            groupBox3.TabIndex = 83;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hình ảnh";
            // 
            // btn_anh
            // 
            btn_anh.BackColor = Color.DarkOrange;
            btn_anh.Location = new Point(102, 414);
            btn_anh.Margin = new Padding(5);
            btn_anh.Name = "btn_anh";
            btn_anh.Size = new Size(153, 59);
            btn_anh.TabIndex = 84;
            btn_anh.Text = "Ảnh";
            btn_anh.UseVisualStyleBackColor = false;
            btn_anh.Click += btn_anh_Click;
            // 
            // pbhinhanh
            // 
            pbhinhanh.BackColor = SystemColors.ActiveCaptionText;
            pbhinhanh.Location = new Point(49, 54);
            pbhinhanh.Margin = new Padding(5);
            pbhinhanh.Name = "pbhinhanh";
            pbhinhanh.Size = new Size(258, 350);
            pbhinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbhinhanh.TabIndex = 82;
            pbhinhanh.TabStop = false;
            // 
            // btn_LoadDGV
            // 
            btn_LoadDGV.BackColor = SystemColors.ControlLightLight;
            btn_LoadDGV.BackgroundImage = (Image)resources.GetObject("btn_LoadDGV.BackgroundImage");
            btn_LoadDGV.BackgroundImageLayout = ImageLayout.Stretch;
            btn_LoadDGV.Location = new Point(2361, 525);
            btn_LoadDGV.Margin = new Padding(5, 6, 5, 6);
            btn_LoadDGV.Name = "btn_LoadDGV";
            btn_LoadDGV.Size = new Size(115, 94);
            btn_LoadDGV.TabIndex = 79;
            btn_LoadDGV.UseVisualStyleBackColor = false;
            btn_LoadDGV.Click += btn_LoadDGV_Click;
            // 
            // btn_suaNV
            // 
            btn_suaNV.BackgroundImage = (Image)resources.GetObject("btn_suaNV.BackgroundImage");
            btn_suaNV.BackgroundImageLayout = ImageLayout.Stretch;
            btn_suaNV.Location = new Point(2361, 246);
            btn_suaNV.Margin = new Padding(5, 6, 5, 6);
            btn_suaNV.Name = "btn_suaNV";
            btn_suaNV.Size = new Size(115, 94);
            btn_suaNV.TabIndex = 78;
            btn_suaNV.UseVisualStyleBackColor = true;
            btn_suaNV.Click += btn_suaNV_Click;
            // 
            // btn_themNV
            // 
            btn_themNV.BackgroundImage = (Image)resources.GetObject("btn_themNV.BackgroundImage");
            btn_themNV.BackgroundImageLayout = ImageLayout.Stretch;
            btn_themNV.Location = new Point(2361, 117);
            btn_themNV.Margin = new Padding(5, 6, 5, 6);
            btn_themNV.Name = "btn_themNV";
            btn_themNV.Size = new Size(115, 93);
            btn_themNV.TabIndex = 77;
            btn_themNV.UseVisualStyleBackColor = true;
            btn_themNV.Click += btn_themNV_Click;
            // 
            // dtpNgayvaolam
            // 
            dtpNgayvaolam.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayvaolam.CustomFormat = "dd/MM/yyyy";
            dtpNgayvaolam.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayvaolam.Format = DateTimePickerFormat.Custom;
            dtpNgayvaolam.Location = new Point(1240, 442);
            dtpNgayvaolam.Margin = new Padding(5);
            dtpNgayvaolam.Name = "dtpNgayvaolam";
            dtpNgayvaolam.Size = new Size(620, 56);
            dtpNgayvaolam.TabIndex = 72;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(918, 455);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 50);
            label1.TabIndex = 71;
            label1.Text = "Ngày vào làm";
            // 
            // lbmk
            // 
            lbmk.AutoSize = true;
            lbmk.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbmk.Location = new Point(918, 312);
            lbmk.Margin = new Padding(5, 0, 5, 0);
            lbmk.Name = "lbmk";
            lbmk.Size = new Size(176, 50);
            lbmk.TabIndex = 70;
            lbmk.Text = "Mật khẩu";
            // 
            // txtmatkhau
            // 
            txtmatkhau.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtmatkhau.Location = new Point(1240, 306);
            txtmatkhau.Margin = new Padding(5);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(620, 56);
            txtmatkhau.TabIndex = 69;
            // 
            // lbtentk
            // 
            lbtentk.AutoSize = true;
            lbtentk.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbtentk.Location = new Point(918, 189);
            lbtentk.Margin = new Padding(5, 0, 5, 0);
            lbtentk.Name = "lbtentk";
            lbtentk.Size = new Size(176, 50);
            lbtentk.TabIndex = 68;
            lbtentk.Text = "Tài khoản";
            // 
            // txttentk
            // 
            txttentk.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttentk.Location = new Point(1240, 182);
            txttentk.Margin = new Padding(5);
            txttentk.Name = "txttentk";
            txttentk.Size = new Size(620, 56);
            txttentk.TabIndex = 67;
            // 
            // lbcccd
            // 
            lbcccd.AutoSize = true;
            lbcccd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbcccd.Location = new Point(20, 480);
            lbcccd.Margin = new Padding(5, 0, 5, 0);
            lbcccd.Name = "lbcccd";
            lbcccd.Size = new Size(157, 45);
            lbcccd.TabIndex = 66;
            lbcccd.Text = "số CMND";
            // 
            // txtCccd
            // 
            txtCccd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCccd.Location = new Point(229, 472);
            txtCccd.Margin = new Padding(5);
            txtCccd.Name = "txtCccd";
            txtCccd.Size = new Size(618, 50);
            txtCccd.TabIndex = 65;
            // 
            // lbdiachi
            // 
            lbdiachi.AutoSize = true;
            lbdiachi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbdiachi.Location = new Point(20, 372);
            lbdiachi.Margin = new Padding(5, 0, 5, 0);
            lbdiachi.Name = "lbdiachi";
            lbdiachi.Size = new Size(116, 45);
            lbdiachi.TabIndex = 64;
            lbdiachi.Text = "Địa chỉ";
            // 
            // txtdiachi
            // 
            txtdiachi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdiachi.Location = new Point(229, 363);
            txtdiachi.Margin = new Padding(5);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(618, 50);
            txtdiachi.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 266);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 45);
            label3.TabIndex = 62;
            label3.Text = "SĐT";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDT.Location = new Point(229, 258);
            txtSDT.Margin = new Padding(5);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(618, 50);
            txtSDT.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 167);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 45);
            label2.TabIndex = 60;
            label2.Text = "Tên NV";
            // 
            // txttenNV
            // 
            txttenNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttenNV.Location = new Point(229, 158);
            txttenNV.Margin = new Padding(5);
            txttenNV.Name = "txttenNV";
            txttenNV.Size = new Size(618, 50);
            txttenNV.TabIndex = 59;
            // 
            // lbmanv
            // 
            lbmanv.AutoSize = true;
            lbmanv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbmanv.Location = new Point(20, 69);
            lbmanv.Margin = new Padding(5, 0, 5, 0);
            lbmanv.Name = "lbmanv";
            lbmanv.Size = new Size(118, 45);
            lbmanv.TabIndex = 57;
            lbmanv.Text = "Mã NV";
            // 
            // txtmanv
            // 
            txtmanv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtmanv.Location = new Point(229, 61);
            txtmanv.Margin = new Padding(5);
            txtmanv.Name = "txtmanv";
            txtmanv.Size = new Size(618, 50);
            txtmanv.TabIndex = 56;
            // 
            // Form_QuanLyNV
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2564, 1559);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form_QuanLyNV";
            Text = "Form_QuanLyNV";
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvnhanvien).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbhinhanh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private GroupBox groupBox4;
        private DataGridView dgvnhanvien;
        private GroupBox groupBox2;
        private ComboBox cbolocDU;
        private TextBox txttimkiem;
        private Panel panel1;
        private GroupBox groupBox1;
        private RadioButton rbtnghilam;
        private RadioButton rbtdanglam;
        private Label label4;
        private Button btn_Reset;
        private GroupBox groupBox7;
        private RadioButton rdonu;
        private RadioButton rdoNam;
        private Label label9;
        private GroupBox groupBox6;
        private RadioButton rdoquanly;
        private RadioButton rdoNhanvien;
        private Label label10;
        private GroupBox groupBox3;
        private Button btn_anh;
        private PictureBox pbhinhanh;
        private Button btn_LoadDGV;
        private Button btn_suaNV;
        private Button btn_themNV;
        private DateTimePicker dtpNgayvaolam;
        private Label label1;
        private Label lbmk;
        private TextBox txtmatkhau;
        private Label lbtentk;
        private TextBox txttentk;
        private Label lbcccd;
        private TextBox txtCccd;
        private Label lbdiachi;
        private TextBox txtdiachi;
        private Label label3;
        private TextBox txtSDT;
        private Label label2;
        private TextBox txttenNV;
        private Label lbmanv;
        private TextBox txtmanv;
    }
}