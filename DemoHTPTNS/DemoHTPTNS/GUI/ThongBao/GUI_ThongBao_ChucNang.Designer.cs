namespace DemoHTPTNS.GUI.ThongBao
{
    partial class GUI_ThongBao_ChucNang
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
            this.bntDanhSach = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntDanhSach
            // 
            this.bntDanhSach.Location = new System.Drawing.Point(14, 14);
            this.bntDanhSach.Name = "bntDanhSach";
            this.bntDanhSach.Size = new System.Drawing.Size(230, 27);
            this.bntDanhSach.TabIndex = 0;
            this.bntDanhSach.Text = "Danh sách mẫu thông báo";
            this.bntDanhSach.UseVisualStyleBackColor = true;
            this.bntDanhSach.Click += new System.EventHandler(this.bntDanhSach_Click);
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(262, 14);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(230, 27);
            this.bntThem.TabIndex = 1;
            this.bntThem.Text = "Thêm mẫu thông báo";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // GUI_ThongBao_ChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.bntDanhSach);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Name = "GUI_ThongBao_ChucNang";
            this.Text = "GUI_ThongBao_ChucNang";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bntDanhSach;
        private System.Windows.Forms.Button bntThem;
    }
}