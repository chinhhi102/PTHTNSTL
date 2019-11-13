using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DemoHTPTNS.GUI.XuLy;

namespace DemoHTPTNS.GUI.XuLy
{
    public partial class GUI_XuLyHoSo : Form
    {
        private GUI_XuLy_DanhSachHSPV fHSPV = null;
        private GUI_XuLy_DanhSachKQPV fKQPV = null;
        public GUI_XuLyHoSo()
        {
            InitializeComponent();
        }

        private Form ShowOrActiveForm(Form form, Type t)
        {
            if (form == null)
            {
                form = (Form)Activator.CreateInstance(t);
                form.MdiParent = this.MdiParent;
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                if (form.IsDisposed)
                {
                    form = (Form)Activator.CreateInstance(t);
                    form.MdiParent = this.MdiParent;
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

        private void bntDatLich_Click(object sender, EventArgs e)
        {
            fHSPV = ShowOrActiveForm(fHSPV, typeof(GUI_XuLy_DanhSachHSPV)) as GUI_XuLy_DanhSachHSPV;
        }

        private void bntXuLyKQ_Click(object sender, EventArgs e)
        {
            fKQPV = ShowOrActiveForm(fKQPV, typeof(GUI_XuLy_DanhSachKQPV)) as GUI_XuLy_DanhSachKQPV;
        }
    }
}
