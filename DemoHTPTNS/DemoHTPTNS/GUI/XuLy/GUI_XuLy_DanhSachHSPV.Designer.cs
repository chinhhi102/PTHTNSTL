﻿namespace DemoHTPTNS.GUI.XuLy
{
    partial class GUI_XuLy_DanhSachHSPV
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDSHSPV = new System.Windows.Forms.DataGridView();
            this.bntLuu = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.pnlGioiTinh = new System.Windows.Forms.Panel();
            this.rbntNu = new System.Windows.Forms.RadioButton();
            this.rbntNam = new System.Windows.Forms.RadioButton();
            this.bntGuiEmail = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpLichPV = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHSPV)).BeginInit();
            this.pnlGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỒ SƠ XÉT TUYỂN PHỎNG VẤN";
            // 
            // dtgvDSHSPV
            // 
            this.dtgvDSHSPV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSHSPV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHSPV.Location = new System.Drawing.Point(14, 323);
            this.dtgvDSHSPV.Name = "dtgvDSHSPV";
            this.dtgvDSHSPV.ReadOnly = true;
            this.dtgvDSHSPV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSHSPV.Size = new System.Drawing.Size(1511, 377);
            this.dtgvDSHSPV.TabIndex = 1;
            this.dtgvDSHSPV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSHSPV_CellClick);
            // 
            // bntLuu
            // 
            this.bntLuu.Location = new System.Drawing.Point(1153, 707);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(117, 55);
            this.bntLuu.TabIndex = 2;
            this.bntLuu.Text = "LƯU";
            this.bntLuu.UseVisualStyleBackColor = true;
            this.bntLuu.Click += new System.EventHandler(this.bntLuu_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntThoat.Location = new System.Drawing.Point(1288, 707);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(112, 55);
            this.bntThoat.TabIndex = 2;
            this.bntThoat.Text = "THOÁT";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(1011, 75);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.ReadOnly = true;
            this.txtViTri.Size = new System.Drawing.Size(233, 22);
            this.txtViTri.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(862, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Vị Trí Thử Việc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(232, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Giới Tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(129, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày/Tháng/Năm Sinh:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(334, 108);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(416, 22);
            this.txtHoTen.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(189, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên Nhân Viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(334, 74);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(102, 22);
            this.txtMaNV.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(191, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã Nhân Viên:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(334, 149);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(233, 22);
            this.dtpNgaySinh.TabIndex = 28;
            // 
            // pnlGioiTinh
            // 
            this.pnlGioiTinh.Controls.Add(this.rbntNu);
            this.pnlGioiTinh.Controls.Add(this.rbntNam);
            this.pnlGioiTinh.Enabled = false;
            this.pnlGioiTinh.Location = new System.Drawing.Point(334, 189);
            this.pnlGioiTinh.Name = "pnlGioiTinh";
            this.pnlGioiTinh.Size = new System.Drawing.Size(156, 27);
            this.pnlGioiTinh.TabIndex = 31;
            // 
            // rbntNu
            // 
            this.rbntNu.AutoSize = true;
            this.rbntNu.Location = new System.Drawing.Point(91, 5);
            this.rbntNu.Name = "rbntNu";
            this.rbntNu.Size = new System.Drawing.Size(42, 19);
            this.rbntNu.TabIndex = 0;
            this.rbntNu.TabStop = true;
            this.rbntNu.Text = "Nữ";
            this.rbntNu.UseVisualStyleBackColor = true;
            // 
            // rbntNam
            // 
            this.rbntNam.AutoSize = true;
            this.rbntNam.Location = new System.Drawing.Point(5, 5);
            this.rbntNam.Name = "rbntNam";
            this.rbntNam.Size = new System.Drawing.Size(50, 19);
            this.rbntNam.TabIndex = 0;
            this.rbntNam.TabStop = true;
            this.rbntNam.Text = "Nam";
            this.rbntNam.UseVisualStyleBackColor = true;
            // 
            // bntGuiEmail
            // 
            this.bntGuiEmail.Location = new System.Drawing.Point(1245, 271);
            this.bntGuiEmail.Name = "bntGuiEmail";
            this.bntGuiEmail.Size = new System.Drawing.Size(87, 27);
            this.bntGuiEmail.TabIndex = 32;
            this.bntGuiEmail.Text = "Gửi Email";
            this.bntGuiEmail.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(838, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Đặt lịch phỏng vấn:";
            // 
            // dtpLichPV
            // 
            this.dtpLichPV.Location = new System.Drawing.Point(1011, 149);
            this.dtpLichPV.Name = "dtpLichPV";
            this.dtpLichPV.Size = new System.Drawing.Size(233, 22);
            this.dtpLichPV.TabIndex = 28;
            // 
            // GUI_XuLy_DanhSachHSPV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntThoat;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.bntGuiEmail);
            this.Controls.Add(this.pnlGioiTinh);
            this.Controls.Add(this.dtpLichPV);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntLuu);
            this.Controls.Add(this.dtgvDSHSPV);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Name = "GUI_XuLy_DanhSachHSPV";
            this.Text = "GUI_XuLy_DanhSachHSPV";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHSPV)).EndInit();
            this.pnlGioiTinh.ResumeLayout(false);
            this.pnlGioiTinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDSHSPV;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Panel pnlGioiTinh;
        private System.Windows.Forms.RadioButton rbntNu;
        private System.Windows.Forms.RadioButton rbntNam;
        private System.Windows.Forms.Button bntGuiEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpLichPV;
    }
}