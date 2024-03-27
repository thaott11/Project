namespace DuAn1_Coffe.PRL.Forms
{
    partial class Form_GiamGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GiamGia));
            btn_Reset = new Button();
            btn_Load = new Button();
            btn_suaGG = new Button();
            btn_themGG = new Button();
            dtpNgayBatDau = new DateTimePicker();
            label2 = new Label();
            txtSoLuong = new TextBox();
            label9 = new Label();
            txtGiamToiDa = new TextBox();
            txtMaGiamGia = new TextBox();
            dtpNgayKetThuc = new DateTimePicker();
            txtTiLeGiam = new TextBox();
            txtDonToiThieu = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtTimKiem = new TextBox();
            dgvgiamgia = new DataGridView();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvgiamgia).BeginInit();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(2090, 491);
            btn_Reset.Margin = new Padding(5);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(119, 98);
            btn_Reset.TabIndex = 84;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_Load
            // 
            btn_Load.Location = new Point(2086, 354);
            btn_Load.Margin = new Padding(5);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(122, 104);
            btn_Load.TabIndex = 83;
            btn_Load.Text = "Load";
            btn_Load.UseVisualStyleBackColor = true;
            btn_Load.Click += btn_Load_Click;
            // 
            // btn_suaGG
            // 
            btn_suaGG.BackgroundImage = (Image)resources.GetObject("btn_suaGG.BackgroundImage");
            btn_suaGG.BackgroundImageLayout = ImageLayout.Stretch;
            btn_suaGG.Location = new Point(2086, 206);
            btn_suaGG.Margin = new Padding(5, 6, 5, 6);
            btn_suaGG.Name = "btn_suaGG";
            btn_suaGG.Size = new Size(115, 107);
            btn_suaGG.TabIndex = 82;
            btn_suaGG.UseVisualStyleBackColor = true;
            btn_suaGG.Click += btn_suaGG_Click;
            // 
            // btn_themGG
            // 
            btn_themGG.BackgroundImage = (Image)resources.GetObject("btn_themGG.BackgroundImage");
            btn_themGG.BackgroundImageLayout = ImageLayout.Stretch;
            btn_themGG.Location = new Point(2086, 66);
            btn_themGG.Margin = new Padding(5, 6, 5, 6);
            btn_themGG.Name = "btn_themGG";
            btn_themGG.Size = new Size(115, 96);
            btn_themGG.TabIndex = 81;
            btn_themGG.UseVisualStyleBackColor = true;
            btn_themGG.Click += btn_themGG_Click;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.CustomFormat = "dd-MM-yyyy";
            dtpNgayBatDau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.Location = new Point(429, 170);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(485, 50);
            dtpNgayBatDau.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 181);
            label2.Name = "label2";
            label2.Size = new Size(253, 46);
            label2.TabIndex = 31;
            label2.Text = "Ngày bắt đầu :";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(1373, 181);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(386, 50);
            txtSoLuong.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1055, 189);
            label9.Name = "label9";
            label9.Size = new Size(245, 46);
            label9.TabIndex = 29;
            label9.Text = "Số lượng mã :";
            // 
            // txtGiamToiDa
            // 
            txtGiamToiDa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGiamToiDa.Location = new Point(1373, 75);
            txtGiamToiDa.Name = "txtGiamToiDa";
            txtGiamToiDa.Size = new Size(397, 50);
            txtGiamToiDa.TabIndex = 28;
            // 
            // txtMaGiamGia
            // 
            txtMaGiamGia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaGiamGia.Location = new Point(429, 75);
            txtMaGiamGia.Name = "txtMaGiamGia";
            txtMaGiamGia.Size = new Size(485, 50);
            txtMaGiamGia.TabIndex = 27;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.CustomFormat = "dd-MM-yyyy";
            dtpNgayKetThuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.Location = new Point(429, 288);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(485, 50);
            dtpNgayKetThuc.TabIndex = 26;
            // 
            // txtTiLeGiam
            // 
            txtTiLeGiam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTiLeGiam.Location = new Point(429, 410);
            txtTiLeGiam.Name = "txtTiLeGiam";
            txtTiLeGiam.Size = new Size(485, 50);
            txtTiLeGiam.TabIndex = 25;
            // 
            // txtDonToiThieu
            // 
            txtDonToiThieu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDonToiThieu.Location = new Point(427, 536);
            txtDonToiThieu.Name = "txtDonToiThieu";
            txtDonToiThieu.Size = new Size(487, 50);
            txtDonToiThieu.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1055, 86);
            label7.Name = "label7";
            label7.Size = new Size(228, 46);
            label7.TabIndex = 23;
            label7.Text = "Giảm tối đa :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(54, 544);
            label6.Name = "label6";
            label6.Size = new Size(339, 46);
            label6.TabIndex = 22;
            label6.Text = "Đơn hàng tối thiếu :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(54, 410);
            label4.Name = "label4";
            label4.Size = new Size(203, 46);
            label4.TabIndex = 21;
            label4.Text = "Tỉ lệ giảm :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(54, 288);
            label3.Name = "label3";
            label3.Size = new Size(262, 46);
            label3.TabIndex = 20;
            label3.Text = "Ngày kết thúc :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 75);
            label1.Name = "label1";
            label1.Size = new Size(244, 46);
            label1.TabIndex = 19;
            label1.Text = "Mã giảm giá :";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(294, 34);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.Size = new Size(573, 52);
            txtTimKiem.TabIndex = 5;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // dgvgiamgia
            // 
            dgvgiamgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvgiamgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvgiamgia.Dock = DockStyle.Fill;
            dgvgiamgia.Location = new Point(0, 96);
            dgvgiamgia.Margin = new Padding(5);
            dgvgiamgia.Name = "dgvgiamgia";
            dgvgiamgia.RowHeadersWidth = 51;
            dgvgiamgia.Size = new Size(2564, 751);
            dgvgiamgia.TabIndex = 1;
            dgvgiamgia.CellContentClick += dgvgiamgia_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(2564, 96);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách mã giảm giá ";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvgiamgia);
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 712);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(2564, 847);
            panel3.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Reset);
            panel1.Controls.Add(btn_Load);
            panel1.Controls.Add(btn_suaGG);
            panel1.Controls.Add(btn_themGG);
            panel1.Controls.Add(dtpNgayBatDau);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtGiamToiDa);
            panel1.Controls.Add(txtMaGiamGia);
            panel1.Controls.Add(dtpNgayKetThuc);
            panel1.Controls.Add(txtTiLeGiam);
            panel1.Controls.Add(txtDonToiThieu);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2564, 712);
            panel1.TabIndex = 4;
            // 
            // Form_GiamGia
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2564, 1559);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form_GiamGia";
            Text = "Form_GiamGia";
            ((System.ComponentModel.ISupportInitialize)dgvgiamgia).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Reset;
        private Button btn_Load;
        private Button btn_suaGG;
        private Button btn_themGG;
        private DateTimePicker dtpNgayBatDau;
        private Label label2;
        private TextBox txtSoLuong;
        private Label label9;
        private TextBox txtGiamToiDa;
        private TextBox txtMaGiamGia;
        private DateTimePicker dtpNgayKetThuc;
        private TextBox txtTiLeGiam;
        private TextBox txtDonToiThieu;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtTimKiem;
        private DataGridView dgvgiamgia;
        private GroupBox groupBox1;
        private Panel panel3;
        private Panel panel1;
    }
}