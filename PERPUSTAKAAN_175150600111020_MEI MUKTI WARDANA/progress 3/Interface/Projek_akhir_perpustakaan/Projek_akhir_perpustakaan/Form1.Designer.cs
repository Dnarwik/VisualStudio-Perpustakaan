namespace Projek_akhir_perpustakaan
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelAtasLogin = new System.Windows.Forms.Panel();
            this.lblPerpustakaanFilkom = new System.Windows.Forms.Label();
            this.pictBoxFilkom = new System.Windows.Forms.PictureBox();
            this.panelBawahLogin = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonDaftarPadaLogin = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.textBoxUsernameLogin = new System.Windows.Forms.TextBox();
            this.labelBelumDaftar = new System.Windows.Forms.Label();
            this.labelPasswordLogin = new System.Windows.Forms.Label();
            this.labelUsernameLogin = new System.Windows.Forms.Label();
            this.panelDaftarAnggota = new System.Windows.Forms.Panel();
            this.buttonKembaliLogin = new System.Windows.Forms.Button();
            this.labelKonfirmPassDaftar = new System.Windows.Forms.Label();
            this.textBoxKonfirmPassDaftar = new System.Windows.Forms.TextBox();
            this.buttonDaftar = new System.Windows.Forms.Button();
            this.textBoxPassDaftar = new System.Windows.Forms.TextBox();
            this.textBoxUsernameDaftar = new System.Windows.Forms.TextBox();
            this.labelPassDaftar = new System.Windows.Forms.Label();
            this.labelUsernameDaftar = new System.Windows.Forms.Label();
            this.panelAtasLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxFilkom)).BeginInit();
            this.panelBawahLogin.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelDaftarAnggota.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAtasLogin
            // 
            this.panelAtasLogin.BackColor = System.Drawing.Color.Orange;
            this.panelAtasLogin.Controls.Add(this.lblPerpustakaanFilkom);
            this.panelAtasLogin.Controls.Add(this.pictBoxFilkom);
            this.panelAtasLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtasLogin.Location = new System.Drawing.Point(0, 0);
            this.panelAtasLogin.Name = "panelAtasLogin";
            this.panelAtasLogin.Size = new System.Drawing.Size(537, 67);
            this.panelAtasLogin.TabIndex = 0;
            // 
            // lblPerpustakaanFilkom
            // 
            this.lblPerpustakaanFilkom.AutoSize = true;
            this.lblPerpustakaanFilkom.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerpustakaanFilkom.Location = new System.Drawing.Point(225, 18);
            this.lblPerpustakaanFilkom.Name = "lblPerpustakaanFilkom";
            this.lblPerpustakaanFilkom.Size = new System.Drawing.Size(263, 29);
            this.lblPerpustakaanFilkom.TabIndex = 1;
            this.lblPerpustakaanFilkom.Text = "Perpustakaan Fikom";
            // 
            // pictBoxFilkom
            // 
            this.pictBoxFilkom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictBoxFilkom.BackgroundImage")));
            this.pictBoxFilkom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictBoxFilkom.Location = new System.Drawing.Point(0, 0);
            this.pictBoxFilkom.Name = "pictBoxFilkom";
            this.pictBoxFilkom.Size = new System.Drawing.Size(184, 65);
            this.pictBoxFilkom.TabIndex = 0;
            this.pictBoxFilkom.TabStop = false;
            // 
            // panelBawahLogin
            // 
            this.panelBawahLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelBawahLogin.Controls.Add(this.lblCopyright);
            this.panelBawahLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBawahLogin.Location = new System.Drawing.Point(0, 348);
            this.panelBawahLogin.Name = "panelBawahLogin";
            this.panelBawahLogin.Size = new System.Drawing.Size(537, 26);
            this.panelBawahLogin.TabIndex = 1;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(142, 6);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(254, 13);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "Copyright © Kelompok 1 Pemvis , All rights reserved.";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelLogin.Controls.Add(this.buttonDaftarPadaLogin);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.textBoxPasswordLogin);
            this.panelLogin.Controls.Add(this.textBoxUsernameLogin);
            this.panelLogin.Controls.Add(this.labelBelumDaftar);
            this.panelLogin.Controls.Add(this.labelPasswordLogin);
            this.panelLogin.Controls.Add(this.labelUsernameLogin);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 67);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(537, 281);
            this.panelLogin.TabIndex = 2;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // buttonDaftarPadaLogin
            // 
            this.buttonDaftarPadaLogin.BackColor = System.Drawing.Color.Cyan;
            this.buttonDaftarPadaLogin.Location = new System.Drawing.Point(247, 240);
            this.buttonDaftarPadaLogin.Name = "buttonDaftarPadaLogin";
            this.buttonDaftarPadaLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonDaftarPadaLogin.TabIndex = 6;
            this.buttonDaftarPadaLogin.Text = "Daftar";
            this.buttonDaftarPadaLogin.UseVisualStyleBackColor = false;
            this.buttonDaftarPadaLogin.Click += new System.EventHandler(this.buttonDaftarPadaLogin_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(321, 151);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPasswordLogin
            // 
            this.textBoxPasswordLogin.Location = new System.Drawing.Point(193, 116);
            this.textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            this.textBoxPasswordLogin.PasswordChar = '*';
            this.textBoxPasswordLogin.Size = new System.Drawing.Size(203, 20);
            this.textBoxPasswordLogin.TabIndex = 4;
            this.textBoxPasswordLogin.TextChanged += new System.EventHandler(this.textBoxPasswordLogin_TextChanged);
            // 
            // textBoxUsernameLogin
            // 
            this.textBoxUsernameLogin.Location = new System.Drawing.Point(193, 74);
            this.textBoxUsernameLogin.Name = "textBoxUsernameLogin";
            this.textBoxUsernameLogin.Size = new System.Drawing.Size(203, 20);
            this.textBoxUsernameLogin.TabIndex = 3;
            this.textBoxUsernameLogin.TextChanged += new System.EventHandler(this.textBoxUsernameLogin_TextChanged);
            // 
            // labelBelumDaftar
            // 
            this.labelBelumDaftar.AutoSize = true;
            this.labelBelumDaftar.Location = new System.Drawing.Point(211, 202);
            this.labelBelumDaftar.Name = "labelBelumDaftar";
            this.labelBelumDaftar.Size = new System.Drawing.Size(146, 13);
            this.labelBelumDaftar.TabIndex = 2;
            this.labelBelumDaftar.Text = "Belum punya akun anggota ?";
            // 
            // labelPasswordLogin
            // 
            this.labelPasswordLogin.AutoSize = true;
            this.labelPasswordLogin.Location = new System.Drawing.Point(129, 119);
            this.labelPasswordLogin.Name = "labelPasswordLogin";
            this.labelPasswordLogin.Size = new System.Drawing.Size(53, 13);
            this.labelPasswordLogin.TabIndex = 1;
            this.labelPasswordLogin.Text = "Password";
            // 
            // labelUsernameLogin
            // 
            this.labelUsernameLogin.AutoSize = true;
            this.labelUsernameLogin.Location = new System.Drawing.Point(129, 77);
            this.labelUsernameLogin.Name = "labelUsernameLogin";
            this.labelUsernameLogin.Size = new System.Drawing.Size(55, 13);
            this.labelUsernameLogin.TabIndex = 0;
            this.labelUsernameLogin.Text = "Username";
            // 
            // panelDaftarAnggota
            // 
            this.panelDaftarAnggota.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelDaftarAnggota.Controls.Add(this.buttonKembaliLogin);
            this.panelDaftarAnggota.Controls.Add(this.labelKonfirmPassDaftar);
            this.panelDaftarAnggota.Controls.Add(this.textBoxKonfirmPassDaftar);
            this.panelDaftarAnggota.Controls.Add(this.buttonDaftar);
            this.panelDaftarAnggota.Controls.Add(this.textBoxPassDaftar);
            this.panelDaftarAnggota.Controls.Add(this.textBoxUsernameDaftar);
            this.panelDaftarAnggota.Controls.Add(this.labelPassDaftar);
            this.panelDaftarAnggota.Controls.Add(this.labelUsernameDaftar);
            this.panelDaftarAnggota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDaftarAnggota.Location = new System.Drawing.Point(0, 0);
            this.panelDaftarAnggota.Name = "panelDaftarAnggota";
            this.panelDaftarAnggota.Size = new System.Drawing.Size(537, 374);
            this.panelDaftarAnggota.TabIndex = 3;
            // 
            // buttonKembaliLogin
            // 
            this.buttonKembaliLogin.Location = new System.Drawing.Point(138, 302);
            this.buttonKembaliLogin.Name = "buttonKembaliLogin";
            this.buttonKembaliLogin.Size = new System.Drawing.Size(264, 23);
            this.buttonKembaliLogin.TabIndex = 13;
            this.buttonKembaliLogin.Text = "Kembali ke halaman Login";
            this.buttonKembaliLogin.UseVisualStyleBackColor = true;
            this.buttonKembaliLogin.Click += new System.EventHandler(this.buttonKembaliLogin_Click);
            // 
            // labelKonfirmPassDaftar
            // 
            this.labelKonfirmPassDaftar.AutoSize = true;
            this.labelKonfirmPassDaftar.Location = new System.Drawing.Point(86, 221);
            this.labelKonfirmPassDaftar.Name = "labelKonfirmPassDaftar";
            this.labelKonfirmPassDaftar.Size = new System.Drawing.Size(104, 13);
            this.labelKonfirmPassDaftar.TabIndex = 12;
            this.labelKonfirmPassDaftar.Text = "Konfirmasi Password";
            // 
            // textBoxKonfirmPassDaftar
            // 
            this.textBoxKonfirmPassDaftar.Location = new System.Drawing.Point(199, 218);
            this.textBoxKonfirmPassDaftar.Name = "textBoxKonfirmPassDaftar";
            this.textBoxKonfirmPassDaftar.PasswordChar = '*';
            this.textBoxKonfirmPassDaftar.Size = new System.Drawing.Size(203, 20);
            this.textBoxKonfirmPassDaftar.TabIndex = 11;
            this.textBoxKonfirmPassDaftar.TextChanged += new System.EventHandler(this.textBoxKonfirmPassDaftar_TextChanged);
            // 
            // buttonDaftar
            // 
            this.buttonDaftar.Location = new System.Drawing.Point(327, 261);
            this.buttonDaftar.Name = "buttonDaftar";
            this.buttonDaftar.Size = new System.Drawing.Size(75, 23);
            this.buttonDaftar.TabIndex = 10;
            this.buttonDaftar.Text = "Daftar";
            this.buttonDaftar.UseVisualStyleBackColor = true;
            this.buttonDaftar.Click += new System.EventHandler(this.buttonDaftar_Click);
            // 
            // textBoxPassDaftar
            // 
            this.textBoxPassDaftar.Location = new System.Drawing.Point(199, 179);
            this.textBoxPassDaftar.Name = "textBoxPassDaftar";
            this.textBoxPassDaftar.PasswordChar = '*';
            this.textBoxPassDaftar.Size = new System.Drawing.Size(203, 20);
            this.textBoxPassDaftar.TabIndex = 9;
            this.textBoxPassDaftar.TextChanged += new System.EventHandler(this.textBoxPassDaftar_TextChanged);
            // 
            // textBoxUsernameDaftar
            // 
            this.textBoxUsernameDaftar.Location = new System.Drawing.Point(199, 137);
            this.textBoxUsernameDaftar.Name = "textBoxUsernameDaftar";
            this.textBoxUsernameDaftar.Size = new System.Drawing.Size(203, 20);
            this.textBoxUsernameDaftar.TabIndex = 8;
            this.textBoxUsernameDaftar.TextChanged += new System.EventHandler(this.textBoxUsernameDaftar_TextChanged);
            // 
            // labelPassDaftar
            // 
            this.labelPassDaftar.AutoSize = true;
            this.labelPassDaftar.Location = new System.Drawing.Point(135, 182);
            this.labelPassDaftar.Name = "labelPassDaftar";
            this.labelPassDaftar.Size = new System.Drawing.Size(53, 13);
            this.labelPassDaftar.TabIndex = 7;
            this.labelPassDaftar.Text = "Password";
            // 
            // labelUsernameDaftar
            // 
            this.labelUsernameDaftar.AutoSize = true;
            this.labelUsernameDaftar.Location = new System.Drawing.Point(135, 140);
            this.labelUsernameDaftar.Name = "labelUsernameDaftar";
            this.labelUsernameDaftar.Size = new System.Drawing.Size(55, 13);
            this.labelUsernameDaftar.TabIndex = 6;
            this.labelUsernameDaftar.Text = "Username";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 374);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelBawahLogin);
            this.Controls.Add(this.panelAtasLogin);
            this.Controls.Add(this.panelDaftarAnggota);
            this.Name = "Form1";
            this.Text = "Perpustakaan Filkom";
            this.panelAtasLogin.ResumeLayout(false);
            this.panelAtasLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxFilkom)).EndInit();
            this.panelBawahLogin.ResumeLayout(false);
            this.panelBawahLogin.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelDaftarAnggota.ResumeLayout(false);
            this.panelDaftarAnggota.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAtasLogin;
        private System.Windows.Forms.Label lblPerpustakaanFilkom;
        private System.Windows.Forms.PictureBox pictBoxFilkom;
        private System.Windows.Forms.Panel panelBawahLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelDaftarAnggota;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button buttonDaftarPadaLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPasswordLogin;
        private System.Windows.Forms.TextBox textBoxUsernameLogin;
        private System.Windows.Forms.Label labelBelumDaftar;
        private System.Windows.Forms.Label labelPasswordLogin;
        private System.Windows.Forms.Label labelUsernameLogin;
        private System.Windows.Forms.Button buttonKembaliLogin;
        private System.Windows.Forms.Label labelKonfirmPassDaftar;
        private System.Windows.Forms.TextBox textBoxKonfirmPassDaftar;
        private System.Windows.Forms.Button buttonDaftar;
        private System.Windows.Forms.TextBox textBoxPassDaftar;
        private System.Windows.Forms.TextBox textBoxUsernameDaftar;
        private System.Windows.Forms.Label labelPassDaftar;
        private System.Windows.Forms.Label labelUsernameDaftar;
    }
}

