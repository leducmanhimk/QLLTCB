
namespace QLLTCB
{
    partial class fmQLsanbay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmQLsanbay));
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrout = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btm_sreach = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_flighttime = new System.Windows.Forms.TextBox();
            this.cb_AAID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_DPID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_khoangcach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_masanbay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_rfar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;

            this.label1.Location = new System.Drawing.Point(348, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);

            this.label1.Location = new System.Drawing.Point(356, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);

            this.label1.TabIndex = 3;
            this.label1.Text = "Sân Bay";
            // 
            // dtgrout
            // 
            this.dtgrout.AllowUserToAddRows = false;
            this.dtgrout.AllowUserToDeleteRows = false;
            this.dtgrout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrout.Location = new System.Drawing.Point(411, 27);
            this.dtgrout.Name = "dtgrout";
            this.dtgrout.ReadOnly = true;
            this.dtgrout.RowHeadersWidth = 62;
            this.dtgrout.Size = new System.Drawing.Size(425, 250);
            this.dtgrout.TabIndex = 4;
            this.dtgrout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrout_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(393, 250);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btm_sreach);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_flighttime);
            this.panel1.Controls.Add(this.cb_AAID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_DPID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_khoangcach);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_masanbay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(411, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 108);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(334, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 33);
            this.button2.TabIndex = 13;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_update
            // 
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(240, 67);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(88, 33);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "&Cập nhật";
            this.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(159, 67);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 33);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "&Thêm";
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btm_sreach
            // 
            this.btm_sreach.Image = ((System.Drawing.Image)(resources.GetObject("btm_sreach.Image")));
            this.btm_sreach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_sreach.Location = new System.Drawing.Point(70, 67);
            this.btm_sreach.Name = "btm_sreach";
            this.btm_sreach.Size = new System.Drawing.Size(83, 33);
            this.btm_sreach.TabIndex = 10;
            this.btm_sreach.Text = "&Tìm kiếm";
            this.btm_sreach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btm_sreach.UseVisualStyleBackColor = true;
            this.btm_sreach.Click += new System.EventHandler(this.btm_sreach_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Flighttime:";
            // 
            // txt_flighttime
            // 
            this.txt_flighttime.Location = new System.Drawing.Point(359, 22);
            this.txt_flighttime.Name = "txt_flighttime";
            this.txt_flighttime.Size = new System.Drawing.Size(51, 20);
            this.txt_flighttime.TabIndex = 8;
            // 
            // cb_AAID
            // 
            this.cb_AAID.DisplayMember = "HAN";
            this.cb_AAID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AAID.FormattingEnabled = true;
            this.cb_AAID.Items.AddRange(new object[] {
            "ADH",
            "AJU",
            "BSB",
            "CAY",
            "CSY",
            "DME",
            "HAN",
            "HIJ",
            "KHV",
            "LAS",
            "MWH",
            "NGS",
            "SGN"});
            this.cb_AAID.Location = new System.Drawing.Point(177, 21);
            this.cb_AAID.Name = "cb_AAID";
            this.cb_AAID.Size = new System.Drawing.Size(85, 21);
            this.cb_AAID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "AAID:";
            // 
            // cb_DPID
            // 
            this.cb_DPID.DisplayMember = "HAN";
            this.cb_DPID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_DPID.FormattingEnabled = true;
            this.cb_DPID.Items.AddRange(new object[] {
            "ADH",
            "AJU",
            "BSB",
            "CAY",
            "CSY",
            "DME",
            "HAN",
            "HIJ",
            "KHV",
            "LAS",
            "MWH",
            "NGS",
            "SGN"});
            this.cb_DPID.Location = new System.Drawing.Point(72, 24);
            this.cb_DPID.Name = "cb_DPID";
            this.cb_DPID.Size = new System.Drawing.Size(87, 21);
            this.cb_DPID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DPID:";
            // 
            // txt_khoangcach
            // 
            this.txt_khoangcach.Location = new System.Drawing.Point(279, 24);
            this.txt_khoangcach.Name = "txt_khoangcach";
            this.txt_khoangcach.Size = new System.Drawing.Size(67, 20);
            this.txt_khoangcach.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distance:";
            // 
            // txt_masanbay
            // 
            this.txt_masanbay.Location = new System.Drawing.Point(3, 23);
            this.txt_masanbay.Name = "txt_masanbay";
            this.txt_masanbay.Size = new System.Drawing.Size(51, 20);
            this.txt_masanbay.TabIndex = 1;
            this.txt_masanbay.TextChanged += new System.EventHandler(this.txt_masanbay_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btn_rfar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 107);
            this.panel2.TabIndex = 7;
            // 
            // btn_rfar
            // 
            this.btn_rfar.Image = global::QLLTCB.Properties.Resources.Button_Reload_icon;
            this.btn_rfar.Location = new System.Drawing.Point(210, 15);
            this.btn_rfar.Name = "btn_rfar";
            this.btn_rfar.Size = new System.Drawing.Size(34, 35);
            this.btn_rfar.TabIndex = 8;
            this.btn_rfar.UseVisualStyleBackColor = true;
            this.btn_rfar.Click += new System.EventHandler(this.btn_rfar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nhập mã hoặc tên:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(115, 20);
            this.textBox4.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(124, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Tìm&Kiếm";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fmQLsanbay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 464);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dtgrout);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmQLsanbay";
            this.Text = "fmQLsanbay";
            this.Load += new System.EventHandler(this.fmQLsanbay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrout;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_masanbay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_khoangcach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_DPID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_AAID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_flighttime;
        private System.Windows.Forms.Button btm_sreach;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_rfar;
    }
}