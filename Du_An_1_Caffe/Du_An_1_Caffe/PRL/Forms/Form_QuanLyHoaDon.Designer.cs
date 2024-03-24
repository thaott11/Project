namespace Du_An_1_Caffe.PRL.Forms
{
    partial class Form_QuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyHoaDon));
            panel1 = new Panel();
            btn_suaKH = new Button();
            txttimkiemnguoitao = new TextBox();
            label4 = new Label();
            txttimkiemmahoadon = new TextBox();
            label3 = new Label();
            cbolochoadon = new ComboBox();
            btn_timNgay = new Button();
            dtpDen = new DateTimePicker();
            label2 = new Label();
            dtpTu = new DateTimePicker();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgvhoadon = new DataGridView();
            groupBox2 = new GroupBox();
            dgvhoadonchitiet = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoadonchitiet).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(btn_suaKH);
            panel1.Controls.Add(txttimkiemnguoitao);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txttimkiemmahoadon);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbolochoadon);
            panel1.Controls.Add(btn_timNgay);
            panel1.Controls.Add(dtpDen);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpTu);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 688);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2558, 451);
            panel1.TabIndex = 3;
            // 
            // btn_suaKH
            // 
            btn_suaKH.BackgroundImage = (Image)resources.GetObject("btn_suaKH.BackgroundImage");
            btn_suaKH.BackgroundImageLayout = ImageLayout.Stretch;
            btn_suaKH.Location = new Point(1684, 194);
            btn_suaKH.Margin = new Padding(5, 6, 5, 6);
            btn_suaKH.Name = "btn_suaKH";
            btn_suaKH.Size = new Size(106, 82);
            btn_suaKH.TabIndex = 58;
            btn_suaKH.UseVisualStyleBackColor = true;
            btn_suaKH.Click += btn_suaKH_Click;
            // 
            // txttimkiemnguoitao
            // 
            txttimkiemnguoitao.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttimkiemnguoitao.Location = new Point(377, 336);
            txttimkiemnguoitao.Margin = new Padding(5);
            txttimkiemnguoitao.Name = "txttimkiemnguoitao";
            txttimkiemnguoitao.PlaceholderText = "Tìm kiếm";
            txttimkiemnguoitao.Size = new Size(417, 56);
            txttimkiemnguoitao.TabIndex = 19;
            txttimkiemnguoitao.TextChanged += txttimkiemnguoitao_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(135, 347);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(189, 50);
            label4.TabIndex = 18;
            label4.Text = "Người tạo";
            // 
            // txttimkiemmahoadon
            // 
            txttimkiemmahoadon.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttimkiemmahoadon.Location = new Point(377, 206);
            txttimkiemmahoadon.Margin = new Padding(5);
            txttimkiemmahoadon.Name = "txttimkiemmahoadon";
            txttimkiemmahoadon.PlaceholderText = "Tìm kiếm";
            txttimkiemmahoadon.Size = new Size(417, 56);
            txttimkiemmahoadon.TabIndex = 17;
            txttimkiemmahoadon.TextChanged += txttimkiemmahoadon_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(135, 218);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 50);
            label3.TabIndex = 16;
            label3.Text = "Mã HD";
            // 
            // cbolochoadon
            // 
            cbolochoadon.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbolochoadon.FormattingEnabled = true;
            cbolochoadon.Items.AddRange(new object[] { "Tất cả", "Đã thanh toán", "Chưa thanh toán" });
            cbolochoadon.Location = new Point(1155, 213);
            cbolochoadon.Margin = new Padding(5);
            cbolochoadon.Name = "cbolochoadon";
            cbolochoadon.Size = new Size(404, 58);
            cbolochoadon.TabIndex = 15;
            cbolochoadon.Text = "Lọc";
            // 
            // btn_timNgay
            // 
            btn_timNgay.BackColor = Color.AntiqueWhite;
            btn_timNgay.ForeColor = SystemColors.ActiveCaptionText;
            btn_timNgay.Location = new Point(1684, 82);
            btn_timNgay.Margin = new Padding(5);
            btn_timNgay.Name = "btn_timNgay";
            btn_timNgay.Size = new Size(154, 66);
            btn_timNgay.TabIndex = 14;
            btn_timNgay.Text = "Tìm";
            btn_timNgay.UseVisualStyleBackColor = false;
            btn_timNgay.Click += btn_timNgay_Click;
            // 
            // dtpDen
            // 
            dtpDen.CustomFormat = "dd/MM/yyyy";
            dtpDen.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDen.Format = DateTimePickerFormat.Custom;
            dtpDen.Location = new Point(1155, 83);
            dtpDen.Margin = new Padding(5);
            dtpDen.Name = "dtpDen";
            dtpDen.Size = new Size(404, 56);
            dtpDen.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(941, 93);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 50);
            label2.TabIndex = 12;
            label2.Text = "Đến";
            // 
            // dtpTu
            // 
            dtpTu.CustomFormat = "dd/MM/yyyy";
            dtpTu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTu.Format = DateTimePickerFormat.Custom;
            dtpTu.Location = new Point(390, 82);
            dtpTu.Margin = new Padding(5);
            dtpTu.Name = "dtpTu";
            dtpTu.Size = new Size(404, 56);
            dtpTu.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(135, 98);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 50);
            label1.TabIndex = 10;
            label1.Text = "Từ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvhoadon);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(2558, 688);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa Đơn";
            // 
            // dgvhoadon
            // 
            dgvhoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvhoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhoadon.Dock = DockStyle.Fill;
            dgvhoadon.Location = new Point(5, 42);
            dgvhoadon.Margin = new Padding(5);
            dgvhoadon.Name = "dgvhoadon";
            dgvhoadon.RowHeadersWidth = 51;
            dgvhoadon.Size = new Size(2548, 641);
            dgvhoadon.TabIndex = 0;
            dgvhoadon.CellContentClick += dgvhoadon_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvhoadonchitiet);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(2558, 1559);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa Đơn Chi tiết";
            // 
            // dgvhoadonchitiet
            // 
            dgvhoadonchitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvhoadonchitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhoadonchitiet.Dock = DockStyle.Fill;
            dgvhoadonchitiet.Location = new Point(5, 42);
            dgvhoadonchitiet.Margin = new Padding(5);
            dgvhoadonchitiet.Name = "dgvhoadonchitiet";
            dgvhoadonchitiet.RowHeadersWidth = 51;
            dgvhoadonchitiet.Size = new Size(2548, 1512);
            dgvhoadonchitiet.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // Form_QuanLyHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2558, 1559);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form_QuanLyHoaDon";
            Text = "Form_QuanLyHoaDon";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvhoadonchitiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_suaKH;
        private TextBox txttimkiemnguoitao;
        private Label label4;
        private TextBox txttimkiemmahoadon;
        private Label label3;
        private ComboBox cbolochoadon;
        private Button btn_timNgay;
        private DateTimePicker dtpDen;
        private Label label2;
        private DateTimePicker dtpTu;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvhoadon;
        private GroupBox groupBox2;
        private DataGridView dgvhoadonchitiet;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}