namespace DemoHTPTNS.GUI.CapNhap
{
    partial class GUI_CapNhap_DSHoSo
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
            this.dtgvDanhSachHoSo = new System.Windows.Forms.DataGridView();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntCapNhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHoSo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH CÁC HỒ SƠ";
            // 
            // dtgvDanhSachHoSo
            // 
            this.dtgvDanhSachHoSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachHoSo.Location = new System.Drawing.Point(13, 41);
            this.dtgvDanhSachHoSo.Name = "dtgvDanhSachHoSo";
            this.dtgvDanhSachHoSo.ReadOnly = true;
            this.dtgvDanhSachHoSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSachHoSo.Size = new System.Drawing.Size(1242, 323);
            this.dtgvDanhSachHoSo.TabIndex = 1;
            // 
            // bntThoat
            // 
            this.bntThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntThoat.Location = new System.Drawing.Point(1180, 370);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(75, 23);
            this.bntThoat.TabIndex = 2;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntCapNhap
            // 
            this.bntCapNhap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntCapNhap.Location = new System.Drawing.Point(1099, 370);
            this.bntCapNhap.Name = "bntCapNhap";
            this.bntCapNhap.Size = new System.Drawing.Size(75, 23);
            this.bntCapNhap.TabIndex = 2;
            this.bntCapNhap.Text = "Cập nhập";
            this.bntCapNhap.UseVisualStyleBackColor = true;
            this.bntCapNhap.Click += new System.EventHandler(this.bntCapNhap_Click);
            // 
            // GUI_CapNhap_DSHoSo
            // 
            this.AcceptButton = this.bntCapNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntThoat;
            this.ClientSize = new System.Drawing.Size(1267, 402);
            this.Controls.Add(this.bntCapNhap);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.dtgvDanhSachHoSo);
            this.Controls.Add(this.label1);
            this.Name = "GUI_CapNhap_DSHoSo";
            this.Text = "GUI_ThongBao_DanhSach";
            this.Load += new System.EventHandler(this.GUI_CapNhap_DSHoSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHoSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDanhSachHoSo;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntCapNhap;
    }
}