using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace JsonFormatUsingEmoji
{
    public partial class Form1 : Form
    {
        private List<Category> GetEmojiList()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string jsonContent = File.ReadAllText("smiley_content.json");
            return serializer.Deserialize<List<Category>>(jsonContent);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var list = GetEmojiList();
            DisplayList(list);
        }

        private void DisplayList(List<Category> list)
        {
            foreach (Category items in list)
            {

                Label label = new Label() { Text = items.category };
                label.AutoSize = false;
                label.Width = ClientSize.Width;
                label.Height = 80;
                label.Font = new Font(FontFamily.GenericMonospace, 20);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Margin = new Padding(0, 20, 0, 20);
                flowLayoutPanel1.SetFlowBreak(label, true);
                flowLayoutPanel1.Controls.Add(label);
                DisplayItems(items);

            }
        }

        private void DisplayItems(Category item)
        {
            foreach (Item it in item.items)
            {
                Button button = new Button();
                button.Text = it.art + "\n" + it.name;
                button.Font = new Font(FontFamily.GenericSansSerif, 14);
                button.Padding = new Padding(5);
                button.Width = ClientSize.Width / 2 - 50;
                button.Height = 80;
                button.Click += CopyText;
                flowLayoutPanel1.Controls.Add(button);

            }
            Label lbl = new Label();
            flowLayoutPanel1.SetFlowBreak(lbl, true);
            flowLayoutPanel1.Controls.Add(lbl);


        }

        private void CopyText(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            string[] info = clickedBtn.Text.Split('\n');
            Clipboard.SetText(info[0]);
            MessageBox.Show(info[0] + " Kopyalandi!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
