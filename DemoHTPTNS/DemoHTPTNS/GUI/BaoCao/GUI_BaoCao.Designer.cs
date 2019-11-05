namespace DemoHTPTNS.GUI.BaoCao
{
    partial class GUI_BaoCao
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
            this.bntViTri = new System.Windows.Forms.Button();
            this.bntPhongBan = new System.Windows.Forms.Button();
            this.bntChuyenMon = new System.Windows.Forms.Button();
            this.bntKhaNang = new System.Windows.Forms.Button();
            this.bntTienLuong = new System.Windows.Forms.Button();
            this.bntHoSo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntViTri
            // 
            this.bntViTri.Location = new System.Drawing.Point(13, 13);
            this.bntViTri.Name = "bntViTri";
            this.bntViTri.Size = new System.Drawing.Size(173, 23);
            this.bntViTri.TabIndex = 4;
            this.bntViTri.Text = "BÁO CÁO THEO VỊ TRÍ";
            this.bntViTri.UseVisualStyleBackColor = true;
            this.bntViTri.Click += new System.EventHandler(this.bntViTri_Click);
            // 
            // bntPhongBan
            // 
            this.bntPhongBan.Location = new System.Drawing.Point(192, 13);
            this.bntPhongBan.Name = "bntPhongBan";
            this.bntPhongBan.Size = new System.Drawing.Size(173, 23);
            this.bntPhongBan.TabIndex = 4;
            this.bntPhongBan.Text = "BÁO CÁO THEO PHÒNG BAN";
            this.bntPhongBan.UseVisualStyleBackColor = true;
            this.bntPhongBan.Click += new System.EventHandler(this.bntPhongBan_Click);
            // 
            // bntChuyenMon
            // 
            this.bntChuyenMon.Location = new System.Drawing.Point(371, 13);
            this.bntChuyenMon.Name = "bntChuyenMon";
            this.bntChuyenMon.Size = new System.Drawing.Size(173, 23);
            this.bntChuyenMon.TabIndex = 4;
            this.bntChuyenMon.Text = "BÁO CÁO THEO CHUYÊN MÔN";
            this.bntChuyenMon.UseVisualStyleBackColor = true;
            this.bntChuyenMon.Click += new System.EventHandler(this.bntChuyenMon_Click);
            // 
            // bntKhaNang
            // 
            this.bntKhaNang.Location = new System.Drawing.Point(550, 12);
            this.bntKhaNang.Name = "bntKhaNang";
            this.bntKhaNang.Size = new System.Drawing.Size(173, 23);
            this.bntKhaNang.TabIndex = 4;
            this.bntKhaNang.Text = "BÁO CÁO THEO KHẢ NĂNG";
            this.bntKhaNang.UseVisualStyleBackColor = true;
            this.bntKhaNang.Click += new System.EventHandler(this.bntKhaNang_Click);
            // 
            // bntTienLuong
            // 
            this.bntTienLuong.Location = new System.Drawing.Point(729, 12);
            this.bntTienLuong.Name = "bntTienLuong";
            this.bntTienLuong.Size = new System.Drawing.Size(173, 23);
            this.bntTienLuong.TabIndex = 4;
            this.bntTienLuong.Text = "BÁO CÁO THEO TIỀN LƯƠNG";
            this.bntTienLuong.UseVisualStyleBackColor = true;
            this.bntTienLuong.Click += new System.EventHandler(this.bntTienLuong_Click);
            // 
            // bntHoSo
            // 
            this.bntHoSo.Location = new System.Drawing.Point(908, 12);
            this.bntHoSo.Name = "bntHoSo";
            this.bntHoSo.Size = new System.Drawing.Size(183, 23);
            this.bntHoSo.TabIndex = 4;
            this.bntHoSo.Text = "BÁO CÁO THEO HỒ SƠ NHẬN";
            this.bntHoSo.UseVisualStyleBackColor = true;
            this.bntHoSo.Click += new System.EventHandler(this.bntHoSo_Click);
            // 
            // GUI_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 569);
            this.Controls.Add(this.bntHoSo);
            this.Controls.Add(this.bntTienLuong);
            this.Controls.Add(this.bntKhaNang);
            this.Controls.Add(this.bntChuyenMon);
            this.Controls.Add(this.bntPhongBan);
            this.Controls.Add(this.bntViTri);
            this.Name = "GUI_BaoCao";
            this.Text = "GUI_BaoCao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntViTri;
        private System.Windows.Forms.Button bntPhongBan;
        private System.Windows.Forms.Button bntChuyenMon;
        private System.Windows.Forms.Button bntKhaNang;
        private System.Windows.Forms.Button bntTienLuong;
        private System.Windows.Forms.Button bntHoSo;
    }
}