
namespace QLLTCB
{
    partial class fmthongtincanhan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.txbReen = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Re_enPass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "NewPass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(399, 364);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 42);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(264, 46);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(386, 22);
            this.txbName.TabIndex = 6;
            // 
            // txbNewPass
            // 
            this.txbNewPass.Location = new System.Drawing.Point(264, 228);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Size = new System.Drawing.Size(386, 22);
            this.txbNewPass.TabIndex = 7;
            // 
            // txbReen
            // 
            this.txbReen.Location = new System.Drawing.Point(264, 296);
            this.txbReen.Name = "txbReen";
            this.txbReen.Size = new System.Drawing.Size(386, 22);
            this.txbReen.TabIndex = 8;
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(264, 163);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(386, 22);
            this.txbPass.TabIndex = 9;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(264, 100);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(386, 22);
            this.txbEmail.TabIndex = 10;
            // 
            // fmthongtincanhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbReen);
            this.Controls.Add(this.txbNewPass);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmthongtincanhan";
            this.Text = "fmthongtincanhan";
            this.Load += new System.EventHandler(this.fmthongtincanhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.TextBox txbReen;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbEmail;
    }
}