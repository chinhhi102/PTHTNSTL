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
            this.bntDatLich.Location = new System.Drawing.Point(12, 12);
            this.bntDatLich.Name = "bntDatLich";
            this.bntDatLich.Size = new System.Drawing.Size(204, 23);
            this.bntDatLich.TabIndex = 0;
            this.bntDatLich.Text = "Đặt lịch phỏng vấn";
            this.bntDatLich.UseVisualStyleBackColor = true;
            this.bntDatLich.Click += new System.EventHandler(this.bntDatLich_Click);
            // 
            // bntXuLyKQ
            // 
            this.bntXuLyKQ.Location = new System.Drawing.Point(222, 12);
            this.bntXuLyKQ.Name = "bntXuLyKQ";
            this.bntXuLyKQ.Size = new System.Drawing.Size(204, 23);
            this.bntXuLyKQ.TabIndex = 0;
            this.bntXuLyKQ.Text = "Xử lý kết quả phỏng vấn";
            this.bntXuLyKQ.UseVisualStyleBackColor = true;
            this.bntXuLyKQ.Click += new System.EventHandler(this.bntXuLyKQ_Click);
            // 
            // GUI_XuLyHoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 355);
            this.Controls.Add(this.bntXuLyKQ);
            this.Controls.Add(this.bntDatLich);
            this.Name = "GUI_XuLyHoSo";
            this.Text = "GUI_XuLyHoSo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntDatLich;
        private System.Windows.Forms.Button bntXuLyKQ;
    }
}