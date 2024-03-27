namespace DuAn1_Coffe.PRL.Forms
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
            groupBox2 = new GroupBox();
            dgvhoadonchitiet = new DataGridView();
            groupBox1 = new GroupBox();
            dgvhoadon = new DataGridView();
            panel1 = new Panel();
            lbsauKM = new Label();
            lbkhuyenmai = new Label();
            lbtonggia = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            checkedListBox1 = new CheckedListBox();
            btn_load = new Button();
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
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoadonchitiet).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvhoadonchitiet);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 1139);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(2564, 420);
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
            dgvhoadonchitiet.Size = new Size(2554, 373);
            dgvhoadonchitiet.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvhoadon);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 451);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(2564, 688);
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
            dgvhoadon.Size = new Size(2554, 641);
            dgvhoadon.TabIndex = 0;
            dgvhoadon.CellContentDoubleClick += dgvhoadon_CellContentDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(lbsauKM);
            panel1.Controls.Add(lbkhuyenmai);
            panel1.Controls.Add(lbtonggia);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(btn_load);
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
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2564, 451);
            panel1.TabIndex = 3;
            // 
            // lbsauKM
            // 
            lbsauKM.AutoSize = true;
            lbsauKM.Location = new Point(1903, 304);
            lbsauKM.Name = "lbsauKM";
            lbsauKM.Size = new Size(0, 32);
            lbsauKM.TabIndex = 63;
            // 
            // lbkhuyenmai
            // 
            lbkhuyenmai.AutoSize = true;
            lbkhuyenmai.Location = new Point(1903, 200);
            lbkhuyenmai.Name = "lbkhuyenmai";
            lbkhuyenmai.Size = new Size(0, 32);
            lbkhuyenmai.TabIndex = 63;
            // 
            // lbtonggia
            // 
            lbtonggia.AutoSize = true;
            lbtonggia.Location = new Point(1919, 98);
            lbtonggia.Name = "lbtonggia";
            lbtonggia.Size = new Size(0, 32);
            lbtonggia.TabIndex = 63;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1737, 200);
            label8.Name = "label8";
            label8.Size = new Size(147, 32);
            label8.TabIndex = 62;
            label8.Text = "Khuyến Mãi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1684, 304);
            label6.Name = "label6";
            label6.Size = new Size(200, 32);
            label6.TabIndex = 62;
            label6.Text = " Sau Khuyến Mãi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1769, 98);
            label5.Name = "label5";
            label5.Size = new Size(115, 32);
            label5.TabIndex = 61;
            label5.Text = "Tổng Giá:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(1306, 37);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(8, 4);
            checkedListBox1.TabIndex = 60;
            // 
            // btn_load
            // 
            btn_load.BackColor = Color.AntiqueWhite;
            btn_load.Location = new Point(1403, 287);
            btn_load.Margin = new Padding(5);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(153, 67);
            btn_load.TabIndex = 59;
            btn_load.Text = "Load";
            btn_load.UseVisualStyleBackColor = false;
            // 
            // txttimkiemnguoitao
            // 
            txttimkiemnguoitao.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttimkiemnguoitao.Location = new Point(234, 342);
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
            label4.Location = new Point(9, 342);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(189, 50);
            label4.TabIndex = 18;
            label4.Text = "Người tạo";
            // 
            // txttimkiemmahoadon
            // 
            txttimkiemmahoadon.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttimkiemmahoadon.Location = new Point(234, 213);
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
            label3.Location = new Point(48, 216);
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
            cbolochoadon.Location = new Point(882, 213);
            cbolochoadon.Margin = new Padding(5);
            cbolochoadon.Name = "cbolochoadon";
            cbolochoadon.Size = new Size(404, 58);
            cbolochoadon.TabIndex = 15;
            cbolochoadon.Text = "Lọc";
            cbolochoadon.SelectedIndexChanged += cbolochoadon_SelectedIndexChanged;
            // 
            // btn_timNgay
            // 
            btn_timNgay.BackColor = Color.AntiqueWhite;
            btn_timNgay.ForeColor = SystemColors.ActiveCaptionText;
            btn_timNgay.Location = new Point(1402, 94);
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
            dtpDen.Location = new Point(882, 93);
            dtpDen.Margin = new Padding(5);
            dtpDen.Name = "dtpDen";
            dtpDen.Size = new Size(404, 56);
            dtpDen.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(768, 98);
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
            dtpTu.Location = new Point(234, 92);
            dtpTu.Margin = new Padding(5);
            dtpTu.Name = "dtpTu";
            dtpTu.Size = new Size(417, 56);
            dtpTu.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(112, 97);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 50);
            label1.TabIndex = 10;
            label1.Text = "Từ";
            // 
            // Form_QuanLyHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2564, 1559);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form_QuanLyHoaDon";
            Text = "Form_QuanLyHoaDon";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvhoadonchitiet).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvhoadonchitiet;
        private GroupBox groupBox1;
        private DataGridView dgvhoadon;
        private Panel panel1;
        private Button btn_load;
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
        private Label lbsauKM;
        private Label lbkhuyenmai;
        private Label lbtonggia;
        private Label label8;
        private Label label6;
        private Label label5;
        private CheckedListBox checkedListBox1;
    }
}