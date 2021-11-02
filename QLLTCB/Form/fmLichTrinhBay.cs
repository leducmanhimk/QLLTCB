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
    public partial class fmLichTrinhBay : Form
    {
        public fmLichTrinhBay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bạn đã ấn vào nút này");
        }

        private void fmLichTrinhBay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLLichTrinhchuyenbayDataSet.Schedules' table. You can move, or remove it, as needed.
            this.schedulesTableAdapter.Fill(this.qLLichTrinhchuyenbayDataSet.Schedules);

        }

        
    }
}
