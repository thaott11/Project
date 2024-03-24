namespace Du_An_1_Caffe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rbtnhanvien = new RadioButton();
            rbtAdmin = new RadioButton();
            checkMK = new CheckBox();
            bt_dn = new Button();
            tb_mk = new TextBox();
            tb_tk = new TextBox();
            SuspendLayout();
            // 
            // rbtnhanvien
            // 
            rbtnhanvien.AutoSize = true;
            rbtnhanvien.FlatStyle = FlatStyle.Flat;
            rbtnhanvien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnhanvien.Location = new Point(517, 329);
            rbtnhanvien.Margin = new Padding(5);
            rbtnhanvien.Name = "rbtnhanvien";
            rbtnhanvien.Size = new Size(192, 49);
            rbtnhanvien.TabIndex = 19;
            rbtnhanvien.TabStop = true;
            rbtnhanvien.Text = "Nhân viên";
            rbtnhanvien.UseVisualStyleBackColor = true;
            // 
            // rbtAdmin
            // 
            rbtAdmin.AutoSize = true;
            rbtAdmin.FlatStyle = FlatStyle.Flat;
            rbtAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtAdmin.Location = new Point(228, 329);
            rbtAdmin.Margin = new Padding(5);
            rbtAdmin.Name = "rbtAdmin";
            rbtAdmin.Size = new Size(143, 49);
            rbtAdmin.TabIndex = 18;
            rbtAdmin.TabStop = true;
            rbtAdmin.Text = "Admin";
            rbtAdmin.UseVisualStyleBackColor = true;
            // 
            // checkMK
            // 
            checkMK.AutoSize = true;
            checkMK.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkMK.Location = new Point(736, 237);
            checkMK.Margin = new Padding(5);
            checkMK.Name = "checkMK";
            checkMK.Size = new Size(28, 27);
            checkMK.TabIndex = 17;
            checkMK.UseVisualStyleBackColor = true;
            // 
            // bt_dn
            // 
            bt_dn.BackColor = Color.MediumSeaGreen;
            bt_dn.Location = new Point(374, 461);
            bt_dn.Margin = new Padding(5, 6, 5, 6);
            bt_dn.Name = "bt_dn";
            bt_dn.Size = new Size(185, 85);
            bt_dn.TabIndex = 16;
            bt_dn.Text = "Đăng Nhập";
            bt_dn.UseVisualStyleBackColor = false;
            // 
            // tb_mk
            // 
            tb_mk.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_mk.Location = new Point(140, 223);
            tb_mk.Margin = new Padding(5, 6, 5, 6);
            tb_mk.Name = "tb_mk";
            tb_mk.PasswordChar = '●';
            tb_mk.PlaceholderText = "Password";
            tb_mk.Size = new Size(639, 46);
            tb_mk.TabIndex = 15;
            // 
            // tb_tk
            // 
            tb_tk.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_tk.Location = new Point(140, 113);
            tb_tk.Margin = new Padding(5, 6, 5, 6);
            tb_tk.Name = "tb_tk";
            tb_tk.PlaceholderText = "UserName";
            tb_tk.Size = new Size(639, 46);
            tb_tk.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 714);
            Controls.Add(rbtnhanvien);
            Controls.Add(rbtAdmin);
            Controls.Add(checkMK);
            Controls.Add(bt_dn);
            Controls.Add(tb_mk);
            Controls.Add(tb_tk);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbtnhanvien;
        private RadioButton rbtAdmin;
        private CheckBox checkMK;
        private Button bt_dn;
        private TextBox tb_mk;
        private TextBox tb_tk;
    }
}
