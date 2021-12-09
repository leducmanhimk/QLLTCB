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
        string strNhan2;
        public fmthongtincanhan()
        {
            InitializeComponent();

        }
        public fmthongtincanhan(string giatrinhan, string giatrinhan1, string giatrinhan2) : this()
        {
            strNhan = giatrinhan;
            txbEmail.Text = strNhan;
            strNhan1 = giatrinhan1;
            txbName.Text = strNhan1;
            strNhan2 = giatrinhan2;
            txbPhone.Text = strNhan2;
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
            txbName.Enabled = false;
            txbPhone.Enabled = false;
            txbEmail.Enabled = false;

        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            {
                SqlCommand cmd;
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
                        /*  SqlDataAdapter da1 = new SqlDataAdapter("update Admins set Admin_password=N'" + txbNewPass.Text + "' where Admin_email=N'" + txbEmail.Text.Trim() + "'", sqlConnection);
                          DataTable dt1 = new DataTable();
                          da1.Fill(dt1);
                          MessageBox.Show("Doi mat khau thanh cong !", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     */
                        cmd = new SqlCommand();
                        cmd.CommandText = "fm_doimatkhau";
                        cmd.Connection = sqlConnection;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@newpass", txbNewPass.Text);
                        cmd.Parameters.AddWithValue("@email", txbEmail.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da1.Fill(ds);
                        DialogResult dialog = new DialogResult();
                        dialog=MessageBox.Show("Doi mat khau thanh cong !", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog == DialogResult.OK)
                        {
                            //tắt phiên người dùng hiện tại và mớ một phiên mới
                            Application.Restart();
                        }
                    }
                    else
                    {
                        MessageBox.Show(" NewPass và Reen không trùng hoặc bạn chưa nhập liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(" Bạn chưa nhập liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}