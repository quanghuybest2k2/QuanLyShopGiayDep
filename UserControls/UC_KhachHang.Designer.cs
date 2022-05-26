
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
            this.lblUC_KhachHang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUC_KhachHang
            // 
            this.lblUC_KhachHang.AutoSize = true;
            this.lblUC_KhachHang.Font = new System.Drawing.Font("Century Gothic", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUC_KhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUC_KhachHang.Location = new System.Drawing.Point(318, 230);
            this.lblUC_KhachHang.Name = "lblUC_KhachHang";
            this.lblUC_KhachHang.Size = new System.Drawing.Size(301, 56);
            this.lblUC_KhachHang.TabIndex = 3;
            this.lblUC_KhachHang.Text = "Khách hàng";
            // 
            // UC_KhachHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblUC_KhachHang);
            this.Name = "UC_KhachHang";
            this.Size = new System.Drawing.Size(962, 517);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUC_KhachHang;
    }
}
