namespace OnplazaVietPhap
{
    partial class Nhaphang
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
            this.cbMaSp = new System.Windows.Forms.ComboBox();
            this.cbTenSP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSoluong = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbGia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tbSoluongnhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTongtien = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTongsoluong = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbngaynhap = new System.Windows.Forms.TextBox();
            this.tbmaphieunhap = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(312, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sản phẩm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên sản phẩm";
            // 
            // cbMaSp
            // 
            this.cbMaSp.FormattingEnabled = true;
            this.cbMaSp.Location = new System.Drawing.Point(131, 7);
            this.cbMaSp.Name = "cbMaSp";
            this.cbMaSp.Size = new System.Drawing.Size(287, 30);
            this.cbMaSp.TabIndex = 5;
            this.cbMaSp.SelectedIndexChanged += new System.EventHandler(this.cbMaSp_SelectedIndexChanged);
            // 
            // cbTenSP
            // 
            this.cbTenSP.FormattingEnabled = true;
            this.cbTenSP.Location = new System.Drawing.Point(131, 43);
            this.cbTenSP.Name = "cbTenSP";
            this.cbTenSP.Size = new System.Drawing.Size(287, 30);
            this.cbTenSP.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng";
            // 
            // cbSoluong
            // 
            this.cbSoluong.FormattingEnabled = true;
            this.cbSoluong.Location = new System.Drawing.Point(131, 86);
            this.cbSoluong.Name = "cbSoluong";
            this.cbSoluong.Size = new System.Drawing.Size(287, 30);
            this.cbSoluong.TabIndex = 8;
            this.cbSoluong.SelectedIndexChanged += new System.EventHandler(this.cbSoluong_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.cbGia);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbSoluong);
            this.panel1.Controls.Add(this.cbMaSp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbTenSP);
            this.panel1.Location = new System.Drawing.Point(16, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 165);
            this.panel1.TabIndex = 9;
            // 
            // cbGia
            // 
            this.cbGia.FormattingEnabled = true;
            this.cbGia.Location = new System.Drawing.Point(131, 125);
            this.cbGia.Name = "cbGia";
            this.cbGia.Size = new System.Drawing.Size(287, 30);
            this.cbGia.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gía";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "KHO";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.tbmaphieunhap);
            this.panel2.Controls.Add(this.tbngaynhap);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.tbSoluongnhap);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(471, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 165);
            this.panel2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "CẬP NHẬT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbSoluongnhap
            // 
            this.tbSoluongnhap.Location = new System.Drawing.Point(181, 91);
            this.tbSoluongnhap.Name = "tbSoluongnhap";
            this.tbSoluongnhap.Size = new System.Drawing.Size(153, 29);
            this.tbSoluongnhap.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(456, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tổng tiên nhập";
            // 
            // tbTongtien
            // 
            this.tbTongtien.Location = new System.Drawing.Point(635, 302);
            this.tbTongtien.Name = "tbTongtien";
            this.tbTongtien.Size = new System.Drawing.Size(153, 29);
            this.tbTongtien.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "XÁC NHẬN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 22);
            this.label9.TabIndex = 13;
            this.label9.Text = "NHẬP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tổng số lượng";
            // 
            // tbTongsoluong
            // 
            this.tbTongsoluong.Location = new System.Drawing.Point(147, 376);
            this.tbTongsoluong.Name = "tbTongsoluong";
            this.tbTongsoluong.Size = new System.Drawing.Size(194, 29);
            this.tbTongsoluong.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(12, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 39);
            this.button3.TabIndex = 14;
            this.button3.Text = "VỀ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 22);
            this.label11.TabIndex = 15;
            this.label11.Text = "Mã phiếu nhập";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 22);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ngày nhập";
            // 
            // tbngaynhap
            // 
            this.tbngaynhap.Location = new System.Drawing.Point(181, 51);
            this.tbngaynhap.Name = "tbngaynhap";
            this.tbngaynhap.Size = new System.Drawing.Size(153, 29);
            this.tbngaynhap.TabIndex = 17;
            this.tbngaynhap.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // tbmaphieunhap
            // 
            this.tbmaphieunhap.Location = new System.Drawing.Point(181, 15);
            this.tbmaphieunhap.Name = "tbmaphieunhap";
            this.tbmaphieunhap.Size = new System.Drawing.Size(153, 29);
            this.tbmaphieunhap.TabIndex = 18;
            // 
            // Nhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 483);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbTongtien);
            this.Controls.Add(this.tbTongsoluong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Nhaphang";
            this.Text = "Nhaphang";
            this.Load += new System.EventHandler(this.Nhaphang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaSp;
        private System.Windows.Forms.ComboBox cbTenSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSoluong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbSoluongnhap;
        private System.Windows.Forms.TextBox tbTongtien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTongsoluong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbmaphieunhap;
        private System.Windows.Forms.TextBox tbngaynhap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}