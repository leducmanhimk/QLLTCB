using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QLLTCB
{
    public partial class fmthongtincanhan : Form
    {
        string strNhan;
        string strNhan1;
        public fmthongtincanhan()
        {
            InitializeComponent();

        }
        public fmthongtincanhan(string giatrinhan, string giatrinhan1) : this()
        {
            strNhan = giatrinhan;
            txbEmail.Text = strNhan;
            strNhan1 = giatrinhan1;
            txbName.Text = strNhan1;
        }

        private void fmthongtincanhan_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            string connect = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
            sqlConnection = new SqlConnection(connect);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            
        }

        
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            {
                SqlConnection sqlConnection = new SqlConnection();
                string connect = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
                sqlConnection = new SqlConnection(connect);
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                SqlDataAdapter da = new SqlDataAdapter("select * from Admins where Admin_email=N'" + txbEmail.Text.Trim() + "'and Admin_password=N'" + txbPass.Text.Trim() + "'", sqlConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (txbNewPass.Text == txbReen.Text)
                    {
                        SqlDataAdapter da1 = new SqlDataAdapter("update Admins set Admin_password=N'" + txbNewPass.Text + "' where Admin_email=N'" + txbEmail.Text.Trim() + "'", sqlConnection);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        MessageBox.Show("Doi mat khau thanh cong !", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show(" mat khau chua duoc nhap hoac mat khau nhap lai chua dung!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(" !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}