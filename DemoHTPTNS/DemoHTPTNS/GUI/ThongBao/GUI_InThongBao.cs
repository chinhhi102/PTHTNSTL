using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DemoHTPTNS.DAL;
using System.Drawing.Printing;

namespace DemoHTPTNS.GUI.ThongBao
{
    public partial class GUI_InThongBao : Form
    {
        DataTable dtCongViec = null;
        DataTable dtMauThongBao = null;
        Bitmap bmp;
        int indexSelected = 0;
        public GUI_InThongBao()
        {
            InitializeComponent();
        }

        public GUI_InThongBao(int key)
        {
            InitializeComponent();
            LoadData(key);
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_InThongBao_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string sql = String.Format("Select * From tbl_ChucVu");
            dtCongViec = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text);
            foreach(DataRow dr in dtCongViec.Rows)
            {
                    cbbViTriTuyen.Items.Add(dr[1]);
            }
            for (var i = 1; i < 100; i++)
            {
                cbbTuoiTu.Items.Add(i);
                cbbTuoiDen.Items.Add(i);
            }
        }

        private void LoadData(int key)
        {
            string sql = String.Format("Select top(1) * From tbl_MauThongBao where @MaThongBao = MaThongBao");
            dtMauThongBao = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text,
                "@MaThongBao", SqlDbType.Int, key);
            sql = String.Format("Select * From tbl_ChucVu");
            dtCongViec = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text);
            foreach (DataRow dr in dtCongViec.Rows)
            {
                cbbViTriTuyen.Items.Add(dr[1]);
            }
            for (var i = 1; i < 100; i++)
            {
                cbbTuoiTu.Items.Add(i);
                cbbTuoiDen.Items.Add(i);
            }
            BindingData();
        }
        private void BindingData()
        {
            txtNoiLamViec.Text = dtMauThongBao.Rows[0]["NoiLamViec"].ToString();
            txtYeuCauKyThuat.Text = dtMauThongBao.Rows[0]["YeuCauKyThuat"].ToString();
            txtSLThamGia.Text = dtMauThongBao.Rows[0]["SoLuongThamGia"].ToString();
            txtSoNguoiCanTuyen.Text = dtMauThongBao.Rows[0]["SoNguoiCanTuyen"].ToString();
            txtYeuCauKhac.Text = dtMauThongBao.Rows[0]["YeuCauKhac"].ToString();
            txtNgoaiNgu.Text = dtMauThongBao.Rows[0]["YeuCauNgoaiNgu"].ToString();
            cbbTuoiTu.Text = dtMauThongBao.Rows[0]["TuoiTu"].ToString();
            cbbTuoiDen.Text = dtMauThongBao.Rows[0]["TuoiDen"].ToString();
            txtLuongCB.Text = dtMauThongBao.Rows[0]["MucLuong"].ToString();
            txtThoiGianLam.Text = dtMauThongBao.Rows[0]["ThoiGianLamViec"].ToString();
            int tt = Convert.ToInt32(dtMauThongBao.Rows[0]["TinhTrangHonNhan"].ToString());
            radioDocThan.Checked = (tt == 1);
            radioDaKetHon.Checked = (tt == 2);
            radioKhong.Checked = (tt == 0);
            txtHinhThucTuyen.Text = dtMauThongBao.Rows[0]["HinhThucTuyen"].ToString();
            txtXuatCanh.Text = dtMauThongBao.Rows[0]["NgayDuKienXuatCanh"].ToString();
            int id = 0;
            foreach (DataRow dr in dtCongViec.Rows)
            {
                if(dr[0].ToString() == dtMauThongBao.Rows[0]["MaCV"].ToString())
                {
                    cbbViTriTuyen.SelectedIndex = id;
                    break;
                }
                id++;
            }
        }

        private void cbbViTriTuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelected = cbbViTriTuyen.SelectedIndex;
            txtNDCongViec.Text = "";
            txtNDCongViec.Text = dtCongViec.Rows[indexSelected][2].ToString();
            txtQuyenLoiDuocHuong.Text = "";
            txtQuyenLoiDuocHuong.Text = dtCongViec.Rows[indexSelected][3].ToString();
        }

        private void bntInThongBao_Click(object sender, EventArgs e)
        {
            epInThongBao.Clear();
            if (txtNoiLamViec.Text.Length == 0)
            {
                epInThongBao.SetError(txtNoiLamViec, "Nơi làm việc không được bỏ trống!");
                txtNoiLamViec.Focus();
                return;
            };
            if(txtYeuCauKyThuat.Text.Length == 0)
            {
                epInThongBao.SetError(txtYeuCauKyThuat, "Yêu cầu kĩ thuật không được bỏ trống!");
                txtYeuCauKyThuat.Focus();
                return;
            }
            if (cbbViTriTuyen.Text.Length == 0)
            {
                epInThongBao.SetError(cbbViTriTuyen, "Vị trí tuyển không được bỏ trống!");
                cbbViTriTuyen.Focus();
                return;
            };
            if (txtLuongCB.Text.Length == 0)
            {
                epInThongBao.SetError(txtLuongCB, "Lương cơ bản không được bỏ trống!");
                txtLuongCB.Focus();
                return;
            }
            if(txtThoiGianLam.Text.Length == 0)
            {
                epInThongBao.SetError(txtThoiGianLam, "Thời gian làm không được bỏ trống!");
                txtThoiGianLam.Focus();
                return;
            }
            if(cbbTuoiTu.Text.Length == 0)
            {
                epInThongBao.SetError(cbbTuoiTu, "Tuổi không được bỏ trống!");
                cbbTuoiTu.Focus();
                return;
            }
            if (cbbTuoiDen.Text.Length == 0)
            {
                epInThongBao.SetError(cbbTuoiDen, "Tuổi không được bỏ trống!");
                cbbTuoiDen.Focus();
                return;
            }
            if(cbbViTriTuyen.Text != dtCongViec.Rows[indexSelected][1].ToString())
            {
                epInThongBao.SetError(cbbViTriTuyen, "Không tìm thấy công việc!");
                cbbViTriTuyen.Focus();
                return;
            }
            print();
            DialogResult result = MessageBox.Show("Bạn có muốn lưu lại mẫu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                try
                {
                    string sql = String.Format("Insert into tbl_MauThongBao values(@NoiLamViec, @YeuCauKyThuat, @SoLuongThamGia, @SoNguoiCanTuyen, @MaCV, @YeuCauKhac, @YeuCauNgoaiNgu, @TuoiTu, @TuoiDen, @MucLuong, @ThoiGianLamViec, @TinhTrangHonNhan, @HinhThucTuyen, @NgayDuKienXuatCanh, @NgayTaoMau)");
                    SqlServerHelper.ExecuteNonQuery(sql, CommandType.Text,
                        "@NoiLamViec", SqlDbType.NVarChar, txtNoiLamViec.Text,
                        "@YeuCauKyThuat", SqlDbType.NVarChar, txtYeuCauKyThuat.Text,
                        "@SoLuongThamGia", SqlDbType.NVarChar, txtSLThamGia.Text,
                        "@SoNguoiCanTuyen", SqlDbType.NVarChar, txtSoNguoiCanTuyen.Text,
                        "@MaCV", SqlDbType.Int, Convert.ToInt32(dtCongViec.Rows[indexSelected][0]),
                        "@YeuCauKhac", SqlDbType.NVarChar, txtYeuCauKhac.Text,
                        "@YeuCauNgoaiNgu", SqlDbType.NVarChar, txtNgoaiNgu.Text,
                        "@TuoiTu", SqlDbType.Int, Convert.ToInt32(cbbTuoiTu.Text),
                        "@TuoiDen", SqlDbType.Int, Convert.ToInt32(cbbTuoiDen.Text),
                        "@MucLuong", SqlDbType.NVarChar, txtLuongCB.Text,
                        "@ThoiGianLamViec", SqlDbType.NVarChar, txtThoiGianLam.Text,
                        "@TinhTrangHonNhan", SqlDbType.NVarChar, (radioDocThan.Checked ? 1 : radioDaKetHon.Checked ? 2 : 0),
                        "@HinhThucTuyen", SqlDbType.NVarChar, txtHinhThucTuyen.Text,
                        "@NgayDuKienXuatCanh", SqlDbType.NVarChar, txtXuatCanh.Text,
                        "@NgayTaoMau", SqlDbType.Date, DateTime.Now);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lưu bị lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(ex.ToString());
                }
            }
            this.Close();
        }

        private void print()
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics gm = Graphics.FromImage(bmp);
            gm.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printDialog1.ShowDialog();
        }
        private void txtNoiLamViec_TextChanged(object sender, EventArgs e)
        {
            string s = txtNoiLamViec.Text;
            if(s.Length == 0)
            {
                epInThongBao.SetError(txtNoiLamViec, "Nơi làm việc không được bỏ trống!");
            }
            else
            {
                epInThongBao.Clear();
            }
        }

        private void txtYeuCauKyThuat_TextChanged(object sender, EventArgs e)
        {
            string s = txtYeuCauKyThuat.Text;
            if (s.Length == 0)
            {
                epInThongBao.SetError(txtYeuCauKyThuat, "Yêu cầu kĩ thuật không được bỏ trống!");
            }
            else
            {
                epInThongBao.Clear();
            }
        }

        private void txtLuongCB_TextChanged(object sender, EventArgs e)
        {
            string s = txtLuongCB.Text;
            if (s.Length == 0)
            {
                epInThongBao.SetError(txtLuongCB, "Lương cơ bản không được bỏ trống!");
            }
            else
            {
                epInThongBao.Clear();
            }
        }

        private void txtThoiGianLam_TextChanged(object sender, EventArgs e)
        {
            string s = txtThoiGianLam.Text;
            if (s.Length == 0)
            {
                epInThongBao.SetError(txtThoiGianLam, "Thời gian làm không được bỏ trống!");
            }
            else
            {
                epInThongBao.Clear();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
