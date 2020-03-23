using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projek_akhir_perpustakaan
{
    //Author : MEI MUKTI WARDANA (175150600111020)

    public partial class Form2 : Form
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "perpustakaan";
        private const String UID = "root";
        private const String PASSWORD = "inipassword";
        private static MySqlConnection dbConn;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 frm1)
        {
            InitializeComponent();
            Form _formm1 = frm1;
            this.Owner = _formm1;
        }

        private void panelKelolaBuku_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            String connString = builder.ToString();

            dbConn = new MySqlConnection(connString);
            String query = "SELECT * FROM buku";
            DataTable dt = new DataTable();

            MySqlDataAdapter da;
            da = new MySqlDataAdapter(query, dbConn);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void textBoxKelolaKodeB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKelolaJudulB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKelolaNamaP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKelolaTahunT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxIsbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPenerbit_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBoxKelolaKodeB.Text = row.Cells["Kode_buku"].Value.ToString();
                textBoxKelolaJudulB.Text = row.Cells["Judul"].Value.ToString();
                textBoxKelolaNamaP.Text = row.Cells["Penulis"].Value.ToString();
                textBoxKelolaTahunT.Text = row.Cells["Tahun_terbit"].Value.ToString();
                textBoxIsbn.Text = row.Cells["ISBN"].Value.ToString();
                textBoxPenerbit.Text = row.Cells["Penerbit"].Value.ToString();
            }
        }

        private void buttonKelolaAdd_Click(object sender, EventArgs e)
        {
            if (textBoxKelolaKodeB.Text != "" && textBoxIsbn.Text != "" && textBoxKelolaJudulB.Text != "" && textBoxKelolaNamaP.Text != "" && textBoxKelolaTahunT.Text != "" && textBoxPenerbit.Text != "")
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = SERVER;
                builder.Database = DATABASE;
                builder.UserID = UID;
                builder.Password = PASSWORD;

                String connString = builder.ToString();

                dbConn = new MySqlConnection(connString);

                String query = string.Format("INSERT INTO buku(Kode_buku,ISBN,Judul,Penulis,Tahun_terbit,Penerbit) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", textBoxKelolaKodeB.Text, textBoxIsbn.Text, textBoxKelolaJudulB.Text, textBoxKelolaNamaP.Text, textBoxKelolaTahunT.Text, textBoxPenerbit.Text);
                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                dbConn.Open();
                cmd.ExecuteNonQuery();
                dbConn.Close();
                MessageBox.Show("Data berhasil ditambah");
            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong");
            }

        }

        private void buttonKelolaUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxKelolaKodeB.Text != "" && textBoxIsbn.Text != "" && textBoxKelolaJudulB.Text != "" && textBoxKelolaNamaP.Text != "" && textBoxKelolaTahunT.Text != "" && textBoxPenerbit.Text != "")
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = SERVER;
                builder.Database = DATABASE;
                builder.UserID = UID;
                builder.Password = PASSWORD;

                String connString = builder.ToString();

                dbConn = new MySqlConnection(connString);

                MySqlCommand cmd;
                cmd = new MySqlCommand("UPDATE buku SET ISBN=@ISBN,Judul=@Judul,Penulis=@Penulis,Tahun_terbit=@Tahun_terbit,Penerbit=@Penerbit WHERE Kode_buku=@Kode_buku", dbConn);
                dbConn.Open();
                cmd.Parameters.AddWithValue("@Kode_buku", textBoxKelolaKodeB.Text);
                cmd.Parameters.AddWithValue("@ISBN", textBoxIsbn.Text);
                cmd.Parameters.AddWithValue("@Judul", textBoxKelolaJudulB.Text);
                cmd.Parameters.AddWithValue("@Penulis", textBoxKelolaNamaP.Text);
                cmd.Parameters.AddWithValue("@Tahun_terbit", textBoxKelolaTahunT.Text);
                cmd.Parameters.AddWithValue("@Penerbit", textBoxPenerbit.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate");
                dbConn.Close();
            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong");
            }

        }

        private void buttonKelolaDelete_Click(object sender, EventArgs e)
        {
            if (textBoxKelolaKodeB.Text != "")
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = SERVER;
                builder.Database = DATABASE;
                builder.UserID = UID;
                builder.Password = PASSWORD;

                String connString = builder.ToString();

                dbConn = new MySqlConnection(connString);
                String query = string.Format("DELETE  from buku where Kode_buku IN ('" + textBoxKelolaKodeB.Text + "')");
                
                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                dbConn.Open();
                cmd.ExecuteNonQuery();
                dbConn.Close();
                MessageBox.Show("Data berhasil didelete");
            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong");
            }
        }
    }
}
