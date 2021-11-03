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
    public partial class fmQLsanbay : Form
    {
        public fmQLsanbay()
        {
            InitializeComponent();
        }

        private void btm_sreach_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void fmQLsanbay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLLichTrinhchuyenbayDataSet2.Routes' table. You can move, or remove it, as needed.
            this.routesTableAdapter.Fill(this.qLLichTrinhchuyenbayDataSet2.Routes);

        }
    }
}
