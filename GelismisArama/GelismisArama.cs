using System;
using System.Windows.Forms;

namespace GelismisArama
{
    public partial class GelismisArama : Form
    {
        string cs = @"Data Source=LAPTOP-UI9DTME8;Initial Catalog=Movies;Integrated Security=True";
        public GelismisArama()
        {
            InitializeComponent();
        }

        void Sorgu()
        {
            string sorgu3;
            int languageId = (int)comboBox1.SelectedValue;
            string filmAd = textBox1.Text;
            int maxSure = (int)numericUpDown1.Value;
            sorgu3 = "select * from tblFilm where FilmName like '%" + filmAd +
                "%' and FilmLanguageID=" + languageId +
                "and FilmRunTimeMinutes<" + maxSure;
            dataGridView1.DataSource = SehirIlce.Sorgu(sorgu3, cs);
        }

        private void GelismisArama_Load(object sender, EventArgs e)
        {
            string sorgu1 = "select * from tblLanguage";
            comboBox1.DisplayMember = "Language";
            comboBox1.ValueMember = "LanguageID";
            comboBox1.DataSource = SehirIlce.Sorgu(sorgu1, cs);

            if (textBox1.Text == "" || numericUpDown1.Value == 0)
            {
                string sorgu2 = "select * from tblFilm";
                dataGridView1.DataSource = SehirIlce.Sorgu(sorgu2, cs);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Sorgu();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Sorgu();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sorgu();
        }
    }
}
