
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
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
            this.dtgrout.Size = new System.Drawing.Size(420, 250);
            this.dtgrout.TabIndex = 4;
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.panel1.Size = new System.Drawing.Size(420, 108);
            this.panel1.TabIndex = 6;
            // 
            // btn_update
            // 
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(279, 70);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 37);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "&Update";
            this.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(177, 72);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(67, 33);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "&Add";
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btm_sreach
            // 
            this.btm_sreach.Image = ((System.Drawing.Image)(resources.GetObject("btm_sreach.Image")));
            this.btm_sreach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_sreach.Location = new System.Drawing.Point(62, 72);
            this.btm_sreach.Name = "btm_sreach";
            this.btm_sreach.Size = new System.Drawing.Size(75, 33);
            this.btm_sreach.TabIndex = 10;
            this.btm_sreach.Text = "&Sreach";
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
            this.cb_AAID.DisplayMember = "ArrivalAiportID";
            this.cb_AAID.FormattingEnabled = true;
            this.cb_AAID.Location = new System.Drawing.Point(260, 23);
            this.cb_AAID.Name = "cb_AAID";
            this.cb_AAID.Size = new System.Drawing.Size(85, 21);
            this.cb_AAID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "AAID:";
            // 
            // cb_DPID
            // 
            this.cb_DPID.DisplayMember = "DepartureAiportID";
            this.cb_DPID.FormattingEnabled = true;
            this.cb_DPID.Location = new System.Drawing.Point(149, 23);
            this.cb_DPID.Name = "cb_DPID";
            this.cb_DPID.Size = new System.Drawing.Size(87, 21);
            this.cb_DPID.TabIndex = 5;
            this.cb_DPID.ValueMember = "DepartureAiportID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DPID:";
            // 
            // txt_khoangcach
            // 
            this.txt_khoangcach.Location = new System.Drawing.Point(71, 23);
            this.txt_khoangcach.Name = "txt_khoangcach";
            this.txt_khoangcach.Size = new System.Drawing.Size(67, 20);
            this.txt_khoangcach.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 7);
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
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 107);
            this.panel2.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 7);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(115, 20);
            this.textBox4.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(124, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Sreach";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fmQLsanbay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 404);
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
    }
}