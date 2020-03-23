namespace Projek_akhir_perpustakaan
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panelBawahLogin = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.panelAtasLogin = new System.Windows.Forms.Panel();
            this.lblPerpustakaanFilkom = new System.Windows.Forms.Label();
            this.pictBoxFilkom = new System.Windows.Forms.PictureBox();
            this.panelKelolaBuku = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCari = new System.Windows.Forms.Button();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelBawahLogin.SuspendLayout();
            this.panelAtasLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxFilkom)).BeginInit();
            this.panelKelolaBuku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBawahLogin
            // 
            this.panelBawahLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelBawahLogin.Controls.Add(this.lblCopyright);
            this.panelBawahLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBawahLogin.Location = new System.Drawing.Point(0, 371);
            this.panelBawahLogin.Name = "panelBawahLogin";
            this.panelBawahLogin.Size = new System.Drawing.Size(683, 26);
            this.panelBawahLogin.TabIndex = 5;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(227, 4);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(254, 13);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "Copyright © Kelompok 1 Pemvis , All rights reserved.";
            // 
            // panelAtasLogin
            // 
            this.panelAtasLogin.BackColor = System.Drawing.Color.Orange;
            this.panelAtasLogin.Controls.Add(this.lblPerpustakaanFilkom);
            this.panelAtasLogin.Controls.Add(this.pictBoxFilkom);
            this.panelAtasLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtasLogin.Location = new System.Drawing.Point(0, 0);
            this.panelAtasLogin.Name = "panelAtasLogin";
            this.panelAtasLogin.Size = new System.Drawing.Size(683, 67);
            this.panelAtasLogin.TabIndex = 4;
            // 
            // lblPerpustakaanFilkom
            // 
            this.lblPerpustakaanFilkom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // panelKelolaBuku
            // 
            this.panelKelolaBuku.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelKelolaBuku.Controls.Add(this.dataGridView1);
            this.panelKelolaBuku.Controls.Add(this.buttonReset);
            this.panelKelolaBuku.Controls.Add(this.buttonCari);
            this.panelKelolaBuku.Controls.Add(this.textBoxCari);
            this.panelKelolaBuku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKelolaBuku.Location = new System.Drawing.Point(0, 67);
            this.panelKelolaBuku.Name = "panelKelolaBuku";
            this.panelKelolaBuku.Size = new System.Drawing.Size(683, 304);
            this.panelKelolaBuku.TabIndex = 6;
            this.panelKelolaBuku.Paint += new System.Windows.Forms.PaintEventHandler(this.panelKelolaBuku_Paint);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(289, 44);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset/Load";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCari
            // 
            this.buttonCari.Location = new System.Drawing.Point(202, 44);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(75, 23);
            this.buttonCari.TabIndex = 4;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = true;
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(12, 44);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(172, 20);
            this.textBoxCari.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(659, 225);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 397);
            this.Controls.Add(this.panelKelolaBuku);
            this.Controls.Add(this.panelBawahLogin);
            this.Controls.Add(this.panelAtasLogin);
            this.Name = "Form3";
            this.Text = "Cari Buku";
            this.panelBawahLogin.ResumeLayout(false);
            this.panelBawahLogin.PerformLayout();
            this.panelAtasLogin.ResumeLayout(false);
            this.panelAtasLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxFilkom)).EndInit();
            this.panelKelolaBuku.ResumeLayout(false);
            this.panelKelolaBuku.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBawahLogin;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Panel panelAtasLogin;
        private System.Windows.Forms.Label lblPerpustakaanFilkom;
        private System.Windows.Forms.PictureBox pictBoxFilkom;
        private System.Windows.Forms.Panel panelKelolaBuku;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}