namespace DemoHTPTNS.GUI.XuLy
{
    partial class GUI_XuLyHoSo
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
            this.bntDatLich = new System.Windows.Forms.Button();
            this.bntXuLyKQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntDatLich
            // 
            this.bntDatLich.Location = new System.Drawing.Point(14, 14);
            this.bntDatLich.Name = "bntDatLich";
            this.bntDatLich.Size = new System.Drawing.Size(238, 27);
            this.bntDatLich.TabIndex = 0;
            this.bntDatLich.Text = "Đặt lịch phỏng vấn";
            this.bntDatLich.UseVisualStyleBackColor = true;
            this.bntDatLich.Click += new System.EventHandler(this.bntDatLich_Click);
            // 
            // bntXuLyKQ
            // 
            this.bntXuLyKQ.Location = new System.Drawing.Point(259, 14);
            this.bntXuLyKQ.Name = "bntXuLyKQ";
            this.bntXuLyKQ.Size = new System.Drawing.Size(238, 27);
            this.bntXuLyKQ.TabIndex = 0;
            this.bntXuLyKQ.Text = "Xử lý kết quả phỏng vấn";
            this.bntXuLyKQ.UseVisualStyleBackColor = true;
            this.bntXuLyKQ.Click += new System.EventHandler(this.bntXuLyKQ_Click);
            // 
            // GUI_XuLyHoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 410);
            this.Controls.Add(this.bntXuLyKQ);
            this.Controls.Add(this.bntDatLich);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Name = "GUI_XuLyHoSo";
            this.Text = "GUI_XuLyHoSo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntDatLich;
        private System.Windows.Forms.Button bntXuLyKQ;
    }
}