
namespace task2
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
            this.label_Hoten = new System.Windows.Forms.Label();
            this.label_HienThi = new System.Windows.Forms.Label();
            this.button_Chao = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Hoten
            // 
            this.label_Hoten.AutoSize = true;
            this.label_Hoten.Location = new System.Drawing.Point(124, 77);
            this.label_Hoten.Name = "label_Hoten";
            this.label_Hoten.Size = new System.Drawing.Size(137, 20);
            this.label_Hoten.TabIndex = 0;
            this.label_Hoten.Text = "Họ tên của bạn:";
            // 
            // label_HienThi
            // 
            this.label_HienThi.AutoSize = true;
            this.label_HienThi.Location = new System.Drawing.Point(124, 244);
            this.label_HienThi.Name = "label_HienThi";
            this.label_HienThi.Size = new System.Drawing.Size(0, 20);
            this.label_HienThi.TabIndex = 1;
            // 
            // button_Chao
            // 
            this.button_Chao.Location = new System.Drawing.Point(433, 244);
            this.button_Chao.Name = "button_Chao";
            this.button_Chao.Size = new System.Drawing.Size(76, 42);
            this.button_Chao.TabIndex = 2;
            this.button_Chao.Text = "Chào";
            this.button_Chao.UseVisualStyleBackColor = true;
            this.button_Chao.Click += new System.EventHandler(this.button_Chao_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 26);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.button_Chao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Chao);
            this.Controls.Add(this.label_HienThi);
            this.Controls.Add(this.label_Hoten);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Chào";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Hoten;
        private System.Windows.Forms.Label label_HienThi;
        private System.Windows.Forms.Button button_Chao;
        private System.Windows.Forms.TextBox textBox1;
    }
}

