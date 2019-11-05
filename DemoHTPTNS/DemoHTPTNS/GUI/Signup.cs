using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DemoHTPTNS.DAL;

namespace DemoHTPTNS.GUI
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        String tablename = "tbl_TaiKhoan";
        private void bntDangky_Click(object sender, EventArgs e)
        {
            String ho = txtHoVaTenDem.Text;
            String ten = txtTen.Text;
            String tk = txtTaiKhoan.Text;
            String mk = txtMatKhau.Text;
            String rmk = txtNhapLaiMK.Text;
            epValidation.Clear();
            if(string.IsNullOrWhiteSpace(ho) == true)
            {
                txtHoVaTenDem.Focus();
                epValidation.SetError(txtHoVaTenDem, "Họ và tên đệm không được bỏ trống!");
            }else if(string.IsNullOrWhiteSpace(ten) == true)
            {
                txtTen.Focus();
                epValidation.SetError(txtTen, "Tên không được bỏ trống!");
            }else if(string.IsNullOrWhiteSpace(tk) == true)
            {
                txtTaiKhoan.Focus();
                epValidation.SetError(txtTaiKhoan, "Tài khoản không được bỏ trống");
            }else if(string.IsNullOrWhiteSpace(mk) == true)
            {
                txtMatKhau.Focus();
                epValidation.SetError(txtMatKhau, "Mật khẩu không được bỏ trống!");
            }else if(mk.Length < 6)
            {
                txtMatKhau.Focus();
                epValidation.SetError(txtMatKhau, "Mật khẩu phải từ 6 - 50 kí tự!");
            }
            else if(mk != rmk)
            {
                txtNhapLaiMK.Focus();
                epValidation.SetError(txtNhapLaiMK, "Nhập lại mật khẩu không đúng!");
            }
            else
            {
                String sql = String.Format("Insert into {0} values(@username, @password, @permission, @ten, @ho)", tablename);
                SqlServerHelper.ExecuteNonQuery(sql, CommandType.Text, 
                    "@ho", SqlDbType.NVarChar, ho,
                    "@ten", SqlDbType.NVarChar, ten,
                    "@username", SqlDbType.NVarChar, tk,
                    "@password", SqlDbType.NVarChar, mk,
                    "@permission", SqlDbType.Int, 2);
                this.Close();
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            String mk = txtMatKhau.Text;
            if (mk.Length < 6)
                epValidation.SetError(txtMatKhau, "Mật khẩu phải từ 6 - 50 kí tự!");
            else
            {
                epValidation.Clear();
            }
            txtNhapLaiMK_TextChanged(sender, e);
        }

        private void bntTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNhapLaiMK_TextChanged(object sender, EventArgs e)
        {
            String mk = txtMatKhau.Text;
            String rmk = txtNhapLaiMK.Text;
            if (mk != rmk)
            {
                epValidation.SetError(txtNhapLaiMK, "Nhập lại mật khẩu không đúng!");
            }
            else
            {
                epValidation.Clear();
            }
        }
    }
}
