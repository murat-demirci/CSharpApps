using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GelismisArama
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_baglan_Click(object sender, EventArgs e)
        {
            string adress = @"Data Source=LAPTOP-UI9DTME8;Initial Catalog=Movies;Integrated Security=True";
            if (connection.State == ConnectionState.Open)
            {
                MessageBox.Show("Baglanti zaten acik", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = adress;
                connection.Open();
            }
            else
            {
                MessageBox.Show(connection.State.ToString());
            }
        }

        private void btn_tablogetir_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tblFilm", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            connection.Close();
            MessageBox.Show("Baglanti kapatildi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = "";

        }
    }
}
