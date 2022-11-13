using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApartmanOtomasyon
{
    public partial class Giderler : Form
    {
        SqlHelper sqlHelper = new SqlHelper();
        public Giderler()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int para = Convert.ToInt32(numericUpDown1.Value);
            DateTime tarih = dateTimePicker1.Value;
            string giderler = "";
            foreach (Control item in groupBox1.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    giderler += item.Text + ',';
                }
            }
            giderler = giderler.Remove(giderler.Length - 1);

            SqlParameter p1 = new SqlParameter("Para", para);
            SqlParameter p2 = new SqlParameter("Tarih", tarih);
            SqlParameter p3 = new SqlParameter("Gider", giderler);

            sqlHelper.ExecuteProc("giderler", p1, p2, p3);
        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            DataTable dt = sqlHelper.GetTable("select Gider,Para,Tarih from GiderTablosu");
            foreach (DataRow item in dt.Rows)
            {
                listBox1.Items.Add(item[0]);
                listBox2.Items.Add(item[1].ToString());
                listBox3.Items.Add(item[2].ToString().Remove(10));
            }
        }
    }
}
