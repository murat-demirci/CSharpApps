using System;
using System.Windows.Forms;

namespace ApartmanOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gelirler_Click(object sender, EventArgs e)
        {
            new Gelirler().Show();
        }

        private void btn_giderler_Click(object sender, EventArgs e)
        {
            new Giderler().Show();
        }
    }
}
