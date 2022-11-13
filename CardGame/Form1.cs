using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CardGame
{
    public partial class Form1 : Form
    {
        public PictureBox card1 = new PictureBox();
        public PictureBox card2 = new PictureBox();
        public PictureBox card3 = new PictureBox();
        public PictureBox card4 = new PictureBox();
        public PictureBox card5 = new PictureBox();
        public PictureBox card6 = new PictureBox();
        public PictureBox card7 = new PictureBox();
        public PictureBox card8 = new PictureBox();
        public PictureBox card9 = new PictureBox();
        public List<PictureBox> pictureBoxes = new List<PictureBox>();
        public string[] cardList = Directory.GetFiles(@"C:\Users\demur\Desktop\WebFiles\UdemyStudioDers\CSharp\CardGame\Kartlar");
        public string[] cardArry1 = new string[26];
        public string[] cardArry2 = new string[26];
        private string secCard;
        private int AIscore = 0;
        private int playerScore = 0, count = 0, l = 17, k = 3;

        public Form1()
        {
            InitializeComponent();
            cardList = Karistir(cardList);
            KartiBol(cardList);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button5.Enabled = true;
            button1.Enabled = false;
            card1.ImageLocation = cardList[0];
            card1.Location = new Point(100, 70);
            card1.Size = new Size(100, 150);
            card1.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(card1);
            int index = card1.ImageLocation.LastIndexOf(@"\");
            char ch = card1.ImageLocation.ElementAt(index + 1);
            if (ch == 'o')
            {
                AIscore += 10;
            }
            else if (ch == 'a')
            {
                if (AIscore + 11 <= 21)
                {
                    AIscore += 11;
                }
                else
                {
                    AIscore += 1;
                }
            }
            else
            {
                switch (ch)
                {
                    case '2':
                        AIscore += 2;
                        break;
                    case '3':
                        AIscore += 3;
                        break;
                    case '4':
                        AIscore += 4;
                        break;
                    case '5':
                        AIscore += 5;
                        break;
                    case '6':
                        AIscore += 6;
                        break;
                    case '7':
                        AIscore += 7;
                        break;
                    case '8':
                        AIscore += 8;
                        break;
                    case '9':
                        AIscore += 9;
                        break;
                    default:
                        break;
                }
            }
            label2.Text = AIscore.ToString();

            card3.ImageLocation = @"C:\Users\demur\Desktop\WebFiles\UdemyStudioDers\CSharp\CardGame\arka.jpg";
            card3.Location = new Point(117, 70);
            card3.Size = new Size(100, 150);
            card3.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(card3);
            secCard = cardList[2];
            card3.BringToFront();



            card2.ImageLocation = cardList[1];
            card2.Location = new Point(100, 230);
            card2.Size = new Size(100, 150);
            card2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(card2);
            char ch2 = card2.ImageLocation.ElementAt(index + 1);
            if (ch2 == 'o')
            {
                playerScore += 10;
            }
            else if (ch2 == 'a')
            {
                if (playerScore + 11 <= 21)
                {
                    playerScore += 11;
                }
                else
                {
                    playerScore += 1;
                }
            }
            else
            {
                switch (ch2)
                {
                    case '2':
                        playerScore += 2;
                        break;
                    case '3':
                        playerScore += 3;
                        break;
                    case '4':
                        playerScore += 4;
                        break;
                    case '5':
                        playerScore += 5;
                        break;
                    case '6':
                        playerScore += 6;
                        break;
                    case '7':
                        playerScore += 7;
                        break;
                    case '8':
                        playerScore += 8;
                        break;
                    case '9':
                        playerScore += 9;
                        break;
                    default:
                        break;
                }
            }
            label1.Text = playerScore.ToString();

            card4.ImageLocation = cardList[k];
            card4.Location = new Point(100 + l, 230);
            card4.Size = new Size(100, 150);
            card4.SizeMode = PictureBoxSizeMode.StretchImage;
            l += 17;
            k++;

            card5.ImageLocation = cardList[k];
            card5.Location = new Point(100 + l, 230);
            card5.Size = new Size(100, 150);
            card5.SizeMode = PictureBoxSizeMode.StretchImage;
            l += 17;
            k++;

            card6.ImageLocation = cardList[k];
            card6.Location = new Point(100 + l, 230);
            card6.Size = new Size(100, 150);
            card6.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBoxes.Add(card4);
            pictureBoxes.Add(card5);
            pictureBoxes.Add(card6);

            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cardList = Karistir(cardList);
            KartiBol(cardList);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button1.Enabled = true;
            button5.Enabled = true;
            AIscore = 0;
            playerScore = 0;
            label1.Text = "0";
            label2.Text = "0";
            button4.Visible = false;
            button6.Visible = false;
            count = 0;
            k = 3;
            l = 17;
            foreach (PictureBox item in pictureBoxes)
            {
                Controls.Remove(item);
                Controls.Remove(card2);
                Controls.Remove(card1);
                Controls.Remove(card3);
                Controls.Remove(card7);
                Controls.Remove(card8);
            }
            cardList = Karistir(cardList);
            KartiBol(cardList);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            card3.ImageLocation = secCard;
            card3.Location = new Point(117, 70);
            card3.Size = new Size(100, 150);
            card3.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(card3);
            card3.BringToFront();
            int index = card3.ImageLocation.LastIndexOf(@"\");
            char ch = card3.ImageLocation.ElementAt(index + 1);
            if (ch == 'o')
            {
                AIscore += 10;
            }
            else if (ch == 'a')
            {
                if (AIscore + 11 <= 21)
                {
                    AIscore += 11;
                }
                else
                {
                    AIscore += 1;
                }
            }
            else
            {
                switch (ch)
                {
                    case '2':
                        AIscore += 2;
                        break;
                    case '3':
                        AIscore += 3;
                        break;
                    case '4':
                        AIscore += 4;
                        break;
                    case '5':
                        AIscore += 5;
                        break;
                    case '6':
                        AIscore += 6;
                        break;
                    case '7':
                        AIscore += 7;
                        break;
                    case '8':
                        AIscore += 8;
                        break;
                    case '9':
                        AIscore += 9;
                        break;
                    default:
                        break;
                }
            }
            label2.Text = AIscore.ToString();
            if (AIscore <= 11)
            {
                card7.ImageLocation = cardList[7];
                card7.Location = new Point(134, 70);
                card7.Size = new Size(100, 150);
                card7.SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(card7);
                card7.BringToFront();
                int index1 = card7.ImageLocation.LastIndexOf(@"\");
                char ch1 = card7.ImageLocation.ElementAt(index1 + 1);
                if (ch1 == 'o')
                {
                    AIscore += 10;
                }
                else if (ch1 == 'a')
                {
                    if (AIscore + 11 <= 21)
                    {
                        AIscore += 11;
                    }
                    else
                    {
                        AIscore += 1;
                    }
                }
                else
                {
                    switch (ch1)
                    {
                        case '2':
                            AIscore += 2;
                            break;
                        case '3':
                            AIscore += 3;
                            break;
                        case '4':
                            AIscore += 4;
                            break;
                        case '5':
                            AIscore += 5;
                            break;
                        case '6':
                            AIscore += 6;
                            break;
                        case '7':
                            AIscore += 7;
                            break;
                        case '8':
                            AIscore += 8;
                            break;
                        case '9':
                            AIscore += 9;
                            break;
                        default:
                            break;
                    }
                }
                label2.Text = AIscore.ToString();
            }
            else if (AIscore > 14)
            {
                card8.ImageLocation = cardList[8];
                card8.Location = new Point(151, 70);
                card8.Size = new Size(100, 150);
                card8.SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(card8);
                card8.BringToFront();
                int index2 = card8.ImageLocation.LastIndexOf(@"\");
                char ch2 = card8.ImageLocation.ElementAt(index2 + 1);
                if (ch2 == 'o')
                {
                    AIscore += 10;
                }
                else if (ch2 == 'a')
                {
                    if (AIscore + 11 <= 21)
                    {
                        AIscore += 11;
                    }
                    else
                    {
                        AIscore += 1;
                    }
                }
                else
                {
                    switch (ch2)
                    {
                        case '2':
                            AIscore += 2;
                            break;
                        case '3':
                            AIscore += 3;
                            break;
                        case '4':
                            AIscore += 4;
                            break;
                        case '5':
                            AIscore += 5;
                            break;
                        case '6':
                            AIscore += 6;
                            break;
                        case '7':
                            AIscore += 7;
                            break;
                        case '8':
                            AIscore += 8;
                            break;
                        case '9':
                            AIscore += 9;
                            break;
                        default:
                            break;
                    }
                }
                label2.Text = AIscore.ToString();
            }
            int totalAi = 21 - AIscore;
            int totalPlayer = 21 - playerScore;
            if (AIscore > 21)
            {
                button6.Visible = true;
                button6.BringToFront();
                button3.Enabled = false;
                button5.Enabled = false;
            }
            else if (totalAi < totalPlayer | totalAi == 0)
            {
                button4.Visible = true;
                button4.BringToFront();
                button3.Enabled = false;
                button5.Enabled = false;
            }
            else if (totalAi > totalPlayer | totalPlayer == 0)
            {
                button6.Visible = true;
                button6.BringToFront();
                button3.Enabled = false;
                button5.Enabled = false;
            }
        }

        private void KartiBol(string[] cardList)
        {
            for (int i = 0; i < cardList.Length / 2; i++)
            {
                cardArry1[i] = cardList[i];
            }
            int j = 0;
            for (int i = 26; i < cardList.Length; i++)
            {
                cardArry2[j] = cardList[i];
                j++;
            }
            cardList = Array.Empty<string>();
            foreach (string item in cardArry2)
            {
                cardList.Append(item);
            }
            foreach (string item in cardArry1)
            {
                cardList.Append(item);
            }

        }

        private string[] Karistir(string[] cardList)
        {
            string[] cekilenCard = new string[cardList.Length];
            Random rand = new Random();
            for (int i = 0; i < cardList.Length; i++)
            {
                string card = cardList[rand.Next(0, cardList.Length)];
                if (!cekilenCard.Contains(card))
                {
                    cekilenCard[i] = card;
                }
                else
                {
                    i--;
                    continue;
                }
            }
            return cekilenCard;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count < 3)
            {
                int index = card1.ImageLocation.LastIndexOf(@"\");
                char ch2 = pictureBoxes[count].ImageLocation.ElementAt(index + 1);
                Controls.Add(pictureBoxes[count]);
                pictureBoxes[count].BringToFront();
                if (ch2 == 'o')
                {
                    playerScore += 10;
                }
                else if (ch2 == 'a')
                {
                    if (playerScore + 11 <= 21)
                    {
                        playerScore += 11;
                    }
                    else
                    {
                        playerScore += 1;
                    }
                }
                else
                {
                    switch (ch2)
                    {
                        case '2':
                            playerScore += 2;
                            break;
                        case '3':
                            playerScore += 3;
                            break;
                        case '4':
                            playerScore += 4;
                            break;
                        case '5':
                            playerScore += 5;
                            break;
                        case '6':
                            playerScore += 6;
                            break;
                        case '7':
                            playerScore += 7;
                            break;
                        case '8':
                            playerScore += 8;
                            break;
                        case '9':
                            playerScore += 9;
                            break;
                        default:
                            break;
                    }
                }
                label1.Text = playerScore.ToString();
                if (playerScore > 21)
                {
                    button4.Visible = true;
                    button4.BringToFront();
                    button3.Enabled = false;
                    button2.Enabled = false;
                    button5.Enabled = false;
                }
                else if (playerScore == 21)
                {
                    button6.Visible = true;
                    button6.BringToFront();
                    button3.Enabled = false;
                    button2.Enabled = false;
                    button5.Enabled = false;
                }
                count++;
            }

        }
    }
}
