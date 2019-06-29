using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Media;

namespace CHIEC_NOI_KI_DIEU
{
    public partial class frm_home : DevExpress.XtraEditors.XtraForm
    {

      
      
        public frm_home()
        {
            InitializeComponent();
            Nhacnen();
            Home();
        }


        private void Nhacnen()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"Media\Nhacnen3.wav");

            simpleSound.Play();


        }
        private void bt_Thoat_ItemClick(object sender, TileItemEventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn  có muốn thoát không!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                Application.Exit();
            }
         
        }

       
        private void bt_ThietLap_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!pn_ThietLap.Controls.Contains(uc_ThietLap.ThietLap))
            {
                pn_ThietLap.Controls.Add(uc_ThietLap.ThietLap);
                uc_ThietLap.ThietLap.Dock = DockStyle.Fill;
                uc_ThietLap.ThietLap.BringToFront();

            }
            else
            {
                uc_ThietLap.ThietLap.BringToFront();
            }



        }


        private void Home()
        {
            if (!pn_ThietLap.Controls.Contains(uc_Home.ThietLap))
            {
                pn_ThietLap.Controls.Add(uc_Home.ThietLap);
                uc_Home.ThietLap.Dock = DockStyle.Fill;
                uc_Home.ThietLap.BringToFront();

            }
            else
            {
                uc_Home.ThietLap.BringToFront();
            }
        }
        private void bt_TrangChu_ItemClick(object sender, TileItemEventArgs e)
        {

            Home();

        }

        private void bt_thongtin_ItemClick(object sender, TileItemEventArgs e)
        {

            if (!pn_ThietLap.Controls.Contains(uc_Thongtin.ThietLap))
            {
                pn_ThietLap.Controls.Add(uc_Thongtin.ThietLap);
               uc_Thongtin.ThietLap.Dock = DockStyle.Fill;
               uc_Thongtin.ThietLap.BringToFront();

            }
            else
            {
                uc_Thongtin.ThietLap.BringToFront();
            }

        }

        private void bt_tintuc_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!pn_ThietLap.Controls.Contains(uc_tintuc.ThietLap))
            {
                pn_ThietLap.Controls.Add(uc_tintuc.ThietLap);
               uc_tintuc.ThietLap.Dock = DockStyle.Fill;
                uc_tintuc.ThietLap.BringToFront();

            }
            else
            {
              uc_tintuc.ThietLap.BringToFront();
            }
        }
    }
}