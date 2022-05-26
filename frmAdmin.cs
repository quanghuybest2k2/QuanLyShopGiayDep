﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopGiayDep.UserControls;

namespace QuanLyShopGiayDep
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            UC_TrangChu uc = new UC_TrangChu();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelBottom.Controls.Clear();
            panelBottom.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnTrangChuAdmin_Click(object sender, EventArgs e)
        {
            UC_TrangChu uc = new UC_TrangChu();
            addUserControl(uc);
        }

        private void btnKhachHangAdmin_Click(object sender, EventArgs e)
        {
            UC_KhachHang uc = new UC_KhachHang();
            addUserControl(uc);
        }

        private void btnNhaCCAdmin_Click(object sender, EventArgs e)
        {
            UC_NhaCC uc = new UC_NhaCC();
            addUserControl(uc);
        }

        private void btnTheLoaiAdmin_Click(object sender, EventArgs e)
        {
            UC_TheLoai uc = new UC_TheLoai();
            addUserControl(uc);
        }

        private void btnTaiKhoanAdmin_Click(object sender, EventArgs e)
        {
            UC_TaiKhoan uc = new UC_TaiKhoan();
            addUserControl(uc);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}