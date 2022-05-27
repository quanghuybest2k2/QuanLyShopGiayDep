
namespace QuanLyShopGiayDep.UserControls
{
    partial class UC_NhaCC
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
            this.gbTopAdmin = new System.Windows.Forms.GroupBox();
            this.btnTimKiemNhaCC = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            this.txtDiaChiNhaCCAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNhaCCAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDNhaCCAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.mtxtSDTNhaCCAdmin = new System.Windows.Forms.MaskedTextBox();
            this.lblTGCCAdmin = new ReaLTaiizor.Controls.FoxLabel();
            this.lblDiaChiNhaCCAdmin = new ReaLTaiizor.Controls.FoxLabel();
            this.lblSDTNhaCCAdmin = new ReaLTaiizor.Controls.FoxLabel();
            this.lblTenNhaCCAdmin = new ReaLTaiizor.Controls.FoxLabel();
            this.lblIDNhCCAdmin = new ReaLTaiizor.Controls.FoxLabel();
            this.gbDanhSachNhaCC = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachNhaCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemNhaCC = new System.Windows.Forms.Button();
            this.gbTopAdmin.SuspendLayout();
            this.gbDanhSachNhaCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachNhaCC)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTopAdmin
            // 
            this.gbTopAdmin.Controls.Add(this.btnTimKiemNhaCC);
            this.gbTopAdmin.Controls.Add(this.dtpDenNgay);
            this.gbTopAdmin.Controls.Add(this.dtpTuNgay);
            this.gbTopAdmin.Controls.Add(this.foxLabel2);
            this.gbTopAdmin.Controls.Add(this.foxLabel1);
            this.gbTopAdmin.Controls.Add(this.txtDiaChiNhaCCAdmin);
            this.gbTopAdmin.Controls.Add(this.txtTenNhaCCAdmin);
            this.gbTopAdmin.Controls.Add(this.txtIDNhaCCAdmin);
            this.gbTopAdmin.Controls.Add(this.mtxtSDTNhaCCAdmin);
            this.gbTopAdmin.Controls.Add(this.lblTGCCAdmin);
            this.gbTopAdmin.Controls.Add(this.lblDiaChiNhaCCAdmin);
            this.gbTopAdmin.Controls.Add(this.lblSDTNhaCCAdmin);
            this.gbTopAdmin.Controls.Add(this.lblTenNhaCCAdmin);
            this.gbTopAdmin.Controls.Add(this.lblIDNhCCAdmin);
            this.gbTopAdmin.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTopAdmin.ForeColor = System.Drawing.Color.White;
            this.gbTopAdmin.Location = new System.Drawing.Point(82, 3);
            this.gbTopAdmin.Name = "gbTopAdmin";
            this.gbTopAdmin.Size = new System.Drawing.Size(811, 254);
            this.gbTopAdmin.TabIndex = 1;
            this.gbTopAdmin.TabStop = false;
            this.gbTopAdmin.Text = "Tìm kiếm theo nhà cung cấp";
            // 
            // btnTimKiemNhaCC
            // 
            this.btnTimKiemNhaCC.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTimKiemNhaCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemNhaCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemNhaCC.Location = new System.Drawing.Point(281, 210);
            this.btnTimKiemNhaCC.Name = "btnTimKiemNhaCC";
            this.btnTimKiemNhaCC.Size = new System.Drawing.Size(179, 38);
            this.btnTimKiemNhaCC.TabIndex = 5;
            this.btnTimKiemNhaCC.Text = "Tìm kiếm";
            this.btnTimKiemNhaCC.UseVisualStyleBackColor = false;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(553, 181);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(179, 22);
            this.dtpDenNgay.TabIndex = 17;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(281, 181);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(179, 22);
            this.dtpTuNgay.TabIndex = 17;
            // 
            // foxLabel2
            // 
            this.foxLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.foxLabel2.Location = new System.Drawing.Point(475, 186);
            this.foxLabel2.Name = "foxLabel2";
            this.foxLabel2.Size = new System.Drawing.Size(106, 17);
            this.foxLabel2.TabIndex = 16;
            this.foxLabel2.Text = "Đến ngày:";
            // 
            // foxLabel1
            // 
            this.foxLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.foxLabel1.Location = new System.Drawing.Point(217, 182);
            this.foxLabel1.Name = "foxLabel1";
            this.foxLabel1.Size = new System.Drawing.Size(106, 17);
            this.foxLabel1.TabIndex = 15;
            this.foxLabel1.Text = "Từ ngày:";
            // 
            // txtDiaChiNhaCCAdmin
            // 
            this.txtDiaChiNhaCCAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChiNhaCCAdmin.DefaultText = "";
            this.txtDiaChiNhaCCAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChiNhaCCAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChiNhaCCAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChiNhaCCAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChiNhaCCAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChiNhaCCAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChiNhaCCAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChiNhaCCAdmin.Location = new System.Drawing.Point(253, 137);
            this.txtDiaChiNhaCCAdmin.Name = "txtDiaChiNhaCCAdmin";
            this.txtDiaChiNhaCCAdmin.PasswordChar = '\0';
            this.txtDiaChiNhaCCAdmin.PlaceholderText = "";
            this.txtDiaChiNhaCCAdmin.SelectedText = "";
            this.txtDiaChiNhaCCAdmin.Size = new System.Drawing.Size(251, 28);
            this.txtDiaChiNhaCCAdmin.TabIndex = 4;
            // 
            // txtTenNhaCCAdmin
            // 
            this.txtTenNhaCCAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhaCCAdmin.DefaultText = "";
            this.txtTenNhaCCAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNhaCCAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNhaCCAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhaCCAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhaCCAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhaCCAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNhaCCAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhaCCAdmin.Location = new System.Drawing.Point(254, 58);
            this.txtTenNhaCCAdmin.Name = "txtTenNhaCCAdmin";
            this.txtTenNhaCCAdmin.PasswordChar = '\0';
            this.txtTenNhaCCAdmin.PlaceholderText = "";
            this.txtTenNhaCCAdmin.SelectedText = "";
            this.txtTenNhaCCAdmin.Size = new System.Drawing.Size(251, 28);
            this.txtTenNhaCCAdmin.TabIndex = 2;
            // 
            // txtIDNhaCCAdmin
            // 
            this.txtIDNhaCCAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDNhaCCAdmin.DefaultText = "";
            this.txtIDNhaCCAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDNhaCCAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDNhaCCAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNhaCCAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNhaCCAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNhaCCAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDNhaCCAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNhaCCAdmin.Location = new System.Drawing.Point(254, 15);
            this.txtIDNhaCCAdmin.Name = "txtIDNhaCCAdmin";
            this.txtIDNhaCCAdmin.PasswordChar = '\0';
            this.txtIDNhaCCAdmin.PlaceholderText = "";
            this.txtIDNhaCCAdmin.SelectedText = "";
            this.txtIDNhaCCAdmin.Size = new System.Drawing.Size(251, 28);
            this.txtIDNhaCCAdmin.TabIndex = 1;
            // 
            // mtxtSDTNhaCCAdmin
            // 
            this.mtxtSDTNhaCCAdmin.Location = new System.Drawing.Point(253, 99);
            this.mtxtSDTNhaCCAdmin.Mask = "000.000.0000";
            this.mtxtSDTNhaCCAdmin.Name = "mtxtSDTNhaCCAdmin";
            this.mtxtSDTNhaCCAdmin.Size = new System.Drawing.Size(251, 22);
            this.mtxtSDTNhaCCAdmin.TabIndex = 3;
            // 
            // lblTGCCAdmin
            // 
            this.lblTGCCAdmin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTGCCAdmin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTGCCAdmin.Location = new System.Drawing.Point(44, 182);
            this.lblTGCCAdmin.Name = "lblTGCCAdmin";
            this.lblTGCCAdmin.Size = new System.Drawing.Size(158, 21);
            this.lblTGCCAdmin.TabIndex = 0;
            this.lblTGCCAdmin.Text = "Thời gian cung cấp hàng";
            // 
            // lblDiaChiNhaCCAdmin
            // 
            this.lblDiaChiNhaCCAdmin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiaChiNhaCCAdmin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDiaChiNhaCCAdmin.Location = new System.Drawing.Point(44, 148);
            this.lblDiaChiNhaCCAdmin.Name = "lblDiaChiNhaCCAdmin";
            this.lblDiaChiNhaCCAdmin.Size = new System.Drawing.Size(106, 17);
            this.lblDiaChiNhaCCAdmin.TabIndex = 0;
            this.lblDiaChiNhaCCAdmin.Text = "Địa chỉ";
            // 
            // lblSDTNhaCCAdmin
            // 
            this.lblSDTNhaCCAdmin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSDTNhaCCAdmin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSDTNhaCCAdmin.Location = new System.Drawing.Point(44, 104);
            this.lblSDTNhaCCAdmin.Name = "lblSDTNhaCCAdmin";
            this.lblSDTNhaCCAdmin.Size = new System.Drawing.Size(106, 17);
            this.lblSDTNhaCCAdmin.TabIndex = 0;
            this.lblSDTNhaCCAdmin.Text = "Số điện thoại";
            // 
            // lblTenNhaCCAdmin
            // 
            this.lblTenNhaCCAdmin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTenNhaCCAdmin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTenNhaCCAdmin.Location = new System.Drawing.Point(44, 67);
            this.lblTenNhaCCAdmin.Name = "lblTenNhaCCAdmin";
            this.lblTenNhaCCAdmin.Size = new System.Drawing.Size(128, 19);
            this.lblTenNhaCCAdmin.TabIndex = 0;
            this.lblTenNhaCCAdmin.Text = "Tên nhà cung cấp";
            // 
            // lblIDNhCCAdmin
            // 
            this.lblIDNhCCAdmin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIDNhCCAdmin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblIDNhCCAdmin.Location = new System.Drawing.Point(44, 24);
            this.lblIDNhCCAdmin.Name = "lblIDNhCCAdmin";
            this.lblIDNhCCAdmin.Size = new System.Drawing.Size(53, 19);
            this.lblIDNhCCAdmin.TabIndex = 0;
            this.lblIDNhCCAdmin.Text = "ID";
            // 
            // gbDanhSachNhaCC
            // 
            this.gbDanhSachNhaCC.Controls.Add(this.dtgvDanhSachNhaCC);
            this.gbDanhSachNhaCC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDanhSachNhaCC.ForeColor = System.Drawing.Color.White;
            this.gbDanhSachNhaCC.Location = new System.Drawing.Point(82, 256);
            this.gbDanhSachNhaCC.Name = "gbDanhSachNhaCC";
            this.gbDanhSachNhaCC.Size = new System.Drawing.Size(811, 258);
            this.gbDanhSachNhaCC.TabIndex = 0;
            this.gbDanhSachNhaCC.TabStop = false;
            this.gbDanhSachNhaCC.Text = "Danh sách nhà cung cấp";
            // 
            // dtgvDanhSachNhaCC
            // 
            this.dtgvDanhSachNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachNhaCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgvDanhSachNhaCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachNhaCC.Location = new System.Drawing.Point(3, 21);
            this.dtgvDanhSachNhaCC.Name = "dtgvDanhSachNhaCC";
            this.dtgvDanhSachNhaCC.Size = new System.Drawing.Size(805, 234);
            this.dtgvDanhSachNhaCC.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã nhà cung cấp";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên nhà cung cấp";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Từ ngày";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Đến ngày";
            this.Column6.Name = "Column6";
            // 
            // btnThemNhaCC
            // 
            this.btnThemNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhaCC.Location = new System.Drawing.Point(899, 256);
            this.btnThemNhaCC.Name = "btnThemNhaCC";
            this.btnThemNhaCC.Size = new System.Drawing.Size(43, 30);
            this.btnThemNhaCC.TabIndex = 6;
            this.btnThemNhaCC.Text = "+";
            this.btnThemNhaCC.UseVisualStyleBackColor = true;
            // 
            // UC_NhaCC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.btnThemNhaCC);
            this.Controls.Add(this.gbDanhSachNhaCC);
            this.Controls.Add(this.gbTopAdmin);
            this.Name = "UC_NhaCC";
            this.Size = new System.Drawing.Size(962, 517);
            this.gbTopAdmin.ResumeLayout(false);
            this.gbTopAdmin.PerformLayout();
            this.gbDanhSachNhaCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachNhaCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTopAdmin;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChiNhaCCAdmin;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNhaCCAdmin;
        private Guna.UI2.WinForms.Guna2TextBox txtIDNhaCCAdmin;
        private System.Windows.Forms.MaskedTextBox mtxtSDTNhaCCAdmin;
        private ReaLTaiizor.Controls.FoxLabel lblDiaChiNhaCCAdmin;
        private ReaLTaiizor.Controls.FoxLabel lblSDTNhaCCAdmin;
        private ReaLTaiizor.Controls.FoxLabel lblTenNhaCCAdmin;
        private ReaLTaiizor.Controls.FoxLabel lblIDNhCCAdmin;
        private ReaLTaiizor.Controls.FoxLabel lblTGCCAdmin;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.GroupBox gbDanhSachNhaCC;
        private System.Windows.Forms.Button btnThemNhaCC;
        private System.Windows.Forms.DataGridView dtgvDanhSachNhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnTimKiemNhaCC;
    }
}
