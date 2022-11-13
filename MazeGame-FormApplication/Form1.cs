using System;
using System.Drawing;
using System.Windows.Forms;

namespace MazeGame_FormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            MoveToStart();
        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations");
            Close();
        }

        private void MoveToStart()
        {
            //Form1.SetStyle(ControlStyles.UserPaint, true);
            //Form1.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //Form1.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            Point startingPoint = panel1.Location;
            startingPoint.Offset(5, 5);
            Cursor.Position = PointToScreen(startingPoint);

        }

        private void Wall(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
