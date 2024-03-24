namespace Du_An_1_Caffe.PRL.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            panel5 = new Panel();
            groupBox6 = new GroupBox();
            dgvsanpham = new DataGridView();
            panel4 = new Panel();
            groupBox5 = new GroupBox();
            dgvgiohang = new DataGridView();
            panel3 = new Panel();
            groupBox4 = new GroupBox();
            btnXoa = new Button();
            comboBox1 = new ComboBox();
            txttimkiem = new TextBox();
            panel2 = new Panel();
            groupBox7 = new GroupBox();
            cbbnhanvien = new ComboBox();
            btn_huydon = new Button();
            btn_suaKH = new Button();
            btn_thanhtoan = new Button();
            btn_taohoadon = new Button();
            label6 = new Label();
            dtpNgaytao = new DateTimePicker();
            label5 = new Label();
            txttienthua = new TextBox();
            label4 = new Label();
            txtTienKhachTra = new TextBox();
            label3 = new Label();
            txttongtien = new TextBox();
            label7 = new Label();
            lbten = new Label();
            txtmahoadon = new TextBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            dgvhoadonchitiet = new DataGridView();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            cbbkhachhang = new ComboBox();
            btn_thaydoi = new Button();
            btn_chon = new Button();
            txtdiachi = new TextBox();
            txtsdt = new TextBox();
            label8 = new Label();
            label2 = new Label();
            txttenKH = new TextBox();
            label1 = new Label();
            txtghichu = new TextBox();
            label9 = new Label();
            panel5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsanpham).BeginInit();
            panel4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvgiohang).BeginInit();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel2.SuspendLayout();
            groupBox7.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoadonchitiet).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(groupBox6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 1023);
            panel5.Margin = new Padding(5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1719, 536);
            panel5.TabIndex = 9;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgvsanpham);
            groupBox6.Dock = DockStyle.Left;
            groupBox6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.Location = new Point(0, 0);
            groupBox6.Margin = new Padding(5);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(5);
            groupBox6.Size = new Size(1662, 536);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "Danh Sách Sản Phẩm ";
            // 
            // dgvsanpham
            // 
            dgvsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsanpham.Dock = DockStyle.Left;
            dgvsanpham.Location = new Point(5, 39);
            dgvsanpham.Margin = new Padding(5);
            dgvsanpham.Name = "dgvsanpham";
            dgvsanpham.RowHeadersWidth = 51;
            dgvsanpham.Size = new Size(1648, 492);
            dgvsanpham.TabIndex = 0;
            dgvsanpham.CellContentClick += dgvsanpham_CellContentClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 442);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1719, 581);
            panel4.TabIndex = 8;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgvgiohang);
            groupBox5.Dock = DockStyle.Left;
            groupBox5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(0, 0);
            groupBox5.Margin = new Padding(5);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(5);
            groupBox5.Size = new Size(1667, 581);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Giỏ hàng";
            // 
            // dgvgiohang
            // 
            dgvgiohang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvgiohang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvgiohang.Dock = DockStyle.Fill;
            dgvgiohang.Location = new Point(5, 42);
            dgvgiohang.Margin = new Padding(5);
            dgvgiohang.Name = "dgvgiohang";
            dgvgiohang.RowHeadersWidth = 51;
            dgvgiohang.Size = new Size(1657, 534);
            dgvgiohang.TabIndex = 0;
            dgvgiohang.CellValueChanged += dgvgiohang_CellValueChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSalmon;
            panel3.Controls.Add(groupBox4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 365);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1719, 77);
            panel3.TabIndex = 7;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.DarkSalmon;
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Controls.Add(txttimkiem);
            groupBox4.Dock = DockStyle.Left;
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(0, 0);
            groupBox4.Margin = new Padding(5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(5);
            groupBox4.Size = new Size(1667, 77);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(671, 26);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(240, 46);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1246, 22);
            comboBox1.Margin = new Padding(5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(347, 44);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "Lọc";
            // 
            // txttimkiem
            // 
            txttimkiem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txttimkiem.Location = new Point(162, 19);
            txttimkiem.Margin = new Padding(5);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.PlaceholderText = "Tìm kiếm";
            txttimkiem.Size = new Size(388, 44);
            txttimkiem.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox7);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1719, 365);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(845, 1194);
            panel2.TabIndex = 6;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = SystemColors.ActiveCaption;
            groupBox7.Controls.Add(txtghichu);
            groupBox7.Controls.Add(cbbnhanvien);
            groupBox7.Controls.Add(btn_huydon);
            groupBox7.Controls.Add(btn_suaKH);
            groupBox7.Controls.Add(btn_thanhtoan);
            groupBox7.Controls.Add(btn_taohoadon);
            groupBox7.Controls.Add(label9);
            groupBox7.Controls.Add(label6);
            groupBox7.Controls.Add(dtpNgaytao);
            groupBox7.Controls.Add(label5);
            groupBox7.Controls.Add(txttienthua);
            groupBox7.Controls.Add(label4);
            groupBox7.Controls.Add(txtTienKhachTra);
            groupBox7.Controls.Add(label3);
            groupBox7.Controls.Add(txttongtien);
            groupBox7.Controls.Add(label7);
            groupBox7.Controls.Add(lbten);
            groupBox7.Controls.Add(txtmahoadon);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox7.Location = new Point(0, 0);
            groupBox7.Margin = new Padding(5);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(5);
            groupBox7.Size = new Size(845, 1194);
            groupBox7.TabIndex = 0;
            groupBox7.TabStop = false;
            groupBox7.Text = "Thông tin hóa đơn";
            // 
            // cbbnhanvien
            // 
            cbbnhanvien.FormattingEnabled = true;
            cbbnhanvien.Location = new Point(237, 618);
            cbbnhanvien.Name = "cbbnhanvien";
            cbbnhanvien.Size = new Size(586, 44);
            cbbnhanvien.TabIndex = 77;
            // 
            // btn_huydon
            // 
            btn_huydon.Location = new Point(490, 893);
            btn_huydon.Margin = new Padding(5);
            btn_huydon.Name = "btn_huydon";
            btn_huydon.Size = new Size(184, 82);
            btn_huydon.TabIndex = 76;
            btn_huydon.Text = "Hủy đơn";
            btn_huydon.UseVisualStyleBackColor = true;
            // 
            // btn_suaKH
            // 
            btn_suaKH.BackgroundImage = (Image)resources.GetObject("btn_suaKH.BackgroundImage");
            btn_suaKH.BackgroundImageLayout = ImageLayout.Stretch;
            btn_suaKH.Location = new Point(717, 893);
            btn_suaKH.Margin = new Padding(5, 6, 5, 6);
            btn_suaKH.Name = "btn_suaKH";
            btn_suaKH.Size = new Size(106, 82);
            btn_suaKH.TabIndex = 75;
            btn_suaKH.UseVisualStyleBackColor = true;
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.Location = new Point(258, 893);
            btn_thanhtoan.Margin = new Padding(5);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(184, 82);
            btn_thanhtoan.TabIndex = 74;
            btn_thanhtoan.Text = "Thanh toán";
            btn_thanhtoan.UseVisualStyleBackColor = true;
            btn_thanhtoan.Click += btn_thanhtoan_Click;
            // 
            // btn_taohoadon
            // 
            btn_taohoadon.Location = new Point(28, 893);
            btn_taohoadon.Margin = new Padding(5);
            btn_taohoadon.Name = "btn_taohoadon";
            btn_taohoadon.Size = new Size(166, 82);
            btn_taohoadon.TabIndex = 73;
            btn_taohoadon.Text = "Tạo đơn";
            btn_taohoadon.UseVisualStyleBackColor = true;
            btn_taohoadon.Click += btn_taohoadon_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(32, 624);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 38);
            label6.TabIndex = 71;
            label6.Text = "Nhân viên";
            // 
            // dtpNgaytao
            // 
            dtpNgaytao.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaytao.CustomFormat = "dd/MM/yyyy";
            dtpNgaytao.Format = DateTimePickerFormat.Custom;
            dtpNgaytao.Location = new Point(226, 494);
            dtpNgaytao.Margin = new Padding(5);
            dtpNgaytao.Name = "dtpNgaytao";
            dtpNgaytao.Size = new Size(597, 44);
            dtpNgaytao.TabIndex = 70;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(34, 496);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 38);
            label5.TabIndex = 69;
            label5.Text = "Ngày";
            // 
            // txttienthua
            // 
            txttienthua.Location = new Point(236, 381);
            txttienthua.Margin = new Padding(5);
            txttienthua.Name = "txttienthua";
            txttienthua.Size = new Size(597, 44);
            txttienthua.TabIndex = 68;
            txttienthua.TextChanged += txttienthua_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 389);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(139, 38);
            label4.TabIndex = 67;
            label4.Text = "Tiền Thừa";
            // 
            // txtTienKhachTra
            // 
            txtTienKhachTra.Location = new Point(226, 270);
            txtTienKhachTra.Margin = new Padding(5);
            txtTienKhachTra.Name = "txtTienKhachTra";
            txtTienKhachTra.Size = new Size(597, 44);
            txtTienKhachTra.TabIndex = 66;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 279);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(192, 38);
            label3.TabIndex = 65;
            label3.Text = "Tiền khách trả";
            // 
            // txttongtien
            // 
            txttongtien.Location = new Point(226, 174);
            txttongtien.Margin = new Padding(5);
            txttongtien.Name = "txttongtien";
            txttongtien.Size = new Size(597, 44);
            txttongtien.TabIndex = 64;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(26, 183);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(135, 38);
            label7.TabIndex = 63;
            label7.Text = "Tổng tiền";
            // 
            // lbten
            // 
            lbten.AutoSize = true;
            lbten.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbten.Location = new Point(26, 85);
            lbten.Margin = new Padding(5, 0, 5, 0);
            lbten.Name = "lbten";
            lbten.Size = new Size(104, 38);
            lbten.TabIndex = 60;
            lbten.Text = "Mã HD";
            // 
            // txtmahoadon
            // 
            txtmahoadon.Location = new Point(226, 77);
            txtmahoadon.Margin = new Padding(5);
            txtmahoadon.Name = "txtmahoadon";
            txtmahoadon.Size = new Size(597, 44);
            txtmahoadon.TabIndex = 59;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2564, 365);
            panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSalmon;
            groupBox1.Controls.Add(dgvhoadonchitiet);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(1719, 365);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa đơn chi tiết";
            // 
            // dgvhoadonchitiet
            // 
            dgvhoadonchitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvhoadonchitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhoadonchitiet.Dock = DockStyle.Left;
            dgvhoadonchitiet.Location = new Point(5, 37);
            dgvhoadonchitiet.Margin = new Padding(5);
            dgvhoadonchitiet.Name = "dgvhoadonchitiet";
            dgvhoadonchitiet.RowHeadersWidth = 51;
            dgvhoadonchitiet.Size = new Size(1318, 323);
            dgvhoadonchitiet.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(1350, 42);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(317, 310);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "QR";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(39, 42);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 232);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Khaki;
            groupBox3.Controls.Add(cbbkhachhang);
            groupBox3.Controls.Add(btn_thaydoi);
            groupBox3.Controls.Add(btn_chon);
            groupBox3.Controls.Add(txtdiachi);
            groupBox3.Controls.Add(txtsdt);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txttenKH);
            groupBox3.Controls.Add(label1);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(1719, 0);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(845, 365);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin khách hàng";
            // 
            // cbbkhachhang
            // 
            cbbkhachhang.FormattingEnabled = true;
            cbbkhachhang.Location = new Point(613, 37);
            cbbkhachhang.Name = "cbbkhachhang";
            cbbkhachhang.Size = new Size(178, 39);
            cbbkhachhang.TabIndex = 10;
            // 
            // btn_thaydoi
            // 
            btn_thaydoi.Location = new Point(658, 194);
            btn_thaydoi.Margin = new Padding(5);
            btn_thaydoi.Name = "btn_thaydoi";
            btn_thaydoi.Size = new Size(133, 58);
            btn_thaydoi.TabIndex = 9;
            btn_thaydoi.Text = "Thay đổi";
            btn_thaydoi.UseVisualStyleBackColor = true;
            // 
            // btn_chon
            // 
            btn_chon.Location = new Point(658, 95);
            btn_chon.Margin = new Padding(5);
            btn_chon.Name = "btn_chon";
            btn_chon.Size = new Size(133, 58);
            btn_chon.TabIndex = 8;
            btn_chon.Text = "Chọn ";
            btn_chon.UseVisualStyleBackColor = true;
            // 
            // txtdiachi
            // 
            txtdiachi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtdiachi.Location = new Point(211, 218);
            txtdiachi.Margin = new Padding(5);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(388, 44);
            txtdiachi.TabIndex = 7;
            // 
            // txtsdt
            // 
            txtsdt.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtsdt.Location = new Point(211, 127);
            txtsdt.Margin = new Padding(5);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(388, 44);
            txtsdt.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(73, 221);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(121, 36);
            label8.TabIndex = 6;
            label8.Text = "Địa Chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(117, 135);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 36);
            label2.TabIndex = 6;
            label2.Text = "SĐT";
            // 
            // txttenKH
            // 
            txttenKH.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txttenKH.Location = new Point(211, 42);
            txttenKH.Margin = new Padding(5);
            txttenKH.Name = "txttenKH";
            txttenKH.Size = new Size(388, 44);
            txttenKH.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 50);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 36);
            label1.TabIndex = 4;
            label1.Text = "Tên KH";
            // 
            // txtghichu
            // 
            txtghichu.Location = new Point(236, 707);
            txtghichu.Name = "txtghichu";
            txtghichu.Size = new Size(587, 44);
            txtghichu.TabIndex = 78;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(26, 713);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(116, 38);
            label9.TabIndex = 71;
            label9.Text = "Ghi Chú";
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2564, 1559);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form_Menu";
            Text = "Form_Menu";
            Load += Form_Menu_Load;
            panel5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvsanpham).EndInit();
            panel4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvgiohang).EndInit();
            panel3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvhoadonchitiet).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private GroupBox groupBox6;
        private DataGridView dgvsanpham;
        private Panel panel4;
        private GroupBox groupBox5;
        private DataGridView dgvgiohang;
        private Panel panel3;
        private GroupBox groupBox4;
        private Button btnXoa;
        private ComboBox comboBox1;
        private TextBox txttimkiem;
        private Panel panel2;
        private GroupBox groupBox7;
        private Button btn_huydon;
        private Button btn_suaKH;
        private Button btn_thanhtoan;
        private Button btn_taohoadon;
        private Label label6;
        private DateTimePicker dtpNgaytao;
        private Label label5;
        private TextBox txttienthua;
        private Label label4;
        private TextBox txtTienKhachTra;
        private Label label3;
        private TextBox txttongtien;
        private Label label7;
        private Label lbten;
        private TextBox txtmahoadon;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private Button btn_thaydoi;
        private Button btn_chon;
        private TextBox txtsdt;
        private Label label2;
        private TextBox txttenKH;
        private Label label1;
        private DataGridView dgvhoadonchitiet;
        private TextBox txtdiachi;
        private Label label8;
        private ComboBox cbbnhanvien;
        private ComboBox cbbkhachhang;
        private TextBox txtghichu;
        private Label label9;
    }
}