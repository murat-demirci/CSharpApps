using System;
using System.Windows.Forms;
using System.Xml;

namespace ExchangeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string currencyxml = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlfile = new XmlDocument();
            xmlfile.Load(currencyxml);

            string dolarBuying = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lbl_dolaralis.Text = dolarBuying;
            string dolarSelling = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lbl_dolarsatis.Text = dolarSelling;
            string euroBuying = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lbl_euroalis.Text = euroBuying;
            string euroSelling = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbl_eurosatis.Text = euroSelling;

        }

        private void btn_dolarlais_Click(object sender, EventArgs e)
        {
            txt_kur.Text = lbl_dolaralis.Text;
        }

        private void btn_dolarsatis_Click(object sender, EventArgs e)
        {
            txt_kur.Text = lbl_dolarsatis.Text;
        }

        private void btn_euroalis_Click(object sender, EventArgs e)
        {
            txt_kur.Text = lbl_euroalis.Text;
        }

        private void btn_eurosatis_Click(object sender, EventArgs e)
        {
            txt_kur.Text = lbl_eurosatis.Text;
        }

        private void btn_dovizal_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            txt_kur.Text = txt_kur.Text.Replace('.', ',');
            kur = Convert.ToDouble(txt_kur.Text);
            miktar = Convert.ToDouble(txt_miktar.Text);
            tutar = miktar * kur;
            txt_tutar.Text = tutar.ToString().Replace(',', '.');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_kur.Text = txt_kur.Text.Replace('.', ',');
            double kur = Convert.ToDouble(txt_kur.Text);
            double miktar = Convert.ToDouble(txt_miktar.Text.Replace('.', ','));
            int tutar = Convert.ToInt32(miktar / kur);
            txt_tutar.Text = tutar.ToString();
            double kalan = miktar % kur;
            txt_kalan.Text = kalan.ToString().Replace(',', '.');
        }
    }
}
