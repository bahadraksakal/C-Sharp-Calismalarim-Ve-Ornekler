using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MirasAlmaOrnek
    {
    }
    class Varlik 
    {
        public string Isim;
        public int Yas;    
        public string getIsim()
        {
            return Isim;
        }
        public void setIsim(string Yeniad)
        {
            Isim = Yeniad;

        }
    }
    class Insan1 : Varlik     // İnsan varlığı miras alıyor. Varlığın içindekileride insanda da kullanabiliriz ama kullanmak zorunda değiliz.
    { //interface alırken public kullanılmaz geet set komutu kullanılır yani prob alınır ayrıca interface de  atanan tanımı yeni class kesinlikle içermek zorundadır.
      //public void AdıDegistir(string YeniAd)
      // {
      //     Isim = YeniAd;

        // }
        string Insanadı;
        void IsimTanımla()
        {
            Insanadı = getIsim();
        }
    
    }
}
