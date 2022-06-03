using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopGiayDep.Common;
//using QuanLyShopGiayDep.Models;
using DAL;
//using DTO;

namespace QuanLyShopGiayDep
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        bool Login(string userName, string password)
        {
            return QuanTriVien_DAL.Instance.Login(userName, password);
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
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var tenDangNhap = txtTaiKhoan.Text;
            var matKhau = txtMatKhau.Text;

            InputValidator inputValidator = new InputValidator();

            inputValidator
                .SetTitle("Tên đăng nhập")
                .SetInputString(tenDangNhap)
                .SanitizeInput()
                .Require()
                .MustBeValidString();

            inputValidator
                .SetTitle("Mật khẩu")
                .SetInputString(matKhau)
                .SanitizeInput()
                .Require();

            if (inputValidator.HasError)
            {
                MessageBox.Show(inputValidator.GetErrorMessage(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Login(tenDangNhap, matKhau))
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông tin không hợp lệ");
                return;
            }

            QuanTriVien_DTO loginAccount = QuanTriVien_DAL.Instance.GetAccountByUserName(tenDangNhap);

            FrmQuanLyShopGiayDep frm = new FrmQuanLyShopGiayDep(loginAccount);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void chkHienThongTin_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienThongTin.Checked;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msg = "Bạn có chắc chắn muốn thoát chương trình ?";
            var result = MessageBox.Show(msg, "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
