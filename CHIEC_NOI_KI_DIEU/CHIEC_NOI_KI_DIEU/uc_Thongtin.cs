using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CHIEC_NOI_KI_DIEU
{
    public partial class uc_Thongtin : UserControl
    {


        private static uc_Thongtin _TL;

        public static uc_Thongtin ThietLap
        {
            get
            {
                if (_TL == null)
                {
                    _TL = new uc_Thongtin();

                }
                return _TL;
            }
        }
        public uc_Thongtin()
        {
            InitializeComponent();
            khoitao();
            Nhacnen();
        }

        private void khoitao()
        {
            pc_Hinh.Image = Image.FromFile(@"Resources/thongtin.jpg");
        }
        public void Nhacnen()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"Media\nhacnen1.wav");

            simpleSound.Play();

        }
    }
}
