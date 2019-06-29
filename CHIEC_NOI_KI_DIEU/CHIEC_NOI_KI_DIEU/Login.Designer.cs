namespace CHIEC_NOI_KI_DIEU
{
    partial class frm_Login
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
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.pn_Hinh = new System.Windows.Forms.Panel();
            this.bt_dangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.bt_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(501, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(418, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "TK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(418, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "MK:";
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.BackColor = System.Drawing.Color.White;
            this.txt_taikhoan.Location = new System.Drawing.Point(481, 213);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(187, 21);
            this.txt_taikhoan.TabIndex = 3;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(481, 272);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(187, 21);
            this.txt_matkhau.TabIndex = 4;
            // 
            // pn_Hinh
            // 
            this.pn_Hinh.Location = new System.Drawing.Point(0, 0);
            this.pn_Hinh.Name = "pn_Hinh";
            this.pn_Hinh.Size = new System.Drawing.Size(400, 533);
            this.pn_Hinh.TabIndex = 7;
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dangnhap.Appearance.Options.UseFont = true;
            this.bt_dangnhap.Location = new System.Drawing.Point(481, 348);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(85, 32);
            this.bt_dangnhap.TabIndex = 8;
            this.bt_dangnhap.Text = "Đăng nhập";
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Appearance.Options.UseFont = true;
            this.bt_thoat.Location = new System.Drawing.Point(583, 348);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(85, 32);
            this.bt_thoat.TabIndex = 9;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongbao.ForeColor = System.Drawing.Color.Red;
            this.lb_thongbao.Location = new System.Drawing.Point(481, 312);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(133, 20);
            this.lb_thongbao.TabIndex = 10;
            this.lb_thongbao.Text = "Vui lòng đăng nhập!";
            // 
            // frm_Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 533);
            this.Controls.Add(this.lb_thongbao);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.pn_Hinh);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChu";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Panel pn_Hinh;
        private DevExpress.XtraEditors.SimpleButton bt_dangnhap;
        private DevExpress.XtraEditors.SimpleButton bt_thoat;
        private System.Windows.Forms.Label lb_thongbao;
    }
}