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

        

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("bạn đã ấn vào nút này");
        }

        private void fmLichTrinhBay_Load(object sender, EventArgs e)
        {
            string sql;
            SqlCommand cmd;
            SqlConnection sqlConnection = new SqlConnection();
            string con = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
            sqlConnection = new SqlConnection(con);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            sql = "select Date,Time,DepartureAiportID,ArrivalAiportID,MakeModel,TotalSeats,EconomyPrice from((Schedules INNER JOIN Routes on Schedules.RouteID = Routes.ID)INNER JOIN Aircrafts on Schedules.AircraftID = Aircrafts.ID)";
            SqlDataAdapter sqlData = new SqlDataAdapter(sql,sqlConnection);
            DataSet set = new DataSet();
            sqlData.Fill(set);
            Sld_dtg.DataSource = set.Tables[0];
            Sld_dtg.Refresh();

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Sld_dtg.DefaultCellStyle.BackColor = Color.Red;
        }
    }
}
