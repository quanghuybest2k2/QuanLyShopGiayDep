
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
            this.btnExit = new ReaLTaiizor.Controls.AirButton();
            this.lblAdminTieuDe = new System.Windows.Forms.Label();
            this.pbAdminTieuDe = new System.Windows.Forms.PictureBox();
            this.paneCenter = new System.Windows.Forms.Panel();
            this.btnTaiKhoanAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhaCCAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnTheLoaiAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhachHangAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrangChuAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminTieuDe)).BeginInit();
            this.paneCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.lblAdminTieuDe);
            this.panelTop.Controls.Add(this.pbAdminTieuDe);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(990, 62);
            this.panelTop.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.Image = null;
            this.btnExit.Location = new System.Drawing.Point(945, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.NoRounding = false;
            this.btnExit.Size = new System.Drawing.Size(33, 29);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.Transparent = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAdminTieuDe
            // 
            this.lblAdminTieuDe.AutoSize = true;
            this.lblAdminTieuDe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblAdminTieuDe.Location = new System.Drawing.Point(54, 24);
            this.lblAdminTieuDe.Name = "lblAdminTieuDe";
            this.lblAdminTieuDe.Size = new System.Drawing.Size(175, 18);
            this.lblAdminTieuDe.TabIndex = 1;
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
            this.paneCenter.Controls.Add(this.btnTheLoaiAdmin);
            this.paneCenter.Controls.Add(this.btnKhachHangAdmin);
            this.paneCenter.Controls.Add(this.btnTrangChuAdmin);
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
            this.btnTaiKhoanAdmin.Location = new System.Drawing.Point(616, -2);
            this.btnTaiKhoanAdmin.Name = "btnTaiKhoanAdmin";
            this.btnTaiKhoanAdmin.Size = new System.Drawing.Size(140, 45);
            this.btnTaiKhoanAdmin.TabIndex = 0;
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
            this.btnNhaCCAdmin.Location = new System.Drawing.Point(463, -3);
            this.btnNhaCCAdmin.Name = "btnNhaCCAdmin";
            this.btnNhaCCAdmin.Size = new System.Drawing.Size(147, 45);
            this.btnNhaCCAdmin.TabIndex = 0;
            this.btnNhaCCAdmin.Text = "Nhà cung cấp";
            this.btnNhaCCAdmin.Click += new System.EventHandler(this.btnNhaCCAdmin_Click);
            // 
            // btnTheLoaiAdmin
            // 
            this.btnTheLoaiAdmin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTheLoaiAdmin.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTheLoaiAdmin.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnTheLoaiAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTheLoaiAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTheLoaiAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTheLoaiAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTheLoaiAdmin.FillColor = System.Drawing.Color.White;
            this.btnTheLoaiAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheLoaiAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTheLoaiAdmin.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTheLoaiAdmin.Location = new System.Drawing.Point(313, 0);
            this.btnTheLoaiAdmin.Name = "btnTheLoaiAdmin";
            this.btnTheLoaiAdmin.Size = new System.Drawing.Size(144, 45);
            this.btnTheLoaiAdmin.TabIndex = 0;
            this.btnTheLoaiAdmin.Text = "Thể loại";
            this.btnTheLoaiAdmin.Click += new System.EventHandler(this.btnTheLoaiAdmin_Click);
            // 
            // btnKhachHangAdmin
            // 
            this.btnKhachHangAdmin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKhachHangAdmin.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKhachHangAdmin.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnKhachHangAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHangAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHangAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhachHangAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhachHangAdmin.FillColor = System.Drawing.Color.White;
            this.btnKhachHangAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHangAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKhachHangAdmin.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKhachHangAdmin.Location = new System.Drawing.Point(160, -2);
            this.btnKhachHangAdmin.Name = "btnKhachHangAdmin";
            this.btnKhachHangAdmin.Size = new System.Drawing.Size(147, 45);
            this.btnKhachHangAdmin.TabIndex = 0;
            this.btnKhachHangAdmin.Text = "Khách hàng";
            this.btnKhachHangAdmin.Click += new System.EventHandler(this.btnKhachHangAdmin_Click);
            // 
            // btnTrangChuAdmin
            // 
            this.btnTrangChuAdmin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTrangChuAdmin.Checked = true;
            this.btnTrangChuAdmin.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTrangChuAdmin.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTrangChuAdmin.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnTrangChuAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangChuAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangChuAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrangChuAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrangChuAdmin.FillColor = System.Drawing.Color.White;
            this.btnTrangChuAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChuAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTrangChuAdmin.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTrangChuAdmin.Location = new System.Drawing.Point(3, -2);
            this.btnTrangChuAdmin.Name = "btnTrangChuAdmin";
            this.btnTrangChuAdmin.Size = new System.Drawing.Size(151, 45);
            this.btnTrangChuAdmin.TabIndex = 0;
            this.btnTrangChuAdmin.Text = "Trang chủ";
            this.btnTrangChuAdmin.Click += new System.EventHandler(this.btnTrangChuAdmin_Click);
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
        private Guna.UI2.WinForms.Guna2Button btnTrangChuAdmin;
        private Guna.UI2.WinForms.Guna2Button btnNhaCCAdmin;
        private Guna.UI2.WinForms.Guna2Button btnTheLoaiAdmin;
        private Guna.UI2.WinForms.Guna2Button btnKhachHangAdmin;
        private Guna.UI2.WinForms.Guna2Button btnTaiKhoanAdmin;
        private ReaLTaiizor.Controls.AirButton btnExit;
    }
}