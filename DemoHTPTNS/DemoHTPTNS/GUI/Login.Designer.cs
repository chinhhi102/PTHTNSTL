namespace DemoHTPTNS.GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.bntDangNhap = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntDangky = new System.Windows.Forms.Button();
            this.epLogin = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(160, 67);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(206, 22);
            this.txtTaiKhoan.TabIndex = 1;
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(160, 121);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(206, 22);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // bntDangNhap
            // 
            this.bntDangNhap.Location = new System.Drawing.Point(49, 168);
            this.bntDangNhap.Name = "bntDangNhap";
            this.bntDangNhap.Size = new System.Drawing.Size(87, 27);
            this.bntDangNhap.TabIndex = 3;
            this.bntDangNhap.Text = "Đăng nhập";
            this.bntDangNhap.UseVisualStyleBackColor = true;
            this.bntDangNhap.Click += new System.EventHandler(this.bntDangnhap_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntThoat.Location = new System.Drawing.Point(279, 168);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(87, 27);
            this.bntThoat.TabIndex = 4;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntDangky
            // 
            this.bntDangky.Location = new System.Drawing.Point(160, 168);
            this.bntDangky.Name = "bntDangky";
            this.bntDangky.Size = new System.Drawing.Size(87, 27);
            this.bntDangky.TabIndex = 3;
            this.bntDangky.Text = "Đăng ký";
            this.bntDangky.UseVisualStyleBackColor = true;
            this.bntDangky.Click += new System.EventHandler(this.bntDangky_Click);
            // 
            // epLogin
            // 
            this.epLogin.ContainerControl = this;
            // 
            // Login
            // 
            this.AcceptButton = this.bntDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntThoat;
            this.ClientSize = new System.Drawing.Size(407, 258);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntDangky);
            this.Controls.Add(this.bntDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.epLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button bntDangNhap;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntDangky;
        private System.Windows.Forms.ErrorProvider epLogin;
    }
}