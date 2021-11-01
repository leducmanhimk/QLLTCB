
namespace QLLTCB
{
    partial class fmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_lichbay = new System.Windows.Forms.Button();
            this.btn_sanbay = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_taikhoan = new System.Windows.Forms.Button();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelchild = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_lichbay);
            this.panel1.Controls.Add(this.btn_sanbay);
            this.panel1.Controls.Add(this.btn_admin);
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.btn_taikhoan);
            this.panel1.Controls.Add(this.btn_dangxuat);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 763);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 129);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_lichbay
            // 
            this.btn_lichbay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_lichbay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_lichbay.Image = ((System.Drawing.Image)(resources.GetObject("btn_lichbay.Image")));
            this.btn_lichbay.Location = new System.Drawing.Point(26, 135);
            this.btn_lichbay.Name = "btn_lichbay";
            this.btn_lichbay.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_lichbay.Size = new System.Drawing.Size(232, 77);
            this.btn_lichbay.TabIndex = 2;
            this.btn_lichbay.Text = "Lịch Trình Bay";
            this.btn_lichbay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_lichbay.UseVisualStyleBackColor = true;
            this.btn_lichbay.Click += new System.EventHandler(this.btn_lichbay_Click);
            // 
            // btn_sanbay
            // 
            this.btn_sanbay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_sanbay.Image = ((System.Drawing.Image)(resources.GetObject("btn_sanbay.Image")));
            this.btn_sanbay.Location = new System.Drawing.Point(26, 232);
            this.btn_sanbay.Name = "btn_sanbay";
            this.btn_sanbay.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_sanbay.Size = new System.Drawing.Size(232, 86);
            this.btn_sanbay.TabIndex = 3;
            this.btn_sanbay.Text = "    Sân bay của tôi";
            this.btn_sanbay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sanbay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sanbay.UseVisualStyleBackColor = true;
            // 
            // btn_admin
            // 
            this.btn_admin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_admin.Image = ((System.Drawing.Image)(resources.GetObject("btn_admin.Image")));
            this.btn_admin.Location = new System.Drawing.Point(26, 346);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_admin.Size = new System.Drawing.Size(232, 86);
            this.btn_admin.TabIndex = 4;
            this.btn_admin.Text = "Admins";
            this.btn_admin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_admin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_admin.UseVisualStyleBackColor = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(26, 671);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_thoat.Size = new System.Drawing.Size(232, 86);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_taikhoan
            // 
            this.btn_taikhoan.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_taikhoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_taikhoan.Image")));
            this.btn_taikhoan.Location = new System.Drawing.Point(26, 451);
            this.btn_taikhoan.Name = "btn_taikhoan";
            this.btn_taikhoan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_taikhoan.Size = new System.Drawing.Size(232, 86);
            this.btn_taikhoan.TabIndex = 5;
            this.btn_taikhoan.Text = "Tài khoản của tôi";
            this.btn_taikhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_taikhoan.UseVisualStyleBackColor = true;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_dangxuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_dangxuat.Image")));
            this.btn_dangxuat.Location = new System.Drawing.Point(26, 558);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_dangxuat.Size = new System.Drawing.Size(232, 86);
            this.btn_dangxuat.TabIndex = 6;
            this.btn_dangxuat.Text = "đăng xuất";
            this.btn_dangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(279, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1005, 80);
            this.panel3.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(572, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(626, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(580, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // panelchild
            // 
            this.panelchild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchild.Location = new System.Drawing.Point(279, 80);
            this.panelchild.Name = "panelchild";
            this.panelchild.Size = new System.Drawing.Size(1005, 683);
            this.panelchild.TabIndex = 11;
            // 
            // fmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 763);
            this.Controls.Add(this.panelchild);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Lịch Trình Chuyến Bay";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_lichbay;
        private System.Windows.Forms.Button btn_sanbay;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_taikhoan;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelchild;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}