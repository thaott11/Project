namespace DuAn1_Coffe.PRL.Forms
{
    partial class Form_Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            panel5 = new Panel();
            groupBox6 = new GroupBox();
            dgvhoadonct = new DataGridView();
            panel4 = new Panel();
            groupBox5 = new GroupBox();
            dgvsanpham = new DataGridView();
            panel3 = new Panel();
            groupBox4 = new GroupBox();
            btn_tatcam = new Button();
            btn_batcam = new Button();
            btn_Xoasp = new Button();
            txttimkiem = new TextBox();
            panel2 = new Panel();
            groupBox7 = new GroupBox();
            txtIdHoaDon = new TextBox();
            cbbnguoitao = new ComboBox();
            cbbgiamgia = new ComboBox();
            label10 = new Label();
            label8 = new Label();
            cbbnhanvien = new ComboBox();
            txtGhiChu = new TextBox();
            btn_huydon = new Button();
            btn_suaKH = new Button();
            btn_thanhtoan = new Button();
            btn_taohoadon = new Button();
            label6 = new Label();
            dtpNgaytao = new DateTimePicker();
            label5 = new Label();
            txttienthua = new TextBox();
            label4 = new Label();
            txttienkhachtra = new TextBox();
            label3 = new Label();
            txtsaugiamgia = new TextBox();
            txttongtien = new TextBox();
            label7 = new Label();
            lbten = new Label();
            txtmahoadon = new TextBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            dgvdanhsachhoadon = new DataGridView();
            groupBox2 = new GroupBox();
            cbo_Cam = new ComboBox();
            ptb_Image = new PictureBox();
            groupBox3 = new GroupBox();
            cboid = new ComboBox();
            btn_thaydoi = new Button();
            btn_chon = new Button();
            txtdiachi = new TextBox();
            txtSDT = new TextBox();
            label12 = new Label();
            txttenKH = new TextBox();
            label11 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoadonct).BeginInit();
            panel4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsanpham).BeginInit();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel2.SuspendLayout();
            groupBox7.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdanhsachhoadon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Image).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSalmon;
            panel5.Controls.Add(groupBox6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 639);
            panel5.Name = "panel5";
            panel5.Size = new Size(1033, 330);
            panel5.TabIndex = 9;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgvhoadonct);
            groupBox6.Dock = DockStyle.Left;
            groupBox6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.Location = new Point(0, 0);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1023, 330);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "Hóa đơn chi tiết";
            // 
            // dgvhoadonct
            // 
            dgvhoadonct.BackgroundColor = SystemColors.ButtonFace;
            dgvhoadonct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhoadonct.Location = new Point(5, 26);
            dgvhoadonct.Margin = new Padding(2);
            dgvhoadonct.Name = "dgvhoadonct";
            dgvhoadonct.RowHeadersWidth = 82;
            dgvhoadonct.RowTemplate.Height = 41;
            dgvhoadonct.Size = new Size(1013, 301);
            dgvhoadonct.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSalmon;
            panel4.Controls.Add(groupBox5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 276);
            panel4.Name = "panel4";
            panel4.Size = new Size(1033, 363);
            panel4.TabIndex = 8;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgvsanpham);
            groupBox5.Dock = DockStyle.Left;
            groupBox5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1026, 363);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách sản phẩm";
            // 
            // dgvsanpham
            // 
            dgvsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsanpham.BackgroundColor = SystemColors.ButtonFace;
            dgvsanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsanpham.Dock = DockStyle.Fill;
            dgvsanpham.Location = new Point(3, 26);
            dgvsanpham.Name = "dgvsanpham";
            dgvsanpham.RowHeadersWidth = 51;
            dgvsanpham.Size = new Size(1020, 334);
            dgvsanpham.TabIndex = 0;
            dgvsanpham.CellContentClick += dgvsanpham_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSalmon;
            panel3.Controls.Add(groupBox4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 228);
            panel3.Name = "panel3";
            panel3.Size = new Size(1033, 48);
            panel3.TabIndex = 7;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.DarkSalmon;
            groupBox4.Controls.Add(btn_tatcam);
            groupBox4.Controls.Add(btn_batcam);
            groupBox4.Controls.Add(btn_Xoasp);
            groupBox4.Controls.Add(txttimkiem);
            groupBox4.Dock = DockStyle.Left;
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1026, 48);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // btn_tatcam
            // 
            btn_tatcam.Location = new Point(937, 14);
            btn_tatcam.Name = "btn_tatcam";
            btn_tatcam.Size = new Size(86, 29);
            btn_tatcam.TabIndex = 14;
            btn_tatcam.Text = "Tắt cam";
            btn_tatcam.UseVisualStyleBackColor = true;
            btn_tatcam.Click += btn_tatcam_Click;
            // 
            // btn_batcam
            // 
            btn_batcam.Location = new Point(833, 14);
            btn_batcam.Name = "btn_batcam";
            btn_batcam.Size = new Size(86, 29);
            btn_batcam.TabIndex = 13;
            btn_batcam.Text = "Bật cam";
            btn_batcam.UseVisualStyleBackColor = true;
            btn_batcam.Click += btn_batcam_Click;
            // 
            // btn_Xoasp
            // 
            btn_Xoasp.Location = new Point(423, 16);
            btn_Xoasp.Name = "btn_Xoasp";
            btn_Xoasp.Size = new Size(70, 29);
            btn_Xoasp.TabIndex = 12;
            btn_Xoasp.Text = "Xóa";
            btn_Xoasp.UseVisualStyleBackColor = true;
            btn_Xoasp.Click += btn_Xoasp_Click;
            // 
            // txttimkiem
            // 
            txttimkiem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txttimkiem.Location = new Point(83, 15);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.PlaceholderText = "Tìm kiếm";
            txttimkiem.Size = new Size(184, 28);
            txttimkiem.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox7);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1033, 228);
            panel2.Name = "panel2";
            panel2.Size = new Size(520, 741);
            panel2.TabIndex = 6;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = SystemColors.ActiveCaption;
            groupBox7.Controls.Add(txtIdHoaDon);
            groupBox7.Controls.Add(cbbnguoitao);
            groupBox7.Controls.Add(cbbgiamgia);
            groupBox7.Controls.Add(label10);
            groupBox7.Controls.Add(label8);
            groupBox7.Controls.Add(cbbnhanvien);
            groupBox7.Controls.Add(txtGhiChu);
            groupBox7.Controls.Add(btn_huydon);
            groupBox7.Controls.Add(btn_suaKH);
            groupBox7.Controls.Add(btn_thanhtoan);
            groupBox7.Controls.Add(btn_taohoadon);
            groupBox7.Controls.Add(label6);
            groupBox7.Controls.Add(dtpNgaytao);
            groupBox7.Controls.Add(label5);
            groupBox7.Controls.Add(txttienthua);
            groupBox7.Controls.Add(label4);
            groupBox7.Controls.Add(txttienkhachtra);
            groupBox7.Controls.Add(label3);
            groupBox7.Controls.Add(txtsaugiamgia);
            groupBox7.Controls.Add(txttongtien);
            groupBox7.Controls.Add(label7);
            groupBox7.Controls.Add(lbten);
            groupBox7.Controls.Add(txtmahoadon);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox7.Location = new Point(0, 0);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(520, 741);
            groupBox7.TabIndex = 0;
            groupBox7.TabStop = false;
            groupBox7.Text = "Thông tin hóa đơn";
            // 
            // txtIdHoaDon
            // 
            txtIdHoaDon.Location = new Point(419, 15);
            txtIdHoaDon.Margin = new Padding(2);
            txtIdHoaDon.Name = "txtIdHoaDon";
            txtIdHoaDon.Size = new Size(44, 30);
            txtIdHoaDon.TabIndex = 11;
            txtIdHoaDon.Visible = false;
            // 
            // cbbnguoitao
            // 
            cbbnguoitao.FormattingEnabled = true;
            cbbnguoitao.Location = new Point(139, 518);
            cbbnguoitao.Margin = new Padding(2);
            cbbnguoitao.Name = "cbbnguoitao";
            cbbnguoitao.Size = new Size(366, 31);
            cbbnguoitao.TabIndex = 82;
            cbbnguoitao.Visible = false;
            // 
            // cbbgiamgia
            // 
            cbbgiamgia.FormattingEnabled = true;
            cbbgiamgia.Location = new Point(139, 146);
            cbbgiamgia.Margin = new Padding(2);
            cbbgiamgia.Name = "cbbgiamgia";
            cbbgiamgia.Size = new Size(369, 31);
            cbbgiamgia.TabIndex = 81;
            cbbgiamgia.SelectedIndexChanged += cbbgiamgia_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(5, 196);
            label10.Name = "label10";
            label10.Size = new Size(109, 23);
            label10.TabIndex = 80;
            label10.Text = "Sau Gảm Giá";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(27, 149);
            label8.Name = "label8";
            label8.Size = new Size(80, 23);
            label8.TabIndex = 80;
            label8.Text = "Giá Giảm";
            // 
            // cbbnhanvien
            // 
            cbbnhanvien.FormattingEnabled = true;
            cbbnhanvien.Location = new Point(459, 716);
            cbbnhanvien.Margin = new Padding(2);
            cbbnhanvien.Name = "cbbnhanvien";
            cbbnhanvien.Size = new Size(61, 31);
            cbbnhanvien.TabIndex = 79;
            cbbnhanvien.Visible = false;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGhiChu.Location = new Point(140, 423);
            txtGhiChu.Margin = new Padding(2);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(365, 76);
            txtGhiChu.TabIndex = 77;
            // 
            // btn_huydon
            // 
            btn_huydon.Location = new Point(300, 629);
            btn_huydon.Name = "btn_huydon";
            btn_huydon.Size = new Size(113, 51);
            btn_huydon.TabIndex = 76;
            btn_huydon.Text = "Hủy đơn";
            btn_huydon.UseVisualStyleBackColor = true;
            btn_huydon.Click += btn_huydon_Click;
            // 
            // btn_suaKH
            // 
            btn_suaKH.BackgroundImage = (Image)resources.GetObject("btn_suaKH.BackgroundImage");
            btn_suaKH.BackgroundImageLayout = ImageLayout.Stretch;
            btn_suaKH.Location = new Point(455, 629);
            btn_suaKH.Margin = new Padding(3, 4, 3, 4);
            btn_suaKH.Name = "btn_suaKH";
            btn_suaKH.Size = new Size(65, 51);
            btn_suaKH.TabIndex = 75;
            btn_suaKH.UseVisualStyleBackColor = true;
            btn_suaKH.Click += btn_suaKH_Click;
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.Location = new Point(165, 629);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(113, 51);
            btn_thanhtoan.TabIndex = 74;
            btn_thanhtoan.Text = "Thanh toán";
            btn_thanhtoan.UseVisualStyleBackColor = true;
            btn_thanhtoan.Click += btn_thanhtoan_Click;
            // 
            // btn_taohoadon
            // 
            btn_taohoadon.Location = new Point(23, 629);
            btn_taohoadon.Name = "btn_taohoadon";
            btn_taohoadon.Size = new Size(102, 51);
            btn_taohoadon.TabIndex = 73;
            btn_taohoadon.Text = "Tạo đơn";
            btn_taohoadon.UseVisualStyleBackColor = true;
            btn_taohoadon.Click += btn_taohoadon_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 452);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 71;
            label6.Text = "Ghi chú";
            // 
            // dtpNgaytao
            // 
            dtpNgaytao.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaytao.CustomFormat = "dd/MM/yyyy";
            dtpNgaytao.Format = DateTimePickerFormat.Custom;
            dtpNgaytao.Location = new Point(139, 370);
            dtpNgaytao.Name = "dtpNgaytao";
            dtpNgaytao.Size = new Size(369, 30);
            dtpNgaytao.TabIndex = 70;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 371);
            label5.Name = "label5";
            label5.Size = new Size(50, 23);
            label5.TabIndex = 69;
            label5.Text = "Ngày";
            // 
            // txttienthua
            // 
            txttienthua.Location = new Point(139, 300);
            txttienthua.Name = "txttienthua";
            txttienthua.Size = new Size(369, 30);
            txttienthua.TabIndex = 68;
            txttienthua.TextChanged += txttienthua_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 304);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 67;
            label4.Text = "Tiền Thừa";
            // 
            // txttienkhachtra
            // 
            txttienkhachtra.Location = new Point(140, 243);
            txttienkhachtra.Name = "txttienkhachtra";
            txttienkhachtra.Size = new Size(369, 30);
            txttienkhachtra.TabIndex = 66;
            txttienkhachtra.TextChanged += txttienkhachtra_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 243);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 65;
            label3.Text = "Tiền khách trả";
            // 
            // txtsaugiamgia
            // 
            txtsaugiamgia.Location = new Point(139, 194);
            txtsaugiamgia.Name = "txtsaugiamgia";
            txtsaugiamgia.Size = new Size(369, 30);
            txtsaugiamgia.TabIndex = 64;
            // 
            // txttongtien
            // 
            txttongtien.Location = new Point(139, 101);
            txttongtien.Name = "txttongtien";
            txttongtien.Size = new Size(369, 30);
            txttongtien.TabIndex = 64;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 101);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 63;
            label7.Text = "Tổng tiền";
            // 
            // lbten
            // 
            lbten.AutoSize = true;
            lbten.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbten.Location = new Point(32, 49);
            lbten.Name = "lbten";
            lbten.Size = new Size(63, 23);
            lbten.TabIndex = 60;
            lbten.Text = "Mã HD";
            // 
            // txtmahoadon
            // 
            txtmahoadon.Location = new Point(139, 48);
            txtmahoadon.Name = "txtmahoadon";
            txtmahoadon.Size = new Size(369, 30);
            txtmahoadon.TabIndex = 59;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1553, 228);
            panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSalmon;
            groupBox1.Controls.Add(dgvdanhsachhoadon);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1033, 228);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dgvdanhsachhoadon
            // 
            dgvdanhsachhoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdanhsachhoadon.BackgroundColor = SystemColors.ButtonFace;
            dgvdanhsachhoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdanhsachhoadon.Dock = DockStyle.Left;
            dgvdanhsachhoadon.Location = new Point(3, 23);
            dgvdanhsachhoadon.Name = "dgvdanhsachhoadon";
            dgvdanhsachhoadon.RowHeadersWidth = 51;
            dgvdanhsachhoadon.Size = new Size(811, 202);
            dgvdanhsachhoadon.TabIndex = 2;
            dgvdanhsachhoadon.CellMouseDoubleClick += dgvdanhsachhoadon_CellMouseDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbo_Cam);
            groupBox2.Controls.Add(ptb_Image);
            groupBox2.Location = new Point(820, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(206, 209);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "QR";
            // 
            // cbo_Cam
            // 
            cbo_Cam.FormattingEnabled = true;
            cbo_Cam.Location = new Point(47, 176);
            cbo_Cam.Name = "cbo_Cam";
            cbo_Cam.Size = new Size(113, 27);
            cbo_Cam.TabIndex = 13;
            cbo_Cam.Text = "Chọn came";
            // 
            // ptb_Image
            // 
            ptb_Image.BackColor = SystemColors.ActiveCaptionText;
            ptb_Image.BorderStyle = BorderStyle.FixedSingle;
            ptb_Image.Location = new Point(6, 25);
            ptb_Image.Name = "ptb_Image";
            ptb_Image.Size = new Size(192, 145);
            ptb_Image.SizeMode = PictureBoxSizeMode.Zoom;
            ptb_Image.TabIndex = 0;
            ptb_Image.TabStop = false;
            ptb_Image.Click += ptb_Image_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Khaki;
            groupBox3.Controls.Add(cboid);
            groupBox3.Controls.Add(btn_thaydoi);
            groupBox3.Controls.Add(btn_chon);
            groupBox3.Controls.Add(txtdiachi);
            groupBox3.Controls.Add(txtSDT);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txttenKH);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label1);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(1033, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(520, 228);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin khách hàng";
            // 
            // cboid
            // 
            cboid.FormattingEnabled = true;
            cboid.Location = new Point(480, 8);
            cboid.Margin = new Padding(2);
            cboid.Name = "cboid";
            cboid.Size = new Size(34, 27);
            cboid.TabIndex = 10;
            cboid.Visible = false;
            // 
            // btn_thaydoi
            // 
            btn_thaydoi.Location = new Point(404, 114);
            btn_thaydoi.Name = "btn_thaydoi";
            btn_thaydoi.Size = new Size(82, 36);
            btn_thaydoi.TabIndex = 9;
            btn_thaydoi.Text = "Thay đổi";
            btn_thaydoi.UseVisualStyleBackColor = true;
            // 
            // btn_chon
            // 
            btn_chon.Location = new Point(404, 60);
            btn_chon.Name = "btn_chon";
            btn_chon.Size = new Size(82, 36);
            btn_chon.TabIndex = 8;
            btn_chon.Text = "Chọn ";
            btn_chon.UseVisualStyleBackColor = true;
            // 
            // txtdiachi
            // 
            txtdiachi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtdiachi.Location = new Point(132, 151);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(240, 30);
            txtdiachi.TabIndex = 5;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSDT.Location = new Point(132, 100);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(240, 30);
            txtSDT.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(34, 153);
            label12.Name = "label12";
            label12.Size = new Size(73, 23);
            label12.TabIndex = 4;
            label12.Text = "Địa Chỉ";
            // 
            // txttenKH
            // 
            txttenKH.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txttenKH.Location = new Point(132, 49);
            txttenKH.Name = "txttenKH";
            txttenKH.Size = new Size(240, 30);
            txttenKH.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(59, 105);
            label11.Name = "label11";
            label11.Size = new Size(48, 23);
            label11.TabIndex = 4;
            label11.Text = "SĐT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 51);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 4;
            label1.Text = "Tên KH";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1553, 969);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form_Menu";
            Text = "Form_Menu";
            FormClosing += Form_Menu_FormClosing;
            Load += Form_Menu_Load;
            panel5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvhoadonct).EndInit();
            panel4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvsanpham).EndInit();
            panel3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvdanhsachhoadon).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptb_Image).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private GroupBox groupBox6;
        private Panel panel4;
        private GroupBox groupBox5;
        private DataGridView dgvsanpham;
        private Panel panel3;
        private GroupBox groupBox4;
        private Button btn_tatcam;
        private Button btn_batcam;
        private Button btn_Xoasp;
        private TextBox txttimkiem;
        private Panel panel2;
        private GroupBox groupBox7;
        private Label label8;
        private ComboBox cbbnhanvien;
        private TextBox txtGhiChu;
        private Button btn_huydon;
        private Button btn_suaKH;
        private Button btn_thanhtoan;
        private Button btn_taohoadon;
        private Label label6;
        private DateTimePicker dtpNgaytao;
        private Label label5;
        private TextBox txttienthua;
        private Label label4;
        private TextBox txttienkhachtra;
        private Label label3;
        private TextBox txttongtien;
        private Label label7;
        private Label lbten;
        private TextBox txtmahoadon;
        private Panel panel1;
        private GroupBox groupBox1;
        private DataGridView dgvdanhsachhoadon;
        private GroupBox groupBox2;
        private ComboBox cbo_Cam;
        private PictureBox ptb_Image;
        private GroupBox groupBox3;
        private ComboBox cboid;
        private Button btn_thaydoi;
        private Button btn_chon;
        private TextBox txttenKH;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dgvhoadonct;
        private ComboBox cbbnguoitao;
        private ComboBox cbbgiamgia;
        private Label label10;
        private TextBox txtsaugiamgia;
        private TextBox txtdiachi;
        private TextBox txtSDT;
        private Label label12;
        private Label label11;
        private TextBox txtIdHoaDon;
    }
}