namespace Projek_akhir_perpustakaan
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelBawahLogin = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.panelAtasLogin = new System.Windows.Forms.Panel();
            this.lblPerpustakaanFilkom = new System.Windows.Forms.Label();
            this.pictBoxFilkom = new System.Windows.Forms.PictureBox();
            this.panelKelolaBuku = new System.Windows.Forms.Panel();
            this.textBoxPenerbit = new System.Windows.Forms.TextBox();
            this.labelPenerbit = new System.Windows.Forms.Label();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.labelIsbn = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonKelolaDelete = new System.Windows.Forms.Button();
            this.buttonKelolaUpdate = new System.Windows.Forms.Button();
            this.buttonKelolaAdd = new System.Windows.Forms.Button();
            this.textBoxKelolaTahunT = new System.Windows.Forms.TextBox();
            this.textBoxKelolaNamaP = new System.Windows.Forms.TextBox();
            this.textBoxKelolaJudulB = new System.Windows.Forms.TextBox();
            this.labelKelolaTahunT = new System.Windows.Forms.Label();
            this.labelKelolaNamaP = new System.Windows.Forms.Label();
            this.labelKelolaJudulB = new System.Windows.Forms.Label();
            this.labelKelolaKodeB = new System.Windows.Forms.Label();
            this.textBoxKelolaKodeB = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCari = new System.Windows.Forms.Button();
            this.textBoxCari = new System.Windows.Forms.TextBox();
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
            this.panelBawahLogin.Location = new System.Drawing.Point(0, 372);
            this.panelBawahLogin.Name = "panelBawahLogin";
            this.panelBawahLogin.Size = new System.Drawing.Size(682, 26);
            this.panelBawahLogin.TabIndex = 3;
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
            this.panelAtasLogin.Size = new System.Drawing.Size(682, 67);
            this.panelAtasLogin.TabIndex = 2;
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
            this.panelKelolaBuku.Controls.Add(this.textBoxPenerbit);
            this.panelKelolaBuku.Controls.Add(this.labelPenerbit);
            this.panelKelolaBuku.Controls.Add(this.textBoxIsbn);
            this.panelKelolaBuku.Controls.Add(this.labelIsbn);
            this.panelKelolaBuku.Controls.Add(this.dataGridView1);
            this.panelKelolaBuku.Controls.Add(this.buttonKelolaDelete);
            this.panelKelolaBuku.Controls.Add(this.buttonKelolaUpdate);
            this.panelKelolaBuku.Controls.Add(this.buttonKelolaAdd);
            this.panelKelolaBuku.Controls.Add(this.textBoxKelolaTahunT);
            this.panelKelolaBuku.Controls.Add(this.textBoxKelolaNamaP);
            this.panelKelolaBuku.Controls.Add(this.textBoxKelolaJudulB);
            this.panelKelolaBuku.Controls.Add(this.labelKelolaTahunT);
            this.panelKelolaBuku.Controls.Add(this.labelKelolaNamaP);
            this.panelKelolaBuku.Controls.Add(this.labelKelolaJudulB);
            this.panelKelolaBuku.Controls.Add(this.labelKelolaKodeB);
            this.panelKelolaBuku.Controls.Add(this.textBoxKelolaKodeB);
            this.panelKelolaBuku.Controls.Add(this.buttonReset);
            this.panelKelolaBuku.Controls.Add(this.buttonCari);
            this.panelKelolaBuku.Controls.Add(this.textBoxCari);
            this.panelKelolaBuku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKelolaBuku.Location = new System.Drawing.Point(0, 67);
            this.panelKelolaBuku.Name = "panelKelolaBuku";
            this.panelKelolaBuku.Size = new System.Drawing.Size(682, 305);
            this.panelKelolaBuku.TabIndex = 4;
            this.panelKelolaBuku.Paint += new System.Windows.Forms.PaintEventHandler(this.panelKelolaBuku_Paint);
            // 
            // textBoxPenerbit
            // 
            this.textBoxPenerbit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPenerbit.Location = new System.Drawing.Point(562, 184);
            this.textBoxPenerbit.Name = "textBoxPenerbit";
            this.textBoxPenerbit.Size = new System.Drawing.Size(108, 20);
            this.textBoxPenerbit.TabIndex = 21;
            this.textBoxPenerbit.TextChanged += new System.EventHandler(this.textBoxPenerbit_TextChanged);
            // 
            // labelPenerbit
            // 
            this.labelPenerbit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPenerbit.AutoSize = true;
            this.labelPenerbit.Location = new System.Drawing.Point(468, 187);
            this.labelPenerbit.Name = "labelPenerbit";
            this.labelPenerbit.Size = new System.Drawing.Size(46, 13);
            this.labelPenerbit.TabIndex = 20;
            this.labelPenerbit.Text = "Penerbit";
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIsbn.Location = new System.Drawing.Point(562, 158);
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(108, 20);
            this.textBoxIsbn.TabIndex = 19;
            this.textBoxIsbn.TextChanged += new System.EventHandler(this.textBoxIsbn_TextChanged);
            // 
            // labelIsbn
            // 
            this.labelIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIsbn.AutoSize = true;
            this.labelIsbn.Location = new System.Drawing.Point(468, 161);
            this.labelIsbn.Name = "labelIsbn";
            this.labelIsbn.Size = new System.Drawing.Size(32, 13);
            this.labelIsbn.TabIndex = 18;
            this.labelIsbn.Text = "ISBN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(451, 238);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonKelolaDelete
            // 
            this.buttonKelolaDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKelolaDelete.Location = new System.Drawing.Point(471, 273);
            this.buttonKelolaDelete.Name = "buttonKelolaDelete";
            this.buttonKelolaDelete.Size = new System.Drawing.Size(199, 23);
            this.buttonKelolaDelete.TabIndex = 16;
            this.buttonKelolaDelete.Text = "Delete";
            this.buttonKelolaDelete.UseVisualStyleBackColor = true;
            this.buttonKelolaDelete.Click += new System.EventHandler(this.buttonKelolaDelete_Click);
            // 
            // buttonKelolaUpdate
            // 
            this.buttonKelolaUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKelolaUpdate.Location = new System.Drawing.Point(471, 244);
            this.buttonKelolaUpdate.Name = "buttonKelolaUpdate";
            this.buttonKelolaUpdate.Size = new System.Drawing.Size(199, 23);
            this.buttonKelolaUpdate.TabIndex = 15;
            this.buttonKelolaUpdate.Text = "Update";
            this.buttonKelolaUpdate.UseVisualStyleBackColor = true;
            this.buttonKelolaUpdate.Click += new System.EventHandler(this.buttonKelolaUpdate_Click);
            // 
            // buttonKelolaAdd
            // 
            this.buttonKelolaAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKelolaAdd.Location = new System.Drawing.Point(471, 212);
            this.buttonKelolaAdd.Name = "buttonKelolaAdd";
            this.buttonKelolaAdd.Size = new System.Drawing.Size(199, 23);
            this.buttonKelolaAdd.TabIndex = 14;
            this.buttonKelolaAdd.Text = "Add";
            this.buttonKelolaAdd.UseVisualStyleBackColor = true;
            this.buttonKelolaAdd.Click += new System.EventHandler(this.buttonKelolaAdd_Click);
            // 
            // textBoxKelolaTahunT
            // 
            this.textBoxKelolaTahunT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKelolaTahunT.Location = new System.Drawing.Point(562, 132);
            this.textBoxKelolaTahunT.Name = "textBoxKelolaTahunT";
            this.textBoxKelolaTahunT.Size = new System.Drawing.Size(108, 20);
            this.textBoxKelolaTahunT.TabIndex = 13;
            this.textBoxKelolaTahunT.TextChanged += new System.EventHandler(this.textBoxKelolaTahunT_TextChanged);
            // 
            // textBoxKelolaNamaP
            // 
            this.textBoxKelolaNamaP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKelolaNamaP.Location = new System.Drawing.Point(562, 106);
            this.textBoxKelolaNamaP.Name = "textBoxKelolaNamaP";
            this.textBoxKelolaNamaP.Size = new System.Drawing.Size(108, 20);
            this.textBoxKelolaNamaP.TabIndex = 12;
            this.textBoxKelolaNamaP.TextChanged += new System.EventHandler(this.textBoxKelolaNamaP_TextChanged);
            // 
            // textBoxKelolaJudulB
            // 
            this.textBoxKelolaJudulB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKelolaJudulB.Location = new System.Drawing.Point(562, 80);
            this.textBoxKelolaJudulB.Name = "textBoxKelolaJudulB";
            this.textBoxKelolaJudulB.Size = new System.Drawing.Size(108, 20);
            this.textBoxKelolaJudulB.TabIndex = 11;
            this.textBoxKelolaJudulB.TextChanged += new System.EventHandler(this.textBoxKelolaJudulB_TextChanged);
            // 
            // labelKelolaTahunT
            // 
            this.labelKelolaTahunT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKelolaTahunT.AutoSize = true;
            this.labelKelolaTahunT.Location = new System.Drawing.Point(468, 135);
            this.labelKelolaTahunT.Name = "labelKelolaTahunT";
            this.labelKelolaTahunT.Size = new System.Drawing.Size(68, 13);
            this.labelKelolaTahunT.TabIndex = 10;
            this.labelKelolaTahunT.Text = "Tahun Terbit";
            // 
            // labelKelolaNamaP
            // 
            this.labelKelolaNamaP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKelolaNamaP.AutoSize = true;
            this.labelKelolaNamaP.Location = new System.Drawing.Point(468, 109);
            this.labelKelolaNamaP.Name = "labelKelolaNamaP";
            this.labelKelolaNamaP.Size = new System.Drawing.Size(72, 13);
            this.labelKelolaNamaP.TabIndex = 9;
            this.labelKelolaNamaP.Text = "Nama Penulis";
            // 
            // labelKelolaJudulB
            // 
            this.labelKelolaJudulB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKelolaJudulB.AutoSize = true;
            this.labelKelolaJudulB.Location = new System.Drawing.Point(468, 83);
            this.labelKelolaJudulB.Name = "labelKelolaJudulB";
            this.labelKelolaJudulB.Size = new System.Drawing.Size(60, 13);
            this.labelKelolaJudulB.TabIndex = 8;
            this.labelKelolaJudulB.Text = "Judul Buku";
            // 
            // labelKelolaKodeB
            // 
            this.labelKelolaKodeB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKelolaKodeB.AutoSize = true;
            this.labelKelolaKodeB.Location = new System.Drawing.Point(468, 58);
            this.labelKelolaKodeB.Name = "labelKelolaKodeB";
            this.labelKelolaKodeB.Size = new System.Drawing.Size(60, 13);
            this.labelKelolaKodeB.TabIndex = 7;
            this.labelKelolaKodeB.Text = "Kode Buku";
            // 
            // textBoxKelolaKodeB
            // 
            this.textBoxKelolaKodeB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKelolaKodeB.Location = new System.Drawing.Point(562, 55);
            this.textBoxKelolaKodeB.Name = "textBoxKelolaKodeB";
            this.textBoxKelolaKodeB.Size = new System.Drawing.Size(108, 20);
            this.textBoxKelolaKodeB.TabIndex = 6;
            this.textBoxKelolaKodeB.TextChanged += new System.EventHandler(this.textBoxKelolaKodeB_TextChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(289, 32);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset/Load";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCari
            // 
            this.buttonCari.Location = new System.Drawing.Point(202, 32);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(75, 23);
            this.buttonCari.TabIndex = 4;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = true;
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(12, 32);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(172, 20);
            this.textBoxCari.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 398);
            this.Controls.Add(this.panelKelolaBuku);
            this.Controls.Add(this.panelBawahLogin);
            this.Controls.Add(this.panelAtasLogin);
            this.Name = "Form2";
            this.Text = "Kelola Buku";
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
        private System.Windows.Forms.Button buttonKelolaDelete;
        private System.Windows.Forms.Button buttonKelolaUpdate;
        private System.Windows.Forms.Button buttonKelolaAdd;
        private System.Windows.Forms.TextBox textBoxKelolaTahunT;
        private System.Windows.Forms.TextBox textBoxKelolaNamaP;
        private System.Windows.Forms.TextBox textBoxKelolaJudulB;
        private System.Windows.Forms.Label labelKelolaTahunT;
        private System.Windows.Forms.Label labelKelolaNamaP;
        private System.Windows.Forms.Label labelKelolaJudulB;
        private System.Windows.Forms.Label labelKelolaKodeB;
        private System.Windows.Forms.TextBox textBoxKelolaKodeB;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxPenerbit;
        private System.Windows.Forms.Label labelPenerbit;
        private System.Windows.Forms.TextBox textBoxIsbn;
        private System.Windows.Forms.Label labelIsbn;
    }
}