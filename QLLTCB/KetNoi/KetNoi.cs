using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLTCB.KetNoi
{
    class KetNoi
    {
        string ConnectionString = "";
        SqlConnection con;
        public KetNoi() { }
        //khởi tạo kết nối
        public void Khoitaoketnoi() {
            con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\C#\QLLTCB\QLLTCB\Appdata\QLLichTrinhchuyenbay.mdf;Integrated Security=True");
            con.Open();
        }
        //đóng kết nôi
        public void DongketNoi() {
            con.Close();
        }
    }
}
