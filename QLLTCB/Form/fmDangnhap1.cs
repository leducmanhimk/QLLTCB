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

namespace QuanLyLichTrinhChuyenBay
{
   
    public partial class fmDangnhap1 : Form
    {
        
        public fmDangnhap1()
        {
            InitializeComponent();
        }
        fmMain main = new fmMain();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_email, "bạn chưa điền tên tài khoản!");
                return;
            }
           
            else
            {
                errorProvider1.Clear();
            }
            if (txt_matkhau.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_matkhau, "bạn chưa điền mật khẩu!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                SqlConnection sqlConnection = new SqlConnection();
                string connect = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
                sqlConnection = new SqlConnection(connect);
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                string sql = "select * from Admins where Admin_email='"+txt_email.Text.Trim()+ "' and Admin_password='"+txt_matkhau.Text.Trim()+"'";
                SqlDataAdapter da = new SqlDataAdapter(sql, sqlConnection);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception)
            {
                label3.Text = "kết nối thất bại!";

                throw;
            }
            
            
            
            
        }
    }
}
