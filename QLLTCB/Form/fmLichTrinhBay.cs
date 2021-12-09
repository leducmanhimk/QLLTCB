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
    public partial class fmLichTrinhBay : Form
    {
        public fmLichTrinhBay()
        {
            InitializeComponent();
            
        }
        //sự kiện lọc chuyến bay
        private void button1_Click_1(object sender, EventArgs e)
        {
            dtpnayloc. Format = DateTimePickerFormat.Short;
            DateTime loc;
            loc = dtpnayloc.Value;
            string sql;
            SqlCommand cmd;
            if (cb_diemdi.SelectedItem.Equals(cb_diemden.SelectedItem) == true)
            {
                errorProvider1.SetError(cb_diemdi, "không được để địa điểm trùng nhau");
                errorProvider1.SetError(cb_diemden, "không được để địa điểm trùng nhau");
                return;
            }
            else
            {
                errorProvider1.Clear();
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
                //kiểm tra trước xem có tồn tại bản ghi không
                sql = "Select Count(*) From Schedules where FlightNumber='" + txt_sohieubay.Text + "'";
                cmd = new SqlCommand(sql, sqlConnection);
                int val = (int)cmd.ExecuteScalar();
                if (val > 0)
                {
                    
                    cmd.CommandText = "AC_TimSHB";
                    cmd.Connection = sqlConnection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@makemodel", txt_sohieubay.Text);
                    cmd.Parameters.AddWithValue("@diemdi", cb_diemdi.SelectedItem);
                    cmd.Parameters.AddWithValue("@diemden", cb_diemden.SelectedItem);
                    cmd.Parameters.AddWithValue("@loc", loc);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da1.Fill(ds);
                    Sld_dtg.DataSource = ds.Tables[0];
           
            
            //setup các cột
                  //  Sld_dtg.Columns[8].Visible = false;
                    Sld_dtg.Columns[0].HeaderText = "Mã";
                    Sld_dtg.Columns[1].HeaderText = "ngày bay";
                    Sld_dtg.Columns[2].HeaderText = "thời gian";
                    Sld_dtg.Columns[3].HeaderText = "mã sân bay đi";
                    Sld_dtg.Columns[4].HeaderText = "mã sân bay đến";
                    Sld_dtg.Columns[5].HeaderText = "số hiệu";
                    Sld_dtg.Columns[6].HeaderText = "số ghế";
                    Sld_dtg.Columns[7].HeaderText = "giá thương mại";
                   
                    Sld_dtg.Columns[0].Width = 75;                  
                    Sld_dtg.Refresh();
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

        private void fmLichTrinhBay_Load(object sender, EventArgs e)
        {
            cb_diemden.SelectedItem = cb_diemden.SelectedText = "HAN";
            cb_diemdi.SelectedItem = cb_diemdi.SelectedText = "HAN";
            
            SqlCommand cmd;
            SqlConnection sqlConnection = new SqlConnection();
            string con = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
            sqlConnection = new SqlConnection(con);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "LT_hienthiall";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection;
            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataSet set = new DataSet();
            sqlData.Fill(set);
            Sld_dtg.DataSource = set.Tables[0];
            
            //setup các cột
            Sld_dtg.Columns[8].Visible = false;
            Sld_dtg.Columns[0].HeaderText = "Mã";
            Sld_dtg.Columns[0].Width = 75;
            Sld_dtg.Columns[1].HeaderText = "ngày bay";
            Sld_dtg.Columns[2].HeaderText = "thời gian";
            Sld_dtg.Columns[3].HeaderText = "mã sân bay đi";
            Sld_dtg.Columns[4].HeaderText = "mã sân bay đến";
            Sld_dtg.Columns[5].HeaderText = "số hiệu";
            Sld_dtg.Columns[6].HeaderText = "số ghế";
            Sld_dtg.Columns[7].HeaderText = "giá thương mại";
            Sld_dtg.Refresh();
           
        }

        public void LoadSD()
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
            cmd.CommandText = "LT_hienthiall";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection;
            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataSet set = new DataSet();
            sqlData.Fill(set);
            Sld_dtg.DataSource = set.Tables[0];

            Sld_dtg.Columns[8].Visible = false;
            Sld_dtg.Columns[0].HeaderText = "Mã";
            Sld_dtg.Columns[0].Width = 75;
            Sld_dtg.Columns[1].HeaderText = "ngày bay";
            Sld_dtg.Columns[2].HeaderText = "thời gian";
            Sld_dtg.Columns[3].HeaderText = "mã sân bay đi";
            Sld_dtg.Columns[4].HeaderText = "mã sân bay đến";
            Sld_dtg.Columns[5].HeaderText = "số hiệu";
            Sld_dtg.Columns[6].HeaderText = "số ghế";
            Sld_dtg.Columns[7].HeaderText = "giá thương mại";
            Sld_dtg.Refresh();
            
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            string con = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
            sqlConnection = new SqlConnection(con);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            //lấy giá trị cofim
            bool value = true;
            if (this.Sld_dtg.SelectedRows.Count == 1)
            {
                int count = Sld_dtg.CurrentCell.RowIndex;
                value = (bool)Sld_dtg.Rows[count].Cells[8].Value;
            }
            if (value == true)
            {
                //sự kiện hủy chuyesn bán
                DialogResult dialog = MessageBox.Show("bạn muốn hủy chuyến bay này chứ!", "hủy chuyến bay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in Sld_dtg.Rows)
                    {

                        if (this.Sld_dtg.SelectedRows.Count == 1)
                        {//thay đổi cột thành màu đỏ
                            int count = Sld_dtg.CurrentCell.RowIndex;
                            Sld_dtg.Rows[count].DefaultCellStyle.BackColor = Color.Red;
                            Sld_dtg.Rows[count].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                    //string sql = "UPDATE Schedules SET Confirmed = 0 Where ID like'%" + txt_malich.Text + "%'";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "LT_doitrangthaichuyenbay";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = sqlConnection;
                    cmd.Parameters.AddWithValue("@malichbay", txt_malich.Text.Trim());
                    cmd.Parameters.Add("@giatri",SqlDbType.Int).Value = 0;
                    cmd.ExecuteNonQuery();
                    LoadSD();
                   
                }
            }
                if(value == false)
                {
                DialogResult dialog1 = MessageBox.Show("bạn muốn kích hoạt chuyến bay này chứ!", "kích hoạt chuyến bay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                foreach (DataGridViewRow row1 in Sld_dtg.Rows)
                    {
                        if (dialog1 == DialogResult.Yes)
                        {
                            if (this.Sld_dtg.SelectedRows.Count == 1)
                            {//thay đổi cột thành màu trắng

                                int count = Sld_dtg.CurrentCell.RowIndex;
                                Sld_dtg.Rows[count].DefaultCellStyle.BackColor = Color.Aqua;
                                Sld_dtg.Rows[count].DefaultCellStyle.ForeColor = Color.Black;       
                            }
                        }
                        //string sql = "UPDATE Schedules SET Confirmed = 1 Where ID like'%" + txt_malich.Text + "%'";
                        SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "LT_doitrangthaichuyenbay";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = sqlConnection;
                    cmd.Parameters.AddWithValue("@malichbay", txt_malich.Text.Trim());
                    cmd.Parameters.Add("@giatri", SqlDbType.Int).Value = 1;
                    cmd.ExecuteNonQuery();
                    LoadSD();
                   
                }
                }
        }
        //sự kiện khi nguoiwfw dùng kick vào bản ghi
        private void Sld_dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //lấy giá trị tương ứng với row đang được chọn
                txt_malich.Text = Sld_dtg[0, e.RowIndex].Value.ToString();
                dtpsuangaybay.Value = (DateTime)Sld_dtg[1, e.RowIndex].Value;
                txt_thoigian.Text = Sld_dtg[2, e.RowIndex].Value.ToString();
               
                txt_giathuongmai.Text = Sld_dtg[7, e.RowIndex].Value.ToString();
                //kiểm tra tình trạng chuyến bay
                bool value1 = (bool)Sld_dtg[8,e.RowIndex].Value;                
                    if (value1 == false)
                    {
                        
                        btn_huy.Text = "kích hoạt";
                    }
                    else
                    {
                        btn_huy.Text = "Hủy chuyến bay";
                    }       
                    //

            }
            catch (Exception)
            {

                throw;
            }
        }
        //sự kiện kiểm tra confim chuyến bay
        private void Sld_dtg_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < Sld_dtg.Rows.Count; i++)
            {
                //thay đổi cột thành màu đỏ nếu giá trị confim là flase
                bool value = (bool)Sld_dtg.Rows[i].Cells[8].Value;
                if (value == false)
                {
                    Sld_dtg.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    Sld_dtg.Rows[i].DefaultCellStyle.ForeColor = Color.White;                   
                }
                
            }
           
        }
        //sự kiện bấm vào nút sửa
        private void btn_sua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            
            SqlConnection sqlConnection = new SqlConnection();
            string con = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
            sqlConnection = new SqlConnection(con);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            if (dtpsuangaybay.Value == null)
            {
                errorProvider1.SetError(dtpsuangaybay, "bạn chưa nhập ngày!");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txt_thoigian.Text == "")
            {
               errorProvider1.SetError(txt_thoigian, "bạn chưa nhập thời gian!");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txt_giathuongmai.Text == "")
            {
                errorProvider1.SetError(txt_giathuongmai, "bạn chưa nhập giá!");
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                dtpsuangaybay.Format = DateTimePickerFormat.Short;
               // sql = "UPDATE Schedules SET Date='" + dtpsuangaybay.Value.ToString("MM-dd-yyyy") + "',Time='" + txt_thoigian.Text + "',EconomyPrice='" + txt_giathuongmai.Text.ToString() + "' WHERE ID like'%"+txt_malich.Text+"%'";
                cmd = new SqlCommand();
                cmd.CommandText = "LT_sualich";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = sqlConnection;
                cmd.Parameters.AddWithValue("@ngaybay", dtpsuangaybay.Value.Date);
                cmd.Parameters.AddWithValue("@thoigian", txt_thoigian.Text);
                cmd.Parameters.AddWithValue("@masanbay", txt_malich.Text);
                cmd.Parameters.AddWithValue("@giathuongmai", txt_giathuongmai.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("cập nhật chuyến bay thành công!", "thành Công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSD();
               
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi!", "lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //load lại trang
        private void btn_reset_Click(object sender, EventArgs e)
        {
            LoadSD();
        }
    }
}
