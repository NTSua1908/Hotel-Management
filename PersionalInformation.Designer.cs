﻿
namespace Hotel_Management
{
    partial class PersionalInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersionalInformation));
            this.labelPersionalInformation = new System.Windows.Forms.Label();
            this.btnSaveAI = new System.Windows.Forms.Button();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.cbBoxAccessRights = new System.Windows.Forms.ComboBox();
            this.labelUserCode = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelYourName = new System.Windows.Forms.Label();
            this.txbUserCode = new System.Windows.Forms.TextBox();
            this.txbYourName = new System.Windows.Forms.TextBox();
            this.listBoxAcountInformation = new System.Windows.Forms.ListBox();
            this.labelSecurity = new System.Windows.Forms.Label();
            this.labelAcountInformation = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSaveSecurity = new System.Windows.Forms.Button();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.labelConfirmNewPass = new System.Windows.Forms.Label();
            this.txbConfirmNewPass = new System.Windows.Forms.TextBox();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelAccessRights = new System.Windows.Forms.Label();
            this.btnHideNewPass = new System.Windows.Forms.Button();
            this.btnHideConfirmNewPass = new System.Windows.Forms.Button();
            this.btnShowConfirmNewPass = new System.Windows.Forms.Button();
            this.btnShowNewPass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPersionalInformation
            // 
            this.labelPersionalInformation.AutoSize = true;
            this.labelPersionalInformation.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersionalInformation.ForeColor = System.Drawing.Color.Teal;
            this.labelPersionalInformation.Location = new System.Drawing.Point(27, 9);
            this.labelPersionalInformation.Name = "labelPersionalInformation";
            this.labelPersionalInformation.Size = new System.Drawing.Size(181, 25);
            this.labelPersionalInformation.TabIndex = 0;
            this.labelPersionalInformation.Text = "Thông tin cá nhân";
            // 
            // btnSaveAI
            // 
            this.btnSaveAI.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAI.Location = new System.Drawing.Point(366, 367);
            this.btnSaveAI.Name = "btnSaveAI";
            this.btnSaveAI.Size = new System.Drawing.Size(143, 34);
            this.btnSaveAI.TabIndex = 1;
            this.btnSaveAI.Text = "Lưu thay đổi";
            this.btnSaveAI.UseVisualStyleBackColor = true;
            this.btnSaveAI.Click += new System.EventHandler(this.btnSaveAI_Click);
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(311, 226);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(240, 24);
            this.txbUserName.TabIndex = 2;
            // 
            // cbBoxAccessRights
            // 
            this.cbBoxAccessRights.FormattingEnabled = true;
            this.cbBoxAccessRights.Location = new System.Drawing.Point(633, 298);
            this.cbBoxAccessRights.Name = "cbBoxAccessRights";
            this.cbBoxAccessRights.Size = new System.Drawing.Size(220, 26);
            this.cbBoxAccessRights.TabIndex = 3;
            // 
            // labelUserCode
            // 
            this.labelUserCode.AutoSize = true;
            this.labelUserCode.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserCode.ForeColor = System.Drawing.Color.Teal;
            this.labelUserCode.Location = new System.Drawing.Point(307, 119);
            this.labelUserCode.Name = "labelUserCode";
            this.labelUserCode.Size = new System.Drawing.Size(119, 20);
            this.labelUserCode.TabIndex = 5;
            this.labelUserCode.Text = "Mã người dùng:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.Teal;
            this.labelUserName.Location = new System.Drawing.Point(307, 194);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(115, 20);
            this.labelUserName.TabIndex = 6;
            this.labelUserName.Text = "Tên đăng nhập:";
            // 
            // labelYourName
            // 
            this.labelYourName.AutoSize = true;
            this.labelYourName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourName.ForeColor = System.Drawing.Color.Teal;
            this.labelYourName.Location = new System.Drawing.Point(307, 266);
            this.labelYourName.Name = "labelYourName";
            this.labelYourName.Size = new System.Drawing.Size(121, 20);
            this.labelYourName.TabIndex = 7;
            this.labelYourName.Text = "Tên người dùng:";
            // 
            // txbUserCode
            // 
            this.txbUserCode.Location = new System.Drawing.Point(311, 153);
            this.txbUserCode.Name = "txbUserCode";
            this.txbUserCode.Size = new System.Drawing.Size(240, 24);
            this.txbUserCode.TabIndex = 8;
            // 
            // txbYourName
            // 
            this.txbYourName.Location = new System.Drawing.Point(311, 300);
            this.txbYourName.Name = "txbYourName";
            this.txbYourName.Size = new System.Drawing.Size(243, 24);
            this.txbYourName.TabIndex = 9;
            // 
            // listBoxAcountInformation
            // 
            this.listBoxAcountInformation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBoxAcountInformation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.listBoxAcountInformation.FormattingEnabled = true;
            this.listBoxAcountInformation.ItemHeight = 18;
            this.listBoxAcountInformation.Location = new System.Drawing.Point(288, 86);
            this.listBoxAcountInformation.Name = "listBoxAcountInformation";
            this.listBoxAcountInformation.Size = new System.Drawing.Size(291, 328);
            this.listBoxAcountInformation.TabIndex = 10;
            // 
            // labelSecurity
            // 
            this.labelSecurity.AutoSize = true;
            this.labelSecurity.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecurity.ForeColor = System.Drawing.Color.Teal;
            this.labelSecurity.Location = new System.Drawing.Point(709, 74);
            this.labelSecurity.Name = "labelSecurity";
            this.labelSecurity.Size = new System.Drawing.Size(77, 23);
            this.labelSecurity.TabIndex = 11;
            this.labelSecurity.Text = "Bảo mật";
            // 
            // labelAcountInformation
            // 
            this.labelAcountInformation.AutoSize = true;
            this.labelAcountInformation.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcountInformation.ForeColor = System.Drawing.Color.Teal;
            this.labelAcountInformation.Location = new System.Drawing.Point(342, 74);
            this.labelAcountInformation.Name = "labelAcountInformation";
            this.labelAcountInformation.Size = new System.Drawing.Size(167, 23);
            this.labelAcountInformation.TabIndex = 12;
            this.labelAcountInformation.Text = "Thông tin tài khoản";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(602, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 328);
            this.listBox1.TabIndex = 13;
            // 
            // btnSaveSecurity
            // 
            this.btnSaveSecurity.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSecurity.Location = new System.Drawing.Point(665, 367);
            this.btnSaveSecurity.Name = "btnSaveSecurity";
            this.btnSaveSecurity.Size = new System.Drawing.Size(143, 34);
            this.btnSaveSecurity.TabIndex = 14;
            this.btnSaveSecurity.Text = "Lưu thay đổi";
            this.btnSaveSecurity.UseVisualStyleBackColor = true;
            this.btnSaveSecurity.Click += new System.EventHandler(this.btnSaveSecurity_Click);
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPass.ForeColor = System.Drawing.Color.Teal;
            this.labelNewPass.Location = new System.Drawing.Point(629, 119);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(108, 20);
            this.labelNewPass.TabIndex = 15;
            this.labelNewPass.Text = "Mật khẩu mới:";
            // 
            // labelConfirmNewPass
            // 
            this.labelConfirmNewPass.AutoSize = true;
            this.labelConfirmNewPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmNewPass.ForeColor = System.Drawing.Color.Teal;
            this.labelConfirmNewPass.Location = new System.Drawing.Point(629, 194);
            this.labelConfirmNewPass.Name = "labelConfirmNewPass";
            this.labelConfirmNewPass.Size = new System.Drawing.Size(174, 20);
            this.labelConfirmNewPass.TabIndex = 16;
            this.labelConfirmNewPass.Text = "Xác nhận mật khẩu mới:";
            // 
            // txbConfirmNewPass
            // 
            this.txbConfirmNewPass.Location = new System.Drawing.Point(633, 226);
            this.txbConfirmNewPass.Name = "txbConfirmNewPass";
            this.txbConfirmNewPass.Size = new System.Drawing.Size(220, 24);
            this.txbConfirmNewPass.TabIndex = 17;
            // 
            // txbNewPass
            // 
            this.txbNewPass.Location = new System.Drawing.Point(633, 153);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Size = new System.Drawing.Size(220, 24);
            this.txbNewPass.TabIndex = 18;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(547, 437);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 35);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelAccessRights
            // 
            this.labelAccessRights.AutoSize = true;
            this.labelAccessRights.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccessRights.ForeColor = System.Drawing.Color.Teal;
            this.labelAccessRights.Location = new System.Drawing.Point(629, 266);
            this.labelAccessRights.Name = "labelAccessRights";
            this.labelAccessRights.Size = new System.Drawing.Size(118, 20);
            this.labelAccessRights.TabIndex = 20;
            this.labelAccessRights.Text = "Quyền truy cập:";
            // 
            // btnHideNewPass
            // 
            this.btnHideNewPass.Image = ((System.Drawing.Image)(resources.GetObject("btnHideNewPass.Image")));
            this.btnHideNewPass.Location = new System.Drawing.Point(826, 153);
            this.btnHideNewPass.Name = "btnHideNewPass";
            this.btnHideNewPass.Size = new System.Drawing.Size(27, 24);
            this.btnHideNewPass.TabIndex = 22;
            this.btnHideNewPass.UseVisualStyleBackColor = true;
            this.btnHideNewPass.Click += new System.EventHandler(this.btnHideNewPass_Click);
            // 
            // btnHideConfirmNewPass
            // 
            this.btnHideConfirmNewPass.Image = ((System.Drawing.Image)(resources.GetObject("btnHideConfirmNewPass.Image")));
            this.btnHideConfirmNewPass.Location = new System.Drawing.Point(827, 226);
            this.btnHideConfirmNewPass.Name = "btnHideConfirmNewPass";
            this.btnHideConfirmNewPass.Size = new System.Drawing.Size(26, 24);
            this.btnHideConfirmNewPass.TabIndex = 23;
            this.btnHideConfirmNewPass.UseVisualStyleBackColor = true;
            this.btnHideConfirmNewPass.Click += new System.EventHandler(this.btnHideConfirmNewPass_Click);
            // 
            // btnShowConfirmNewPass
            // 
            this.btnShowConfirmNewPass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowConfirmNewPass.Image")));
            this.btnShowConfirmNewPass.Location = new System.Drawing.Point(827, 226);
            this.btnShowConfirmNewPass.Name = "btnShowConfirmNewPass";
            this.btnShowConfirmNewPass.Size = new System.Drawing.Size(26, 24);
            this.btnShowConfirmNewPass.TabIndex = 24;
            this.btnShowConfirmNewPass.UseVisualStyleBackColor = true;
            this.btnShowConfirmNewPass.Click += new System.EventHandler(this.btnShowConfirmNewPass_Click);
            // 
            // btnShowNewPass
            // 
            this.btnShowNewPass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowNewPass.Image")));
            this.btnShowNewPass.Location = new System.Drawing.Point(826, 153);
            this.btnShowNewPass.Name = "btnShowNewPass";
            this.btnShowNewPass.Size = new System.Drawing.Size(27, 24);
            this.btnShowNewPass.TabIndex = 21;
            this.btnShowNewPass.UseVisualStyleBackColor = true;
            this.btnShowNewPass.Click += new System.EventHandler(this.btnShowNewPass_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_Management.Properties.Resources.avatar_default;
            this.pictureBox1.Location = new System.Drawing.Point(32, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PersionalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 506);
            this.Controls.Add(this.btnShowConfirmNewPass);
            this.Controls.Add(this.btnHideConfirmNewPass);
            this.Controls.Add(this.btnHideNewPass);
            this.Controls.Add(this.btnShowNewPass);
            this.Controls.Add(this.labelAccessRights);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txbNewPass);
            this.Controls.Add(this.txbConfirmNewPass);
            this.Controls.Add(this.labelConfirmNewPass);
            this.Controls.Add(this.labelNewPass);
            this.Controls.Add(this.btnSaveSecurity);
            this.Controls.Add(this.labelSecurity);
            this.Controls.Add(this.cbBoxAccessRights);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelAcountInformation);
            this.Controls.Add(this.btnSaveAI);
            this.Controls.Add(this.txbYourName);
            this.Controls.Add(this.labelYourName);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelUserCode);
            this.Controls.Add(this.txbUserCode);
            this.Controls.Add(this.listBoxAcountInformation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPersionalInformation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PersionalInformation";
            this.Text = "PersionalInformation";
            this.Load += new System.EventHandler(this.PersionalInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPersionalInformation;
        private System.Windows.Forms.Button btnSaveAI;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.ComboBox cbBoxAccessRights;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUserCode;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelYourName;
        private System.Windows.Forms.TextBox txbUserCode;
        private System.Windows.Forms.TextBox txbYourName;
        private System.Windows.Forms.ListBox listBoxAcountInformation;
        private System.Windows.Forms.Label labelSecurity;
        private System.Windows.Forms.Label labelAcountInformation;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSaveSecurity;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.Label labelConfirmNewPass;
        private System.Windows.Forms.TextBox txbConfirmNewPass;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelAccessRights;
        private System.Windows.Forms.Button btnShowNewPass;
        private System.Windows.Forms.Button btnHideNewPass;
        private System.Windows.Forms.Button btnHideConfirmNewPass;
        private System.Windows.Forms.Button btnShowConfirmNewPass;
    }
}