namespace DemoHTPTNS.GUI.ThongBao
{
    partial class GUI_ThongBao_DanhSach
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
            this.dtgvDanhSachMau = new System.Windows.Forms.DataGridView();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntInMau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachMau)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH CÁC MẪU ĐÃ LƯU";
            // 
            // dtgvDanhSachMau
            // 
            this.dtgvDanhSachMau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachMau.Location = new System.Drawing.Point(15, 47);
            this.dtgvDanhSachMau.Name = "dtgvDanhSachMau";
            this.dtgvDanhSachMau.ReadOnly = true;
            this.dtgvDanhSachMau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSachMau.Size = new System.Drawing.Size(1449, 373);
            this.dtgvDanhSachMau.TabIndex = 1;
            this.dtgvDanhSachMau.Click += new System.EventHandler(this.dtgvDanhSachMau_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntThoat.Location = new System.Drawing.Point(1377, 427);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(87, 27);
            this.bntThoat.TabIndex = 2;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntInMau
            // 
            this.bntInMau.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntInMau.Location = new System.Drawing.Point(1282, 427);
            this.bntInMau.Name = "bntInMau";
            this.bntInMau.Size = new System.Drawing.Size(87, 27);
            this.bntInMau.TabIndex = 2;
            this.bntInMau.Text = "In mẫu";
            this.bntInMau.UseVisualStyleBackColor = true;
            this.bntInMau.Click += new System.EventHandler(this.bntInMau_Click);
            // 
            // GUI_ThongBao_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntThoat;
            this.ClientSize = new System.Drawing.Size(1370, 464);
            this.Controls.Add(this.bntInMau);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.dtgvDanhSachMau);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Name = "GUI_ThongBao_DanhSach";
            this.Text = "GUI_ThongBao_DanhSach";
            this.Load += new System.EventHandler(this.GUI_ThongBao_DanhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachMau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDanhSachMau;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntInMau;
    }
}