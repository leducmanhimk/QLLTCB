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
        public void LoadDataAircrafts()
        {

            SqlConnection sqlConnection = new SqlConnection();
            string con = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
            sqlConnection = new SqlConnection(con);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            string sql1 = "select * from Aircrafts";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, sqlConnection);
            DataSet ds = new DataSet();
            da1.Fill(ds);

            //chỉnh sửa độ rộng của cột
            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.Columns[0].HeaderText = "Mã máy Bay";
            dataGridView2.Columns[1].HeaderText = "Tên Máy bay";
            dataGridView2.Columns[2].HeaderText = "Mã Số Hiệu";
            dataGridView2.Columns[3].HeaderText = "Tổng số ghế";
            dataGridView2.Columns[4].HeaderText = "Ghế thương mại";
            dataGridView2.Columns[5].HeaderText = "Ghế thương nhân";

            dataGridView2.Columns[0].Width = 50;
            dataGridView2.Columns[1].Width = 50;
            dataGridView2.Columns[2].Width = 50;
            dataGridView2.Columns[3].Width = 50;
            dataGridView2.Columns[4].Width = 50;
            dataGridView2.Refresh();
        }
        public void LoadDataRouts()
        {
           
            SqlConnection sqlConnection = new SqlConnection();
            string con = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
            sqlConnection = new SqlConnection(con);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            string sql = "select * from  Routes";
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlConnection);
            DataSet dsr = new DataSet();
            da.Fill(dsr);
            

            dtgrout.DataSource = dsr.Tables[0];
            dtgrout.Columns[0].HeaderText = "Mã Định Tuyến";
            dtgrout.Columns[1].HeaderText = "Sân bay Đi";
            dtgrout.Columns[2].HeaderText = "Sân bay Đến";
            dtgrout.Columns[3].HeaderText = "Khoảng cách";
            dtgrout.Columns[4].HeaderText = "Thời Gian";

            dtgrout.Columns[0].Width = 60;
            dtgrout.Columns[1].Width = 80;
            dtgrout.Columns[2].Width = 80;
            dtgrout.Columns[3].Width = 60;
            dtgrout.Columns[4].Width = 60;
            dtgrout.Refresh();
            sqlConnection.Close();
        }
        public fmQLsanbay()
        {
            InitializeComponent();
        }

        private void btm_sreach_Click(object sender, EventArgs e)
        {
            string sql;
            SqlCommand cmd;
            try
            {
                SqlConnection sqlConnection = new SqlConnection();
                string con = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
                sqlConnection = new SqlConnection(con);
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                sql = "Select Count(*) From  Routes where ID='" + txt_masanbay.Text + "'";
                cmd = new SqlCommand(sql, sqlConnection);
                int val = (int)cmd.ExecuteScalar();
                if (val > 0)
                {
                    sql = "select * from Routes where ID='" + txt_masanbay.Text + "'";
                    cmd = new SqlCommand(sql, sqlConnection);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(sql, sqlConnection);
                    DataSet dsr = new DataSet();
                    da.Fill(dsr);


                    dtgrout.DataSource = dsr.Tables[0];
                    dtgrout.Columns[0].HeaderText = "Mã Định Tuyến";
                    dtgrout.Columns[1].HeaderText = "Sân bay Đi";
                    dtgrout.Columns[2].HeaderText = "Sân bay Đến";
                    dtgrout.Columns[3].HeaderText = "Khoảng cách";
                    dtgrout.Columns[4].HeaderText = "Thời Gian";

                    dtgrout.Columns[0].Width = 60;
                    dtgrout.Columns[1].Width = 80;
                    dtgrout.Columns[2].Width = 80;
                    dtgrout.Columns[3].Width = 60;
                    dtgrout.Columns[4].Width = 60;
                    dtgrout.Refresh();
                    sqlConnection.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bản ghi!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            


        }
        public void KichHoat()
        {
            txt_masanbay.Enabled = true;
            txt_khoangcach.Enabled = true;
            txt_flighttime.Enabled = true;
            cb_AAID.Enabled = true;
            cb_DPID.Enabled = true;
        }
        //sự kiện bấm vào nút thêm
        private void btn_add_Click(object sender, EventArgs e)
        {
            KichHoat();
        }
       
        //sự kiện bấm vào nút cập nhật
        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlConnection sqlConnection = new SqlConnection();
            string con = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
            sqlConnection = new SqlConnection(con);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            string sql;
            if (dtgrout.Rows.Count == 0)
            {
                MessageBox.Show("không còn dữ liệu", "thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_masanbay.Text == "")
            {
                MessageBox.Show("bạn chưa chọn bản ghi nào!", "thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_DPID.SelectedItem.Equals(cb_AAID.SelectedItem) == true)
            {
                errorProvider1.SetError(cb_AAID, "không được để địa điểm trùng nhau");
                errorProvider1.SetError(cb_DPID, "không được để địa điểm trùng nhau");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                sql = "UPDATE Routes SET DepartureAiportID='" + cb_DPID.SelectedItem + "',ArrivalAiportID='" + cb_AAID.SelectedItem + "',Distance='" + txt_khoangcach.Text.ToString() + "',FlightTime='" + txt_flighttime.Text + "'WHERE ID='" 
                    + txt_masanbay.Text + "'";
                cmd = new SqlCommand(sql, sqlConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa Đổi dữ Liệu thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataRouts();

            }
            catch (Exception)
            {
                MessageBox.Show("Thất bại!,sửa đổi dữ liệu thất bại", "thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }
        //sự kiện khi nạp form
        private void fmQLsanbay_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btm_sreach, "tìm kiếm theo mã định tuyến");
            toolTip1.SetToolTip(btn_update, "chỉnh sủa các thông tin của định tuyến");
            toolTip1.SetToolTip(btn_add, "thêm một bản ghi mới");
            //đặt giá trị mặc định cho cb
            cb_AAID.SelectedItem = cb_AAID.SelectedText = "HAN";
            cb_DPID.SelectedItem = cb_DPID.SelectedText = "HAN";
            //khởi tạo kết nối
            SqlConnection connection = new SqlConnection();
            string connec = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
            connection = new SqlConnection(connec);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            LoadDataRouts();

            LoadDataAircrafts();

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            SqlCommand cmd;
            if (textBox4.Text == "")
            {
                MessageBox.Show("bạn chưa nhập giá trị");
            }

            try
            {
                SqlConnection sqlConnection = new SqlConnection();
                string con = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
                sqlConnection = new SqlConnection(con);
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                sql = "Select Count(*) From Aircrafts where ID like'%" + textBox4.Text + "%'";
                cmd = new SqlCommand(sql, sqlConnection);
                int val = (int)cmd.ExecuteScalar();
                if (val > 0)
                {
                    sql = "select * from Aircrafts where ID like'%" + textBox4.Text + "%' OR Name like '%"+textBox4.Text+"%'";
                    cmd = new SqlCommand(sql, sqlConnection);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da1 = new SqlDataAdapter(sql, sqlConnection);
                    DataSet ds = new DataSet();
                    da1.Fill(ds);

                    //chỉnh sửa độ rộng của cột
                    dataGridView2.DataSource = ds.Tables[0];
                    dataGridView2.Columns[0].HeaderText = "Mã máy Bay";
                    dataGridView2.Columns[1].HeaderText = "Tên Máy bay";
                    dataGridView2.Columns[2].HeaderText = "Mã Số Hiệu";
                    dataGridView2.Columns[3].HeaderText = "Tổng số ghế";
                    dataGridView2.Columns[4].HeaderText = "Ghế thương mại";
                    dataGridView2.Columns[5].HeaderText = "Ghế thương nhân";

                    dataGridView2.Columns[0].Width = 50;
                    dataGridView2.Columns[1].Width = 50;
                    dataGridView2.Columns[2].Width = 50;
                    dataGridView2.Columns[3].Width = 50;
                    dataGridView2.Columns[4].Width = 50;
                    dataGridView2.Refresh();
                    sqlConnection.Close();
                }
                else
                {
                    MessageBox.Show("không tìm thấy máy bay!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            string sql;
            if (txt_masanbay.Text == "")
            {
                errorProvider1.SetError(txt_masanbay, "bạn chưa nhập mã!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txt_khoangcach.Text == "")
            {
                errorProvider1.SetError(txt_khoangcach, "bạn chưa nhập khoảng cách!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txt_flighttime.Text == "")
            {
                errorProvider1.SetError(txt_flighttime, "bạn chưa nhập thời gian!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (cb_DPID.SelectedItem.Equals(cb_AAID.SelectedItem) == true)
            {
                errorProvider1.SetError(cb_AAID, "không được để địa điểm trùng nhau");
                errorProvider1.SetError(cb_DPID, "không được để địa điểm trùng nhau");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }


            SqlConnection sqlConnection = new SqlConnection();
            string con = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
            sqlConnection = new SqlConnection(con);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            sql = "Select Count(*) From  Routes where ID='" + txt_masanbay.Text + "'";
            cmd = new SqlCommand(sql, sqlConnection);
            int val = (int)cmd.ExecuteScalar();
            if (val > 0)
            {
                errorProvider1.SetError(txt_masanbay, "mã đã tồn tại trong cơ sở dũ liệu");
                return;
            }
            sql = "INSERT INTO Routes(ID,DepartureAiportID,ArrivalAiportID,Distance,FlightTime)VALUES (";
            sql += "N'" + txt_masanbay.Text + "','" + cb_DPID.SelectedItem + "','" + cb_AAID.SelectedItem + "','" + txt_khoangcach.Text + "','" + txt_flighttime.Text + "')";

            cmd = new SqlCommand(sql, sqlConnection);
            cmd.ExecuteNonQuery();
            LoadDataRouts();
            sqlConnection.Close();
            MessageBox.Show("bạn đã thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //sự kiện khi người dùng kick và bản ghi
        private void dtgrout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_masanbay.Text = dtgrout[0, e.RowIndex].Value.ToString();
                cb_DPID.ValueMember = dtgrout[1, e.RowIndex].Value.ToString();
                cb_AAID.ValueMember = dtgrout[2, e.RowIndex].Value.ToString();
                txt_khoangcach.Text = dtgrout[3, e.RowIndex].Value.ToString();
                txt_flighttime.Text = dtgrout[4, e.RowIndex].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
