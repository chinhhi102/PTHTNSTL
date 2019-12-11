namespace DemoHTPTNS.GUI
{
    partial class Signup
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoVaTenDem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
            this.bntDangky = new System.Windows.Forms.Button();
            this.bntTrove = new System.Windows.Forms.Button();
            this.epValidation = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epValidation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên đệm";
            // 
            // txtHoVaTenDem
            // 
            this.txtHoVaTenDem.Location = new System.Drawing.Point(33, 52);
            this.txtHoVaTenDem.Name = "txtHoVaTenDem";
            this.txtHoVaTenDem.Size = new System.Drawing.Size(116, 22);
            this.txtHoVaTenDem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài khoản";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(33, 117);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(264, 22);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(33, 181);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(264, 22);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(181, 52);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(116, 22);
            this.txtTen.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.Location = new System.Drawing.Point(33, 247);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.PasswordChar = '*';
            this.txtNhapLaiMK.Size = new System.Drawing.Size(264, 22);
            this.txtNhapLaiMK.TabIndex = 5;
            this.txtNhapLaiMK.TextChanged += new System.EventHandler(this.txtNhapLaiMK_TextChanged);
            // 
            // bntDangky
            // 
            this.bntDangky.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDangky.Location = new System.Drawing.Point(33, 292);
            this.bntDangky.Name = "bntDangky";
            this.bntDangky.Size = new System.Drawing.Size(117, 36);
            this.bntDangky.TabIndex = 6;
            this.bntDangky.Text = "Đăng ký";
            this.bntDangky.UseVisualStyleBackColor = true;
            this.bntDangky.Click += new System.EventHandler(this.bntDangky_Click);
            // 
            // bntTrove
            // 
            this.bntTrove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntTrove.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.bntTrove.Location = new System.Drawing.Point(181, 292);
            this.bntTrove.Name = "bntTrove";
            this.bntTrove.Size = new System.Drawing.Size(117, 36);
            this.bntTrove.TabIndex = 7;
            this.bntTrove.Text = "Trở về";
            this.bntTrove.UseVisualStyleBackColor = true;
            this.bntTrove.Click += new System.EventHandler(this.bntTrove_Click);
            // 
            // epValidation
            // 
            this.epValidation.ContainerControl = this;
            // 
            // Signup
            // 
            this.AcceptButton = this.bntDangky;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntTrove;
            this.ClientSize = new System.Drawing.Size(357, 353);
            this.Controls.Add(this.bntTrove);
            this.Controls.Add(this.bntDangky);
            this.Controls.Add(this.txtNhapLaiMK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoVaTenDem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Name = "Signup";
            this.Text = "Đăng ký";
            ((System.ComponentModel.ISupportInitialize)(this.epValidation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoVaTenDem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNhapLaiMK;
        private System.Windows.Forms.Button bntDangky;
        private System.Windows.Forms.Button bntTrove;
        private System.Windows.Forms.ErrorProvider epValidation;
    }
}