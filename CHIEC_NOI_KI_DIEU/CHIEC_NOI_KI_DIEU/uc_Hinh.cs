using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CHIEC_NOI_KI_DIEU
{
    public partial class uc_Hinh : DevExpress.XtraEditors.XtraUserControl
    {

        private static  uc_Hinh _Hinh;

        public static uc_Hinh Hinh
            {
            get{
                if(_Hinh==null)
                {
                    _Hinh = new uc_Hinh();
                   
                }
                return _Hinh;
            }
            }


        public uc_Hinh()
        {
            InitializeComponent();
         
         
        }
     
    }
}
