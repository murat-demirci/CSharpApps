using System;
using System.Windows.Forms;

namespace GeriSayim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private int second = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (second > 0)
            {
                progressBar2.Value++;
                second--;
                label4.Text = second.ToString() + " Remained";
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("Time is up", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                second = 10;
                progressBar2.Value = 0;
            }
        }
    }
}
