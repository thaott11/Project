namespace Du_An_1_Caffe.PRL.Forms
{
    partial class Form_LichSuHoaDon
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
            dgvhoadon = new DataGridView();
            dgvsanphamct = new DataGridView();
            dgvhoadonchitiet = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvsanphamct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvhoadonchitiet).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvhoadon
            // 
            dgvhoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhoadon.Location = new Point(21, 59);
            dgvhoadon.Name = "dgvhoadon";
            dgvhoadon.RowHeadersWidth = 82;
            dgvhoadon.RowTemplate.Height = 41;
            dgvhoadon.Size = new Size(1304, 528);
            dgvhoadon.TabIndex = 0;
            // 
            // dgvsanphamct
            // 
            dgvsanphamct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsanphamct.Location = new Point(53, 84);
            dgvsanphamct.Name = "dgvsanphamct";
            dgvsanphamct.RowHeadersWidth = 82;
            dgvsanphamct.RowTemplate.Height = 41;
            dgvsanphamct.Size = new Size(1379, 609);
            dgvsanphamct.TabIndex = 1;
            // 
            // dgvhoadonchitiet
            // 
            dgvhoadonchitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhoadonchitiet.Location = new Point(23, 48);
            dgvhoadonchitiet.Name = "dgvhoadonchitiet";
            dgvhoadonchitiet.RowHeadersWidth = 82;
            dgvhoadonchitiet.RowTemplate.Height = 41;
            dgvhoadonchitiet.Size = new Size(1075, 519);
            dgvhoadonchitiet.TabIndex = 2;
            dgvhoadonchitiet.CellContentClick += dgvhoadonchitiet_CellContentClick_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvsanphamct);
            groupBox1.Location = new Point(61, 726);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1506, 732);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm trong hóa đơn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvhoadonchitiet);
            groupBox2.Location = new Point(51, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1129, 629);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn chi tiết";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvhoadon);
            groupBox3.Location = new Point(1205, 45);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1329, 640);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa đơn";
            // 
            // Form_LichSuHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2564, 1559);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form_LichSuHoaDon";
            Text = "Form_LichSuHoaDon";
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvsanphamct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvhoadonchitiet).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvhoadon;
        private DataGridView dgvsanphamct;
        private DataGridView dgvhoadonchitiet;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}