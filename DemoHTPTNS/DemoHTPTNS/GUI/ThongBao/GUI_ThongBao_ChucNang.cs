using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoHTPTNS.GUI.ThongBao
{
    public partial class GUI_ThongBao_ChucNang : Form
    {
        public GUI_ThongBao_ChucNang()
        {
            InitializeComponent();
        }

        private GUI_ThongBao_DanhSach fDanhSach = null;
        private GUI_InThongBao fIn = null;

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

        private void bntDanhSach_Click(object sender, EventArgs e)
        {
            fDanhSach = ShowOrActiveForm(fDanhSach, typeof(GUI_ThongBao_DanhSach)) as GUI_ThongBao_DanhSach;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            fIn = ShowOrActiveForm(fIn, typeof(GUI_InThongBao)) as GUI_InThongBao;
        }
    }
}
