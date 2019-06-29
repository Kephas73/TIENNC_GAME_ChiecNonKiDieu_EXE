using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHIEC_NOI_KI_DIEU
{
    public partial class uc_Home : UserControl
    {


        private static uc_Home _TL;

        public static uc_Home ThietLap
        {
            get
            {
                if (_TL == null)
                {
                    _TL = new uc_Home();

                }
                return _TL;
            }
        }
        public uc_Home()
        {
            InitializeComponent();
            khoitao();
            
        }
        private void khoitao()
        {
            pc_Hinh.Image= Image.FromFile(@"Resources/home.jpg");
        }
    }
}
