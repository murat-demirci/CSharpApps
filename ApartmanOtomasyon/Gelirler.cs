using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApartmanOtomasyon
{
    public partial class Gelirler : Form
    {
        SqlHelper sqlHelper = new SqlHelper();
        public Gelirler()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int daireNo = Convert.ToInt32(comboBox1.Text);
            int para = (Int32)numericUpDown1.Value;
            DateTime tarih = dateTimePicker1.Value;

            SqlParameter p1 = new SqlParameter("DaireNo", daireNo);
            SqlParameter p2 = new SqlParameter("Para", para);
            SqlParameter p3 = new SqlParameter("Tarih", tarih);

            sqlHelper.ExecuteProc("odeme_al", p1, p2, p3);
        }

        private void Gelirler_Load(object sender, EventArgs e)
        {
            DataTable dt = sqlHelper.GetTable("select DaireNo, Para, Tarih from AidatOdemesi");

            foreach (DataRow item in dt.Rows)
            {
                listBox1.Items.Add(item[0].ToString());
                listBox2.Items.Add(item[1].ToString());
                listBox3.Items.Add(item[2].ToString().Remove(10));
            }

        }
    }
}
