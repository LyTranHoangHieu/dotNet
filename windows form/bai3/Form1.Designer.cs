
namespace bai3
{
    partial class Form1
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
            this.label_HoTen = new System.Windows.Forms.Label();
            this.label_NgaySinh = new System.Windows.Forms.Label();
            this.label_SoThich = new System.Windows.Forms.Label();
            this.textBox_HoTen = new System.Windows.Forms.TextBox();
            this.textBox_NgaySinh = new System.Windows.Forms.TextBox();
            this.textBox_SoThich = new System.Windows.Forms.TextBox();
            this.button_XacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_HoTen
            // 
            this.label_HoTen.AutoSize = true;
            this.label_HoTen.Location = new System.Drawing.Point(65, 53);
            this.label_HoTen.Name = "label_HoTen";
            this.label_HoTen.Size = new System.Drawing.Size(81, 20);
            this.label_HoTen.TabIndex = 0;
            this.label_HoTen.Text = "Họ và tên:";
            // 
            // label_NgaySinh
            // 
            this.label_NgaySinh.AutoSize = true;
            this.label_NgaySinh.Location = new System.Drawing.Point(65, 172);
            this.label_NgaySinh.Name = "label_NgaySinh";
            this.label_NgaySinh.Size = new System.Drawing.Size(86, 20);
            this.label_NgaySinh.TabIndex = 1;
            this.label_NgaySinh.Text = "Ngày sinh: ";
            // 
            // label_SoThich
            // 
            this.label_SoThich.AutoSize = true;
            this.label_SoThich.Location = new System.Drawing.Point(65, 294);
            this.label_SoThich.Name = "label_SoThich";
            this.label_SoThich.Size = new System.Drawing.Size(71, 20);
            this.label_SoThich.TabIndex = 2;
            this.label_SoThich.Text = "Sở thích:";
            // 
            // textBox_HoTen
            // 
            this.textBox_HoTen.Location = new System.Drawing.Point(198, 53);
            this.textBox_HoTen.Name = "textBox_HoTen";
            this.textBox_HoTen.Size = new System.Drawing.Size(234, 26);
            this.textBox_HoTen.TabIndex = 3;
            // 
            // textBox_NgaySinh
            // 
            this.textBox_NgaySinh.Location = new System.Drawing.Point(198, 172);
            this.textBox_NgaySinh.Name = "textBox_NgaySinh";
            this.textBox_NgaySinh.Size = new System.Drawing.Size(234, 26);
            this.textBox_NgaySinh.TabIndex = 4;
            // 
            // textBox_SoThich
            // 
            this.textBox_SoThich.Location = new System.Drawing.Point(198, 294);
            this.textBox_SoThich.Multiline = true;
            this.textBox_SoThich.Name = "textBox_SoThich";
            this.textBox_SoThich.Size = new System.Drawing.Size(234, 99);
            this.textBox_SoThich.TabIndex = 5;
            this.textBox_SoThich.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button_XacNhan
            // 
            this.button_XacNhan.Location = new System.Drawing.Point(630, 369);
            this.button_XacNhan.Name = "button_XacNhan";
            this.button_XacNhan.Size = new System.Drawing.Size(114, 43);
            this.button_XacNhan.TabIndex = 6;
            this.button_XacNhan.Text = "Xác nhận";
            this.button_XacNhan.UseVisualStyleBackColor = true;
            this.button_XacNhan.Click += new System.EventHandler(this.button_XacNhan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_XacNhan);
            this.Controls.Add(this.textBox_SoThich);
            this.Controls.Add(this.textBox_NgaySinh);
            this.Controls.Add(this.textBox_HoTen);
            this.Controls.Add(this.label_SoThich);
            this.Controls.Add(this.label_NgaySinh);
            this.Controls.Add(this.label_HoTen);
            this.Name = "Form1";
            this.Text = "Thông tin cá nhân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_HoTen;
        private System.Windows.Forms.Label label_NgaySinh;
        private System.Windows.Forms.Label label_SoThich;
        private System.Windows.Forms.TextBox textBox_HoTen;
        private System.Windows.Forms.TextBox textBox_NgaySinh;
        private System.Windows.Forms.TextBox textBox_SoThich;
        private System.Windows.Forms.Button button_XacNhan;
    }
}

