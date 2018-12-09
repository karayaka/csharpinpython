using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;


namespace Listboxsayiödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        
        public void btnkuponolustur_Click(object sender, EventArgs e)
        {
            XmlTextWriter veri = new XmlTextWriter("..\\..\\..\\veri.xml", Encoding.UTF8);
            veri.Formatting = Formatting.Indented;
            veri.WriteStartDocument();

            veri.WriteStartElement("veri");

            lsbkuponlar.Items.Clear();
            lsbsayiadetleri.Items.Clear();
            int kuponSayisi = 0, baslangıcSayisi = 0, bitisSayısı = 0;
            bool kupon = int.TryParse(txtkuponsayisi.Text, out kuponSayisi);
            bool baslangıc = int.TryParse(txtbaslangıc.Text, out baslangıcSayisi);
            bool bitis = int.TryParse(txtbitis.Text, out bitisSayısı);
            
            int[] kpn = new int[6];
            if (!(kupon && baslangıc && bitis))
            {
                MessageBox.Show("Lütfen Geçerli Değerler Giriniz");
                return;
            }
            for (int i = 0; i < kuponSayisi; i++)
            {
                
                int a = 0;
                for (int j = 0; j < 6; j++)
                {
                    
                    a=rnd.Next(baslangıcSayisi, bitisSayısı);
                    kpn[j] = a;
                }
                string nmbr = "";
                string degertop = "";
                foreach (var item in kpn)
                {
                   
                    nmbr += item.ToString() + ",";
                    
                }
                lsbkuponlar.Items.Add(nmbr);

                string degertoplam = "";
                foreach (var item in kpn)
                {

                    
                    string deger = "";
                    int sayiadeti = 0;

                    for (int k = 0; k < kpn.Count(); k++)
                    {
                        
                        
                        
                        if (kpn[k]==item)
                        {
                            sayiadeti++;
                            
                        }
                        

                    }
                    veri.WriteElementString("dizi", i.ToString());

                    veri.WriteElementString("adet", sayiadeti.ToString());
                    veri.WriteElementString("sayi", item.ToString());

                    deger += item.ToString() + "-" + sayiadeti.ToString() + "-";
                    sayiadeti = 1;
                    degertoplam += "(" + deger + ")-";
                    deger = "";
                    degertop += degertoplam;

                    
                    degertoplam = "";

                }
                lsbsayiadetleri.Items.Add(degertop);





            }
            veri.WriteEndElement();
            veri.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Process p = new Process(); // Yeni nesne yarat…
            p.StartInfo.UseShellExecute = false; // Shell kullanma…
            p.StartInfo.RedirectStandardOutput = true; // Çıkışı yönlendir….
            p.StartInfo.FileName = "C:\\Users\\kisar\\AppData\\Local\\Programs\\Python\\Python36-32\\python.exe"; // Python klasörümüz ve derleyicimizin adı…
            p.StartInfo.Arguments = "..\\grafik.py"; // verilecek yani çalıştırılacak python scriptimizin yolu…

            p.Start(); // işlemeye başla…


        }
    }
}
