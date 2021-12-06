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
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
        private DataTable GetDataFromFile()
        {

            DataTable importedData = new DataTable();
            string header = "ID,Date,Time,AircraftID,RouteID,FlightNumber,";

            try
            {
                using (StreamReader sr = new StreamReader(label2.Text))
                {
                    if (string.IsNullOrEmpty(header))
                    {
                        header = sr.ReadLine();
                    }

                    string[] headerColumns = header.Split(',');
                    foreach (string headerColumn in headerColumns)
                    {
                        importedData.Columns.Add(headerColumn);
                    }

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (string.IsNullOrEmpty(line)) continue;
                        string[] fields = line.Split(',');
                        DataRow importedRow = importedData.NewRow();

                        for (int i = 0; i < fields.Count(); i++)
                        {

                            importedRow[i] = fields[i];

                        }

                        importedData.Rows.Add(importedRow);
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("the file could not be read:");
                Console.WriteLine(e.Message);
            }

            return importedData;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            DataTable imported_data = GetDataFromFile();

            if (imported_data == null) return;

            

            MessageBox.Show("load data succ.....!");
            
            Cursor = Cursors.Default;
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
