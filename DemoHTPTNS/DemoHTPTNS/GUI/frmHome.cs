using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DemoHTPTNS.GUI.ThongBao;
using DemoHTPTNS.GUI.BaoCao;
using DemoHTPTNS.GUI.CapNhap;
using DemoHTPTNS.GUI.ChonLoc;
using DemoHTPTNS.GUI.XuLy;

namespace DemoHTPTNS.GUI
{
    public partial class frmHome : Form
    {
        

        #region Init

        DataRow user;
        private GUI_ThongBao_ChucNang fInThongBao = null;
        private GUI_ChonLocHoSo fChonLoc = null;
        private GUI_XuLyHoSo fXuLy = null;
        private GUI_CapNhap_DSHoSo fCapNhap = null;
        private GUI_BaoCao fBaoCao = null;

        public frmHome()
        {
            InitializeComponent();
        }
        public frmHome(DataRow _user)
        {
            user = _user;
            InitializeComponent();
            InitForm();
        }
        private void InitForm()
        {
            //this.BackgroundImage = Properties.Resources.Main_BG;
            //if(user["quyen"].ToString() == "1")
            //{
            //    bntQuanLy.Enabled = false;
            //    bntThongKe.Enabled = false;
            //}
        }

        #endregion

        #region Method

        private Form ShowOrActiveForm(Form form, Type t)
        {
            if (form == null)
            {
                form = (Form)Activator.CreateInstance(t);
                form.MdiParent = this;
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                if (form.IsDisposed)
                {
                    form = (Form)Activator.CreateInstance(t);
                    form.MdiParent = this;
                    form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    form.Dock = DockStyle.Fill;
                    form.Show();
                }
                else
                {
                    form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    form.Dock = DockStyle.Fill;
                    form.Show();
                    form.Activate();
                }
            }
            return form;
        }
        #endregion

        #region Event

        private void mnuInThongBao_Click(object sender, EventArgs e)
        {
            fInThongBao = ShowOrActiveForm(fInThongBao, typeof(GUI_ThongBao_ChucNang)) as GUI_ThongBao_ChucNang;
        }

        private void mnuThuNhanVaChonLoc_Click(object sender, EventArgs e)
        {
            fChonLoc = ShowOrActiveForm(fChonLoc, typeof(GUI_ChonLocHoSo)) as GUI_ChonLocHoSo;
        }

        private void mnuXuLyHoSo_Click(object sender, EventArgs e)
        {
            fXuLy = ShowOrActiveForm(fXuLy, typeof(GUI_XuLyHoSo)) as GUI_XuLyHoSo;
        }

        private void mnuCapNhapTinhHinh_Click(object sender, EventArgs e)
        {
            fCapNhap = ShowOrActiveForm(fCapNhap, typeof(GUI_CapNhap_DSHoSo)) as GUI_CapNhap_DSHoSo;
        }

        private void mnuBaoCao_Click(object sender, EventArgs e)
        {
            fBaoCao = ShowOrActiveForm(fBaoCao, typeof(GUI_BaoCao)) as GUI_BaoCao;
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
        
        #endregion

        

    }
}
