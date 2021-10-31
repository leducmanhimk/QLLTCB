using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLTCB.KetNoi
{
    class KetNoi
    {
        SqlConnection con = new SqlConnection();
        public KetNoi() { }
        //khởi tạo kết nối
        public void Khoitaoketnoi() {
           
            string connec = ConfigurationManager.ConnectionStrings["QLLTCB"].ConnectionString;
            con = new SqlConnection(connec);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }           
        }
        //đóng kết nôi
        public void DongketNoi() {
            con.Close();
        }
    }
    
}
