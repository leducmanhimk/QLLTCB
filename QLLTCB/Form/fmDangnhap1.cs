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
        fmMain ma = new fmMain();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox1, "bạn chưa điền tên tài khoản!");
                return;
            }
           
            else
            {
                errorProvider1.Clear();
            }
            if (textBox2.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox2, "bạn chưa điền mật khẩu!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            connect con = new connect();
            try
            {
               
                con.Khoitaoketnoi();
                
                this.Hide();
                ma.Show();
                con.DongketNoi();
            }
            catch (Exception)
            {
                label3.Text = "kết nối thất bại!";

                throw;
            }
            
            
            
            
        }
    }
}
