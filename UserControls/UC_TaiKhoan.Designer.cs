
namespace QuanLyShopGiayDep.UserControls
{
    partial class UC_TaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvTaiKhoanAdmin = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbQuyenTKAdmin = new System.Windows.Forms.ComboBox();
            this.btnLamMoiTKAdmin = new System.Windows.Forms.Button();
            this.btnXoaTKAdmin = new System.Windows.Forms.Button();
            this.btnLuuTKAdmin = new System.Windows.Forms.Button();
            this.btnSuaTKAdmin = new System.Windows.Forms.Button();
            this.txtTenNVTKAdmin = new System.Windows.Forms.TextBox();
            this.txtCCCDTKAdmin = new System.Windows.Forms.TextBox();
            this.txtMatKhauTKAdmin = new System.Windows.Forms.TextBox();
            this.txtEmailTKAdmin = new System.Windows.Forms.TextBox();
            this.txtTenDNTKAdmin = new System.Windows.Forms.TextBox();
            this.lblVaiTroTKAdmin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMatKhauTKAdmin = new System.Windows.Forms.Label();
            this.lblCCCDTKAdmin = new System.Windows.Forms.Label();
            this.lblEmailTKAdmin = new System.Windows.Forms.Label();
            this.lblTenNVTKAdmin = new System.Windows.Forms.Label();
            this.lblSDTTKAdmin = new System.Windows.Forms.Label();
            this.lblTieuDeTKAdmin = new System.Windows.Forms.Label();
            this.lblTenDNTKAdmin = new System.Windows.Forms.Label();
            this.mtxtSDTTKAdmin = new System.Windows.Forms.MaskedTextBox();
            this.dtpNgayTaoTKAdmin = new System.Windows.Forms.DateTimePicker();
            this.lblDiaChiTKAdmin = new System.Windows.Forms.Label();
            this.txtDiaChiTKAdmin = new System.Windows.Forms.TextBox();
            this.chkKichHoatTKAdmin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoanAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTaiKhoanAdmin
            // 
            this.dtgvTaiKhoanAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvTaiKhoanAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTaiKhoanAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column10,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dtgvTaiKhoanAdmin.Location = new System.Drawing.Point(0, 335);
            this.dtgvTaiKhoanAdmin.Name = "dtgvTaiKhoanAdmin";
            this.dtgvTaiKhoanAdmin.Size = new System.Drawing.Size(959, 183);
            this.dtgvTaiKhoanAdmin.TabIndex = 46;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã tài khoản";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên đăng nhập";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên nhân viên";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số CCCD";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số điện thoại";
            this.Column5.Name = "Column5";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Email";
            this.Column10.Name = "Column10";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Địa chỉ";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Vai trò";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Trạng thái";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Ngày tạo";
            this.Column9.Name = "Column9";
            // 
            // cbbQuyenTKAdmin
            // 
            this.cbbQuyenTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbQuyenTKAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQuyenTKAdmin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbQuyenTKAdmin.FormattingEnabled = true;
            this.cbbQuyenTKAdmin.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbbQuyenTKAdmin.Location = new System.Drawing.Point(594, 204);
            this.cbbQuyenTKAdmin.Name = "cbbQuyenTKAdmin";
            this.cbbQuyenTKAdmin.Size = new System.Drawing.Size(244, 23);
            this.cbbQuyenTKAdmin.TabIndex = 45;
            // 
            // btnLamMoiTKAdmin
            // 
            this.btnLamMoiTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLamMoiTKAdmin.BackColor = System.Drawing.Color.Tomato;
            this.btnLamMoiTKAdmin.FlatAppearance.BorderSize = 0;
            this.btnLamMoiTKAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiTKAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiTKAdmin.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiTKAdmin.Location = new System.Drawing.Point(554, 291);
            this.btnLamMoiTKAdmin.Name = "btnLamMoiTKAdmin";
            this.btnLamMoiTKAdmin.Size = new System.Drawing.Size(124, 38);
            this.btnLamMoiTKAdmin.TabIndex = 42;
            this.btnLamMoiTKAdmin.Text = "Làm mới";
            this.btnLamMoiTKAdmin.UseVisualStyleBackColor = false;
            // 
            // btnXoaTKAdmin
            // 
            this.btnXoaTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaTKAdmin.BackColor = System.Drawing.Color.Red;
            this.btnXoaTKAdmin.FlatAppearance.BorderSize = 0;
            this.btnXoaTKAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTKAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTKAdmin.ForeColor = System.Drawing.Color.White;
            this.btnXoaTKAdmin.Location = new System.Drawing.Point(594, 524);
            this.btnXoaTKAdmin.Name = "btnXoaTKAdmin";
            this.btnXoaTKAdmin.Size = new System.Drawing.Size(111, 38);
            this.btnXoaTKAdmin.TabIndex = 41;
            this.btnXoaTKAdmin.Text = "Xóa";
            this.btnXoaTKAdmin.UseVisualStyleBackColor = false;
            // 
            // btnLuuTKAdmin
            // 
            this.btnLuuTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuuTKAdmin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLuuTKAdmin.FlatAppearance.BorderSize = 0;
            this.btnLuuTKAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuTKAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTKAdmin.ForeColor = System.Drawing.Color.White;
            this.btnLuuTKAdmin.Location = new System.Drawing.Point(708, 291);
            this.btnLuuTKAdmin.Name = "btnLuuTKAdmin";
            this.btnLuuTKAdmin.Size = new System.Drawing.Size(141, 38);
            this.btnLuuTKAdmin.TabIndex = 44;
            this.btnLuuTKAdmin.Text = "Lưu";
            this.btnLuuTKAdmin.UseVisualStyleBackColor = false;
            // 
            // btnSuaTKAdmin
            // 
            this.btnSuaTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaTKAdmin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuaTKAdmin.FlatAppearance.BorderSize = 0;
            this.btnSuaTKAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTKAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTKAdmin.ForeColor = System.Drawing.Color.White;
            this.btnSuaTKAdmin.Location = new System.Drawing.Point(727, 524);
            this.btnSuaTKAdmin.Name = "btnSuaTKAdmin";
            this.btnSuaTKAdmin.Size = new System.Drawing.Size(111, 38);
            this.btnSuaTKAdmin.TabIndex = 43;
            this.btnSuaTKAdmin.Text = "Chỉnh Sửa";
            this.btnSuaTKAdmin.UseVisualStyleBackColor = false;
            // 
            // txtTenNVTKAdmin
            // 
            this.txtTenNVTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNVTKAdmin.Location = new System.Drawing.Point(594, 56);
            this.txtTenNVTKAdmin.Name = "txtTenNVTKAdmin";
            this.txtTenNVTKAdmin.Size = new System.Drawing.Size(244, 20);
            this.txtTenNVTKAdmin.TabIndex = 39;
            // 
            // txtCCCDTKAdmin
            // 
            this.txtCCCDTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCCCDTKAdmin.Location = new System.Drawing.Point(594, 102);
            this.txtCCCDTKAdmin.Name = "txtCCCDTKAdmin";
            this.txtCCCDTKAdmin.Size = new System.Drawing.Size(244, 20);
            this.txtCCCDTKAdmin.TabIndex = 38;
            // 
            // txtMatKhauTKAdmin
            // 
            this.txtMatKhauTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMatKhauTKAdmin.Location = new System.Drawing.Point(241, 203);
            this.txtMatKhauTKAdmin.Name = "txtMatKhauTKAdmin";
            this.txtMatKhauTKAdmin.PasswordChar = '*';
            this.txtMatKhauTKAdmin.Size = new System.Drawing.Size(199, 20);
            this.txtMatKhauTKAdmin.TabIndex = 40;
            // 
            // txtEmailTKAdmin
            // 
            this.txtEmailTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailTKAdmin.Location = new System.Drawing.Point(241, 156);
            this.txtEmailTKAdmin.Name = "txtEmailTKAdmin";
            this.txtEmailTKAdmin.Size = new System.Drawing.Size(199, 20);
            this.txtEmailTKAdmin.TabIndex = 36;
            // 
            // txtTenDNTKAdmin
            // 
            this.txtTenDNTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenDNTKAdmin.Location = new System.Drawing.Point(241, 54);
            this.txtTenDNTKAdmin.Name = "txtTenDNTKAdmin";
            this.txtTenDNTKAdmin.Size = new System.Drawing.Size(199, 20);
            this.txtTenDNTKAdmin.TabIndex = 34;
            // 
            // lblVaiTroTKAdmin
            // 
            this.lblVaiTroTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVaiTroTKAdmin.AutoSize = true;
            this.lblVaiTroTKAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaiTroTKAdmin.Location = new System.Drawing.Point(523, 209);
            this.lblVaiTroTKAdmin.Name = "lblVaiTroTKAdmin";
            this.lblVaiTroTKAdmin.Size = new System.Drawing.Size(62, 19);
            this.lblVaiTroTKAdmin.TabIndex = 32;
            this.lblVaiTroTKAdmin.Text = "Vai trò:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(505, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ngày tạo:";
            // 
            // lblMatKhauTKAdmin
            // 
            this.lblMatKhauTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMatKhauTKAdmin.AutoSize = true;
            this.lblMatKhauTKAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauTKAdmin.Location = new System.Drawing.Point(145, 209);
            this.lblMatKhauTKAdmin.Name = "lblMatKhauTKAdmin";
            this.lblMatKhauTKAdmin.Size = new System.Drawing.Size(82, 19);
            this.lblMatKhauTKAdmin.TabIndex = 30;
            this.lblMatKhauTKAdmin.Text = "Mật khẩu:";
            // 
            // lblCCCDTKAdmin
            // 
            this.lblCCCDTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCCCDTKAdmin.AutoSize = true;
            this.lblCCCDTKAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCDTKAdmin.Location = new System.Drawing.Point(525, 106);
            this.lblCCCDTKAdmin.Name = "lblCCCDTKAdmin";
            this.lblCCCDTKAdmin.Size = new System.Drawing.Size(60, 19);
            this.lblCCCDTKAdmin.TabIndex = 29;
            this.lblCCCDTKAdmin.Text = "CCCD:";
            // 
            // lblEmailTKAdmin
            // 
            this.lblEmailTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailTKAdmin.AutoSize = true;
            this.lblEmailTKAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailTKAdmin.Location = new System.Drawing.Point(171, 160);
            this.lblEmailTKAdmin.Name = "lblEmailTKAdmin";
            this.lblEmailTKAdmin.Size = new System.Drawing.Size(56, 19);
            this.lblEmailTKAdmin.TabIndex = 28;
            this.lblEmailTKAdmin.Text = "Email:";
            // 
            // lblTenNVTKAdmin
            // 
            this.lblTenNVTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenNVTKAdmin.AutoSize = true;
            this.lblTenNVTKAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNVTKAdmin.Location = new System.Drawing.Point(463, 57);
            this.lblTenNVTKAdmin.Name = "lblTenNVTKAdmin";
            this.lblTenNVTKAdmin.Size = new System.Drawing.Size(122, 19);
            this.lblTenNVTKAdmin.TabIndex = 27;
            this.lblTenNVTKAdmin.Text = "Tên nhân viên:";
            // 
            // lblSDTTKAdmin
            // 
            this.lblSDTTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSDTTKAdmin.AutoSize = true;
            this.lblSDTTKAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDTTKAdmin.Location = new System.Drawing.Point(117, 106);
            this.lblSDTTKAdmin.Name = "lblSDTTKAdmin";
            this.lblSDTTKAdmin.Size = new System.Drawing.Size(110, 19);
            this.lblSDTTKAdmin.TabIndex = 26;
            this.lblSDTTKAdmin.Text = "Số điện thoại:";
            // 
            // lblTieuDeTKAdmin
            // 
            this.lblTieuDeTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTieuDeTKAdmin.AutoSize = true;
            this.lblTieuDeTKAdmin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeTKAdmin.Location = new System.Drawing.Point(404, 6);
            this.lblTieuDeTKAdmin.Name = "lblTieuDeTKAdmin";
            this.lblTieuDeTKAdmin.Size = new System.Drawing.Size(213, 28);
            this.lblTieuDeTKAdmin.TabIndex = 33;
            this.lblTieuDeTKAdmin.Text = "Quản lý tài khoản";
            // 
            // lblTenDNTKAdmin
            // 
            this.lblTenDNTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenDNTKAdmin.AutoSize = true;
            this.lblTenDNTKAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDNTKAdmin.Location = new System.Drawing.Point(96, 57);
            this.lblTenDNTKAdmin.Name = "lblTenDNTKAdmin";
            this.lblTenDNTKAdmin.Size = new System.Drawing.Size(131, 19);
            this.lblTenDNTKAdmin.TabIndex = 25;
            this.lblTenDNTKAdmin.Text = "Tên đăng nhập:";
            // 
            // mtxtSDTTKAdmin
            // 
            this.mtxtSDTTKAdmin.Location = new System.Drawing.Point(241, 105);
            this.mtxtSDTTKAdmin.Mask = "000.000.0000";
            this.mtxtSDTTKAdmin.Name = "mtxtSDTTKAdmin";
            this.mtxtSDTTKAdmin.Size = new System.Drawing.Size(199, 20);
            this.mtxtSDTTKAdmin.TabIndex = 47;
            // 
            // dtpNgayTaoTKAdmin
            // 
            this.dtpNgayTaoTKAdmin.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTaoTKAdmin.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTaoTKAdmin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTaoTKAdmin.Location = new System.Drawing.Point(594, 155);
            this.dtpNgayTaoTKAdmin.Name = "dtpNgayTaoTKAdmin";
            this.dtpNgayTaoTKAdmin.Size = new System.Drawing.Size(244, 22);
            this.dtpNgayTaoTKAdmin.TabIndex = 48;
            // 
            // lblDiaChiTKAdmin
            // 
            this.lblDiaChiTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiaChiTKAdmin.AutoSize = true;
            this.lblDiaChiTKAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChiTKAdmin.Location = new System.Drawing.Point(159, 251);
            this.lblDiaChiTKAdmin.Name = "lblDiaChiTKAdmin";
            this.lblDiaChiTKAdmin.Size = new System.Drawing.Size(68, 19);
            this.lblDiaChiTKAdmin.TabIndex = 30;
            this.lblDiaChiTKAdmin.Text = "Địa chỉ:";
            // 
            // txtDiaChiTKAdmin
            // 
            this.txtDiaChiTKAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiaChiTKAdmin.Location = new System.Drawing.Point(241, 250);
            this.txtDiaChiTKAdmin.Name = "txtDiaChiTKAdmin";
            this.txtDiaChiTKAdmin.PasswordChar = '*';
            this.txtDiaChiTKAdmin.Size = new System.Drawing.Size(199, 20);
            this.txtDiaChiTKAdmin.TabIndex = 40;
            // 
            // chkKichHoatTKAdmin
            // 
            this.chkKichHoatTKAdmin.AutoSize = true;
            this.chkKichHoatTKAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKichHoatTKAdmin.Location = new System.Drawing.Point(594, 247);
            this.chkKichHoatTKAdmin.Name = "chkKichHoatTKAdmin";
            this.chkKichHoatTKAdmin.Size = new System.Drawing.Size(98, 23);
            this.chkKichHoatTKAdmin.TabIndex = 49;
            this.chkKichHoatTKAdmin.Text = "kích hoạt";
            this.chkKichHoatTKAdmin.UseVisualStyleBackColor = true;
            // 
            // UC_TaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.chkKichHoatTKAdmin);
            this.Controls.Add(this.dtpNgayTaoTKAdmin);
            this.Controls.Add(this.mtxtSDTTKAdmin);
            this.Controls.Add(this.dtgvTaiKhoanAdmin);
            this.Controls.Add(this.cbbQuyenTKAdmin);
            this.Controls.Add(this.btnLamMoiTKAdmin);
            this.Controls.Add(this.btnXoaTKAdmin);
            this.Controls.Add(this.btnLuuTKAdmin);
            this.Controls.Add(this.btnSuaTKAdmin);
            this.Controls.Add(this.txtTenNVTKAdmin);
            this.Controls.Add(this.txtCCCDTKAdmin);
            this.Controls.Add(this.txtDiaChiTKAdmin);
            this.Controls.Add(this.txtMatKhauTKAdmin);
            this.Controls.Add(this.txtEmailTKAdmin);
            this.Controls.Add(this.txtTenDNTKAdmin);
            this.Controls.Add(this.lblVaiTroTKAdmin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDiaChiTKAdmin);
            this.Controls.Add(this.lblMatKhauTKAdmin);
            this.Controls.Add(this.lblCCCDTKAdmin);
            this.Controls.Add(this.lblEmailTKAdmin);
            this.Controls.Add(this.lblTenNVTKAdmin);
            this.Controls.Add(this.lblSDTTKAdmin);
            this.Controls.Add(this.lblTieuDeTKAdmin);
            this.Controls.Add(this.lblTenDNTKAdmin);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UC_TaiKhoan";
            this.Size = new System.Drawing.Size(962, 558);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoanAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTaiKhoanAdmin;
        private System.Windows.Forms.ComboBox cbbQuyenTKAdmin;
        private System.Windows.Forms.Button btnLamMoiTKAdmin;
        private System.Windows.Forms.Button btnXoaTKAdmin;
        private System.Windows.Forms.Button btnLuuTKAdmin;
        private System.Windows.Forms.Button btnSuaTKAdmin;
        private System.Windows.Forms.TextBox txtTenNVTKAdmin;
        private System.Windows.Forms.TextBox txtCCCDTKAdmin;
        private System.Windows.Forms.TextBox txtMatKhauTKAdmin;
        private System.Windows.Forms.TextBox txtEmailTKAdmin;
        private System.Windows.Forms.TextBox txtTenDNTKAdmin;
        private System.Windows.Forms.Label lblVaiTroTKAdmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMatKhauTKAdmin;
        private System.Windows.Forms.Label lblCCCDTKAdmin;
        private System.Windows.Forms.Label lblEmailTKAdmin;
        private System.Windows.Forms.Label lblTenNVTKAdmin;
        private System.Windows.Forms.Label lblSDTTKAdmin;
        private System.Windows.Forms.Label lblTieuDeTKAdmin;
        private System.Windows.Forms.Label lblTenDNTKAdmin;
        private System.Windows.Forms.MaskedTextBox mtxtSDTTKAdmin;
        private System.Windows.Forms.DateTimePicker dtpNgayTaoTKAdmin;
        private System.Windows.Forms.Label lblDiaChiTKAdmin;
        private System.Windows.Forms.TextBox txtDiaChiTKAdmin;
        private System.Windows.Forms.CheckBox chkKichHoatTKAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}
