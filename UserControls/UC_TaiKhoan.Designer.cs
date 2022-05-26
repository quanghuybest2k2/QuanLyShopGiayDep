
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
            this.lblUC_TaiKhoan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUC_TaiKhoan
            // 
            this.lblUC_TaiKhoan.AutoSize = true;
            this.lblUC_TaiKhoan.Font = new System.Drawing.Font("Century Gothic", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUC_TaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUC_TaiKhoan.Location = new System.Drawing.Point(358, 230);
            this.lblUC_TaiKhoan.Name = "lblUC_TaiKhoan";
            this.lblUC_TaiKhoan.Size = new System.Drawing.Size(239, 56);
            this.lblUC_TaiKhoan.TabIndex = 3;
            this.lblUC_TaiKhoan.Text = "Tài khoản";
            // 
            // UC_TaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.lblUC_TaiKhoan);
            this.Name = "UC_TaiKhoan";
            this.Size = new System.Drawing.Size(962, 517);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUC_TaiKhoan;
    }
}
