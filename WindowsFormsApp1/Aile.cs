using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Aile
    {
        
        public string AnneAdi;
        public string BabaAdi;
        public int CocukSayisi;
        
        private int _Ailegeliri;
        public string AileGeliri
        {
             get
             {
                return "Ailenin Geliri: " + _Ailegeliri + " TL";  // bir int değer olan ailegeliribirimini bu aşamada stringe dönüştürüp sonuna tl yazdırıyoruz fakat değerimiz int olduğu için set komutu yazarken bu bize sorun yaşatacak.

             }
            set
            {

                _Ailegeliri = Int32.Parse(value);

            }
        


    }
           


    }





}
