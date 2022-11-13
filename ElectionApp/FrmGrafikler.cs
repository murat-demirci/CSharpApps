using System.Data.SqlClient;
using System.Windows.Forms;

namespace ElectionApp
{
    public partial class FrmGrafikler : Form
    {
        SqlConnection connection = new
            SqlConnection(@"data source=LAPTOP-UI9DTME8\TEW_SQLEXPRESS;
initial catalog=Election;trusted_connection=true");
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        private void FrmGrafikler_Load(object sender, System.EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select Ilce from TBLELEC", connection);
            SqlDataReader dr = cmd.ExecuteReader();//veri okuma
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            connection.Close();

            connection.Open();
            SqlCommand cmd2 = new SqlCommand("select sum(Hiper),sum(Super),sum(UltraSuper),sum(Extra),sum(ExtraSuper) from TBLELEC", connection);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("Hiper Parti", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("Super Parti", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("UltraSuper Parti", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("Extra Parti", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("ExtraSuper Parti", dr2[4]);
            }
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            connection.Open();
            SqlCommand sql = new SqlCommand("Select * From TBLELEC where Ilce=@P1", connection);
            sql.Parameters.AddWithValue("@P1", comboBox1.Text);
            SqlDataReader sqlDataReader = sql.ExecuteReader();
            while (sqlDataReader.Read())
            {
                progressBar1.Value = int.Parse(sqlDataReader[2].ToString());
                progressBar2.Value = int.Parse(sqlDataReader[3].ToString());
                progressBar3.Value = int.Parse(sqlDataReader[4].ToString());
                progressBar4.Value = int.Parse(sqlDataReader[5].ToString());
                progressBar5.Value = int.Parse(sqlDataReader[6].ToString());

                lbl_hiper.Text = sqlDataReader[2].ToString();
                lbl_super.Text = sqlDataReader[3].ToString();
                lbl_ultrasup.Text = sqlDataReader[4].ToString();
                lbl_extra.Text = sqlDataReader[5].ToString();
                lbl_extrasup.Text = sqlDataReader[6].ToString();
            }
            connection.Close();
        }
    }
}
