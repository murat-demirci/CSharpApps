using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using UcakSavarOyunu.Properties;

namespace UcakSavarOyunu
{
    public partial class Form1 : Form
    {
        PictureBox air_craft = new PictureBox();
        ArrayList ammoList = new ArrayList();
        ArrayList planeList = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            air_craft.Image = Resources.rocket_launcher;
            air_craft.Size = new Size(100, 100);
            air_craft.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(air_craft);
            air_craft.Location = new Point(300, 470);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            planeList.Add(CreatePlane());
            foreach (PictureBox item in planeList)
            {
                PlaneMoves(item);
            }
        }

        private object CreatePlane()
        {
            PictureBox plane = new PictureBox
            {
                Image = Resources.plane,
                Size = new Size(100, 100),
                SizeMode = PictureBoxSizeMode.StretchImage

            };
            Random rand = new Random();
            int planeStart = rand.Next(0, 1000);
            plane.Location = new Point(planeStart, 0);
            timer3.Enabled = true;
            return plane;
        }
        private void PlaneMoves(PictureBox plane)
        {

            //plane.Image = Resources.plane;
            int x = plane.Location.X;
            int y = plane.Location.Y;
            y += 5;
            plane.Location = new Point(x, y);
            Controls.Add(plane);
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            AirCraftMoves(e);
            if (e.KeyCode == Keys.Space)
            {
                ammoList.Add(CreateAmmo());
                timer2.Enabled = true;
            }
        }


        private void AirCraftMoves(KeyEventArgs e)
        {
            int acx = air_craft.Location.X;
            int acy = air_craft.Location.Y;

            if (e.KeyCode == Keys.Right)
            {
                acx += 5;
            }
            else if (e.KeyCode == Keys.Left)
            {
                acx -= 5;
            }
            air_craft.Location = new Point(acx, acy);
            Controls.Add(air_craft);
        }

        private PictureBox CreateAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Resources.bomb;
            ammo.SizeMode = PictureBoxSizeMode.StretchImage;
            ammo.Location = new Point(air_craft.Location.X, air_craft.Location.Y);
            Controls.Add(ammo);
            return ammo;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox item in ammoList)
            {
                AmmoMoves(item);
            }
        }

        private void AmmoMoves(PictureBox ammo)
        {
            ammo.Image = Resources.bomb;
            int ax = ammo.Location.X;
            int ay = ammo.Location.Y;
            ay -= 5;
            ammo.Location = new Point(ax, ay);
            Controls.Add(ammo);
        }

        int point = 0;
        PictureBox removedPlanes = new PictureBox();
        PictureBox removedAmmos = new PictureBox();

        private void timer3_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox item in ammoList)
            {
                foreach (PictureBox item1 in planeList)
                {
                    if (item.Bounds.IntersectsWith(item1.Bounds))//kesistiginde kullanilan metot
                    {
                        Controls.Remove(item);
                        Controls.Remove(item1);
                        removedAmmos = item;
                        removedPlanes = item1;
                        point++;
                        label2.Text = point.ToString();
                    }
                }
            }
            ammoList.Remove(removedAmmos);
            planeList.Remove(removedPlanes);
        }
    }
}
