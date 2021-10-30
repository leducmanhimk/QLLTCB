using QLLTCB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLichTrinhChuyenBay
{
   
    public partial class fmDangnhap1 : Form
    {
        public fmDangnhap1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmMain trangchu = new fmMain();
            trangchu.Show();
            this.Hide();
        }
    }
}
