﻿
namespace QuanLyShopGiayDep
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnExitAdmin = new ReaLTaiizor.Controls.AirButton();
            this.lblAdminTieuDe = new System.Windows.Forms.Label();
            this.pbAdminTieuDe = new System.Windows.Forms.PictureBox();
            this.paneCenter = new System.Windows.Forms.Panel();
            this.btnTaiKhoanAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhaCCAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnHangHoaAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhachHangAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnMinimizeAdmin = new ReaLTaiizor.Controls.AirButton();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminTieuDe)).BeginInit();
            this.paneCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.panelTop.Controls.Add(this.btnMinimizeAdmin);
            this.panelTop.Controls.Add(this.btnExitAdmin);
            this.panelTop.Controls.Add(this.lblAdminTieuDe);
            this.panelTop.Controls.Add(this.pbAdminTieuDe);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(990, 62);
            this.panelTop.TabIndex = 0;
            // 
            // btnExitAdmin
            // 
            this.btnExitAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitAdmin.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnExitAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExitAdmin.Image = null;
            this.btnExitAdmin.Location = new System.Drawing.Point(945, 12);
            this.btnExitAdmin.Name = "btnExitAdmin";
            this.btnExitAdmin.NoRounding = false;
            this.btnExitAdmin.Size = new System.Drawing.Size(33, 29);
            this.btnExitAdmin.TabIndex = 6;
            this.btnExitAdmin.Text = "X";
            this.btnExitAdmin.Transparent = false;
            this.btnExitAdmin.Click += new System.EventHandler(this.btnExitAdmin_Click);
            // 
            // lblAdminTieuDe
            // 
            this.lblAdminTieuDe.AutoSize = true;
            this.lblAdminTieuDe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblAdminTieuDe.Location = new System.Drawing.Point(54, 24);
            this.lblAdminTieuDe.Name = "lblAdminTieuDe";
            this.lblAdminTieuDe.Size = new System.Drawing.Size(175, 18);
            this.lblAdminTieuDe.TabIndex = 0;
            this.lblAdminTieuDe.Text = "Quản lý shop giày dép";
            // 
            // pbAdminTieuDe
            // 
            this.pbAdminTieuDe.Image = ((System.Drawing.Image)(resources.GetObject("pbAdminTieuDe.Image")));
            this.pbAdminTieuDe.Location = new System.Drawing.Point(12, 12);
            this.pbAdminTieuDe.Name = "pbAdminTieuDe";
            this.pbAdminTieuDe.Size = new System.Drawing.Size(36, 44);
            this.pbAdminTieuDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdminTieuDe.TabIndex = 0;
            this.pbAdminTieuDe.TabStop = false;
            // 
            // paneCenter
            // 
            this.paneCenter.BackColor = System.Drawing.Color.White;
            this.paneCenter.Controls.Add(this.btnTaiKhoanAdmin);
            this.paneCenter.Controls.Add(this.btnNhaCCAdmin);
            this.paneCenter.Controls.Add(this.btnHangHoaAdmin);
            this.paneCenter.Controls.Add(this.btnKhachHangAdmin);
            this.paneCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneCenter.Location = new System.Drawing.Point(0, 62);
            this.paneCenter.Name = "paneCenter";
            this.paneCenter.Size = new System.Drawing.Size(990, 48);
            this.paneCenter.TabIndex = 1;
            // 
            // btnTaiKhoanAdmin
            // 
            this.btnTaiKhoanAdmin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTaiKhoanAdmin.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTaiKhoanAdmin.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnTaiKhoanAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiKhoanAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiKhoanAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaiKhoanAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaiKhoanAdmin.FillColor = System.Drawing.Color.White;
            this.btnTaiKhoanAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoanAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTaiKhoanAdmin.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTaiKhoanAdmin.Location = new System.Drawing.Point(501, 0);
            this.btnTaiKhoanAdmin.Name = "btnTaiKhoanAdmin";
            this.btnTaiKhoanAdmin.Size = new System.Drawing.Size(140, 45);
            this.btnTaiKhoanAdmin.TabIndex = 4;
            this.btnTaiKhoanAdmin.Text = "Tài khoản";
            this.btnTaiKhoanAdmin.Click += new System.EventHandler(this.btnTaiKhoanAdmin_Click);
            // 
            // btnNhaCCAdmin
            // 
            this.btnNhaCCAdmin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNhaCCAdmin.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNhaCCAdmin.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnNhaCCAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhaCCAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhaCCAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhaCCAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhaCCAdmin.FillColor = System.Drawing.Color.White;
            this.btnNhaCCAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaCCAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNhaCCAdmin.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNhaCCAdmin.Location = new System.Drawing.Point(338, -2);
            this.btnNhaCCAdmin.Name = "btnNhaCCAdmin";
            this.btnNhaCCAdmin.Size = new System.Drawing.Size(147, 45);
            this.btnNhaCCAdmin.TabIndex = 3;
            this.btnNhaCCAdmin.Text = "Nhà cung cấp";
            this.btnNhaCCAdmin.Click += new System.EventHandler(this.btnNhaCCAdmin_Click);
            // 
            // btnHangHoaAdmin
            // 
            this.btnHangHoaAdmin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHangHoaAdmin.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHangHoaAdmin.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnHangHoaAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHangHoaAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHangHoaAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHangHoaAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHangHoaAdmin.FillColor = System.Drawing.Color.White;
            this.btnHangHoaAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHangHoaAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHangHoaAdmin.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHangHoaAdmin.Location = new System.Drawing.Point(169, 0);
            this.btnHangHoaAdmin.Name = "btnHangHoaAdmin";
            this.btnHangHoaAdmin.Size = new System.Drawing.Size(144, 45);
            this.btnHangHoaAdmin.TabIndex = 2;
            this.btnHangHoaAdmin.Text = "Hàng hóa";
            this.btnHangHoaAdmin.Click += new System.EventHandler(this.btnHangHoaAdmin_Click);
            // 
            // btnKhachHangAdmin
            // 
            this.btnKhachHangAdmin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKhachHangAdmin.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKhachHangAdmin.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKhachHangAdmin.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnKhachHangAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHangAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHangAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhachHangAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhachHangAdmin.FillColor = System.Drawing.Color.White;
            this.btnKhachHangAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHangAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKhachHangAdmin.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKhachHangAdmin.Location = new System.Drawing.Point(0, 0);
            this.btnKhachHangAdmin.Name = "btnKhachHangAdmin";
            this.btnKhachHangAdmin.Size = new System.Drawing.Size(147, 45);
            this.btnKhachHangAdmin.TabIndex = 1;
            this.btnKhachHangAdmin.Text = "Khách hàng";
            this.btnKhachHangAdmin.Click += new System.EventHandler(this.btnKhachHangAdmin_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBottom.Location = new System.Drawing.Point(0, 110);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(990, 560);
            this.panelBottom.TabIndex = 2;
            // 
            // btnMinimizeAdmin
            // 
            this.btnMinimizeAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizeAdmin.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnMinimizeAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimizeAdmin.Image = null;
            this.btnMinimizeAdmin.Location = new System.Drawing.Point(906, 12);
            this.btnMinimizeAdmin.Name = "btnMinimizeAdmin";
            this.btnMinimizeAdmin.NoRounding = false;
            this.btnMinimizeAdmin.Size = new System.Drawing.Size(33, 29);
            this.btnMinimizeAdmin.TabIndex = 5;
            this.btnMinimizeAdmin.Text = "-";
            this.btnMinimizeAdmin.Transparent = false;
            this.btnMinimizeAdmin.Click += new System.EventHandler(this.btnMinimizeAdmin_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(990, 670);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.paneCenter);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminTieuDe)).EndInit();
            this.paneCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel paneCenter;
        private System.Windows.Forms.Label lblAdminTieuDe;
        private System.Windows.Forms.PictureBox pbAdminTieuDe;
        private System.Windows.Forms.Panel panelBottom;
        private Guna.UI2.WinForms.Guna2Button btnNhaCCAdmin;
        private Guna.UI2.WinForms.Guna2Button btnHangHoaAdmin;
        private Guna.UI2.WinForms.Guna2Button btnKhachHangAdmin;
        private Guna.UI2.WinForms.Guna2Button btnTaiKhoanAdmin;
        private ReaLTaiizor.Controls.AirButton btnExitAdmin;
        private ReaLTaiizor.Controls.AirButton btnMinimizeAdmin;
    }
}