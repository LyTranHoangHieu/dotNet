
namespace bai4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_bk = new System.Windows.Forms.TextBox();
            this.txt_cv = new System.Windows.Forms.TextBox();
            this.txt_dt = new System.Windows.Forms.TextBox();
            this.bt_tinh = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_tt = new System.Windows.Forms.Button();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH DIỆN TÍCH VÀ CHU VI HÌNH TRÒN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập bán kính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chu vi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diện tích:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "(m)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "(m)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "( m   )";
            // 
            // txt_bk
            // 
            this.txt_bk.Location = new System.Drawing.Point(207, 120);
            this.txt_bk.Name = "txt_bk";
            this.txt_bk.Size = new System.Drawing.Size(199, 26);
            this.txt_bk.TabIndex = 7;
            // 
            // txt_cv
            // 
            this.txt_cv.Enabled = false;
            this.txt_cv.Location = new System.Drawing.Point(207, 197);
            this.txt_cv.Name = "txt_cv";
            this.txt_cv.Size = new System.Drawing.Size(199, 26);
            this.txt_cv.TabIndex = 8;
            // 
            // txt_dt
            // 
            this.txt_dt.Enabled = false;
            this.txt_dt.Location = new System.Drawing.Point(207, 271);
            this.txt_dt.Name = "txt_dt";
            this.txt_dt.Size = new System.Drawing.Size(199, 26);
            this.txt_dt.TabIndex = 9;
            // 
            // bt_tinh
            // 
            this.bt_tinh.Location = new System.Drawing.Point(144, 356);
            this.bt_tinh.Name = "bt_tinh";
            this.bt_tinh.Size = new System.Drawing.Size(73, 37);
            this.bt_tinh.TabIndex = 10;
            this.bt_tinh.Text = "Tính";
            this.bt_tinh.UseVisualStyleBackColor = true;
            this.bt_tinh.Click += new System.EventHandler(this.bt_tinh_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(534, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "2";
            // 
            // bt_tt
            // 
            this.bt_tt.Location = new System.Drawing.Point(333, 356);
            this.bt_tt.Name = "bt_tt";
            this.bt_tt.Size = new System.Drawing.Size(73, 37);
            this.bt_tt.TabIndex = 13;
            this.bt_tt.Text = "Tiếp tục";
            this.bt_tt.UseVisualStyleBackColor = true;
            this.bt_tt.Click += new System.EventHandler(this.bt_tt_Click);
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.ForeColor = System.Drawing.Color.Red;
            this.lb_thongbao.Location = new System.Drawing.Point(203, 149);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(0, 20);
            this.lb_thongbao.TabIndex = 14;
            // 
            // Form1
            // 
            this.AcceptButton = this.bt_tinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 443);
            this.Controls.Add(this.lb_thongbao);
            this.Controls.Add(this.bt_tt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bt_tinh);
            this.Controls.Add(this.txt_dt);
            this.Controls.Add(this.txt_cv);
            this.Controls.Add(this.txt_bk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Diện tích và chu vi hình tròn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_bk;
        private System.Windows.Forms.TextBox txt_cv;
        private System.Windows.Forms.TextBox txt_dt;
        private System.Windows.Forms.Button bt_tinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_tt;
        private System.Windows.Forms.Label lb_thongbao;
    }
}

