
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
            this.dtgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.colMaTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDangNhapTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNVTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCCDTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDTTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVaiTroTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTaoTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbQuyenTaiKhoan = new System.Windows.Forms.ComboBox();
            this.btnLamMoiTaiKhoan = new System.Windows.Forms.Button();
            this.btnXoaTaiKhoan = new System.Windows.Forms.Button();
            this.btnLuuTaiKhoan = new System.Windows.Forms.Button();
            this.btnSuaTaiKhoan = new System.Windows.Forms.Button();
            this.txtTenNVTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtCCCDTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhauTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtEmailTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtTenDNTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblVaiTroTKAdmin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMatKhauTKAdmin = new System.Windows.Forms.Label();
            this.lblCCCDTKAdmin = new System.Windows.Forms.Label();
            this.lblEmailTKAdmin = new System.Windows.Forms.Label();
            this.lblTenNVTKAdmin = new System.Windows.Forms.Label();
            this.lblSDTTKAdmin = new System.Windows.Forms.Label();
            this.lblTieuDeTaiKhoan = new System.Windows.Forms.Label();
            this.lblTenDNTKAdmin = new System.Windows.Forms.Label();
            this.mtxtSDTTaiKhoan = new System.Windows.Forms.MaskedTextBox();
            this.dtpNgayTaoTaiKhoan = new System.Windows.Forms.DateTimePicker();
            this.lblDiaChiTKAdmin = new System.Windows.Forms.Label();
            this.txtDiaChiTaiKhoan = new System.Windows.Forms.TextBox();
            this.chkKichHoatTaiKhoan = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTaiKhoan
            // 
            this.dtgvTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTaiKhoan,
            this.colTenDangNhapTaiKhoan,
            this.colTenNVTaiKhoan,
            this.colCCCDTaiKhoan,
            this.colSDTTaiKhoan,
            this.colEmailTaiKhoan,
            this.colDiaChiTaiKhoan,
            this.colVaiTroTaiKhoan,
            this.colTrangThaiTaiKhoan,
            this.colNgayTaoTaiKhoan});
            this.dtgvTaiKhoan.Location = new System.Drawing.Point(0, 335);
            this.dtgvTaiKhoan.Name = "dtgvTaiKhoan";
            this.dtgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTaiKhoan.Size = new System.Drawing.Size(959, 183);
            this.dtgvTaiKhoan.TabIndex = 13;
            // 
            // colMaTaiKhoan
            // 
            this.colMaTaiKhoan.HeaderText = "Mã tài khoản";
            this.colMaTaiKhoan.Name = "colMaTaiKhoan";
            // 
            // colTenDangNhapTaiKhoan
            // 
            this.colTenDangNhapTaiKhoan.HeaderText = "Tên đăng nhập";
            this.colTenDangNhapTaiKhoan.Name = "colTenDangNhapTaiKhoan";
            // 
            // colTenNVTaiKhoan
            // 
            this.colTenNVTaiKhoan.HeaderText = "Tên nhân viên";
            this.colTenNVTaiKhoan.Name = "colTenNVTaiKhoan";
            // 
            // colCCCDTaiKhoan
            // 
            this.colCCCDTaiKhoan.HeaderText = "Số CCCD";
            this.colCCCDTaiKhoan.Name = "colCCCDTaiKhoan";
            // 
            // colSDTTaiKhoan
            // 
            this.colSDTTaiKhoan.HeaderText = "Số điện thoại";
            this.colSDTTaiKhoan.Name = "colSDTTaiKhoan";
            // 
            // colEmailTaiKhoan
            // 
            this.colEmailTaiKhoan.HeaderText = "Email";
            this.colEmailTaiKhoan.Name = "colEmailTaiKhoan";
            // 
            // colDiaChiTaiKhoan
            // 
            this.colDiaChiTaiKhoan.HeaderText = "Địa chỉ";
            this.colDiaChiTaiKhoan.Name = "colDiaChiTaiKhoan";
            // 
            // colVaiTroTaiKhoan
            // 
            this.colVaiTroTaiKhoan.HeaderText = "Vai trò";
            this.colVaiTroTaiKhoan.Name = "colVaiTroTaiKhoan";
            // 
            // colTrangThaiTaiKhoan
            // 
            this.colTrangThaiTaiKhoan.HeaderText = "Trạng thái";
            this.colTrangThaiTaiKhoan.Name = "colTrangThaiTaiKhoan";
            // 
            // colNgayTaoTaiKhoan
            // 
            this.colNgayTaoTaiKhoan.HeaderText = "Ngày tạo";
            this.colNgayTaoTaiKhoan.Name = "colNgayTaoTaiKhoan";
            // 
            // cbbQuyenTaiKhoan
            // 
            this.cbbQuyenTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbQuyenTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQuyenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbQuyenTaiKhoan.FormattingEnabled = true;
            this.cbbQuyenTaiKhoan.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbbQuyenTaiKhoan.Location = new System.Drawing.Point(594, 204);
            this.cbbQuyenTaiKhoan.Name = "cbbQuyenTaiKhoan";
            this.cbbQuyenTaiKhoan.Size = new System.Drawing.Size(244, 23);
            this.cbbQuyenTaiKhoan.TabIndex = 9;
            // 
            // btnLamMoiTaiKhoan
            // 
            this.btnLamMoiTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLamMoiTaiKhoan.BackColor = System.Drawing.Color.Tomato;
            this.btnLamMoiTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnLamMoiTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiTaiKhoan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiTaiKhoan.Location = new System.Drawing.Point(554, 291);
            this.btnLamMoiTaiKhoan.Name = "btnLamMoiTaiKhoan";
            this.btnLamMoiTaiKhoan.Size = new System.Drawing.Size(124, 38);
            this.btnLamMoiTaiKhoan.TabIndex = 11;
            this.btnLamMoiTaiKhoan.Text = "Làm mới";
            this.btnLamMoiTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaTaiKhoan.BackColor = System.Drawing.Color.Red;
            this.btnXoaTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnXoaTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTaiKhoan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(594, 524);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(111, 38);
            this.btnXoaTaiKhoan.TabIndex = 14;
            this.btnXoaTaiKhoan.Text = "Xóa";
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // btnLuuTaiKhoan
            // 
            this.btnLuuTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuuTaiKhoan.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLuuTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnLuuTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuTaiKhoan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnLuuTaiKhoan.Location = new System.Drawing.Point(708, 291);
            this.btnLuuTaiKhoan.Name = "btnLuuTaiKhoan";
            this.btnLuuTaiKhoan.Size = new System.Drawing.Size(141, 38);
            this.btnLuuTaiKhoan.TabIndex = 12;
            this.btnLuuTaiKhoan.Text = "Lưu";
            this.btnLuuTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // btnSuaTaiKhoan
            // 
            this.btnSuaTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaTaiKhoan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuaTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnSuaTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTaiKhoan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnSuaTaiKhoan.Location = new System.Drawing.Point(727, 524);
            this.btnSuaTaiKhoan.Name = "btnSuaTaiKhoan";
            this.btnSuaTaiKhoan.Size = new System.Drawing.Size(111, 38);
            this.btnSuaTaiKhoan.TabIndex = 15;
            this.btnSuaTaiKhoan.Text = "Chỉnh Sửa";
            this.btnSuaTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // txtTenNVTaiKhoan
            // 
            this.txtTenNVTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNVTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtTenNVTaiKhoan.Location = new System.Drawing.Point(594, 56);
            this.txtTenNVTaiKhoan.Name = "txtTenNVTaiKhoan";
            this.txtTenNVTaiKhoan.Size = new System.Drawing.Size(244, 20);
            this.txtTenNVTaiKhoan.TabIndex = 6;
            // 
            // txtCCCDTaiKhoan
            // 
            this.txtCCCDTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCCCDTaiKhoan.Location = new System.Drawing.Point(594, 102);
            this.txtCCCDTaiKhoan.Name = "txtCCCDTaiKhoan";
            this.txtCCCDTaiKhoan.Size = new System.Drawing.Size(244, 20);
            this.txtCCCDTaiKhoan.TabIndex = 7;
            // 
            // txtMatKhauTaiKhoan
            // 
            this.txtMatKhauTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMatKhauTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtMatKhauTaiKhoan.Location = new System.Drawing.Point(241, 203);
            this.txtMatKhauTaiKhoan.Name = "txtMatKhauTaiKhoan";
            this.txtMatKhauTaiKhoan.PasswordChar = '*';
            this.txtMatKhauTaiKhoan.Size = new System.Drawing.Size(199, 20);
            this.txtMatKhauTaiKhoan.TabIndex = 4;
            // 
            // txtEmailTaiKhoan
            // 
            this.txtEmailTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtEmailTaiKhoan.Location = new System.Drawing.Point(241, 156);
            this.txtEmailTaiKhoan.Name = "txtEmailTaiKhoan";
            this.txtEmailTaiKhoan.Size = new System.Drawing.Size(199, 20);
            this.txtEmailTaiKhoan.TabIndex = 3;
            // 
            // txtTenDNTaiKhoan
            // 
            this.txtTenDNTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenDNTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtTenDNTaiKhoan.Location = new System.Drawing.Point(241, 54);
            this.txtTenDNTaiKhoan.Name = "txtTenDNTaiKhoan";
            this.txtTenDNTaiKhoan.Size = new System.Drawing.Size(199, 20);
            this.txtTenDNTaiKhoan.TabIndex = 1;
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
            // lblTieuDeTaiKhoan
            // 
            this.lblTieuDeTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTieuDeTaiKhoan.AutoSize = true;
            this.lblTieuDeTaiKhoan.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeTaiKhoan.Location = new System.Drawing.Point(404, 6);
            this.lblTieuDeTaiKhoan.Name = "lblTieuDeTaiKhoan";
            this.lblTieuDeTaiKhoan.Size = new System.Drawing.Size(213, 28);
            this.lblTieuDeTaiKhoan.TabIndex = 33;
            this.lblTieuDeTaiKhoan.Text = "Quản lý tài khoản";
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
            // mtxtSDTTaiKhoan
            // 
            this.mtxtSDTTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtSDTTaiKhoan.Location = new System.Drawing.Point(241, 105);
            this.mtxtSDTTaiKhoan.Mask = "000.000.0000";
            this.mtxtSDTTaiKhoan.Name = "mtxtSDTTaiKhoan";
            this.mtxtSDTTaiKhoan.Size = new System.Drawing.Size(199, 20);
            this.mtxtSDTTaiKhoan.TabIndex = 2;
            // 
            // dtpNgayTaoTaiKhoan
            // 
            this.dtpNgayTaoTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgayTaoTaiKhoan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTaoTaiKhoan.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTaoTaiKhoan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTaoTaiKhoan.Location = new System.Drawing.Point(594, 155);
            this.dtpNgayTaoTaiKhoan.Name = "dtpNgayTaoTaiKhoan";
            this.dtpNgayTaoTaiKhoan.Size = new System.Drawing.Size(244, 22);
            this.dtpNgayTaoTaiKhoan.TabIndex = 8;
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
            // txtDiaChiTaiKhoan
            // 
            this.txtDiaChiTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiaChiTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtDiaChiTaiKhoan.Location = new System.Drawing.Point(241, 250);
            this.txtDiaChiTaiKhoan.Name = "txtDiaChiTaiKhoan";
            this.txtDiaChiTaiKhoan.PasswordChar = '*';
            this.txtDiaChiTaiKhoan.Size = new System.Drawing.Size(199, 20);
            this.txtDiaChiTaiKhoan.TabIndex = 5;
            // 
            // chkKichHoatTaiKhoan
            // 
            this.chkKichHoatTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkKichHoatTaiKhoan.AutoSize = true;
            this.chkKichHoatTaiKhoan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKichHoatTaiKhoan.Location = new System.Drawing.Point(594, 247);
            this.chkKichHoatTaiKhoan.Name = "chkKichHoatTaiKhoan";
            this.chkKichHoatTaiKhoan.Size = new System.Drawing.Size(99, 23);
            this.chkKichHoatTaiKhoan.TabIndex = 10;
            this.chkKichHoatTaiKhoan.Text = "Kích hoạt";
            this.chkKichHoatTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // UC_TaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.chkKichHoatTaiKhoan);
            this.Controls.Add(this.dtpNgayTaoTaiKhoan);
            this.Controls.Add(this.mtxtSDTTaiKhoan);
            this.Controls.Add(this.dtgvTaiKhoan);
            this.Controls.Add(this.cbbQuyenTaiKhoan);
            this.Controls.Add(this.btnLamMoiTaiKhoan);
            this.Controls.Add(this.btnXoaTaiKhoan);
            this.Controls.Add(this.btnLuuTaiKhoan);
            this.Controls.Add(this.btnSuaTaiKhoan);
            this.Controls.Add(this.txtTenNVTaiKhoan);
            this.Controls.Add(this.txtCCCDTaiKhoan);
            this.Controls.Add(this.txtDiaChiTaiKhoan);
            this.Controls.Add(this.txtMatKhauTaiKhoan);
            this.Controls.Add(this.txtEmailTaiKhoan);
            this.Controls.Add(this.txtTenDNTaiKhoan);
            this.Controls.Add(this.lblVaiTroTKAdmin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDiaChiTKAdmin);
            this.Controls.Add(this.lblMatKhauTKAdmin);
            this.Controls.Add(this.lblCCCDTKAdmin);
            this.Controls.Add(this.lblEmailTKAdmin);
            this.Controls.Add(this.lblTenNVTKAdmin);
            this.Controls.Add(this.lblSDTTKAdmin);
            this.Controls.Add(this.lblTieuDeTaiKhoan);
            this.Controls.Add(this.lblTenDNTKAdmin);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UC_TaiKhoan";
            this.Size = new System.Drawing.Size(962, 558);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTaiKhoan;
        private System.Windows.Forms.ComboBox cbbQuyenTaiKhoan;
        private System.Windows.Forms.Button btnLamMoiTaiKhoan;
        private System.Windows.Forms.Button btnXoaTaiKhoan;
        private System.Windows.Forms.Button btnLuuTaiKhoan;
        private System.Windows.Forms.Button btnSuaTaiKhoan;
        private System.Windows.Forms.TextBox txtTenNVTaiKhoan;
        private System.Windows.Forms.TextBox txtCCCDTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhauTaiKhoan;
        private System.Windows.Forms.TextBox txtEmailTaiKhoan;
        private System.Windows.Forms.TextBox txtTenDNTaiKhoan;
        private System.Windows.Forms.Label lblVaiTroTKAdmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMatKhauTKAdmin;
        private System.Windows.Forms.Label lblCCCDTKAdmin;
        private System.Windows.Forms.Label lblEmailTKAdmin;
        private System.Windows.Forms.Label lblTenNVTKAdmin;
        private System.Windows.Forms.Label lblSDTTKAdmin;
        private System.Windows.Forms.Label lblTieuDeTaiKhoan;
        private System.Windows.Forms.Label lblTenDNTKAdmin;
        private System.Windows.Forms.MaskedTextBox mtxtSDTTaiKhoan;
        private System.Windows.Forms.DateTimePicker dtpNgayTaoTaiKhoan;
        private System.Windows.Forms.Label lblDiaChiTKAdmin;
        private System.Windows.Forms.TextBox txtDiaChiTaiKhoan;
        private System.Windows.Forms.CheckBox chkKichHoatTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhapTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNVTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCCDTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDTTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaiTroTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTaoTaiKhoan;
    }
}
