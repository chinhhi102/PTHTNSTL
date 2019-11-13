using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DemoHTPTNS.DAL;

namespace DemoHTPTNS.GUI.ThongBao
{
    public partial class GUI_ThongBao_DanhSach : Form
    {
        DataTable dtMauThongBao = null;
        int RowSelectIndex = 1;
        public GUI_ThongBao_DanhSach()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string sql = String.Format("Select * from Fn_DanhSachThongBao()");
                dtMauThongBao = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text);
                dtgvDanhSachMau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgvDanhSachMau.DataSource = dtMauThongBao;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_ThongBao_DanhSach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bntInMau_Click(object sender, EventArgs e)
        {
            if(RowSelectIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mẫu, Vui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            GUI_InThongBao fInThongBao = new GUI_InThongBao(Convert.ToInt32(dtMauThongBao.Rows[RowSelectIndex][0]));
            fInThongBao.MdiParent = this.MdiParent;
            fInThongBao.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fInThongBao.Dock = DockStyle.Fill;
            fInThongBao.Show();
        }

        private void dtgvDanhSachMau_Click(object sender, EventArgs e)
        {
            RowSelectIndex = dtgvDanhSachMau.CurrentCell.RowIndex;
        }
    }
}
