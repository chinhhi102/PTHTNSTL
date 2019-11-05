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
    public partial class GUI_BaoCao_ChiTietBaoCao : Form
    {
        public GUI_BaoCao_ChiTietBaoCao()
        {
            InitializeComponent();
        }

        private void GUI_BaoCao_ChiTietBaoCao_Load(object sender, EventArgs e)
        {
            lbBaoCao.Text = "BÁO CÁO THEO " + (String)this.Tag;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
