﻿using QLLTCB.KetNoi;
using QuanLyLichTrinhChuyenBay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLTCB
{
    public partial class fmMain : Form
    {
        private Form currenChildForm;
        string Temail = "", Tname = "",Tphone="";
        
        public fmMain()
        {
            InitializeComponent();
        }
        public fmMain(string Email, string Name,string Phone)
        {
            InitializeComponent();
            this.Temail = Email;
            this.Tname = Name;
            this.Tphone = Phone;         
        }
        //sự kiện khi kick vào nút  thoát
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        //hàm mở form con từ panel
        private void OpenChildForm(Form childform) {
            currenChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelchild.Controls.Add(childform);
            panelchild.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        //sự kiện khi ấn vào nút lịch trình bay
        private void btn_lichbay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmLichTrinhBay());
        }

        //sự kiện load trang
        private void fmMain_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1050, 622);
            OpenChildForm(new fmLichTrinhBay());
            toolTip1.SetToolTip(btn_lichbay, "hiển thị thông tin về lịch bay");
            toolTip1.SetToolTip(btn_sanbay, "hiển thị thông tin về sân bay!");
            toolTip1.SetToolTip(btn_taikhoan, "quản lý thông tin về tài khoản");
            toolTip1.SetToolTip(btn_thoat, "thoát khỏi ứng dụng");
            toolTip1.SetToolTip(btn_admin, "quản lý thông tin người dùng");
            toolTip1.SetToolTip(btn_dangxuat, "đăng xuất khỏi chương trình");
            toolTip1.SetToolTip(bnt_export, "áp dụng thay đổi lịch");
        }
        //sự kiện khi kich vào nút sân bay
        private void btn_sanbay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmQLsanbay());
            connect con = new connect();
        }
        //sự kiện khi kick vào nút admin
        private void btn_admin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmQLAdmin());

        }
        //sự kiện khi kich vào nút tài khoản
        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmthongtincanhan(Temail,Tname,Tphone));
        }

        private void bnt_export_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmcsv());
        }

        //sự kiện khi kick nào nút đẵng xuất
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
             dialog = MessageBox.Show("Bạn có chắc là sẽ Đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                //tắt phiên người dùng hiện tại và mớ một phiên mới
                Application.Restart();
            } 
        }
    }
}
