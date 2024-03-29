﻿using System;
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
    public partial class GUI_CapNhapTinhHinh : Form
    {
        private int MaHS;
        int RowSelectIndex = 0;
        private DataTable dtCapNhap = null;
        private DataRow drNhanVien = null;
        public GUI_CapNhapTinhHinh()
        {
            InitializeComponent();
        }

        public GUI_CapNhapTinhHinh(int _MaHS)
        {
            InitializeComponent();
            bntLuu.Enabled = false;
            MaHS = _MaHS;
        }

        private void GUI_CapNhapTinhHinh_Load(object sender, EventArgs e)
        {
            DataLoad();
            string sql = String.Format("Select * From Fn_GetInfoCapNhapNhanVienByMaNV(@MaNV)");
            drNhanVien = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text,
                        "@MaNV", SqlDbType.Int, MaHS).Rows[0];
            txtMaNV.Text = drNhanVien["MaNV"].ToString();
            txtHoTen.Text = drNhanVien["HoTen"].ToString();
            dtpNgaySinh.Text = drNhanVien["NgaySinh"].ToString();
            bool gt =  drNhanVien["GioiTinh"].Equals(true);
            if(gt == true)
            {
                rbntNam.Checked = true;
            }
            else
            {
                rbntNu.Checked = true;
            }
            dtpBD.Text = drNhanVien["NgayThuViec"].ToString();
            dtpKT.Text = drNhanVien["NgayKetThucThuViec"].ToString();
            txtViTri.Text = drNhanVien["TenCV"].ToString();
            BindingData();
        }

        private void BindingData()
        {
            if (RowSelectIndex >= dtCapNhap.Rows.Count)
            {
                return;
            }
            txtThaiDo.Text = dtCapNhap.Rows[RowSelectIndex][1].ToString();
            txtKhaNang.Text = dtCapNhap.Rows[RowSelectIndex][2].ToString();
            txtKinhNghiem.Text = dtCapNhap.Rows[RowSelectIndex][3].ToString();
            txtHieuQua.Text = dtCapNhap.Rows[RowSelectIndex][4].ToString();
        }
        private void DataLoad()
        {
            string sql = String.Format("Select * From Fn_DanhSachTinhHinhThuViec(@MaNV)");
            dtCapNhap = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text,
                        "@MaNV", SqlDbType.Int, MaHS);
            dtgvCapNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCapNhap.DataSource = dtCapNhap;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            txtHieuQua.Text = txtKhaNang.Text = txtThaiDo.Text = txtKinhNghiem.Text = "";
            RowSelectIndex = -1;
            txtKhaNang.Focus();
            bntLuu.Enabled = true;
            bntSua.Enabled = bntXoa.Enabled = false;
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if(RowSelectIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(MessageBox.Show("Bạn có chắc chắn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int indexDel = Convert.ToInt32(dtCapNhap.Rows[RowSelectIndex][0].ToString());
                string sql = String.Format("Delete From tbl_TinhHinhThuViec Where @MaTHTV=MaTHTV");
                SqlServerHelper.ExecuteNonQuery(sql, CommandType.Text,
                                "@MaTHTV", SqlDbType.Int, indexDel);
            }
            DataLoad();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = String.Format("Insert into tbl_TinhHinhThuViec(MaNV, KhaNangLamViec, ThaiDoLamViec, KinhNghiemLamViec, HieuQuaLamViec, NgayCapNhap) values(@MaNV, @KhaNangLamViec, @ThaiDoLamViec, @KinhNghiemLamViec, @HieuQuaLamViec, @NgayCapNhap)");
                SqlServerHelper.ExecuteNonQuery(sql, CommandType.Text,
                               "@MaNV", SqlDbType.Int, MaHS,
                               "@KhaNangLamViec", SqlDbType.NVarChar, txtKhaNang.Text,
                               "@ThaiDoLamViec", SqlDbType.NVarChar, txtThaiDo.Text,
                               "@KinhNghiemLamViec", SqlDbType.NVarChar, txtKinhNghiem.Text,
                               "@HieuQuaLamViec", SqlDbType.NVarChar, txtHieuQua.Text,
                               "@NgayCapNhap", SqlDbType.DateTime, DateTime.Now);
                DataLoad();
                bntSua.Enabled = bntXoa.Enabled = true;
                bntLuu.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntTuyenDung_Click(object sender, EventArgs e)
        {
            // Trạng thái = 1 là chuẩn bị phỏng vấn, = 2 là đang thử việc, = 3 là được nhận, = 4 là bị loại
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn nhận ứng cử viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string sql = String.Format("UPDATE tbl_NhanVien SET TrangThai = @TrangThai where MaNV = @MaNV");
                    SqlServerHelper.ExecuteNonQuery(sql, CommandType.Text,
                        "@TrangThai", SqlDbType.Int, 3,
                        "@MaNV", SqlDbType.Int, MaHS);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bntKhongTuyen_Click(object sender, EventArgs e)
        {
            // Trạng thái = 1 là chuẩn bị phỏng vấn, = 2 là đang thử việc, = 3 là được nhận, = 4 là bị loại
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn loại ứng cử viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string sql = String.Format("UPDATE tbl_NhanVien SET TrangThai = @TrangThai where MaNV = @MaNV");
                    SqlServerHelper.ExecuteNonQuery(sql, CommandType.Text,
                        "@TrangThai", SqlDbType.Int, 4,
                        "@MaNV", SqlDbType.Int, MaHS);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dtgvCapNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bntLuu.Enabled = false;
            bntSua.Enabled = bntXoa.Enabled = true;

            RowSelectIndex = dtgvCapNhap.CurrentCell.RowIndex;
            BindingData();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            try
            {
                int indexUp = Convert.ToInt32(dtCapNhap.Rows[RowSelectIndex][0].ToString());
                string sql = String.Format("Update tbl_TinhHinhThuViec set KhaNangLamViec = @KhaNangLamViec, ThaiDoLamViec = @ThaiDoLamViec, KinhNghiemLamViec = @KinhNghiemLamViec, HieuQuaLamViec = @HieuQuaLamViec WHERE MaTHTV = @MaTHTV");
                SqlServerHelper.ExecuteNonQuery(sql, CommandType.Text,
                               "@MaTHTV", SqlDbType.Int, indexUp,
                               "@KhaNangLamViec", SqlDbType.NVarChar, txtKhaNang.Text,
                               "@ThaiDoLamViec", SqlDbType.NVarChar, txtThaiDo.Text,
                               "@KinhNghiemLamViec", SqlDbType.NVarChar, txtKinhNghiem.Text,
                               "@HieuQuaLamViec", SqlDbType.NVarChar, txtHieuQua.Text);
                DataLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
