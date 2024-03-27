namespace DuAn1_Coffe
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
            bt_dn = new Button();
            tb_mk = new TextBox();
            tb_tk = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // bt_dn
            // 
            bt_dn.BackColor = Color.MediumSeaGreen;
            bt_dn.Location = new Point(442, 496);
            bt_dn.Margin = new Padding(5, 6, 5, 6);
            bt_dn.Name = "bt_dn";
            bt_dn.Size = new Size(185, 85);
            bt_dn.TabIndex = 13;
            bt_dn.Text = "Đăng Nhập";
            bt_dn.UseVisualStyleBackColor = false;
            // 
            // tb_mk
            // 
            tb_mk.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_mk.Location = new Point(231, 354);
            tb_mk.Margin = new Padding(5, 6, 5, 6);
            tb_mk.Name = "tb_mk";
            tb_mk.PasswordChar = '●';
            tb_mk.PlaceholderText = "Password";
            tb_mk.Size = new Size(639, 50);
            tb_mk.TabIndex = 12;
            // 
            // tb_tk
            // 
            tb_tk.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_tk.Location = new Point(231, 191);
            tb_tk.Margin = new Padding(5, 6, 5, 6);
            tb_tk.Name = "tb_tk";
            tb_tk.PlaceholderText = "UserName";
            tb_tk.Size = new Size(639, 50);
            tb_tk.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Location = new Point(442, 496);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(185, 85);
            button1.TabIndex = 16;
            button1.Text = "Đăng Nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(231, 354);
            textBox1.Margin = new Padding(5, 6, 5, 6);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '●';
            textBox1.PlaceholderText = "Password";
            textBox1.Size = new Size(639, 50);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(231, 191);
            textBox2.Margin = new Padding(5, 6, 5, 6);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "UserName";
            textBox2.Size = new Size(639, 50);
            textBox2.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 773);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(bt_dn);
            Controls.Add(tb_mk);
            Controls.Add(tb_tk);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_dn;
        private TextBox tb_mk;
        private TextBox tb_tk;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
