using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{ /// <summary>
  /// Kitap varlığı üzerinde yapılan işlemlere ait oluşturulmuş arayüzdür.
  /// Ekle,Listele,Bul yetenekler,me sahiptir.
  /// </summary>
    public interface IIslem<T> where T:class
    {
        void Ekle(T t);
        List<T> Liste();
        T Bul(int id);
      
    }
}
