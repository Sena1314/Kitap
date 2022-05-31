using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    /// <summary>
    /// SQL işlemleri için oluşturulmuş sınıftır. IIslem üzerinden yetenekleri implement edilmiştir.
    /// Ekle,Listele,Bul method işlemleri SQL kapsamlı burada uygulanmaktadır.
    /// </summary>
    public class SQL : Kitap, IIslem<Kitap>
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Kitaplar;Integrated Security=True");

        public Kitap Bul(int id)
        {
            Kitap KitapListesi = new Kitap();
           
            
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT * FROM Kitap", conn);
            //Bağlantımı açıyorum.
           
            //SqlDataReader nesnem..
            SqlDataReader dr = comm.ExecuteReader();
            
            while (dr.Read())
            {
                Kitap kitap = new Kitap();
                kitap.KitapID = (int)dr[0];
                if (id == kitap.KitapID)
                {
                    kitap.Ad = (string)dr[1];
                    kitap.Yazar = (string)dr[2];
                    kitap.Fiyat = (int)dr[3];
                    Console.Write(kitap.Ad +" ");
                    Console.Write(kitap.Yazar + " ");
                    Console.Write(kitap.Fiyat + " ");
                    KitapListesi = kitap;
                }
            }

            //sqlDataReader ve SqlConnection kapatılıyor.

            conn.Close();
            return KitapListesi;
            
        }

        public void Ekle(Kitap t)
        {
            SqlCommand cmd = new SqlCommand();
        
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Kitap(Ad,Yazar,Fiyat) values ('" + t.Ad + "','" + t.Yazar + "','" + t.Fiyat + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

       
        public List<Kitap> Liste()
        { 
            
            List<Kitap> KitapListesi = new List<Kitap>();
            
            
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT * FROM Kitap", conn);
            //Bağlantımı açıyorum.
           
            //SqlDataReader nesnem..
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                Kitap kitap = new Kitap();
                kitap.KitapID = (int)dr[0];
                kitap.Ad = (string)dr[1];
                kitap.Yazar = (string)dr[2];
                kitap.Fiyat = (int)dr[3];
                KitapListesi.Add(kitap);
             }

            //sqlDataReader ve SqlConnection kapatılıyor.
           
            conn.Close();

            return KitapListesi;
            



        }
  
    }
   
}
