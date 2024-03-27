namespace DuAn1_Coffe.PRL.Forms
{
    partial class Form_QRCode
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            btn_luu = new Button();
            btn_tạo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(232, 309);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(510, 445);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(215, 214);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(565, 50);
            textBox1.TabIndex = 6;
            // 
            // btn_luu
            // 
            btn_luu.Location = new Point(880, 192);
            btn_luu.Margin = new Padding(5);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(153, 77);
            btn_luu.TabIndex = 5;
            btn_luu.Text = "Lưu";
            btn_luu.UseVisualStyleBackColor = true;
            btn_luu.Click += btn_luu_Click;
            // 
            // btn_tạo
            // 
            btn_tạo.Location = new Point(215, 85);
            btn_tạo.Margin = new Padding(5);
            btn_tạo.Name = "btn_tạo";
            btn_tạo.Size = new Size(153, 77);
            btn_tạo.TabIndex = 4;
            btn_tạo.Text = "Tạo";
            btn_tạo.UseVisualStyleBackColor = true;
            btn_tạo.Click += btn_tạo_Click;
            // 
            // Form_QRCode
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 839);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(btn_luu);
            Controls.Add(btn_tạo);
            Name = "Form_QRCode";
            Text = "Form_QRCode";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button btn_luu;
        private Button btn_tạo;
    }
}