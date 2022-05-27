
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
            this.dtgvHangHoaAdmin = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddNewBooks = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangHoaAdmin)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiemHHAdmin
            // 
            this.txtTimKiemHHAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemHHAdmin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemHHAdmin.Location = new System.Drawing.Point(746, 26);
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
            this.lblTimKiemHHAdmin.Location = new System.Drawing.Point(433, 25);
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
            this.cbbTimKiemHHAdmin.Location = new System.Drawing.Point(602, 23);
            this.cbbTimKiemHHAdmin.Name = "cbbTimKiemHHAdmin";
            this.cbbTimKiemHHAdmin.Size = new System.Drawing.Size(138, 23);
            this.cbbTimKiemHHAdmin.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtgvHangHoaAdmin);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(10, 77);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(942, 459);
            this.panel6.TabIndex = 12;
            // 
            // dtgvHangHoaAdmin
            // 
            this.dtgvHangHoaAdmin.AllowUserToAddRows = false;
            this.dtgvHangHoaAdmin.AllowUserToDeleteRows = false;
            this.dtgvHangHoaAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvHangHoaAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHangHoaAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dtgvHangHoaAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHangHoaAdmin.Location = new System.Drawing.Point(0, 0);
            this.dtgvHangHoaAdmin.Name = "dtgvHangHoaAdmin";
            this.dtgvHangHoaAdmin.ReadOnly = true;
            this.dtgvHangHoaAdmin.RowHeadersVisible = false;
            this.dtgvHangHoaAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHangHoaAdmin.Size = new System.Drawing.Size(942, 459);
            this.dtgvHangHoaAdmin.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(193, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "   Add Stock";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.panel5.Controls.Add(this.txtTimKiemHHAdmin);
            this.panel5.Controls.Add(this.lblTimKiemHHAdmin);
            this.panel5.Controls.Add(this.cbbTimKiemHHAdmin);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.btnAddNewBooks);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(942, 67);
            this.panel5.TabIndex = 11;
            // 
            // btnAddNewBooks
            // 
            this.btnAddNewBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddNewBooks.FlatAppearance.BorderSize = 0;
            this.btnAddNewBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBooks.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewBooks.Image")));
            this.btnAddNewBooks.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewBooks.Name = "btnAddNewBooks";
            this.btnAddNewBooks.Size = new System.Drawing.Size(193, 67);
            this.btnAddNewBooks.TabIndex = 0;
            this.btnAddNewBooks.Text = "   Add New Book";
            this.btnAddNewBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewBooks.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(9, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(372, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Copyrights © 2018. All rights Reserved By C# Ui Academy.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 526);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(952, 10);
            this.panel3.TabIndex = 8;
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
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 22);
            this.panel1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Giày dép";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 220;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn vị tính";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Loại giày dép";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nhà cung cấp";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Mô tả";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 170;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Hình ảnh";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 200;
            // 
            // UC_HangHoa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "UC_HangHoa";
            this.Size = new System.Drawing.Size(962, 558);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangHoaAdmin)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTimKiemHHAdmin;
        private System.Windows.Forms.Label lblTimKiemHHAdmin;
        private System.Windows.Forms.ComboBox cbbTimKiemHHAdmin;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dtgvHangHoaAdmin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAddNewBooks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
