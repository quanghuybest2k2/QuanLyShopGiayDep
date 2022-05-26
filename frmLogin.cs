using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopGiayDep
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void timeOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.25;
            }
            else
            {
                timeOut.Stop();
                Application.Exit();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {

            timeOut.Start();
        }

        private void btnThuNho_Click(object sender, EventArgs e)
        {

        }
    }
}
