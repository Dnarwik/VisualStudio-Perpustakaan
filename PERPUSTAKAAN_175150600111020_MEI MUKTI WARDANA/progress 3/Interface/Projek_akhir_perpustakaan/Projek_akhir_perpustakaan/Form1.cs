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

    public partial class Form1 : Form
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "perpustakaan";
        private const String UID = "root";
        private const String PASSWORD = "inipassword";
        private static MySqlConnection dbConn;
        protected String userAnggotaSementara;
        protected String passAnggotaSementara;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxUsernameLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPasswordLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            MySqlDataAdapter adapter;
            DataTable table = new DataTable();

            String connString = builder.ToString();

            dbConn = new MySqlConnection(connString);
            
            try
            {
                bool loginPetugas = false;
                bool loginAnggota = false;

                dbConn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM daftarloginlogoutpetugas WHERE username = '"+textBoxUsernameLogin.Text+"' && password='"+textBoxPasswordLogin.Text+"'", dbConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                    loginPetugas = false;
                }
                else
                {
                    loginPetugas = true;
                }
                dbConn.Close();

                dbConn.Open();
                da = new MySqlDataAdapter("SELECT * FROM daftarloginlogoutanggota WHERE username = '" + textBoxUsernameLogin.Text + "' && password='" + textBoxPasswordLogin.Text + "'", dbConn);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                    loginAnggota = false;
                }
                else
                {
                    loginAnggota = true;
                }
                dbConn.Close();

                if (loginPetugas == true)
                {
                    loginPetugas = false;
                    Form2 frm2 = new Form2(this);
                    frm2.Show();
                }
                else if (loginAnggota == true)
                {
                    loginAnggota = false;
                    Form3 frm3 = new Form3(this);
                    frm3.Show();
                }
                else
                {
                    MessageBox.Show("Password atau Username salah!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Error");
            }
        }

        private void buttonDaftarPadaLogin_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            MySqlDataAdapter adapter;
            DataTable table = new DataTable();

            String connString = builder.ToString();

            dbConn = new MySqlConnection(connString);


            if (textBoxPassDaftar.Text != textBoxKonfirmPassDaftar.Text)
            {
                MessageBox.Show("Password dan konfirmasi password harus sama!");
            }
            else
            {
                String query = string.Format("INSERT INTO daftarloginlogoutanggota (id,nama,username,password) VALUES ('{0}','{1}','{2}','{3}')", "", "", textBoxUsernameDaftar.Text, textBoxPassDaftar.Text);
                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                dbConn.Open();
                cmd.ExecuteNonQuery();
                dbConn.Close();

                MessageBox.Show("Akun Anggota berhasil dibuat");
            }
        }

        private void textBoxUsernameDaftar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassDaftar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKonfirmPassDaftar_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonKembaliLogin_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
        }
    }
}
