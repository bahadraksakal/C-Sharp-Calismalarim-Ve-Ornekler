using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class Ornek_prob
    {
        public int yas { get; set; }
        private string _Isim;
        public string Isim
        {
            get
            {
                return "sayın " + _Isim;


            }
            set
            {
                _Isim = value;

            }

        }



    }



}
