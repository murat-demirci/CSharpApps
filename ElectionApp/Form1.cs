using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ElectionApp
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new
            SqlConnection(@"");
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_oyver_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLELEC (Ilce,Hiper,Super,UltraSuper,Extra,ExtraSuper) values (@P1,@P2,@P3,@P4,@P5,@P6)", connection);
            cmd.Parameters.AddWithValue("@P1", txt_Ilce.Text);
            cmd.Parameters.AddWithValue("@P2", txt_hiper.Text);
            cmd.Parameters.AddWithValue("@P3", txt_super.Text);
            cmd.Parameters.AddWithValue("@P4", txt_ultsup.Text);
            cmd.Parameters.AddWithValue("@P5", txt_extra.Text);
            cmd.Parameters.AddWithValue("@P6", txt_extsup.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Islem Basrili", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void btn_grafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm = new FrmGrafikler();
            frm.Show();
        }
    }
}
