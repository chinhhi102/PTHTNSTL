namespace DemoHTPTNS.GUI
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuInThongBao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuNhanVaChonLoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXuLyHoSo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCapNhapTinhHinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInThongBao,
            this.mnuThuNhanVaChonLoc,
            this.mnuXuLyHoSo,
            this.mnuCapNhapTinhHinh,
            this.mnuBaoCao,
            this.tàiKhoảnToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(1038, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuInThongBao
            // 
            this.mnuInThongBao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnuInThongBao.Name = "mnuInThongBao";
            this.mnuInThongBao.Size = new System.Drawing.Size(111, 20);
            this.mnuInThongBao.Text = "IN THÔNG BÁO";
            this.mnuInThongBao.Click += new System.EventHandler(this.mnuInThongBao_Click);
            // 
            // mnuThuNhanVaChonLoc
            // 
            this.mnuThuNhanVaChonLoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnuThuNhanVaChonLoc.Name = "mnuThuNhanVaChonLoc";
            this.mnuThuNhanVaChonLoc.Size = new System.Drawing.Size(174, 20);
            this.mnuThuNhanVaChonLoc.Text = "THU NHẬN VÀ CHỌN LỌC";
            this.mnuThuNhanVaChonLoc.Click += new System.EventHandler(this.mnuThuNhanVaChonLoc_Click);
            // 
            // mnuXuLyHoSo
            // 
            this.mnuXuLyHoSo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnuXuLyHoSo.Name = "mnuXuLyHoSo";
            this.mnuXuLyHoSo.Size = new System.Drawing.Size(100, 20);
            this.mnuXuLyHoSo.Text = "XỬ LÝ HỒ SƠ";
            this.mnuXuLyHoSo.Click += new System.EventHandler(this.mnuXuLyHoSo_Click);
            // 
            // mnuCapNhapTinhHinh
            // 
            this.mnuCapNhapTinhHinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnuCapNhapTinhHinh.Name = "mnuCapNhapTinhHinh";
            this.mnuCapNhapTinhHinh.Size = new System.Drawing.Size(148, 20);
            this.mnuCapNhapTinhHinh.Text = "CẬP NHẬP TÌNH HÌNH";
            this.mnuCapNhapTinhHinh.Click += new System.EventHandler(this.mnuCapNhapTinhHinh_Click);
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(78, 20);
            this.mnuBaoCao.Text = "BÁO CÁO";
            this.mnuBaoCao.Click += new System.EventHandler(this.mnuBaoCao_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.tàiKhoảnToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Gray;
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 362);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuInThongBao;
        private System.Windows.Forms.ToolStripMenuItem mnuThuNhanVaChonLoc;
        private System.Windows.Forms.ToolStripMenuItem mnuXuLyHoSo;
        private System.Windows.Forms.ToolStripMenuItem mnuCapNhapTinhHinh;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}