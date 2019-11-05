using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoHTPTNS.GUI.BaoCao
{
    public partial class GUI_BaoCao : Form
    {
        public GUI_BaoCao()
        {
            InitializeComponent();
        }
        private String cate = "";
        private GUI_BaoCao_ChiTietBaoCao fBaoCaoChiTiet = null;
        private Form ShowOrActiveForm(Form form, Type t)
        {
            if (form == null)
            {
                form = (Form)Activator.CreateInstance(t);
                form.Tag = this.cate;
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
                    form.Tag = this.cate;
                    form.MdiParent = this.MdiParent;
                    form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    form.Dock = DockStyle.Fill;
                    form.Show();
                }
                else
                {
                    form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    form.Tag = this.cate;
                    form.Dock = DockStyle.Fill;
                    form.Show();
                    form.Activate();
                }
            }
            return form;
        }

        private void bntViTri_Click(object sender, EventArgs e)
        {
            this.cate = "VỊ TRÍ CÔNG VIỆC";
            fBaoCaoChiTiet = null;
            fBaoCaoChiTiet = ShowOrActiveForm(fBaoCaoChiTiet, typeof(GUI_BaoCao_ChiTietBaoCao)) as GUI_BaoCao_ChiTietBaoCao;
        }

        private void bntPhongBan_Click(object sender, EventArgs e)
        {
            this.cate = "PHÒNG BAN";
            fBaoCaoChiTiet = null;
            fBaoCaoChiTiet = ShowOrActiveForm(fBaoCaoChiTiet, typeof(GUI_BaoCao_ChiTietBaoCao)) as GUI_BaoCao_ChiTietBaoCao;
        }

        private void bntChuyenMon_Click(object sender, EventArgs e)
        {
            this.cate = "CHUYÊN MÔN";
            fBaoCaoChiTiet = null;
            fBaoCaoChiTiet = ShowOrActiveForm(fBaoCaoChiTiet, typeof(GUI_BaoCao_ChiTietBaoCao)) as GUI_BaoCao_ChiTietBaoCao;
        }

        private void bntKhaNang_Click(object sender, EventArgs e)
        {
            this.cate = "KHẢ NĂNG LÀM VIỆC";
            fBaoCaoChiTiet = null;
            fBaoCaoChiTiet = ShowOrActiveForm(fBaoCaoChiTiet, typeof(GUI_BaoCao_ChiTietBaoCao)) as GUI_BaoCao_ChiTietBaoCao;
        }

        private void bntTienLuong_Click(object sender, EventArgs e)
        {
            this.cate = "TIỀN LƯƠNG YÊU CẦU";
            fBaoCaoChiTiet = null;
            fBaoCaoChiTiet = ShowOrActiveForm(fBaoCaoChiTiet, typeof(GUI_BaoCao_ChiTietBaoCao)) as GUI_BaoCao_ChiTietBaoCao;
        }

        private void bntHoSo_Click(object sender, EventArgs e)
        {
            this.cate = "HỒ SƠ NHẬN";
            fBaoCaoChiTiet = null;
            fBaoCaoChiTiet = ShowOrActiveForm(fBaoCaoChiTiet, typeof(GUI_BaoCao_ChiTietBaoCao)) as GUI_BaoCao_ChiTietBaoCao;
        }
    }
}
