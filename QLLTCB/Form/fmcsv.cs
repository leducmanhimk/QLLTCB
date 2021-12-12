using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLTCB
{
    public partial class fmcsv : Form
    {
        public fmcsv()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            fmLichTrinhBay fmLichTrinhBay = new fmLichTrinhBay();
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
            fmLichTrinhBay.Sld_dtg.DataSource = set.Tables[0];
            if (fmLichTrinhBay.Sld_dtg.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = fmLichTrinhBay.Sld_dtg.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[fmLichTrinhBay.Sld_dtg.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += fmLichTrinhBay.Sld_dtg.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < fmLichTrinhBay.Sld_dtg.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += fmLichTrinhBay.Sld_dtg.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("xuất dữ liệu thành công !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("lỗi :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            int count = 0;
            int count1 = 0;
            int count2 = 0;
            SqlConnection sqlConnection = new SqlConnection();
            string con = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
            sqlConnection = new SqlConnection(con);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }         
            string[] rawtext = System.IO.File.ReadAllLines(label2.Text);
            string[] data = null;
            string chu = "";
            try
            {
                foreach (string textinline in rawtext)
                {
                    //MessageBox.Show(textinline);
                    
                    data = textinline.Split(',');
                    chu = data[0];
                    if (data.Count() == 10)
                    {
                        
                       
                        if (chu.Equals("ADD"))
                        {
                            cmd = new SqlCommand();
                            cmd.CommandText = "SH_themlichbay";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = sqlConnection;
                            cmd.Parameters.AddWithValue("@machuyenbay", data[1].ToString().Trim());
                            cmd.Parameters.AddWithValue("@ngaybay", data[2]);
                            cmd.Parameters.AddWithValue("@thoigian", data[3]);
                            cmd.Parameters.AddWithValue("@mamaybay", data[4]);
                            cmd.Parameters.AddWithValue("@matuyenbay", data[5]);
                            cmd.Parameters.AddWithValue("@sohieubay", data[6]);
                            cmd.Parameters.AddWithValue("@giathuongmai", data[7]);
                            cmd.Parameters.AddWithValue("@tinhtrang", data[9]);
                            cmd.ExecuteNonQuery();
                            count++;
                        }
                        if (chu.Equals("EDIT"))
                        {
                            cmd = new SqlCommand();
                            cmd.CommandText = "SH_suatuyenbay";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = sqlConnection;
                            cmd.Parameters.AddWithValue("@machuyenbay", data[1].ToString().Trim());
                            cmd.Parameters.AddWithValue("@ngaybay", data[2]);
                            cmd.Parameters.AddWithValue("@thoigian", data[3]);
                            cmd.Parameters.AddWithValue("@mamaybay", data[4]);
                            cmd.Parameters.AddWithValue("@matuyenbay", data[5]);
                            cmd.Parameters.AddWithValue("@sohieubay", data[6]);
                            cmd.Parameters.AddWithValue("@giathuongmai", data[7]);
                            cmd.Parameters.AddWithValue("@tinhtrang", data[9]);
                            cmd.ExecuteNonQuery();
                            count1++;
                        }
                    }
                    else
                    {
                        count2++;
                    }
                }
                label3.Text = "Số bản ghi thêm mới:" + count;
                label4.Text = "Số bản ghi được sửa" + count1;
                label6.Text = "Số bản ghi thiếu dữ liệu" + count2;
                MessageBox.Show("Import thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi" + ex.Message, "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = ".csv";
            openFile.Filter = "Comma Separated (*.csv)|*.csv";
            openFile.ShowDialog();
            label2.Text = openFile.FileName;
        }
    }
    
}
