﻿using QLLTCB;
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

        private void button1_Click(object sender, EventArgs e)
        {
            KetNoi con = new KetNoi();
            try
            {
                con.Khoitaoketnoi();
                label3.Text = "kết nối thành công!";
            }
            catch (Exception)
            {
                label3.Text = "kết nối thất bại!";

                throw;
            }
            con.Khoitaoketnoi();
            
            
            
        }
    }
}
