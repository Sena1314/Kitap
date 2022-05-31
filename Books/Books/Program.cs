using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{/// <summary>
/// İlgili program çalışma senaryosu ;
/// Tüm sınıfların nesneleri bulunmaktadır.
/// Program çalıştığında hangi sınıf üzerinde işlem yapılması belirtilip ,seçilen methoda göre ekle ,listele,bulma işlemi yapacaktır.
/// Uygylamadan çıkmadıkça akış devam edecektir.
/// </summary>
   public class Program
    {

        static void Main(string[] args)
        {


            SQL sql = new SQL();
            Dosya dosya = new Dosya();
            Kitap kitap = new Kitap();
            while (true) { 
           Console.Write("\nİşlem yapmak istediğiniz ortamı seçin \n 1-Database :DB \n 2-Dosya :D \n ");
            var islem = Console.ReadLine();

                if (islem == "DB"|| islem=="db")
                {
                    Console.Write("\nYapmak istediğiniz işlemi seçin  \n 1-Ekle :E \n 2-Listele :L \n 3-Bul :B\n  ");
                    islem = Console.ReadLine();

                    switch (islem)
                    {
                        case ("E"):
                            Console.Write("\nEklemek istediğiniz kitap adını giriniz.\n  ");
                            kitap.Ad = Console.ReadLine();
                            Console.Write("\nEklemek istediğiniz yazar adını giriniz.\n  ");
                            kitap.Yazar = Console.ReadLine();
                            Console.Write("\nEklemek istediğiniz kitabın fiyat bilgisini giriniz.\n  ");
                            kitap.Fiyat = Convert.ToInt32(Console.ReadLine());
                            sql.Ekle(kitap);
                            break;
                        case ("L"):
                            Console.WriteLine("\nKitap Listesi:  ");
                            Yazdir(sql.Liste());
                            // Yazdir(manager.Listele());
                            break;
                        case ("B"):
                            Console.WriteLine("\nBulmak istediğiniz kitap numarasını girin:  ");
                            int numara = Convert.ToInt32(Console.ReadLine());
                            sql.Bul(numara);
                            Console.ReadKey();

                            break;
                        default:
                            // code block
                            break;
                    }
                }
                else if (islem == "D"|| islem=="d")
                {
                    Console.Write("\nYapmak istediğiniz işlemi seçin  \n 1-Ekle :E \n 2-Listele :L \n 3-Bul :B\n  ");
                    islem = Console.ReadLine();

                    switch (islem)
                    {
                        case ("E"):
                            Console.Write("\nEklemek istediğiniz kitap adını giriniz.\n  ");
                            kitap.Ad = Console.ReadLine();
                            Console.Write("\nEklemek istediğiniz yazar adını giriniz.\n  ");
                            kitap.Yazar = Console.ReadLine();
                            Console.Write("\nEklemek istediğiniz kitabın fiyat bilgisini giriniz.\n  ");
                            kitap.Fiyat = Convert.ToInt32(Console.ReadLine());
                            dosya.Ekle(kitap);
                            break;
                        case ("L"):
                            Console.WriteLine("\nKitap Listesi:  ");
                            Yazdir(dosya.Liste());
                            //  Yazdir(manager.Listele());
                            break;
                        case ("B"):
                            Console.WriteLine("\nBulmak istediğiniz kitap numarasını girin:  ");
                            int numara = Convert.ToInt32(Console.ReadLine());
                            dosya.Bul(numara);
                            Console.ReadKey();

                            break;
                        default:
                            // code block
                            break;
                    }


                }

            }
        }
        /// <summary>
        /// Listelenecek kitap nesnesine ait özellikleri yazdırmak için kullanılır.
        /// </summary>
        /// <param name="kitaplar"></param>
      public static void Yazdir(List<Kitap> kitaplar)
        {
            foreach (Kitap kitap in kitaplar)
                Console.WriteLine(kitap);
            Console.ReadKey();
        }
    }
   
}
