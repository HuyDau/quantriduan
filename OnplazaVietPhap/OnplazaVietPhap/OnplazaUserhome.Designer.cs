namespace OnplazaVietPhap
{
    partial class OnplazaUserhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnplazaUserhome));
            this.btnQuanlibanhang = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQLKho = new System.Windows.Forms.Button();
            this.btnTrolai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuanlibanhang
            // 
            this.btnQuanlibanhang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanlibanhang.ForeColor = System.Drawing.Color.Teal;
            this.btnQuanlibanhang.Location = new System.Drawing.Point(231, 84);
            this.btnQuanlibanhang.Name = "btnQuanlibanhang";
            this.btnQuanlibanhang.Size = new System.Drawing.Size(208, 56);
            this.btnQuanlibanhang.TabIndex = 0;
            this.btnQuanlibanhang.Text = "Quản Lí Bán Hàng";
            this.btnQuanlibanhang.UseVisualStyleBackColor = true;
            // 
            // btnQLKH
            // 
            this.btnQLKH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKH.ForeColor = System.Drawing.Color.Teal;
            this.btnQLKH.Location = new System.Drawing.Point(231, 315);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(208, 50);
            this.btnQLKH.TabIndex = 1;
            this.btnQLKH.Text = "Quản Lí Khách Hàng";
            this.btnQLKH.UseVisualStyleBackColor = true;
            // 
            // btnQLKho
            // 
            this.btnQLKho.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKho.ForeColor = System.Drawing.Color.Teal;
            this.btnQLKho.Location = new System.Drawing.Point(231, 203);
            this.btnQLKho.Name = "btnQLKho";
            this.btnQLKho.Size = new System.Drawing.Size(208, 48);
            this.btnQLKho.TabIndex = 2;
            this.btnQLKho.Text = "Quản Lí Kho";
            this.btnQLKho.UseVisualStyleBackColor = true;
            // 
            // btnTrolai
            // 
            this.btnTrolai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrolai.ForeColor = System.Drawing.Color.Red;
            this.btnTrolai.Location = new System.Drawing.Point(508, 385);
            this.btnTrolai.Name = "btnTrolai";
            this.btnTrolai.Size = new System.Drawing.Size(152, 50);
            this.btnTrolai.TabIndex = 3;
            this.btnTrolai.Text = "Đăng Xuất";
            this.btnTrolai.UseVisualStyleBackColor = true;
            // 
            // OnplazaUserhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(672, 447);
            this.Controls.Add(this.btnTrolai);
            this.Controls.Add(this.btnQLKho);
            this.Controls.Add(this.btnQLKH);
            this.Controls.Add(this.btnQuanlibanhang);
            this.Name = "OnplazaUserhome";
            this.Text = "OnplazaUserhome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuanlibanhang;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnQLKho;
        private System.Windows.Forms.Button btnTrolai;
    }
}