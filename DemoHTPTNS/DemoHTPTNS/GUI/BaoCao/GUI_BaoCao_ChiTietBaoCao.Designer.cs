namespace DemoHTPTNS.GUI.BaoCao
{
    partial class GUI_BaoCao_ChiTietBaoCao
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
            this.lbBaoCao = new System.Windows.Forms.Label();
            this.dtgvBaoCao = new System.Windows.Forms.DataGridView();
            this.bntXuatBaoCao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.bntThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBaoCao
            // 
            this.lbBaoCao.AutoSize = true;
            this.lbBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaoCao.Location = new System.Drawing.Point(391, 10);
            this.lbBaoCao.Name = "lbBaoCao";
            this.lbBaoCao.Size = new System.Drawing.Size(76, 25);
            this.lbBaoCao.TabIndex = 0;
            this.lbBaoCao.Text = "label1";
            // 
            // dtgvBaoCao
            // 
            this.dtgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBaoCao.Location = new System.Drawing.Point(12, 102);
            this.dtgvBaoCao.Name = "dtgvBaoCao";
            this.dtgvBaoCao.ReadOnly = true;
            this.dtgvBaoCao.Size = new System.Drawing.Size(1252, 380);
            this.dtgvBaoCao.TabIndex = 1;
            // 
            // bntXuatBaoCao
            // 
            this.bntXuatBaoCao.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntXuatBaoCao.Location = new System.Drawing.Point(1022, 488);
            this.bntXuatBaoCao.Name = "bntXuatBaoCao";
            this.bntXuatBaoCao.Size = new System.Drawing.Size(122, 27);
            this.bntXuatBaoCao.TabIndex = 2;
            this.bntXuatBaoCao.Text = "Xuất Báo Cáo";
            this.bntXuatBaoCao.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(954, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(655, 60);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(269, 22);
            this.dtpTuNgay.TabIndex = 4;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(995, 60);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(269, 22);
            this.dtpDenNgay.TabIndex = 4;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
            // 
            // bntThoat
            // 
            this.bntThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntThoat.Location = new System.Drawing.Point(1173, 488);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(91, 27);
            this.bntThoat.TabIndex = 2;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // GUI_BaoCao_ChiTietBaoCao
            // 
            this.AcceptButton = this.bntXuatBaoCao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntThoat;
            this.ClientSize = new System.Drawing.Size(1370, 519);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntXuatBaoCao);
            this.Controls.Add(this.dtgvBaoCao);
            this.Controls.Add(this.lbBaoCao);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Name = "GUI_BaoCao_ChiTietBaoCao";
            this.Text = "GUI_BaoCao_ChiTietBaoCao";
            this.Load += new System.EventHandler(this.GUI_BaoCao_ChiTietBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBaoCao;
        private System.Windows.Forms.DataGridView dtgvBaoCao;
        private System.Windows.Forms.Button bntXuatBaoCao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button bntThoat;
    }
}