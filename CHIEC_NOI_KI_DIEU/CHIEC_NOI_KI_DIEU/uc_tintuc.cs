using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Media;



namespace CHIEC_NOI_KI_DIEU
{
    public partial class uc_tintuc : UserControl
    {


        private static uc_tintuc _TL;
     
        public static uc_tintuc ThietLap
        {
            get
            {
                if (_TL == null)
                {
                    _TL = new uc_tintuc();

                }
                return _TL;
            }
        }
        public uc_tintuc()
        {
            InitializeComponent();
            Nhacnen();
          
        }

        public void Nhacnen()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"Media\nhacnen1.wav");

            simpleSound.Play();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
