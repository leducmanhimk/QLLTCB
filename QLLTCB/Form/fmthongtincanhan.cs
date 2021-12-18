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
            txbPhone.Text = strNhan2.Trim();
            lbname.Text = strNhan1.Trim();
            lbemail.Text = strNhan.Trim();
            lbdienthoai.Text = strNhan2.Trim();
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
            txbEmail.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
           /* SqlConnection sqlConnection = new SqlConnection();
            string connect = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
            sqlConnection = new SqlConnection(connect);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }*/
            try
            {
                SqlConnection sqlConnection = new SqlConnection();
                string connect = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
                sqlConnection = new SqlConnection(connect);
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                    if (txbPass.Text != "")
                    {
                      string sql = "select * from Admins where Admin_email='" + txbEmail.Text.Trim() + "' and Admin_password='" + txbPass.Text.Trim() + "'";
                      SqlDataAdapter da = new SqlDataAdapter(sql, sqlConnection);
                      DataTable dataTable = new DataTable();
                      da.Fill(dataTable);
                    if (dataTable.Rows.Count == 1)
                    {
                        if (txbNewPass.Text == "")
                        {

                            cmd = new SqlCommand();
                            cmd.CommandText = "TTCN_capnhat";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = sqlConnection;
                            cmd.Parameters.AddWithValue("@email", txbEmail.Text);
                            cmd.Parameters.AddWithValue("@name", txbName.Text);
                            cmd.Parameters.AddWithValue("@phone", txbPhone.Text);

                            cmd.ExecuteNonQuery();
                            DialogResult dialog = new DialogResult();
                            dialog = MessageBox.Show("Sửa Đổi dữ Liệu thành công,Mời đăng nhập lại để cập nhật dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialog == DialogResult.OK)
                            {
                                //tắt phiên người dùng hiện tại và mớ một phiên mới
                                Application.Restart();
                            }
                            sqlConnection.Close();
                        }
                        else
                        {
                            if (txbNewPass.Text == txbReen.Text)
                            {
                                cmd = new SqlCommand();
                                cmd.CommandText = "TTCN_capnhatmk";
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Connection = sqlConnection;
                                cmd.Parameters.AddWithValue("@email", txbEmail.Text);
                                cmd.Parameters.AddWithValue("@newpass", txbNewPass.Text);
                                cmd.Parameters.AddWithValue("@name", txbName.Text);
                                cmd.Parameters.AddWithValue("@phone", txbPhone.Text);

                                cmd.ExecuteNonQuery();
                                DialogResult dialog = new DialogResult();
                                dialog = MessageBox.Show("Sửa Đổi dữ Liệu thành công,Mời đăng nhập lại để cập nhật dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (dialog == DialogResult.OK)
                                {
                                    //tắt phiên người dùng hiện tại và mớ một phiên mới
                                    Application.Restart();
                                }
                                sqlConnection.Close();
                            }
                            else
                            {
                                MessageBox.Show("mật khẩu mới và mật khẩu nhập lại không trùng khớp!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu chưa chính xác,mời nhập lại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                  
                }
                
                else
                {
                    MessageBox.Show("Bạn phải nhập mật khẩu để thay đổi thông tin!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thất bại!,sửa đổi dữ liệu thất bại", "thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
    }

