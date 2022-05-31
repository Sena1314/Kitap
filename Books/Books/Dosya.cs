using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{ /// <summary>
  /// Dosya işlemleri için oluşturulmuş sınıftır. IIslem üzerinden yetenekleri implement edilmiştir.
  /// Ekle,Listele,Bul method işlemleri Dosya kapsamlı burada uygulanmaktadır.
  /// </summary>
    public class Dosya : Kitap,IIslem<Kitap>
    {
        public Kitap Bul(int id)
        {
            Kitap oku = new Kitap();
            string dosya_yolu = @"Kitaplar.txt";
            //Okuma işlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);

            var yazi = sw.ReadLine();
            int i = 1;
            while (yazi != null)
            {

                Kitap kitap = new Kitap();
                string[] degisken = yazi.Split(';');
                kitap.KitapID = i;
                if (id == kitap.KitapID)
                {
                    kitap.Ad = degisken[0];
                    kitap.Yazar = degisken[1];
                    kitap.Fiyat = Convert.ToInt32(degisken[2]);
                    Console.Write(kitap.Ad + " ");
                    Console.Write(kitap.Yazar + " ");
                    Console.Write(kitap.Fiyat + " ");
                  
                    oku=kitap;
                }
                i++;

               
                yazi = sw.ReadLine();


            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            return oku;
        }

        public void Ekle(Kitap t)
        {
            string file = @"Kitaplar.txt";
         
           // FileStream stream = File.Create(file);
            StreamWriter sw = new StreamWriter(file, true);
           
            sw.Write(t.Ad +";");
            sw.Write(t.Yazar+ ";");
            sw.Write(t.Fiyat +"\n");
           
         
            sw.Close();
        }

        public List<Kitap> Liste()
        {
            List<Kitap> oku = new List<Kitap>();
            string dosya_yolu = @"Kitaplar.txt";
            //Okuma işlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);

            var yazi = sw.ReadLine();
            int i = 1;
            while (yazi != null)
            {
               
               Kitap kitap = new Kitap();
               string[] degisken =yazi.Split(';');
                kitap.KitapID = i;
               kitap.Ad = degisken[0];
               kitap.Yazar = degisken[1];
               kitap.Fiyat =Convert.ToInt32(degisken[2]);
                i++;

                    oku.Add(kitap);
                    yazi = sw.ReadLine();
            

            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            return oku;
        }
    }
}
