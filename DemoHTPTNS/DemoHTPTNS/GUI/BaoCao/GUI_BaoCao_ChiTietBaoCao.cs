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

namespace DemoHTPTNS.GUI.BaoCao
{
    public partial class GUI_BaoCao_ChiTietBaoCao : Form
    {
        public GUI_BaoCao_ChiTietBaoCao()
        {
            InitializeComponent();
        }

        private String cate = "";
        private DataTable dt = null;
        private Bitmap bmp;

        /*
        V -> Vi tri công việc
        P -> Phòng Ban
        C -> Chuyên môn
        K -> Khả năng làm việc
        T -> Tiền lương
        H -> Hồ sơ nhận
        */
        private void GUI_BaoCao_ChiTietBaoCao_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
cate = (String)this.Tag;
            lbBaoCao.Text = "BÁO CÁO THEO " + cate;
            DateTime TuNgay = dtpTuNgay.Value;
            DateTime DenNgay = dtpDenNgay.Value;
            try
            {
                string sql = String.Format("Select * From ");
                switch (cate[0])
                {
                    case 'V':
                        {
                            sql += "Fn_BaoCaoViTri(@TuNgay, @DenNgay)";
                            break;
                        }
                    case 'P':
                        {
                            sql += "Fn_BaoCaoPhongBan(@TuNgay, @DenNgay)";
                            break;
                        }
                    case 'C':
                        {
                            sql += "Fn_BaoCaoChuyenMon(@TuNgay, @DenNgay)";
                            break;
                        }
                    case 'K':
                        {
                            sql += "Fn_BaoCaoKhaNang(@TuNgay, @DenNgay)";
                            break;
                        }
                    case 'T':
                        {
                            sql += "Fn_BaoCaoTienLuong(@TuNgay, @DenNgay)";
                            break;
                        }
                    case 'H':
                        {
                            sql += "Fn_BaoCaoHoSoNhan(@TuNgay, @DenNgay)";
                            break;
                        }
                }
                dt = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text,
                    "@TuNgay", SqlDbType.Date, TuNgay,
                    "@DenNgay", SqlDbType.Date, DenNgay);
                dtgvBaoCao.DataSource = dt;
                foreach (DataGridViewColumn c in dtgvBaoCao.Columns)
                {
                    c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Chức năng tạm thời bị lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
             //   MessageBox.Show(ex.ToString(), "Error");
            }
        }
        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bntXuatBaoCao_Click(object sender, EventArgs e)
        {
            print();
        }
        private void print()
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics gm = Graphics.FromImage(bmp);
            gm.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

    }
}
