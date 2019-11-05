﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DemoHTPTNS.DAL;

namespace DemoHTPTNS.GUI
{
    public partial class Login : Form
    {
        DataTable dt = new DataTable();
        string table_1 = "tbl_TaiKhoan";
        public Login()
        {
            InitializeComponent();
            Loaddata();

        }
        private void Loaddata()
        {
            dt = SqlServerHelper.ExecuteDataTable(String.Format("Select * from {0}", table_1), CommandType.Text);
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntDangnhap_Click(object sender, EventArgs e)
        {
            String tk = txtTaiKhoan.Text;
            String mk = txtMatKhau.Text;
            epLogin.Clear();
            if (tk.Length == 0)
            {
                epLogin.SetError(txtTaiKhoan, "Tài khoản không được bỏ trống!");
                txtTaiKhoan.Focus();
                return;
            }
            else if (mk.Length == 0)
            {
                epLogin.SetError(txtMatKhau, "Mật khẩu không được bỏ trống!");
                txtMatKhau.Focus();
                return;
            }
            else
            {
                bool isCorrect = false;
                DataRow isAc = null;
                foreach (DataRow dr in dt.Rows)
                {
                    if (tk == dr[0].ToString() && mk == dr[1].ToString())
                    {
                        isAc = dr;
                        isCorrect = true;
                        break;
                    }
                }
                if (isCorrect)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                    frmHome fMain = new frmHome(isAc);
                    this.Hide();
                    fMain.ShowDialog();
                    Loaddata();
                    txtTaiKhoan.Text = txtMatKhau.Text = "";
                    this.Show();
                    txtTaiKhoan.Focus();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo");
                    txtMatKhau.Text = "";
                }
            }
        }

        private void bntDangky_Click(object sender, EventArgs a)
        {
            Signup fSignup = new Signup();
            this.Hide();
            fSignup.ShowDialog();
            Loaddata();
            txtTaiKhoan.Text = txtMatKhau.Text = "";
            this.Show();
            txtTaiKhoan.Focus();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text;
            if(tk.Length == 0)
            {
                epLogin.SetError(txtTaiKhoan, "Tài khoản không được bỏ trống!");
            }
            else
            {
                epLogin.Clear();
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            string mk = txtMatKhau.Text;
            if (mk.Length == 0)
            {
                epLogin.SetError(txtMatKhau, "Mật khẩu không được bỏ trống!");
            }
            else
            {
                epLogin.Clear();
            }
        }
    }
}
