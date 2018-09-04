using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace sereflikochisar
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		private void yeniÜrünEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			urunEkle ekle = new urunEkle();
			ekle.Show();
			ekle.MdiParent = this;
		}

		private void stokDurumunuGörToolStripMenuItem_Click(object sender, EventArgs e)
		{
			stokGor gor = new stokGor();
			gor.Show();
			gor.MdiParent = this;
		}

		private void satışıYapılanÜrünlerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SatisSor satis = new SatisSor();
			satis.Show();
			satis.MdiParent = this;
		}

		private void MainMenu_Load(object sender, EventArgs e)
		{

            
            
            //altinkaynak.DataService data = new altinkaynak.DataService();

            //string content = @"<?xml version='1.0' encoding='utf-8'?><soap:Envelope xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xsd='http://www.w3.org/2001/XMLSchema' xmlns:soap='http://schemas.xmlsoap.org/soap/envelope/'><soap:Header> <AuthHeader xmlns='http://data.altinkaynak.com/'><Username>AltinkaynakWebServis</Username> <Password>AltinkaynakWebServis</Password> </AuthHeader></soap:Header> <soap:Body><GetGold xmlns='http://data.altinkaynak.com/' /></soap:Body></soap:Envelope>";
            //string url = @"http://data.altinkaynak.com/DataService.asmx";
            //string contenttype = "text/xml; charset=utf-8";
            //string method = "POST";
            //string header = "SOAPAction: \"http://data.altinkaynak.com/GetGold\"";

            //HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            //req.ContentLength = content.Length;
            //req.Method = method;
            //req.ContentType = contenttype;
            //req.Headers.Add(header);

            //Stream strRequest = req.GetRequestStream();
            //StreamWriter sw = new StreamWriter(strRequest);
            //sw.Write(content);
            //sw.Close();

            //HttpWebResponse response = (HttpWebResponse)req.GetResponse();
            //Stream strResponse = response.GetResponseStream();
            //StreamReader sr = new StreamReader(strResponse);
            //richTextBox1.Text = sr.ReadLine();
            //sr.Close();

           /* altinkaynak.DataServiceSoapClient altin = new altinkaynak.DataServiceSoapClient();
			altinkaynak.AuthHeader yetki = new altinkaynak.AuthHeader();
			yetki.Username = "AltinkaynakWebServis";
			yetki.Password = "AltinkaynakWebServis";
			string veri = altin.GetGold(yetki);
		

			XmlReader reader = XmlReader.Create(new StringReader(veri));

			XmlWriterSettings ws = new XmlWriterSettings();
			ws.Indent = true;
			List<string> adi = new List<string>();
			List<string> alis = new List<string>();
			List<string> satis = new List<string>();

			while (reader.Read())
			{

				switch (reader.Name.ToString())
				{
				

					case "Alis":
						satis.Add(reader.ReadString());
						break;
					case "Satis":
						alis.Add(reader.ReadString());
						break;
					case "Aciklama":
						adi.Add(reader.ReadString());
						break;
				}

			}
            */

	





			//}






		}

        private void kategoriEkleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kategoriEkleSil eklesil = new kategoriEkleSil();
            eklesil.Show();
            eklesil.MdiParent = this;
        }

        private void ürünGüncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunGuncelleSil urunGuncelle = new UrunGuncelleSil();
            urunGuncelle.Show();
            urunGuncelle.MdiParent = this;
        }
    }
}
