using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YoutubeApp
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser browser;//add nuget and using --> cefsharp.winforms 

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection =
            new SqlConnection("data source=LAPTOP-UI9DTME8\\TEW_SQLEXPRESS;initial catalog=YoutubeChannelDers;trusted_connection=true");
        private void btn_Save_Click(object sender, EventArgs e)
        {
            connection.Open();//baglanti ac
            SqlCommand cmd = new
                SqlCommand("insert into TBLYoutube (Name,Category,URL) values (@P1,@P2,@P3)", connection);//ekleme
            cmd.Parameters.AddWithValue("@P1", txt_VideoName.Text);
            cmd.Parameters.AddWithValue("@P2", txt_Category.Text);
            cmd.Parameters.AddWithValue("@P3", txt_URL.Text);
            cmd.ExecuteNonQuery();//komutu calistirma
            connection.Close();

            MessageBox.Show("Video added your list", "Information"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void Videos()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TBLYoutube", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);//adapterla cekilen verileri dt ye aktar
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Videos();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser(link);
            browser.MinimumSize = new System.Drawing.Size(100, 100);
            groupBox3.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;

        }
    }
}
