using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class InterfaceGiris
    {
        public List<IVarlik> Varliklar = new List<IVarlik>();
        public void VarlikEkle(IVarlik varlik)
        {
            Varliklar.Add(varlik);

        }

    }
    interface IVarlik
    {
        string Isim { get; set; }
        int Yas { get; set; }
    }
    class Insan : IVarlik  // somut bir nesneye soyut bit özelliği zorunlu kıldık.
    {
        public string Isim { get; set; }  //insasanın bir yaşı ve ismi olmak zorundadır.
        public int Yas { get; set; }
        public string Meslek { get; set; }
    }
    class Bitki : IVarlik
    {
       public string Isim { get; set; }
        public int Yas { get; set; }
    }

    interface IHayvan : IVarlik // SOYUT bir nesnenin içerisinde soyut bir nesne tanımladığım için int lerimi içeri yazmama gerek yok.
    { // isim ve yaşı otomatik olarak içine atadı
        int Ayaksayisi { get; set; }
    }
    class Kopek: IHayvan
    {
        public string Isim { get; set; }
        public int Yas { get; set; }
        public int Ayaksayisi { get; set; }
        
    }
    class Horoz : IHayvan
    {
        public string Isim { get; set; }
        public int Yas { get; set; }
        public int Ayaksayisi { get; set; }

    }
}
