namespace DemoHTPTNS.GUI.ThongBao
{
    partial class GUI_InThongBao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_InThongBao));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoiLamViec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYeuCauKyThuat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSLThamGia = new System.Windows.Forms.TextBox();
            this.txtSoNguoiCanTuyen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNDCongViec = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtYeuCauKhac = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNgoaiNgu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtThoiGianLam = new System.Windows.Forms.TextBox();
            this.bntThoat = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtHinhThucTuyen = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtQuyenLoiDuocHuong = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtXuatCanh = new System.Windows.Forms.TextBox();
            this.pnlTinhTrangHonNhan = new System.Windows.Forms.Panel();
            this.radioKhong = new System.Windows.Forms.RadioButton();
            this.radioDaKetHon = new System.Windows.Forms.RadioButton();
            this.radioDocThan = new System.Windows.Forms.RadioButton();
            this.bntInThongBao = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbbTuoiDen = new System.Windows.Forms.ComboBox();
            this.cbbTuoiTu = new System.Windows.Forms.ComboBox();
            this.cbbViTriTuyen = new System.Windows.Forms.ComboBox();
            this.epInThongBao = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pnlTinhTrangHonNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epInThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG BÁO TUYỂN DỤNG KỸ SƯ THIẾT KẾ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nơi làm việc(*):";
            // 
            // txtNoiLamViec
            // 
            this.txtNoiLamViec.Location = new System.Drawing.Point(203, 67);
            this.txtNoiLamViec.Name = "txtNoiLamViec";
            this.txtNoiLamViec.Size = new System.Drawing.Size(312, 22);
            this.txtNoiLamViec.TabIndex = 0;
            this.txtNoiLamViec.TextChanged += new System.EventHandler(this.txtNoiLamViec_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yêu cầu kỹ thuật, kinh nghiệm(*):";
            // 
            // txtYeuCauKyThuat
            // 
            this.txtYeuCauKyThuat.Location = new System.Drawing.Point(203, 105);
            this.txtYeuCauKyThuat.Multiline = true;
            this.txtYeuCauKyThuat.Name = "txtYeuCauKyThuat";
            this.txtYeuCauKyThuat.Size = new System.Drawing.Size(312, 63);
            this.txtYeuCauKyThuat.TabIndex = 1;
            this.txtYeuCauKyThuat.TextChanged += new System.EventHandler(this.txtYeuCauKyThuat_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng tham gia tuyển:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số người cần tuyển:";
            // 
            // txtSLThamGia
            // 
            this.txtSLThamGia.Location = new System.Drawing.Point(203, 179);
            this.txtSLThamGia.Name = "txtSLThamGia";
            this.txtSLThamGia.Size = new System.Drawing.Size(312, 22);
            this.txtSLThamGia.TabIndex = 2;
            // 
            // txtSoNguoiCanTuyen
            // 
            this.txtSoNguoiCanTuyen.Location = new System.Drawing.Point(203, 220);
            this.txtSoNguoiCanTuyen.Name = "txtSoNguoiCanTuyen";
            this.txtSoNguoiCanTuyen.Size = new System.Drawing.Size(312, 22);
            this.txtSoNguoiCanTuyen.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Vị trí tuyển(*):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nội dung công việc:";
            // 
            // txtNDCongViec
            // 
            this.txtNDCongViec.Location = new System.Drawing.Point(203, 298);
            this.txtNDCongViec.Multiline = true;
            this.txtNDCongViec.Name = "txtNDCongViec";
            this.txtNDCongViec.ReadOnly = true;
            this.txtNDCongViec.Size = new System.Drawing.Size(312, 71);
            this.txtNDCongViec.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Yêu cầu khác:";
            // 
            // txtYeuCauKhac
            // 
            this.txtYeuCauKhac.Location = new System.Drawing.Point(203, 387);
            this.txtYeuCauKhac.Multiline = true;
            this.txtYeuCauKhac.Name = "txtYeuCauKhac";
            this.txtYeuCauKhac.Size = new System.Drawing.Size(312, 55);
            this.txtYeuCauKhac.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Yêu cầu về ngoại ngữ:";
            // 
            // txtNgoaiNgu
            // 
            this.txtNgoaiNgu.Location = new System.Drawing.Point(203, 449);
            this.txtNgoaiNgu.Multiline = true;
            this.txtNgoaiNgu.Name = "txtNgoaiNgu";
            this.txtNgoaiNgu.Size = new System.Drawing.Size(312, 71);
            this.txtNgoaiNgu.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(644, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tuổi(*):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(591, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Lương cơ bản(*):";
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(699, 108);
            this.txtLuongCB.Multiline = true;
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(416, 59);
            this.txtLuongCB.TabIndex = 10;
            this.txtLuongCB.TextChanged += new System.EventHandler(this.txtLuongCB_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(568, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Thời gian làm việc(*):";
            // 
            // txtThoiGianLam
            // 
            this.txtThoiGianLam.Location = new System.Drawing.Point(699, 178);
            this.txtThoiGianLam.Name = "txtThoiGianLam";
            this.txtThoiGianLam.Size = new System.Drawing.Size(416, 22);
            this.txtThoiGianLam.TabIndex = 11;
            this.txtThoiGianLam.TextChanged += new System.EventHandler(this.txtThoiGianLam_TextChanged);
            // 
            // bntThoat
            // 
            this.bntThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntThoat.Location = new System.Drawing.Point(1028, 493);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(87, 27);
            this.bntThoat.TabIndex = 18;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(568, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Tình trạng hôn nhân:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(561, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Hình thức tuyển dụng:";
            // 
            // txtHinhThucTuyen
            // 
            this.txtHinhThucTuyen.Location = new System.Drawing.Point(699, 245);
            this.txtHinhThucTuyen.Multiline = true;
            this.txtHinhThucTuyen.Name = "txtHinhThucTuyen";
            this.txtHinhThucTuyen.Size = new System.Drawing.Size(416, 58);
            this.txtHinhThucTuyen.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(558, 318);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Quyền lợi được hưởng:";
            // 
            // txtQuyenLoiDuocHuong
            // 
            this.txtQuyenLoiDuocHuong.Location = new System.Drawing.Point(699, 315);
            this.txtQuyenLoiDuocHuong.Multiline = true;
            this.txtQuyenLoiDuocHuong.Name = "txtQuyenLoiDuocHuong";
            this.txtQuyenLoiDuocHuong.ReadOnly = true;
            this.txtQuyenLoiDuocHuong.Size = new System.Drawing.Size(416, 79);
            this.txtQuyenLoiDuocHuong.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(548, 405);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "Ngày dự kiến xuất cảnh:";
            // 
            // txtXuatCanh
            // 
            this.txtXuatCanh.Location = new System.Drawing.Point(699, 402);
            this.txtXuatCanh.Multiline = true;
            this.txtXuatCanh.Name = "txtXuatCanh";
            this.txtXuatCanh.Size = new System.Drawing.Size(416, 85);
            this.txtXuatCanh.TabIndex = 15;
            // 
            // pnlTinhTrangHonNhan
            // 
            this.pnlTinhTrangHonNhan.Controls.Add(this.radioKhong);
            this.pnlTinhTrangHonNhan.Controls.Add(this.radioDaKetHon);
            this.pnlTinhTrangHonNhan.Controls.Add(this.radioDocThan);
            this.pnlTinhTrangHonNhan.Location = new System.Drawing.Point(699, 210);
            this.pnlTinhTrangHonNhan.Name = "pnlTinhTrangHonNhan";
            this.pnlTinhTrangHonNhan.Size = new System.Drawing.Size(416, 33);
            this.pnlTinhTrangHonNhan.TabIndex = 12;
            // 
            // radioKhong
            // 
            this.radioKhong.AutoSize = true;
            this.radioKhong.Location = new System.Drawing.Point(224, 5);
            this.radioKhong.Name = "radioKhong";
            this.radioKhong.Size = new System.Drawing.Size(105, 19);
            this.radioKhong.TabIndex = 2;
            this.radioKhong.TabStop = true;
            this.radioKhong.Text = "Không yêu cầu";
            this.radioKhong.UseVisualStyleBackColor = true;
            // 
            // radioDaKetHon
            // 
            this.radioDaKetHon.AutoSize = true;
            this.radioDaKetHon.Location = new System.Drawing.Point(111, 3);
            this.radioDaKetHon.Name = "radioDaKetHon";
            this.radioDaKetHon.Size = new System.Drawing.Size(84, 19);
            this.radioDaKetHon.TabIndex = 1;
            this.radioDaKetHon.TabStop = true;
            this.radioDaKetHon.Text = "Đã kết hôn";
            this.radioDaKetHon.UseVisualStyleBackColor = true;
            // 
            // radioDocThan
            // 
            this.radioDocThan.AutoSize = true;
            this.radioDocThan.Location = new System.Drawing.Point(5, 5);
            this.radioDocThan.Name = "radioDocThan";
            this.radioDocThan.Size = new System.Drawing.Size(73, 19);
            this.radioDocThan.TabIndex = 0;
            this.radioDocThan.TabStop = true;
            this.radioDocThan.Text = "Độc thân";
            this.radioDocThan.UseVisualStyleBackColor = true;
            // 
            // bntInThongBao
            // 
            this.bntInThongBao.Location = new System.Drawing.Point(923, 495);
            this.bntInThongBao.Name = "bntInThongBao";
            this.bntInThongBao.Size = new System.Drawing.Size(87, 27);
            this.bntInThongBao.TabIndex = 16;
            this.bntInThongBao.Text = "In thông báo";
            this.bntInThongBao.UseVisualStyleBackColor = true;
            this.bntInThongBao.Click += new System.EventHandler(this.bntInThongBao_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(712, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 15);
            this.label17.TabIndex = 1;
            this.label17.Text = "Từ:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(818, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 15);
            this.label18.TabIndex = 1;
            this.label18.Text = "Đến:";
            // 
            // cbbTuoiDen
            // 
            this.cbbTuoiDen.FormattingEnabled = true;
            this.cbbTuoiDen.Location = new System.Drawing.Point(860, 67);
            this.cbbTuoiDen.Name = "cbbTuoiDen";
            this.cbbTuoiDen.Size = new System.Drawing.Size(54, 23);
            this.cbbTuoiDen.TabIndex = 19;
            // 
            // cbbTuoiTu
            // 
            this.cbbTuoiTu.FormattingEnabled = true;
            this.cbbTuoiTu.Location = new System.Drawing.Point(745, 67);
            this.cbbTuoiTu.Name = "cbbTuoiTu";
            this.cbbTuoiTu.Size = new System.Drawing.Size(54, 23);
            this.cbbTuoiTu.TabIndex = 19;
            // 
            // cbbViTriTuyen
            // 
            this.cbbViTriTuyen.FormattingEnabled = true;
            this.cbbViTriTuyen.Location = new System.Drawing.Point(203, 257);
            this.cbbViTriTuyen.Name = "cbbViTriTuyen";
            this.cbbViTriTuyen.Size = new System.Drawing.Size(312, 23);
            this.cbbViTriTuyen.TabIndex = 19;
            this.cbbViTriTuyen.SelectedIndexChanged += new System.EventHandler(this.cbbViTriTuyen_SelectedIndexChanged);
            // 
            // epInThongBao
            // 
            this.epInThongBao.ContainerControl = this;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // GUI_InThongBao
            // 
            this.AcceptButton = this.bntInThongBao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntThoat;
            this.ClientSize = new System.Drawing.Size(1176, 534);
            this.Controls.Add(this.cbbViTriTuyen);
            this.Controls.Add(this.cbbTuoiTu);
            this.Controls.Add(this.cbbTuoiDen);
            this.Controls.Add(this.pnlTinhTrangHonNhan);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntInThongBao);
            this.Controls.Add(this.txtXuatCanh);
            this.Controls.Add(this.txtQuyenLoiDuocHuong);
            this.Controls.Add(this.txtHinhThucTuyen);
            this.Controls.Add(this.txtThoiGianLam);
            this.Controls.Add(this.txtLuongCB);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNgoaiNgu);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtYeuCauKhac);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNDCongViec);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSoNguoiCanTuyen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSLThamGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYeuCauKyThuat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNoiLamViec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Name = "GUI_InThongBao";
            this.Text = "GUI_InThongBao";
            this.Load += new System.EventHandler(this.GUI_InThongBao_Load);
            this.pnlTinhTrangHonNhan.ResumeLayout(false);
            this.pnlTinhTrangHonNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epInThongBao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoiLamViec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYeuCauKyThuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSLThamGia;
        private System.Windows.Forms.TextBox txtSoNguoiCanTuyen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNDCongViec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtYeuCauKhac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNgoaiNgu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtThoiGianLam;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtHinhThucTuyen;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtQuyenLoiDuocHuong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtXuatCanh;
        private System.Windows.Forms.Panel pnlTinhTrangHonNhan;
        private System.Windows.Forms.RadioButton radioKhong;
        private System.Windows.Forms.RadioButton radioDaKetHon;
        private System.Windows.Forms.RadioButton radioDocThan;
        private System.Windows.Forms.Button bntInThongBao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbbTuoiDen;
        private System.Windows.Forms.ComboBox cbbTuoiTu;
        private System.Windows.Forms.ComboBox cbbViTriTuyen;
        private System.Windows.Forms.ErrorProvider epInThongBao;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}