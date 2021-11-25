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
        /// <summary>
        ///
        /// </summary>
        fmMain main = new fmMain();
        private void button1_Click(object sender, EventArgs e)
        {
            //check các ràng buộc liên quan đến nhập dữ liệu
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
                  
                    fmMain fm = new fmMain(dataTable.Rows[0][2].ToString(), dataTable.Rows[0][1].ToString());
                    this.Hide();
                    fm.Show();
                }

                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            //ngoại lệ
            catch (Exception)
            {
                //label3.Text = "kết nối thất bại!";
                throw;
            }
            
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //thoát
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Visible = true;
                textBox1.Text = txt_matkhau.Text;
            }
            else
            {
                textBox1.Visible = false;
            }
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email")
            {
                txt_email.Text = "";
                txt_email.ForeColor = Color.Black;
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
                txt_email.ForeColor = Color.Silver;
            }
        }

        private void txt_matkhau_Enter(object sender, EventArgs e)
        {
            if (txt_matkhau.Text == "Mật khẩu")
            {
                txt_matkhau.Text = "";
                txt_matkhau.ForeColor = Color.Black;
            }
        }

        private void txt_matkhau_Leave(object sender, EventArgs e)
        {
            if (txt_matkhau.Text == "")
            {
                txt_matkhau.Text = "Mật khẩu";
                txt_matkhau.ForeColor = Color.Silver;
            }
        }

        private void fmDangnhap1_Load(object sender, EventArgs e)
        {

        }
    }
}
