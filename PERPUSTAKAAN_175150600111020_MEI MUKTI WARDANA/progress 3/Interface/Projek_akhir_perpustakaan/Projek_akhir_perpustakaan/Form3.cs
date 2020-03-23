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

    public partial class Form3 : Form
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "perpustakaan";
        private const String UID = "root";
        private const String PASSWORD = "inipassword";
        private static MySqlConnection dbConn;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 frm1)
        {
            InitializeComponent();
            Form _formm1 = frm1;
            this.Owner = _formm1;
        }

        private void panelKelolaBuku_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
