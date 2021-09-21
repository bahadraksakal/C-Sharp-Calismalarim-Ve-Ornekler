using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Constructor
    {
        private string _Isim = "Bahadır";
        private string _Soyad = "Aksakal";   //  _  karakteri private anlamı taşır.
        public Constructor ()  // constructor new lendiği anda çalışıcak.
        {

            MessageBox.Show("isim: " + _Isim + " Soyad: " + _Soyad + " Constructor () Çalıştı");
        }
        public Constructor(int a)  //normalde aynı şey olsa kullanamayız ama içine parametre girildiğinde kullanabilliyoruz.
        {

            MessageBox.Show("int: " + a + " " + "Constructor () Çalıştı");  // bu ifadeyi temsil eden 2. bir messeage box var.
        }
        public Constructor (string Isim ,string Soyad) 
        {
            _Isim = Isim;
            _Soyad = Soyad;
            //Isim = _Isim;     // bu hareketi yapınca  Bahadır Aksakal yazıyor yani private stringlerimizi değişkenden çıkarıp tek bir değer olan kendi değerlerine eşitlemiş oluyoruz

            //Soyad = _Soyad;
            MessageBox.Show("isim: " + _Isim + " Soyad: " + _Soyad + " Constructor () Çalıştı");
        
        }
    }
}
