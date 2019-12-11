using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DemoHTPTNS.DAL;

namespace DemoHTPTNS.GUI.XuLy
{
    public partial class GUI_XuLy_DanhSachHSPV : Form
    {
        DataTable dtDSHSPV = null;
        DataTable dtViTri = null;
        int SelectedIndex = 0;
        public GUI_XuLy_DanhSachHSPV()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string sql = String.Format("Select * From Fn_LoadDataDSHSPV()");
            dtDSHSPV = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text);
            dtgvDSHSPV.DataSource = dtDSHSPV;
            sql = String.Format("Select * From tbl_ChucVu");
            dtViTri = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text);
            BindingData();
        }

        private void BindingData()
        {
            if (SelectedIndex >= dtDSHSPV.Rows.Count) return;
            txtMaNV.Text = dtDSHSPV.Rows[SelectedIndex][0].ToString();
            txtHoTen.Text = dtDSHSPV.Rows[SelectedIndex][1].ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dtDSHSPV.Rows[SelectedIndex][2].ToString());
            rbntNam.Checked = Convert.ToBoolean(dtDSHSPV.Rows[SelectedIndex][3]);
            rbntNu.Checked = !Convert.ToBoolean(dtDSHSPV.Rows[SelectedIndex][3]);
            foreach(DataRow dr in dtViTri.Rows)
            {
                if(dr[0].ToString() == dtDSHSPV.Rows[SelectedIndex][4].ToString())
                {
                    txtViTri.Text = dr[1].ToString();
                    break;
                }
            }
            if (String.IsNullOrEmpty(dtDSHSPV.Rows[SelectedIndex][5].ToString()))
                dtpLichPV.Value = DateTime.Now;
            else
                dtpLichPV.Value = Convert.ToDateTime(dtDSHSPV.Rows[SelectedIndex][5]);
        }
        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvDSHSPV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedIndex = dtgvDSHSPV.CurrentCell.RowIndex;
            BindingData();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            string sql = String.Format("Update tbl_NhanVien Set NgayPhongVan = @NgayPhongVan, TrangThai = 1 where MaNV = @MaNV");
            SqlServerHelper.ExecuteNonQuery(sql, CommandType.Text,
                "@NgayPhongVan", SqlDbType.DateTime, dtpLichPV.Value,
                "@MaNV", SqlDbType.Int, Convert.ToInt32(txtMaNV.Text));
            LoadData();
        }
    }
}
