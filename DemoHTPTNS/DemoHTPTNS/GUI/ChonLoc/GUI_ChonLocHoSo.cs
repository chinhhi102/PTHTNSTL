using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DemoHTPTNS.DAL;

namespace DemoHTPTNS.GUI.ChonLoc
{
    public partial class GUI_ChonLocHoSo : Form
    {
        DataTable dtChonLoc = null;
        DataTable dtViTri = null;
        DataTable dtTrinhDo = null;
        DataTable dtBacLuong = null;
        DataTable dtCM = null;
        int RowSelectIndex = 0;
        public GUI_ChonLocHoSo()
        {
            InitializeComponent();
            bntLuu.Enabled = false;
            bntThem.Enabled = true;
        }

        private void GUI_ChonLocHoSo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            cbbBacLuong.Items.Clear();
            cbbChuyenMon.Items.Clear();
            cbbTrinhDo.Items.Clear();
            cbbViTriCV.Items.Clear();
            String sql = String.Format("select * from Fn_LoadDataChonLocHoSo()");
            dtChonLoc = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text);
            dtgvChonLoc.DataSource = dtChonLoc;

            sql = String.Format("select * from tbl_ChucVu");
            dtViTri = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text);
            foreach (DataRow dr in dtViTri.Rows)
            {
                cbbViTriCV.Items.Add(dr[1].ToString());
            }

            sql = String.Format("select * from tbl_TrinhDoHocVan");
            dtTrinhDo = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text);
            foreach (DataRow dr in dtTrinhDo.Rows)
            {
                cbbTrinhDo.Items.Add(dr[2].ToString() + " - " + dr[1].ToString());
            }

            sql = String.Format("select * from tbl_Luong");
            dtBacLuong = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text);
            foreach (DataRow dr in dtBacLuong.Rows)
            {
                cbbBacLuong.Items.Add(dr[0].ToString());
            }

            sql = String.Format("select * from tbl_ChuyenMon");
            dtCM = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text);
            foreach (DataRow dr in dtCM.Rows)
            {
                cbbChuyenMon.Items.Add(dr[1].ToString());
            }

            BindingData();
        }

        private void BindingData()
        {
            if (RowSelectIndex >= dtChonLoc.Rows.Count)
            {
                return;
            }

            txtMaNV.Text = dtChonLoc.Rows[RowSelectIndex][0].ToString();
            txtHoTen.Text = dtChonLoc.Rows[RowSelectIndex][1].ToString();
            dtpNgaySinh.Value = DateTime.Parse(dtChonLoc.Rows[RowSelectIndex][2].ToString());
            bool isNam = dtChonLoc.Rows[RowSelectIndex][3].ToString() == "Nam";
            rbntNam.Checked = isNam;
            rbntNu.Checked = !isNam;
            txtSDT.Text = dtChonLoc.Rows[RowSelectIndex][4].ToString();
            txtEmail.Text = dtChonLoc.Rows[RowSelectIndex][5].ToString();
            dtpNgayNopHS.Value = DateTime.Parse(dtChonLoc.Rows[RowSelectIndex][6].ToString());
            txtQueQuan.Text = dtChonLoc.Rows[RowSelectIndex][7].ToString();
            txtDanToc.Text = dtChonLoc.Rows[RowSelectIndex][8].ToString();

            String MaCV = dtChonLoc.Rows[RowSelectIndex][9].ToString();
            String MaTDHV = dtChonLoc.Rows[RowSelectIndex][10].ToString();
            String BacLuong = dtChonLoc.Rows[RowSelectIndex][11].ToString();
            String MaCM = dtChonLoc.Rows[RowSelectIndex][12].ToString();

            for (int i = 0; i < dtViTri.Rows.Count; ++i)
            {
                if (dtViTri.Rows[i][0].ToString() == MaCV)
                {
                    cbbViTriCV.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < dtTrinhDo.Rows.Count; ++i)
            {
                if (dtTrinhDo.Rows[i][0].ToString() == MaTDHV)
                {
                    cbbTrinhDo.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < dtBacLuong.Rows.Count; ++i)
            {
                if (dtBacLuong.Rows[i][0].ToString() == BacLuong)
                {
                    cbbBacLuong.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < dtCM.Rows.Count; ++i)
            {
                if (dtCM.Rows[i][0].ToString() == MaCM)
                {
                    cbbChuyenMon.SelectedIndex = i;
                    break;
                }
            }
        }

        private void dtgvChonLoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowSelectIndex = dtgvChonLoc.CurrentCell.RowIndex;
            bntLuu.Enabled = false;
            bntThem.Enabled = true;
            bntSua.Enabled = bntXoa.Enabled = true;
            BindingData();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = txtHoTen.Text = txtSDT.Text = txtEmail.Text = txtQueQuan.Text = txtDanToc.Text = cbbBacLuong.Text = cbbChuyenMon.Text = cbbTrinhDo.Text = cbbViTriCV.Text = "";
            rbntNam.Checked = rbntNu.Checked = false;
            dtpNgaySinh.Value = dtpNgayNopHS.Value = DateTime.Now;
            txtHoTen.Focus();
            bntSua.Enabled = bntXoa.Enabled = false;
            bntLuu.Enabled = true;
            bntThem.Enabled = false;
        }

        private bool check_Null()
        {
            errorChonLoc.Clear();
            if (txtHoTen.Text == "")
            {
                errorChonLoc.SetError(txtHoTen, "Họ tên không được bỏ trống!");
                return true;
            }
            if (txtSDT.Text == "")
            {
                errorChonLoc.SetError(txtSDT, "SĐT không được bỏ trống!");
                return true;
            }
            if (txtQueQuan.Text == "") {
                errorChonLoc.SetError(txtQueQuan, "Quên quán không được bỏ trống!");
                return true;
            }
            if(cbbViTriCV.SelectedIndex < 0)
            {
                errorChonLoc.SetError(cbbViTriCV, "Vị trí công việc không được bỏ trống!");
                return true;
            }
            if (cbbTrinhDo.SelectedIndex < 0)
            {
                errorChonLoc.SetError(cbbTrinhDo, "Trình độ học vấn không được bỏ trống!");
                return true;
            }
            if (cbbBacLuong.SelectedIndex < 0)
            {
                errorChonLoc.SetError(cbbBacLuong, "Bậc lương không được bỏ trống!");
                return true;
            }
            if (cbbChuyenMon.SelectedIndex < 0)
            {
                errorChonLoc.SetError(cbbChuyenMon, "Chuyên môn không được bỏ trống!");
                return true;
            }
            return false;
        }
        private void bntLuu_Click(object sender, EventArgs e)
        {
            if (check_Null()) return;
            try
            {
                String sql = String.Format("insert into tbl_NhanVien(HoTen, NgaySinh, GioiTinh, SoDienThoai, email, NgayNopHS, QueQuan, DanToc, MaCV, MaTDHV, BacLuong, MaCM) values(@HoTen, @NgaySinh, @GioiTinh, @SoDienThoai, @email, @NgayNopHS, @QueQuan, @DanToc, @MaCV, @MaTDHV, @BacLuong, @MaCM)");
                SqlServerHelper.ExecuteNonQuery(sql, CommandType.Text,
                    "@HoTen", SqlDbType.NVarChar, txtHoTen.Text,
                    "@NgaySinh", SqlDbType.DateTime, dtpNgaySinh.Value,
                    "@GioiTinh", SqlDbType.Bit, rbntNam.Checked,
                    "@SoDienThoai", SqlDbType.NVarChar, txtSDT.Text,
                    "@email", SqlDbType.NVarChar, txtEmail.Text,
                    "@NgayNopHS", SqlDbType.DateTime, dtpNgayNopHS.Value,
                    "@QueQuan", SqlDbType.NVarChar, txtQueQuan.Text,
                    "@DanToc", SqlDbType.NVarChar, txtDanToc.Text,
                    "@MaCV", SqlDbType.Int, Convert.ToInt32(dtViTri.Rows[cbbViTriCV.SelectedIndex][0].ToString()),
                    "@MaTDHV", SqlDbType.Int, Convert.ToInt32(dtTrinhDo.Rows[cbbTrinhDo.SelectedIndex][0].ToString()),
                    "@BacLuong", SqlDbType.Int, Convert.ToInt32(dtBacLuong.Rows[cbbBacLuong.SelectedIndex][0].ToString()),
                    "@MaCM", SqlDbType.Int, Convert.ToInt32(dtCM.Rows[cbbChuyenMon.SelectedIndex][0].ToString()));
                bntLuu.Enabled = false;
                bntSua.Enabled = bntThem.Enabled = bntXoa.Enabled = true;
                LoadData();
                dtgvChonLoc.Rows[RowSelectIndex].Selected = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if (check_Null()) return;
            int MaNV = Convert.ToInt32(txtMaNV.Text);
            String sql = String.Format("UPDATE tbl_NhanVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, SoDienThoai = @SoDienThoai, email = @email, NgayNopHS = @NgayNopHS, QueQuan = @QueQuan, DanToc = @DanToc, MaCV = @MaCV, MaTDHV = @MaTDHV, BacLuong = @BacLuong, MaCM = @MaCM WHERE MaNV = @MaNV");
            SqlServerHelper.ExecuteNonQuery(sql, CommandType.Text,
                "@HoTen", SqlDbType.NVarChar, txtHoTen.Text,
                "@NgaySinh", SqlDbType.DateTime, dtpNgaySinh.Value,
                "@GioiTinh", SqlDbType.Bit, rbntNam.Checked,
                "@SoDienThoai", SqlDbType.NVarChar, txtSDT.Text,
                "@email", SqlDbType.NVarChar, txtEmail.Text,
                "@NgayNopHS", SqlDbType.DateTime, dtpNgayNopHS.Value,
                "@QueQuan", SqlDbType.NVarChar, txtQueQuan.Text,
                "@DanToc", SqlDbType.NVarChar, txtDanToc.Text,
                "@MaCV", SqlDbType.Int, Convert.ToInt32(dtViTri.Rows[cbbViTriCV.SelectedIndex][0].ToString()),
                "@MaTDHV", SqlDbType.Int, Convert.ToInt32(dtTrinhDo.Rows[cbbTrinhDo.SelectedIndex][0].ToString()),
                "@BacLuong", SqlDbType.Int, Convert.ToInt32(cbbBacLuong.Text),
                "@MaCM", SqlDbType.Int, Convert.ToInt32(dtCM.Rows[cbbChuyenMon.SelectedIndex][0].ToString()),
                "@MaNV", SqlDbType.Int, MaNV);
            LoadData();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int MaNV = Convert.ToInt32(txtMaNV.Text);
                string sql = String.Format("Delete From tbl_NhanVien where MaNV = @MaNV");
                SqlServerHelper.ExecuteNonQuery(sql, CommandType.Text,
                    "@MaNV", SqlDbType.Int, MaNV);
                LoadData();
            }
        }

        private void bntTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbLocHS.SelectedIndex == 0 || String.IsNullOrEmpty(txtTimKiem.Text))
            {
                LoadData();
            }
            else
            {
                string sql = String.Format("select * from Fn_LoadDataChonLocHoSoDK(@tukhoa, @loai)");
                dtChonLoc = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text,
                    "@tukhoa", SqlDbType.Int, Convert.ToInt32(txtTimKiem.Text),
                    "@loai", SqlDbType.Int, cbbLocHS.SelectedIndex);
                dtgvChonLoc.DataSource = dtChonLoc;
                BindingData();
            }
        }
    }
}
