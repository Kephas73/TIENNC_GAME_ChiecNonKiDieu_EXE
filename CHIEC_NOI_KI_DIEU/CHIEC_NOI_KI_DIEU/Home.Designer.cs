namespace CHIEC_NOI_KI_DIEU
{
    partial class frm_home
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_home));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_ThietLap = new System.Windows.Forms.Panel();
            this.bt_TrangChu = new DevExpress.XtraEditors.TileItem();
            this.bt_ThietLap = new DevExpress.XtraEditors.TileItem();
            this.bt_thongtin = new DevExpress.XtraEditors.TileItem();
            this.bt_tintuc = new DevExpress.XtraEditors.TileItem();
            this.bt_Thoat = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Groups.Add(this.tileGroup3);
            this.tileControl1.Location = new System.Drawing.Point(12, 54);
            this.tileControl1.MaxId = 37;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(887, 157);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.bt_TrangChu);
            this.tileGroup2.Items.Add(this.bt_ThietLap);
            this.tileGroup2.Items.Add(this.bt_thongtin);
            this.tileGroup2.Items.Add(this.bt_tintuc);
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = "HOME";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.bt_Thoat);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(887, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "BẢNG ĐIỀU HƯỚNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 645);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(887, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Copyright © 2018: Nguyễn Cát Tiên - Phone: 0972342976 - Facebook: https://www.fac" +
    "ebook.com/nguyencattien1997";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_ThietLap
            // 
            this.pn_ThietLap.Location = new System.Drawing.Point(12, 217);
            this.pn_ThietLap.Name = "pn_ThietLap";
            this.pn_ThietLap.Size = new System.Drawing.Size(892, 425);
            this.pn_ThietLap.TabIndex = 2;
            // 
            // bt_TrangChu
            // 
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.Text = "TRANG CHỦ";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.bt_TrangChu.Elements.Add(tileItemElement1);
            this.bt_TrangChu.Id = 20;
            this.bt_TrangChu.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.bt_TrangChu.Name = "bt_TrangChu";
            this.bt_TrangChu.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.bt_TrangChu_ItemClick);
            // 
            // bt_ThietLap
            // 
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement2.Text = "THIẾT LẬP TRÒ CHƠI";
            this.bt_ThietLap.Elements.Add(tileItemElement2);
            this.bt_ThietLap.Id = 19;
            this.bt_ThietLap.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.bt_ThietLap.Name = "bt_ThietLap";
            this.bt_ThietLap.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.bt_ThietLap_ItemClick);
            // 
            // bt_thongtin
            // 
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement3.Text = "THÔNG TIN";
            this.bt_thongtin.Elements.Add(tileItemElement3);
            this.bt_thongtin.Id = 29;
            this.bt_thongtin.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.bt_thongtin.Name = "bt_thongtin";
            this.bt_thongtin.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.bt_thongtin_ItemClick);
            // 
            // bt_tintuc
            // 
            tileItemElement4.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement4.Image")));
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement4.Text = "HƯỚNG DẪN";
            this.bt_tintuc.Elements.Add(tileItemElement4);
            this.bt_tintuc.Id = 36;
            this.bt_tintuc.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.bt_tintuc.Name = "bt_tintuc";
            this.bt_tintuc.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.bt_tintuc_ItemClick);
            // 
            // bt_Thoat
            // 
            tileItemElement5.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement5.Image")));
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement5.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement5.Text = "THOÁT";
            this.bt_Thoat.Elements.Add(tileItemElement5);
            this.bt_Thoat.Id = 35;
            this.bt_Thoat.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.bt_Thoat_ItemClick);
            // 
            // tileItem2
            // 
            tileItemElement6.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement6.Image")));
            tileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement6.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement6.Text = "HƯỚNG DẪN";
            this.tileItem2.Elements.Add(tileItemElement6);
            this.tileItem2.Id = 18;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem2.Name = "tileItem2";
            // 
            // frm_home
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 662);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pn_ThietLap);
            this.Controls.Add(this.tileControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chiếc nói kì diệu-Bảng điều hướng";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TileItem bt_TrangChu;
        private DevExpress.XtraEditors.TileItem bt_ThietLap;
        private DevExpress.XtraEditors.TileItem bt_thongtin;
        private DevExpress.XtraEditors.TileItem bt_tintuc;
        private DevExpress.XtraEditors.TileItem bt_Thoat;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pn_ThietLap;
    }
}