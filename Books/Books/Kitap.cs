using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{/// <summary>
/// Ana sınıftır, Kitap sınıfı üzerinden sql ve dosya işlemleri yapılmaktadır.
/// </summary>
    public class Kitap:IEnumerable
    {
        public int KitapID { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public decimal Fiyat { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{KitapID} {Ad} {Yazar} {Fiyat}";
        }
    }
}
