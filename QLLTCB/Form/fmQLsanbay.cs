using QLLTCB;
using QLLTCB.KetNoi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            SqlConnection connection = new SqlConnection();
            string connec = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
            connection = new SqlConnection(connec);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string sql = "select * from  Routes";
            SqlDataAdapter da = new SqlDataAdapter(sql,connection);
            DataSet dsr = new DataSet();
            da.Fill(dsr);

            dtgrout.DataSource = dsr.Tables[0];
            dtgrout.Refresh();

            string sql1 = "select * from Aircrafts";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, connection);
            DataSet ds = new DataSet();
            da1.Fill(ds);

            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.Columns[0].Width = 50;
            dataGridView2.Refresh();

        }
    }
}
