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
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace CHIEC_NOI_KI_DIEU
{
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {

      
        public frm_Login()
        {
            InitializeComponent();
           
        }

       
        private void TrangChu_Load(object sender, EventArgs e)
        {
           if(!pn_Hinh.Controls.Contains(uc_Hinh.Hinh))
            {
                pn_Hinh.Controls.Add(uc_Hinh.Hinh);
                uc_Hinh.Hinh.Dock = DockStyle.Fill;
                uc_Hinh.Hinh.BringToFront();

            }
           else
            {
                uc_Hinh.Hinh.BringToFront();
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn  có muốn thoát không!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                this.Close();
            }
        }

        void Chay()
        {
            SplashScreenManager.ShowForm(this, typeof(ManHinhCho), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(20);
            }
            SplashScreenManager.CloseForm();
        }
        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_taikhoan.Text == "" ||txt_matkhau.Text == "")
                {
                    throw new Exception("Bạn chưa điền đầy đủ thông tin đăng nhập. Mời đăng nhập lại!");

                }
                else
                {
                    if(txt_taikhoan.Text== "hoadethuong@gmail.com" && txt_matkhau.Text== "admin")

                    {
                        frm_home home = new frm_home();
                        lb_thongbao.ForeColor = Color.Green;
                        lb_thongbao.Text = "Đăng nhập thành công!";
                        Chay();
                        this.Hide();
                        home.ShowDialog();
                                       
                       

                    }
                    else
                    {
                        lb_thongbao.Text = "Đăng nhập thất bại!";
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {

              txt_taikhoan.ResetText();
               txt_matkhau.ResetText();
                

            }
        }
    }
}