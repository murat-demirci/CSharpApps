using System;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Player.URL = openFileDialog1.FileName;
                textBox1.Text = openFileDialog1.FileName.Replace("\\", "+");
                int index = textBox1.Text.LastIndexOf('+');
                textBox1.Text = textBox1.Text.Remove(0, index + 1);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
