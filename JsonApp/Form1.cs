using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace JsonApp
{
    public partial class Form1 : Form
    {
        private List<Kitap> kitaps = new List<Kitap>();
        JavaScriptSerializer serializer = new JavaScriptSerializer();//string turunu json formatinda kaydetmek icin kullanilir
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap
            {
                kitapAdi = textBox1.Text,
                fiyat = numericUpDown1.Value
            };
            kitaps.Add(kitap);
            WriteJson(kitaps);

        }

        private void WriteJson(List<Kitap> kitaps)
        {
            string json = serializer.Serialize(kitaps);
            File.WriteAllText("../../Kitaplar.json", json);//onceki dosya icerigini siler ve yazmaya baslar


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string icerik = File.ReadAllText("../../Kitaplar.json");
            var liste = serializer.Deserialize<List<Kitap>>(icerik);
            listBox1.DisplayMember = "kitapAdi";
            listBox1.ValueMember = "fiyat";

            foreach (Kitap kitap in liste)
            {
                listBox1.Items.Add(kitap.kitapAdi + "-" + kitap.fiyat);
            }
        }

    }
}
