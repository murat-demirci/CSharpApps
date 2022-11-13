using System;
using System.Drawing;
using System.Windows.Forms;

namespace PinponGame_FormApplication
{
    public partial class game_form : Form
    {
        public int speedLeft = 4;
        public int speedTop = 4;
        public int score = 0;
        public game_form()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
            Bounds = Screen.PrimaryScreen.Bounds;//tum ekrani kapla
            rocket.Top = playground.Bottom - (playground.Bottom / 10);

            gameover_lbl.Left = (playground.Width / 2) - (gameover_lbl.Width / 2);
            gameover_lbl.Top = (playground.Height / 2) - (gameover_lbl.Height / 2);
            gameover_lbl.Visible = false;
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            rocket.Left = Cursor.Position.X - (rocket.Width / 2);
            ball.Left += speedLeft;
            ball.Top += speedTop;

            if (ball.Left <= playground.Left)
            {
                speedLeft = -speedLeft;
            }
            if (ball.Right >= playground.Right)
            {
                speedLeft = -speedLeft;
            }
            if (ball.Top <= playground.Top)
            {
                speedTop = -speedTop;
            }
            if (ball.Bottom >= playground.Bottom)
            {
                gameover_lbl.Visible = true;
                timer1.Enabled = false;
            }
            if (ball.Bottom >= rocket.Top && ball.Bottom <= rocket.Bottom &&
                ball.Left >= rocket.Left && ball.Right <= rocket.Right)
            {
                speedTop += 1;
                speedLeft += 1;
                speedTop = -speedTop;
                score += 1;
                points_label.Text = score.ToString();
                Random random = new Random();
                playground.BackColor = Color.FromArgb(random.Next(150, 255),
                    random.Next(150, 255), random.Next(150, 255));
            }
        }

        private void game_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Close(); }
            if (e.KeyCode == Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                speedLeft = 4;
                points_label.Text = "0";
                timer1.Enabled = true;
                gameover_lbl.Visible = false;
                playground.BackColor = Color.White;
            }
        }
    }
}
