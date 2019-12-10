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
    public partial class GUI_XuLy_DanhSachKQPV : Form
    {
        DataTable dtDSKQPV = null;
        DataTable dtViTri = null;
        int SelectedIndex = 0;
        public GUI_XuLy_DanhSachKQPV()
        {
            InitializeComponent();
            cbbKetQua.Items.Add("Chưa phỏng vấn");
            cbbKetQua.Items.Add("Đạt");
            cbbKetQua.Items.Add("Không Đạt");
            LoadData();
        }

        private void LoadData()
        {
            string sql = String.Format("Select * From Fn_LoadDataDSKQPV()");
            dtDSKQPV = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text);
            dtgvDSKQPV.DataSource = dtDSKQPV;
            sql = String.Format("Select * From tbl_ChucVu");
            dtViTri = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text);
            if(dtDSKQPV.Rows.Count > 0)
                BindingData();
        }

        private void BindingData()
        {
            txtMaNV.Text = dtDSKQPV.Rows[SelectedIndex][0].ToString();
            txtHoTen.Text = dtDSKQPV.Rows[SelectedIndex][1].ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dtDSKQPV.Rows[SelectedIndex][2].ToString());
            rbntNam.Checked = Convert.ToBoolean(dtDSKQPV.Rows[SelectedIndex][3]);
            rbntNu.Checked = !Convert.ToBoolean(dtDSKQPV.Rows[SelectedIndex][3]);
            foreach (DataRow dr in dtViTri.Rows)
            {
                if (dr[0].ToString() == dtDSKQPV.Rows[SelectedIndex][4].ToString())
                {
                    txtViTri.Text = dr[1].ToString();
                    break;
                }
            }
            cbbKetQua.SelectedIndex = Convert.ToInt32(dtDSKQPV.Rows[SelectedIndex][5]);
            if (String.IsNullOrEmpty(dtDSKQPV.Rows[SelectedIndex][6].ToString()))
                dtpNgayThuViec.Value = DateTime.Now;
            else
                dtpNgayThuViec.Value = Convert.ToDateTime(dtDSKQPV.Rows[SelectedIndex][6]);
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            string sql = String.Format("Update tbl_NhanVien Set KetQuaPhongVan = @KetQuaPhongVan, NgayThuViec = @NgayThuViec where MaNV = @MaNV");
            SqlServerHelper.ExecuteNonQuery(sql, CommandType.Text,
                "@KetQuaPhongVan", SqlDbType.Int, cbbKetQua.SelectedIndex,
                "@NgayThuViec", SqlDbType.DateTime, dtpNgayThuViec.Value,
                "@MaNV", SqlDbType.Int, Convert.ToInt32(txtMaNV.Text));
            LoadData();
        }
    }
}
