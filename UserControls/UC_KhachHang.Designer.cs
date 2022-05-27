
namespace QuanLyShopGiayDep.UserControls
{
    partial class UC_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_KhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblIDKHAdmin = new ReaLTaiizor.Controls.FoxLabel();
            this.lblTenKHAdmin = new ReaLTaiizor.Controls.FoxLabel();
            this.lblDiaChiKHAdmin = new ReaLTaiizor.Controls.FoxLabel();
            this.mtxtSDTKHAdmin = new System.Windows.Forms.MaskedTextBox();
            this.lblSDTKHAdmin = new ReaLTaiizor.Controls.FoxLabel();
            this.dtgvKhachHangAdmin = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colIDAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKHAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDTAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIDKHAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenKHAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChiKHAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuuKHAdmin = new ReaLTaiizor.Controls.AirButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHangAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDKHAdmin
            // 
            resources.ApplyResources(this.lblIDKHAdmin, "lblIDKHAdmin");
            this.lblIDKHAdmin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblIDKHAdmin.Name = "lblIDKHAdmin";
            // 
            // lblTenKHAdmin
            // 
            resources.ApplyResources(this.lblTenKHAdmin, "lblTenKHAdmin");
            this.lblTenKHAdmin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTenKHAdmin.Name = "lblTenKHAdmin";
            // 
            // lblDiaChiKHAdmin
            // 
            resources.ApplyResources(this.lblDiaChiKHAdmin, "lblDiaChiKHAdmin");
            this.lblDiaChiKHAdmin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDiaChiKHAdmin.Name = "lblDiaChiKHAdmin";
            // 
            // mtxtSDTKHAdmin
            // 
            resources.ApplyResources(this.mtxtSDTKHAdmin, "mtxtSDTKHAdmin");
            this.mtxtSDTKHAdmin.Name = "mtxtSDTKHAdmin";
            // 
            // lblSDTKHAdmin
            // 
            resources.ApplyResources(this.lblSDTKHAdmin, "lblSDTKHAdmin");
            this.lblSDTKHAdmin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSDTKHAdmin.Name = "lblSDTKHAdmin";
            // 
            // dtgvKhachHangAdmin
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvKhachHangAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvKhachHangAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvKhachHangAdmin.BackgroundColor = System.Drawing.Color.White;
            this.dtgvKhachHangAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvKhachHangAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvKhachHangAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvKhachHangAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dtgvKhachHangAdmin, "dtgvKhachHangAdmin");
            this.dtgvKhachHangAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDAdmin,
            this.colTenKHAdmin,
            this.colSDTAdmin,
            this.colDiaChiAdmin});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvKhachHangAdmin.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvKhachHangAdmin.EnableHeadersVisualStyles = false;
            this.dtgvKhachHangAdmin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvKhachHangAdmin.Name = "dtgvKhachHangAdmin";
            this.dtgvKhachHangAdmin.RowHeadersVisible = false;
            this.dtgvKhachHangAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvKhachHangAdmin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvKhachHangAdmin.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvKhachHangAdmin.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvKhachHangAdmin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvKhachHangAdmin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvKhachHangAdmin.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvKhachHangAdmin.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvKhachHangAdmin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvKhachHangAdmin.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvKhachHangAdmin.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvKhachHangAdmin.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvKhachHangAdmin.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvKhachHangAdmin.ThemeStyle.HeaderStyle.Height = 21;
            this.dtgvKhachHangAdmin.ThemeStyle.ReadOnly = false;
            this.dtgvKhachHangAdmin.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvKhachHangAdmin.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvKhachHangAdmin.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvKhachHangAdmin.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvKhachHangAdmin.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvKhachHangAdmin.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvKhachHangAdmin.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colIDAdmin
            // 
            resources.ApplyResources(this.colIDAdmin, "colIDAdmin");
            this.colIDAdmin.Name = "colIDAdmin";
            // 
            // colTenKHAdmin
            // 
            resources.ApplyResources(this.colTenKHAdmin, "colTenKHAdmin");
            this.colTenKHAdmin.Name = "colTenKHAdmin";
            // 
            // colSDTAdmin
            // 
            resources.ApplyResources(this.colSDTAdmin, "colSDTAdmin");
            this.colSDTAdmin.Name = "colSDTAdmin";
            // 
            // colDiaChiAdmin
            // 
            resources.ApplyResources(this.colDiaChiAdmin, "colDiaChiAdmin");
            this.colDiaChiAdmin.Name = "colDiaChiAdmin";
            // 
            // txtIDKHAdmin
            // 
            this.txtIDKHAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDKHAdmin.DefaultText = "";
            this.txtIDKHAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDKHAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDKHAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDKHAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDKHAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtIDKHAdmin, "txtIDKHAdmin");
            this.txtIDKHAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDKHAdmin.Name = "txtIDKHAdmin";
            this.txtIDKHAdmin.PasswordChar = '\0';
            this.txtIDKHAdmin.PlaceholderText = "";
            this.txtIDKHAdmin.SelectedText = "";
            // 
            // txtTenKHAdmin
            // 
            this.txtTenKHAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKHAdmin.DefaultText = "";
            this.txtTenKHAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKHAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKHAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKHAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKHAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtTenKHAdmin, "txtTenKHAdmin");
            this.txtTenKHAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKHAdmin.Name = "txtTenKHAdmin";
            this.txtTenKHAdmin.PasswordChar = '\0';
            this.txtTenKHAdmin.PlaceholderText = "";
            this.txtTenKHAdmin.SelectedText = "";
            // 
            // txtDiaChiKHAdmin
            // 
            this.txtDiaChiKHAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChiKHAdmin.DefaultText = "";
            this.txtDiaChiKHAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChiKHAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChiKHAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChiKHAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChiKHAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtDiaChiKHAdmin, "txtDiaChiKHAdmin");
            this.txtDiaChiKHAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChiKHAdmin.Name = "txtDiaChiKHAdmin";
            this.txtDiaChiKHAdmin.PasswordChar = '\0';
            this.txtDiaChiKHAdmin.PlaceholderText = "";
            this.txtDiaChiKHAdmin.SelectedText = "";
            // 
            // btnLuuKHAdmin
            // 
            this.btnLuuKHAdmin.BackColor = System.Drawing.Color.Silver;
            this.btnLuuKHAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuKHAdmin.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            resources.ApplyResources(this.btnLuuKHAdmin, "btnLuuKHAdmin");
            this.btnLuuKHAdmin.Image = null;
            this.btnLuuKHAdmin.Name = "btnLuuKHAdmin";
            this.btnLuuKHAdmin.NoRounding = false;
            this.btnLuuKHAdmin.Transparent = false;
            // 
            // UC_KhachHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.btnLuuKHAdmin);
            this.Controls.Add(this.txtDiaChiKHAdmin);
            this.Controls.Add(this.txtTenKHAdmin);
            this.Controls.Add(this.txtIDKHAdmin);
            this.Controls.Add(this.dtgvKhachHangAdmin);
            this.Controls.Add(this.mtxtSDTKHAdmin);
            this.Controls.Add(this.lblDiaChiKHAdmin);
            this.Controls.Add(this.lblSDTKHAdmin);
            this.Controls.Add(this.lblTenKHAdmin);
            this.Controls.Add(this.lblIDKHAdmin);
            this.Name = "UC_KhachHang";
            resources.ApplyResources(this, "$this");
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHangAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.FoxLabel lblIDKHAdmin;
        private ReaLTaiizor.Controls.FoxLabel lblTenKHAdmin;
        private ReaLTaiizor.Controls.FoxLabel lblDiaChiKHAdmin;
        private System.Windows.Forms.MaskedTextBox mtxtSDTKHAdmin;
        private ReaLTaiizor.Controls.FoxLabel lblSDTKHAdmin;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvKhachHangAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKHAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDTAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiAdmin;
        private Guna.UI2.WinForms.Guna2TextBox txtIDKHAdmin;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKHAdmin;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChiKHAdmin;
        private ReaLTaiizor.Controls.AirButton btnLuuKHAdmin;
    }
}
