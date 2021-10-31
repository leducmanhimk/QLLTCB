using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLTCB
{
    public partial class fmMain : Form
    {
        private Form currenChildForm;
        public fmMain()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //hàm mở form con từ panel
        private void OpenChildForm(Form childform) {
            currenChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelchild.Controls.Add(childform);
            panelchild.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void btn_lichbay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmLichTrinhBay());
        }
    }
}
