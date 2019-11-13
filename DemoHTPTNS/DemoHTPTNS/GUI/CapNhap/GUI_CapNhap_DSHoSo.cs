using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DemoHTPTNS.DAL;

namespace DemoHTPTNS.GUI.CapNhap
{
    public partial class GUI_CapNhap_DSHoSo : Form
    {
        DataTable dtDSHoSo = null;
        int RowSelectIndex = 1;
        public GUI_CapNhap_DSHoSo()
        {
            InitializeComponent();
        }

        private void GUI_CapNhap_DSHoSo_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            string sql = String.Format("Select * from Fn_DanhSachHoSoCapNhap()");
            dtDSHoSo = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text);
            dtgvDanhSachHoSo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDanhSachHoSo.DataSource = dtDSHoSo;
        }
        private void bntCapNhap_Click(object sender, EventArgs e)
        {
            if (RowSelectIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mẫu, Vui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            GUI_CapNhapTinhHinh fInThongBao = new GUI_CapNhapTinhHinh(Convert.ToInt32(dtDSHoSo.Rows[RowSelectIndex][0]));
            fInThongBao.MdiParent = this.MdiParent;
            fInThongBao.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fInThongBao.Dock = DockStyle.Fill;
            fInThongBao.Show();
        }

        private void dtgvDanhSachMau_Click(object sender, EventArgs e)
        {
            RowSelectIndex = dtgvDanhSachHoSo.CurrentCell.RowIndex;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
