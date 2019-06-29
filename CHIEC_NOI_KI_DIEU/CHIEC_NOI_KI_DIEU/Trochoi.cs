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
using System.IO;

namespace CHIEC_NOI_KI_DIEU
{
    public partial class frm_Trochoi : DevExpress.XtraEditors.XtraForm
    {


        public string cauhoi { set { lb_Cauhoi.Text = value; } }

        string str = File.ReadAllText( @"Game\result.txt");
    
        string hinh= File.ReadAllText(@"Game\image.txt");
        string ten = File.ReadAllText(@"Game\gift.txt");
        string[] Hinh;
        string[] Ten;

        int time;
        int i;
        public frm_Trochoi()
        {
            InitializeComponent();
            Nhacnen();
            khoitao();
            Demo();
            lb_Thongbao.Text="Đáp án tất cả gồm có "+(str.Length-2).ToString()+" ô chữ!";

        }

     
        private void Demo()
        {



            // str = str.Trim();
            //int chieudai = str.Length;

            //  string A = "";
            //for(int i=0; i < str.Length;i++)
            //{
            //    if(str[i].ToString()!=" ")
            //        A = A + str[i];  A.Trim();
            //    txt_test.Text = A.ToUpper();
            //}



            str = str.Replace(" ", "");
            for (int i=0; i< str.Length-2;i++)
            {
                Button bto = new Button();
              bto.BackColor = Color.Orange;
               
              
                bto.Size = new Size(63, 56);
                bto.Name = "bto_" + str[i];
                bto.Text = str[i].ToString().ToUpper();
                bto.ForeColor = Color.Orange;

                bto.MouseDown += new MouseEventHandler(bt_MouseDown);// tạo sự kien click chuot;

                flPan_Ochu.Controls.Add(bto);
            }       
          }

        private void Thongbao( string A)
        {
            str = str.Replace(" ", "");
            int dem = 0;
            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str[i].ToString().ToUpper() == A)
                {
                    dem++;
                }
            }
            if (dem ==0)
            {
                lb_Thongbao.Text = "Chia buồn cùng gia đình. Chữ " + A.ToUpper() + " không có trong đáp án. ";
                lb_Thongbao.ForeColor = Color.Red;
            }
            else
            {
                lb_Thongbao.Text = "Nhà bạn thật có phúc. Có "+ (dem).ToString() + " chữ " + A.ToUpper() + " trong đáp án.";
                lb_Thongbao.ForeColor = Color.Blue;
            }
        }
        private void Monhac(string A)
        {
          
            str = str.Replace(" ", "");
            int dem =0 ;
            for(int i=0;i < str.Length-2;i++)
            {
                if(str[i].ToString().ToUpper()==A)
                {
                    dem++;
                }
            }
           if(dem==0)
            {
                Doansai();
            }
           else
            {
                Doandung();
            }
               
            
    
        }
        private void Hienchu(Control ctrl, string A)
        {

              
            if (ctrl.GetType() == typeof(Button))
            {
               if(ctrl.Text==A)
                {
                    Monhac(A);
                    ctrl.ForeColor = Color.Black;
                   
                }

            }
          
            foreach (Control ctrlChild in ctrl.Controls)// Đệ quy
            {
                Hienchu(ctrlChild,A);
            }
        }

        private void bt_MouseDown(object sender, MouseEventArgs e)
        {
            Doandung();
            Button bt = (Button)sender; 
            bt.ForeColor = Color.Black;

        }

        private void khoitao()
        {
            pc_quay.Image = Image.FromFile(@"Resources/Hoa.jpg");

            Hinh = hinh.Split(',');


            Ten = ten.Split(',');
          
        }
        private void timer_quay_Tick(object sender, EventArgs e)
        {
            if(bt_quay.BackColor==Color.Red)
            {
                bt_quay.BackColor = Color.Yellow;
            }
            else if (bt_quay.BackColor == Color.Yellow)
            {
                bt_quay.BackColor = Color.Green;
            }

             else if (bt_quay.BackColor == Color.Green)
            {
                bt_quay.BackColor = Color.Red;
            }
        }


        private void playSimpleSound(string A)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"Media\Phanqua.wav");
            if(A=="on")
            {
                simpleSound.Play();
            }
            else
            {
                simpleSound.Stop();
            }
           
        }

        private void Doandung()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"Media\Doandung.wav");
           
                simpleSound.Play();
           

        }
        private void Doansai()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"Media\Doansai.wav");

            simpleSound.Play();


        }

        private void Nhacnen()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"Media\batdau.wav");

            simpleSound.Play();


        }
        private void bt_quay_Click(object sender, EventArgs e)
        {

            Hinh = hinh.Split(',');
            
            Ten = ten.Split(',');
            Random random = new Random();
             time = random.Next(0, 200);

            i = 0;
            pc_quay.LoadAsync(@"Game/" + Hinh[i % Hinh.Length]);
         //   pc_quay.Image = Image.FromFile(@"D://Image/" + Hinh[i % Hinh.Length]);

            //for(int i=0; i<time;i++)
            //{
            //    pc_quay.Image = Image.FromFile(@"D://Image/"+Hinh[i % Hinh.Length]);
            //}
        }


        private void pc_quay_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if(i < time)
            {
                i++;
                pc_quay.LoadAsync(@"Game/" + Hinh[i % Hinh.Length]);
              
               
            }
            else
            {
                playSimpleSound("on");
                DialogResult tl = MessageBox.Show("BẠN VỪA QUAY VÀO Ô" + " " + Ten[i % Ten.Length].ToUpper(), "CHÚC MỪNG",MessageBoxButtons.OK,MessageBoxIcon.None);
                if(tl ==DialogResult.OK)
                {
                    playSimpleSound("off");
                }
        
            }
        }

      

        private void bt_O_Click(object sender, EventArgs e)
        {

         
            Hienchu(this, "O");
            Thongbao("O");
            bt_O.Enabled = false;
        }

        private void bt_T_Click(object sender, EventArgs e)
        {
            Hienchu(this, "T");
            Thongbao("T");
            bt_T.Enabled = false;
        }

        private void bt_A_Click(object sender, EventArgs e)
        {
            Hienchu(this, "A");
            Thongbao("A");
            bt_A.Enabled = false;
        }

        private void bt_B_Click(object sender, EventArgs e)
        {
          
            Hienchu(this, "B");
            Thongbao("B");
            bt_B.Enabled = false;
        }

        private void bt_C_Click(object sender, EventArgs e)
        {
            Hienchu(this, "C");
            Thongbao("C");
            bt_C.Enabled = false;
        }

        private void bt_D_Click(object sender, EventArgs e)
        {
            Hienchu(this, "D");
            Thongbao("D");
            bt_D.Enabled = false;
        }

        private void bt_E_Click(object sender, EventArgs e)
        {
            Hienchu(this, "E");
            Thongbao("E");
            bt_E.Enabled = false;
        }

        private void bt_F_Click(object sender, EventArgs e)
        {
            Hienchu(this, "F");
            Thongbao("F");
            bt_F.Enabled = false;
        }

        private void bt_G_Click(object sender, EventArgs e)
        {
            Hienchu(this, "G");
            Thongbao("G");
            bt_G.Enabled = false;
        }

        private void bt_H_Click(object sender, EventArgs e)
        {
            Hienchu(this, "H");
            Thongbao("H");
            bt_H.Enabled = false;
        }

        private void bt_I_Click(object sender, EventArgs e)
        {
            Hienchu(this, "I");
            Thongbao("I");
            bt_I.Enabled = false;

        }

        private void bt_J_Click(object sender, EventArgs e)
        {
            Hienchu(this, "J");
            Thongbao("J");
            bt_J.Enabled = false;
        }

        private void bt_K_Click(object sender, EventArgs e)
        {
            Hienchu(this, "K");
            Thongbao("K");
            bt_K.Enabled = false;
        }

        private void bt_L_Click(object sender, EventArgs e)
        {
            Hienchu(this, "L");
            Thongbao("L");
            bt_L.Enabled = false;
        }

        private void bt_M_Click(object sender, EventArgs e)
        {
            Hienchu(this, "M");
            Thongbao("M");
            bt_M.Enabled = false;
        }

        private void bt_N_Click(object sender, EventArgs e)
        {
            Hienchu(this, "N");
            Thongbao("N");
            bt_N.Enabled = false;
        }

        private void bt_P_Click(object sender, EventArgs e)
        {
            Hienchu(this, "P");
            Thongbao("P");
            bt_P.Enabled = false;
        }

        private void bt_Q_Click(object sender, EventArgs e)
        {
            Hienchu(this, "Q");
            Thongbao("Q");
            bt_Q.Enabled = false;
        }

        private void bt_R_Click(object sender, EventArgs e)
        {
            Hienchu(this, "R");
            Thongbao("R");
            bt_R.Enabled = false;
        }

        private void bt_S_Click(object sender, EventArgs e)
        {
            Hienchu(this, "S");
            Thongbao("S");
            bt_S.Enabled = false;
        }

        private void bt_U_Click(object sender, EventArgs e)
        {
            Hienchu(this, "U");
            Thongbao("U");
            bt_U.Enabled = false;
        }

        private void bt_V_Click(object sender, EventArgs e)
        {
            Hienchu(this, "V");
            Thongbao("V");
            bt_V.Enabled = false;
        }

        private void bt_W_Click(object sender, EventArgs e)
        {
            Hienchu(this, "W");
            Thongbao("W");
            bt_W.Enabled = false;
        }

        private void bt_X_Click(object sender, EventArgs e)
        {
            Hienchu(this, "X");
            Thongbao("X");
            bt_X.Enabled = false;
        }

        private void bt_Y_Click(object sender, EventArgs e)
        {
            Hienchu(this, "Y");
            Thongbao("Y");
            bt_Y.Enabled = false;
        }

        private void bt_Z_Click(object sender, EventArgs e)
        {
            Hienchu(this, "Z");
            Thongbao("Z");
            bt_Z.Enabled = false;
        }

        private void lb_Dapanan_Click(object sender, EventArgs e)
        {

            SoundPlayer simpleSound = new SoundPlayer(@"Media\Dapan.wav");

            simpleSound.Play();
            lb_Dapan.Text = File.ReadAllText(@"Game\result.txt").ToUpper();

        }


        int x=12, y = 22, a = 1;
        Random random = new Random();
        private void timer_chaychu_Tick(object sender, EventArgs e)
        {
           try
            {
                x += a;

                lb_Tieude.Location = new Point(x, y);
                if(x >= 800)
                {
                    a = -1;
                    lb_Tieude.ForeColor=Color.FromArgb(random.Next(0,255), random.Next(0,255),random.Next(0,255));
                }
                if (x <= 12)
                {
                    a = 1;
                    lb_Tieude.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }

            }
            catch(Exception ex)
            { }

        }
    }
}