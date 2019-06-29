using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace CHIEC_NOI_KI_DIEU
{
    public partial class uc_ThietLap : UserControl
    {

        private static uc_ThietLap _TL;

        public static uc_ThietLap ThietLap
        {
            get
            {
                if (_TL == null)
                {
                    _TL = new uc_ThietLap();

                }
                return _TL;
            }
        }

        public string cauhoi { get { return txt_cauhoi.Text; } }
        public string dapan { get { return txt_dapan.Text; } }

        public uc_ThietLap()
        {
            InitializeComponent();
            //Nhacnen();

        }



     

        private void bt_Choi_Click(object sender, EventArgs e)
        {
           

            try
            {
                string Ghi = txt_dapan.Text;
                string directoryPath = txt_duongdan.Text;
              
                string filePath = directoryPath + @"\result.txt";
                System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create);

                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);//fs là 1 FileStream 
                sWriter.WriteLine(Ghi);
                sWriter.Flush();
                fs.Close();

                string filePath1 = Application.StartupPath + @"\game.txt";
                string Ghi1 = txt_duongdan.Text;
                if (System.IO.File.Exists(filePath))
                {
                    File.Delete(filePath1);
                    System.IO.FileStream fs1 = new System.IO.FileStream(filePath1, System.IO.FileMode.Create);

                    StreamWriter sWriter1 = new StreamWriter(fs1, Encoding.UTF8);//fs là 1 FileStream 
                    sWriter1.WriteLine(Ghi1);
                    sWriter1.Flush();
                    fs1.Close();

                }
                else
                {
                    System.IO.FileStream fs1 = new System.IO.FileStream(filePath, System.IO.FileMode.Create);
                }
                frm_Trochoi Trochoi = new frm_Trochoi();
                Trochoi.cauhoi = cauhoi;
                Trochoi.ShowDialog();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                txt_cauhoi.ResetText();
                txt_dapan.ResetText();
                txt_duongdan.ResetText();
                txt_linkhinh.ResetText();
                txt_tenhinh.ResetText();
                txt_tenqua.ResetText();
                txt_ghihinh.ResetText();
                txt_ghitenqua.ResetText();
                lb_SL.Text = "0";
            }

        }


        public void DeleteFolder(string path)
        {
            DirectoryInfo dir2delete = new DirectoryInfo(path);
            foreach (FileInfo file in dir2delete.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in dir2delete.GetDirectories())
            {
                dir.Delete(true);
            }
        }
        private void bt_taofolder_Click(object sender, EventArgs e)
        {

            try
            {

                string directoryPath = "Game";
                if (System.IO.Directory.Exists(directoryPath))
                    {
                            DeleteFolder(Application.StartupPath + @"\" + directoryPath);
                            System.IO.Directory.CreateDirectory(directoryPath);
                            txt_duongdan.Text = Application.StartupPath + @"\" + directoryPath;
                     }
                    else
                    {
                        System.IO.Directory.CreateDirectory(directoryPath);
                        txt_duongdan.Text = Application.StartupPath + @"\" + directoryPath;

                    }
                       
               
              
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
          //  oFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (oFile.ShowDialog() == DialogResult.OK)
            {

                txt_linkhinh.Text = System.IO.Path.GetDirectoryName(oFile.FileName);       
                txt_tenhinh.Text = System.IO.Path.GetFileName(oFile.FileName);
                txt_tenqua.Enabled = true;
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            try
            {
                int C = int.Parse(lb_SL.Text.ToString());
                string A = txt_ghihinh.Text;
                string B = txt_ghitenqua.Text;
               if( txt_linkhinh.Text =="" || txt_tenhinh.Text=="")
                {
                    throw new Exception("Bạn chưa chọn hình.");
                }
               else
                {

                    string fileName = txt_tenhinh.Text;
                    string sourcePath =txt_linkhinh.Text;
                    string targetPath = txt_duongdan.Text;
                    //Combine file và đường dẫn
                    string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                    string destFile = System.IO.Path.Combine(targetPath, fileName);
                    //Copy file từ file nguồn đến file đích
                    System.IO.File.Copy(sourceFile, destFile, true);
                    if(A=="" && B=="")
                    {
                        txt_ghihinh.Text = txt_tenhinh.Text;
                        txt_ghitenqua.Text = txt_tenqua.Text;
                    }
                    else
                    {
                        txt_ghihinh.Text =  A+ "," +txt_tenhinh.Text;
                        txt_ghitenqua.Text = B + "," + txt_tenqua.Text;
                    }
                    C = C + 1;
                    lb_SL.Text = C.ToString();
                    MessageBox.Show("Lưu hình thành công!");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                txt_linkhinh.ResetText();
                txt_tenhinh.ResetText();
                txt_tenqua.ResetText();
                txt_tenqua.Enabled = false;
            }
        }

        private void bt_ghihinh_Click(object sender, EventArgs e)
        {
            try
            {

                string directoryPath = txt_duongdan.Text;
                string Ghi = txt_ghihinh.Text.ToString();
                if (txt_ghihinh.Text=="")
                {
                    throw new Exception("Bạn chưa có thông tin hình ảnh.");
                }
                else
                {
                    string filePath = directoryPath + @"\image.txt";
                    System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create);


                    StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);//fs là 1 FileStream 
                    sWriter.WriteLine(Ghi);
                    sWriter.Flush();
                    fs.Close();

                    MessageBox.Show("Ghi thành công!");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void bt_ghiqua_Click(object sender, EventArgs e)
        {
            try
            {

                string directoryPath = txt_duongdan.Text;
                string Ghi = txt_ghitenqua.Text.ToString();
                if (txt_ghitenqua.Text=="")
                {
                    throw new Exception("Bạn chưa có thông tin tên qua tặng.");
                }
                else
                {

                    string filePath = directoryPath + @"\gift.txt";
                    System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create);

                    StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);//fs là 1 FileStream 
                    sWriter.WriteLine(Ghi);
                    sWriter.Flush();
                    fs.Close();

                    MessageBox.Show("Ghi thành công!");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
