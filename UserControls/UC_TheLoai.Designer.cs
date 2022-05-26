
namespace QuanLyShopGiayDep.UserControls
{
    partial class UC_TheLoai
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
            this.lblUC_TheLoai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUC_TheLoai
            // 
            this.lblUC_TheLoai.AutoSize = true;
            this.lblUC_TheLoai.Font = new System.Drawing.Font("Century Gothic", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUC_TheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUC_TheLoai.Location = new System.Drawing.Point(358, 230);
            this.lblUC_TheLoai.Name = "lblUC_TheLoai";
            this.lblUC_TheLoai.Size = new System.Drawing.Size(191, 56);
            this.lblUC_TheLoai.TabIndex = 3;
            this.lblUC_TheLoai.Text = "Thể loại";
            // 
            // UC_TheLoai
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblUC_TheLoai);
            this.Name = "UC_TheLoai";
            this.Size = new System.Drawing.Size(962, 517);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUC_TheLoai;
    }
}
