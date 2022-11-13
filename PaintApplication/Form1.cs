using System.Drawing;
using System.Windows.Forms;

namespace PaintApplication
{
    public partial class Form1 : Form
    {
        private readonly Bitmap bmp = new Bitmap(1024, 768);//resolution yazilir
        private readonly Pen pen = new Pen(Color.Black, 5);
        private bool drawing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawing) { drawing = false; }
            else { drawing = true; }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.DrawEllipse(pen, e.X, e.Y, 1, 1);
                pictureBox1.Image = bmp;
            }
        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void toolStripButton2_Click(object sender, System.EventArgs e)
        {
            pen.Color = Color.Blue;
        }

        private void toolStripButton3_Click(object sender, System.EventArgs e)
        {
            pen.Color = Color.Green;
        }

        private void toolStripButton4_Click(object sender, System.EventArgs e)
        {
            pen.Color = Color.Black;
        }

        private void toolStripButton5_Click(object sender, System.EventArgs e)
        {
            pen.Color = Color.White;
        }

        private void toolStripButton6_Click(object sender, System.EventArgs e)
        {
            ////Graphics g = Graphics.FromImage(bmp);
            ////g.Clear(ForeColor);
            //ColorPalette pal = bmp.Palette;
            //pal.Entries[1] = Color.LightGray;
            //label1.Text = bmp.Palette.Entries[0].ToString();
            ////pal.Entries[1] = Color.LightGray;
            ////bmp.Palette = pal;
            ////pictureBox1.Image = bmp;
        }

        private void saveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "JPeg Image|*.jpg|Bitmap Image *.bmp|",
                Title = "Save File"
            };
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
