﻿using System;
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
    public partial class fmQLAdmin : Form
    {
        public fmQLAdmin()
        {
            InitializeComponent();
        }
        //hien form admin
        private void fmQLAdmin_Load(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlConnection sqlConnection = new SqlConnection();
            string con = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
            sqlConnection = new SqlConnection(con);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "AD_hienAdmin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection;
            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataSet set = new DataSet();
            sqlData.Fill(set);
            dgv1.DataSource = set.Tables[0];
            txtMaAdmin.Enabled = false;
            txtTenAdmin.Enabled = false;
            txtEmail.Enabled = false;
            txtDienThoai.Enabled = false;
            txtPass.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
        //sự kiện khi ấn nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaAdmin.Enabled = true;
            txtTenAdmin.Enabled = true;
            txtEmail.Enabled = true;
            txtDienThoai.Enabled = true;
            txtPass.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            ResetValue();// xóa trắng text box
            txtMaAdmin.Enabled = true; //cho phép nhập mới
            txtMaAdmin.Focus();
        }
        //sự kiện khi ấn nút lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            string sql;
            if (txtMaAdmin.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenAdmin.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Bạn chưa điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //khởi tạo sql
            SqlConnection sqlConnection = new SqlConnection();
            string con = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
            sqlConnection = new SqlConnection(con);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            sql = "Select Count(*) From  Routes where ID='" + txtMaAdmin.Text + "'";
            cmd = new SqlCommand(sql, sqlConnection);
            int val = (int)cmd.ExecuteScalar();
            if (val > 0)
            {
                MessageBox.Show("mã admin đã tồn tại trong cơ sở dũ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //thực thi sql 

            cmd = new SqlCommand();
            cmd.CommandText = "AD_themAdmin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection;
            cmd.Parameters.AddWithValue("@maadmin", txtMaAdmin.Text);
            cmd.Parameters.AddWithValue("@tenadmin", txtTenAdmin.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@dienthoai", txtDienThoai.Text);
            cmd.Parameters.AddWithValue("@matkhau", txtPass.Text);
            cmd.ExecuteNonQuery();
            Loaddataform();
            sqlConnection.Close();
            MessageBox.Show("bạn đã thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // sự kiện khi ấn nút hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            HideText();
        }
        // sự kiện khi ấn nút xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtMaAdmin.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE Admin WHERE ID=N'" + txtMaAdmin.Text + "'";
                LoadDataGridView();
                ResetValue();
            }
            ResetValue();
            HideText();
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }
        // hiện data from admins
        public void Loaddataform()
        {

            SqlConnection sqlConnection = new SqlConnection();
            string con = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
            sqlConnection = new SqlConnection(con);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            string sql = "select * from  Admins";
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlConnection);
            DataSet dsr = new DataSet();
            da.Fill(dsr);


            dgv1.DataSource = dsr.Tables[0];
            dgv1.Columns[0].HeaderText = "Mã admin";
            dgv1.Columns[1].HeaderText = "Tên admin";
            dgv1.Columns[2].HeaderText = "Email";
            dgv1.Columns[3].HeaderText = "Điện thoại";
            dgv1.Columns[4].HeaderText = "Mật khẩu";

            dgv1.Columns[0].Width = 60;
            dgv1.Columns[1].Width = 100;
            dgv1.Columns[2].Width = 100;
            dgv1.Columns[3].Width = 60;
            dgv1.Columns[4].Width = 60;
            dgv1.Refresh();
            sqlConnection.Close();
        }
        // ẩn button
        private void HideText()
        {
            txtMaAdmin.Enabled = false;
            txtTenAdmin.Enabled = false;
            txtEmail.Enabled = false;
            txtDienThoai.Enabled = false;
            txtPass.Enabled = false;
        }
        // cho phép nhập mới
        private void ResetValue()
        {
            txtMaAdmin.Text = "";
            txtTenAdmin.Text = "";
            txtEmail.Text = "";
            txtDienThoai.Text = "";
            txtPass.Text = "";
        }
        // tùy chỉnh dgv
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT ID,Admin_name,Admin_email,Admin_phone,Admin_password FROm Admins";

            dgv1.Columns[0].HeaderText = "Mã admin";
            dgv1.Columns[1].HeaderText = "Tên admin";
            dgv1.Columns[2].HeaderText = "Điện thoại";
            dgv1.Columns[3].HeaderText = "Email";
            dgv1.Columns[4].HeaderText = "Mật khẩu";
            dgv1.Columns[0].Width = 100;
            dgv1.Columns[1].Width = 150;
            dgv1.Columns[2].Width = 150;
            dgv1.Columns[3].Width = 100;
            dgv1.Columns[4].Width = 100;
            dgv1.AllowUserToAddRows = false;
            dgv1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

    }
}