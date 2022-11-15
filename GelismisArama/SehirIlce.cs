using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GelismisArama
{
    public partial class SehirIlce : Form
    {
        static string cs = @"Data Source=LAPTOP-UI9DTME8\TEW_SQLEXPRESS;Initial Catalog=turkiye;Integrated Security=True";
        public SehirIlce()
        {
            InitializeComponent();
        }

        private void SehirIlce_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from tbl_il";
            comboBox1.DisplayMember = "il_ad";
            comboBox1.ValueMember = "il_id";
            comboBox1.DropDownHeight = 150;
            comboBox1.DataSource = Sorgu(sorgu, cs);
        }

        public static DataTable Sorgu(string sorgu, string cs)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, cs);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            short secilenIlId = (short)comboBox1.SelectedValue;
            string sorgu = "select ilce_ad from tbl_ilce where il_id=" + secilenIlId.ToString();
            comboBox2.DisplayMember = "ilce_ad";
            comboBox2.DropDownHeight = 150;
            comboBox2.DataSource = Sorgu(sorgu, cs);
        }
    }
}
