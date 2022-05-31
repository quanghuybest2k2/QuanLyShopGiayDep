﻿
namespace QuanLyShopGiayDep.UserControls
{
    partial class UC_HangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HangHoa));
            this.txtTimKiemHHAdmin = new System.Windows.Forms.TextBox();
            this.lblTimKiemHHAdmin = new System.Windows.Forms.Label();
            this.cbbTimKiemHHAdmin = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.paneLeftHH = new System.Windows.Forms.Panel();
            this.txtTimDMHHAdmin = new System.Windows.Forms.TextBox();
            this.btnBootAdmin = new System.Windows.Forms.Button();
            this.btnGuocAdmin = new System.Windows.Forms.Button();
            this.btnGiayAdmin = new System.Windows.Forms.Button();
            this.btnDepAdmin = new System.Windows.Forms.Button();
            this.dtgvHangHoaAdmin = new System.Windows.Forms.DataGridView();
            this.panelRightHH = new System.Windows.Forms.Panel();
            this.cbbSoLuongHH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoLuongHH = new System.Windows.Forms.Label();
            this.nrudSoLuongHH = new System.Windows.Forms.NumericUpDown();
            this.cbbNhaCCHH = new System.Windows.Forms.ComboBox();
            this.btnThemDanhMucHH = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStripTongDM = new System.Windows.Forms.StatusStrip();
            this.tsmlTongHH = new System.Windows.Forms.ToolStripStatusLabel();
            this.colIDHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenGDHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDVTHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhaCCHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHinhAnhHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6.SuspendLayout();
            this.paneLeftHH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangHoaAdmin)).BeginInit();
            this.panelRightHH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudSoLuongHH)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStripTongDM.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiemHHAdmin
            // 
            this.txtTimKiemHHAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemHHAdmin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemHHAdmin.ForeColor = System.Drawing.Color.White;
            this.txtTimKiemHHAdmin.Location = new System.Drawing.Point(760, 38);
            this.txtTimKiemHHAdmin.Name = "txtTimKiemHHAdmin";
            this.txtTimKiemHHAdmin.Size = new System.Drawing.Size(179, 21);
            this.txtTimKiemHHAdmin.TabIndex = 5;
            // 
            // lblTimKiemHHAdmin
            // 
            this.lblTimKiemHHAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimKiemHHAdmin.AutoSize = true;
            this.lblTimKiemHHAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemHHAdmin.ForeColor = System.Drawing.Color.White;
            this.lblTimKiemHHAdmin.Location = new System.Drawing.Point(462, 37);
            this.lblTimKiemHHAdmin.Name = "lblTimKiemHHAdmin";
            this.lblTimKiemHHAdmin.Size = new System.Drawing.Size(151, 19);
            this.lblTimKiemHHAdmin.TabIndex = 4;
            this.lblTimKiemHHAdmin.Text = "Tìm kiếm theo loại:";
            // 
            // cbbTimKiemHHAdmin
            // 
            this.cbbTimKiemHHAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTimKiemHHAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiemHHAdmin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimKiemHHAdmin.FormattingEnabled = true;
            this.cbbTimKiemHHAdmin.Items.AddRange(new object[] {
            "Tên giày dép",
            "Giá tiền",
            "Loại giày dép"});
            this.cbbTimKiemHHAdmin.Location = new System.Drawing.Point(619, 36);
            this.cbbTimKiemHHAdmin.Name = "cbbTimKiemHHAdmin";
            this.cbbTimKiemHHAdmin.Size = new System.Drawing.Size(138, 23);
            this.cbbTimKiemHHAdmin.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.paneLeftHH);
            this.panel6.Controls.Add(this.dtgvHangHoaAdmin);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(10, 77);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(942, 459);
            this.panel6.TabIndex = 12;
            // 
            // paneLeftHH
            // 
            this.paneLeftHH.Controls.Add(this.txtTimDMHHAdmin);
            this.paneLeftHH.Controls.Add(this.btnBootAdmin);
            this.paneLeftHH.Controls.Add(this.btnGuocAdmin);
            this.paneLeftHH.Controls.Add(this.btnGiayAdmin);
            this.paneLeftHH.Controls.Add(this.btnDepAdmin);
            this.paneLeftHH.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneLeftHH.Location = new System.Drawing.Point(0, 0);
            this.paneLeftHH.Name = "paneLeftHH";
            this.paneLeftHH.Size = new System.Drawing.Size(193, 459);
            this.paneLeftHH.TabIndex = 2;
            // 
            // txtTimDMHHAdmin
            // 
            this.txtTimDMHHAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimDMHHAdmin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimDMHHAdmin.Location = new System.Drawing.Point(8, 17);
            this.txtTimDMHHAdmin.Multiline = true;
            this.txtTimDMHHAdmin.Name = "txtTimDMHHAdmin";
            this.txtTimDMHHAdmin.Size = new System.Drawing.Size(182, 31);
            this.txtTimDMHHAdmin.TabIndex = 35;
            this.txtTimDMHHAdmin.Text = "-----Tìm danh mục-----";
            // 
            // btnBootAdmin
            // 
            this.btnBootAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBootAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBootAdmin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBootAdmin.Location = new System.Drawing.Point(8, 206);
            this.btnBootAdmin.Name = "btnBootAdmin";
            this.btnBootAdmin.Size = new System.Drawing.Size(182, 45);
            this.btnBootAdmin.TabIndex = 0;
            this.btnBootAdmin.Text = "Boot";
            this.btnBootAdmin.UseVisualStyleBackColor = false;
            // 
            // btnGuocAdmin
            // 
            this.btnGuocAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuocAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuocAdmin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuocAdmin.Location = new System.Drawing.Point(8, 155);
            this.btnGuocAdmin.Name = "btnGuocAdmin";
            this.btnGuocAdmin.Size = new System.Drawing.Size(182, 45);
            this.btnGuocAdmin.TabIndex = 0;
            this.btnGuocAdmin.Text = "Guốc";
            this.btnGuocAdmin.UseVisualStyleBackColor = false;
            // 
            // btnGiayAdmin
            // 
            this.btnGiayAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGiayAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiayAdmin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiayAdmin.Location = new System.Drawing.Point(8, 104);
            this.btnGiayAdmin.Name = "btnGiayAdmin";
            this.btnGiayAdmin.Size = new System.Drawing.Size(182, 45);
            this.btnGiayAdmin.TabIndex = 0;
            this.btnGiayAdmin.Text = "Giày";
            this.btnGiayAdmin.UseVisualStyleBackColor = false;
            // 
            // btnDepAdmin
            // 
            this.btnDepAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDepAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepAdmin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepAdmin.Location = new System.Drawing.Point(8, 53);
            this.btnDepAdmin.Name = "btnDepAdmin";
            this.btnDepAdmin.Size = new System.Drawing.Size(182, 45);
            this.btnDepAdmin.TabIndex = 0;
            this.btnDepAdmin.Text = "Dép";
            this.btnDepAdmin.UseVisualStyleBackColor = false;
            // 
            // dtgvHangHoaAdmin
            // 
            this.dtgvHangHoaAdmin.AllowUserToAddRows = false;
            this.dtgvHangHoaAdmin.AllowUserToDeleteRows = false;
            this.dtgvHangHoaAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvHangHoaAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHangHoaAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDHH,
            this.colTenGDHH,
            this.colDVTHH,
            this.colDonGiaHH,
            this.colLoaiHH,
            this.colNhaCCHH,
            this.colMoTaHH,
            this.colHinhAnhHH});
            this.dtgvHangHoaAdmin.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtgvHangHoaAdmin.Location = new System.Drawing.Point(196, 0);
            this.dtgvHangHoaAdmin.Name = "dtgvHangHoaAdmin";
            this.dtgvHangHoaAdmin.ReadOnly = true;
            this.dtgvHangHoaAdmin.RowHeadersVisible = false;
            this.dtgvHangHoaAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHangHoaAdmin.Size = new System.Drawing.Size(746, 459);
            this.dtgvHangHoaAdmin.TabIndex = 0;
            // 
            // panelRightHH
            // 
            this.panelRightHH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.panelRightHH.Controls.Add(this.cbbSoLuongHH);
            this.panelRightHH.Controls.Add(this.label1);
            this.panelRightHH.Controls.Add(this.lblSoLuongHH);
            this.panelRightHH.Controls.Add(this.nrudSoLuongHH);
            this.panelRightHH.Controls.Add(this.cbbNhaCCHH);
            this.panelRightHH.Controls.Add(this.txtTimKiemHHAdmin);
            this.panelRightHH.Controls.Add(this.lblTimKiemHHAdmin);
            this.panelRightHH.Controls.Add(this.cbbTimKiemHHAdmin);
            this.panelRightHH.Controls.Add(this.btnThemDanhMucHH);
            this.panelRightHH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRightHH.Location = new System.Drawing.Point(10, 10);
            this.panelRightHH.Name = "panelRightHH";
            this.panelRightHH.Size = new System.Drawing.Size(942, 67);
            this.panelRightHH.TabIndex = 11;
            // 
            // cbbSoLuongHH
            // 
            this.cbbSoLuongHH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbSoLuongHH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSoLuongHH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSoLuongHH.FormattingEnabled = true;
            this.cbbSoLuongHH.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.cbbSoLuongHH.Location = new System.Drawing.Point(314, 39);
            this.cbbSoLuongHH.Name = "cbbSoLuongHH";
            this.cbbSoLuongHH.Size = new System.Drawing.Size(51, 23);
            this.cbbSoLuongHH.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhà cung cấp:";
            // 
            // lblSoLuongHH
            // 
            this.lblSoLuongHH.AutoSize = true;
            this.lblSoLuongHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongHH.ForeColor = System.Drawing.Color.White;
            this.lblSoLuongHH.Location = new System.Drawing.Point(218, 43);
            this.lblSoLuongHH.Name = "lblSoLuongHH";
            this.lblSoLuongHH.Size = new System.Drawing.Size(73, 16);
            this.lblSoLuongHH.TabIndex = 8;
            this.lblSoLuongHH.Text = "Số lượng:";
            // 
            // nrudSoLuongHH
            // 
            this.nrudSoLuongHH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrudSoLuongHH.Location = new System.Drawing.Point(392, 39);
            this.nrudSoLuongHH.Name = "nrudSoLuongHH";
            this.nrudSoLuongHH.Size = new System.Drawing.Size(64, 20);
            this.nrudSoLuongHH.TabIndex = 7;
            // 
            // cbbNhaCCHH
            // 
            this.cbbNhaCCHH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbNhaCCHH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNhaCCHH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNhaCCHH.FormattingEnabled = true;
            this.cbbNhaCCHH.Items.AddRange(new object[] {
            "Công ty CP - SX - TM - DV JUNO",
            "Công ty TNHH SX HTD Bình Tiên - Biti\'s",
            "Công ty TNHH MTV Giày Da An Ba",
            "Công ty CP Giầy Việt - Vina-Giầy",
            "Công ty CP Giầy Việt - Vina-Giầy"});
            this.cbbNhaCCHH.Location = new System.Drawing.Point(341, 6);
            this.cbbNhaCCHH.Name = "cbbNhaCCHH";
            this.cbbNhaCCHH.Size = new System.Drawing.Size(450, 23);
            this.cbbNhaCCHH.TabIndex = 6;
            // 
            // btnThemDanhMucHH
            // 
            this.btnThemDanhMucHH.BackColor = System.Drawing.Color.Navy;
            this.btnThemDanhMucHH.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThemDanhMucHH.FlatAppearance.BorderSize = 0;
            this.btnThemDanhMucHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDanhMucHH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDanhMucHH.ForeColor = System.Drawing.Color.White;
            this.btnThemDanhMucHH.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDanhMucHH.Image")));
            this.btnThemDanhMucHH.Location = new System.Drawing.Point(0, 0);
            this.btnThemDanhMucHH.Name = "btnThemDanhMucHH";
            this.btnThemDanhMucHH.Size = new System.Drawing.Size(193, 67);
            this.btnThemDanhMucHH.TabIndex = 0;
            this.btnThemDanhMucHH.Text = "Thêm danh mục giày dép";
            this.btnThemDanhMucHH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemDanhMucHH.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 526);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(952, 10);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(952, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 536);
            this.panel4.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.statusStripTongDM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 22);
            this.panel1.TabIndex = 10;
            // 
            // statusStripTongDM
            // 
            this.statusStripTongDM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmlTongHH});
            this.statusStripTongDM.Location = new System.Drawing.Point(0, 0);
            this.statusStripTongDM.Name = "statusStripTongDM";
            this.statusStripTongDM.Size = new System.Drawing.Size(962, 22);
            this.statusStripTongDM.TabIndex = 0;
            this.statusStripTongDM.Text = "statusStrip1";
            // 
            // tsmlTongHH
            // 
            this.tsmlTongHH.Name = "tsmlTongHH";
            this.tsmlTongHH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsmlTongHH.Size = new System.Drawing.Size(76, 17);
            this.tsmlTongHH.Text = "Số hàng hóa:";
            // 
            // colIDHH
            // 
            this.colIDHH.HeaderText = "ID";
            this.colIDHH.Name = "colIDHH";
            this.colIDHH.ReadOnly = true;
            this.colIDHH.Width = 120;
            // 
            // colTenGDHH
            // 
            this.colTenGDHH.HeaderText = "Tên Giày dép";
            this.colTenGDHH.Name = "colTenGDHH";
            this.colTenGDHH.ReadOnly = true;
            this.colTenGDHH.Width = 220;
            // 
            // colDVTHH
            // 
            this.colDVTHH.HeaderText = "Đơn vị tính";
            this.colDVTHH.Name = "colDVTHH";
            this.colDVTHH.ReadOnly = true;
            this.colDVTHH.Width = 150;
            // 
            // colDonGiaHH
            // 
            this.colDonGiaHH.HeaderText = "Đơn giá";
            this.colDonGiaHH.Name = "colDonGiaHH";
            this.colDonGiaHH.ReadOnly = true;
            this.colDonGiaHH.Width = 200;
            // 
            // colLoaiHH
            // 
            this.colLoaiHH.HeaderText = "Loại giày dép";
            this.colLoaiHH.Name = "colLoaiHH";
            this.colLoaiHH.ReadOnly = true;
            // 
            // colNhaCCHH
            // 
            this.colNhaCCHH.HeaderText = "Nhà cung cấp";
            this.colNhaCCHH.Name = "colNhaCCHH";
            this.colNhaCCHH.ReadOnly = true;
            this.colNhaCCHH.Width = 150;
            // 
            // colMoTaHH
            // 
            this.colMoTaHH.HeaderText = "Mô tả";
            this.colMoTaHH.Name = "colMoTaHH";
            this.colMoTaHH.ReadOnly = true;
            this.colMoTaHH.Width = 170;
            // 
            // colHinhAnhHH
            // 
            this.colHinhAnhHH.HeaderText = "Hình ảnh";
            this.colHinhAnhHH.Name = "colHinhAnhHH";
            this.colHinhAnhHH.ReadOnly = true;
            this.colHinhAnhHH.Width = 200;
            // 
            // UC_HangHoa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panelRightHH);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "UC_HangHoa";
            this.Size = new System.Drawing.Size(962, 558);
            this.panel6.ResumeLayout(false);
            this.paneLeftHH.ResumeLayout(false);
            this.paneLeftHH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangHoaAdmin)).EndInit();
            this.panelRightHH.ResumeLayout(false);
            this.panelRightHH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudSoLuongHH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStripTongDM.ResumeLayout(false);
            this.statusStripTongDM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTimKiemHHAdmin;
        private System.Windows.Forms.Label lblTimKiemHHAdmin;
        private System.Windows.Forms.ComboBox cbbTimKiemHHAdmin;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dtgvHangHoaAdmin;
        private System.Windows.Forms.Panel panelRightHH;
        private System.Windows.Forms.Button btnThemDanhMucHH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel paneLeftHH;
        private System.Windows.Forms.StatusStrip statusStripTongDM;
        private System.Windows.Forms.Button btnDepAdmin;
        private System.Windows.Forms.Button btnGuocAdmin;
        private System.Windows.Forms.Button btnGiayAdmin;
        private System.Windows.Forms.TextBox txtTimDMHHAdmin;
        private System.Windows.Forms.Button btnBootAdmin;
        private System.Windows.Forms.ToolStripStatusLabel tsmlTongHH;
        private System.Windows.Forms.ComboBox cbbNhaCCHH;
        private System.Windows.Forms.ComboBox cbbSoLuongHH;
        private System.Windows.Forms.Label lblSoLuongHH;
        private System.Windows.Forms.NumericUpDown nrudSoLuongHH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenGDHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVTHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaCCHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHinhAnhHH;
    }
}