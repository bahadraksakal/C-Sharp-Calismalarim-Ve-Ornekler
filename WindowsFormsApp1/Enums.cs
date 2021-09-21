using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum Meslekler
    {
        Ogretmen = 1,
        Marangoz = 2,
        Yazilimci = 3,
        Polis = 4,
        Savci = 5,
        Doktor = 6,

    }
    class Enums
    {
        
    }
    class EnumInsan
    {
        public Meslekler Meslegi;
        public string Adi;
        public int Yasi;
    }
}
