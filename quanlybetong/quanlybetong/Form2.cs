using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlybetong
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           var d= cls_Bien.DanhSachBeTong[0];
        }
    }
}
