using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string Adim = "Bahadır";
        string adim2 = "ahmet";        
        string SoyAdim = "Aksakal";
        int TamsayiDegisken = 10000;
        float ReelsayiDegisken = 1.23f;
        double ada = 2.31;
        int sayi1 = 10;
        int sayi2 = 5;
        bool DogruYanlis = false;
        List<string> İsimler = new List<string>();
        List<int> Rakamlar = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int İntToplam = sayi1 + sayi2;
            //string StringToplam = sayi1.ToString() + " " + sayi2.ToString();
            //İsimler.Add("Ahmet"); // 0. elemandır
            //İsimler.Add("Mehmet"); // 1. elemandır
            //İsimler.Add("Veli");  // ..
            Rakamlar.Add(10);  // 0. eleman
            Rakamlar.Add(20);  // 1. eleman
            Rakamlar.Add(30);  // ... böyle gider aşşağıya doğru.
            int Toplam = Rakamlar[0] + Rakamlar[2];
            Rakamlar[0] = Rakamlar[1] + Rakamlar[2];
            int Toplam2 = Rakamlar[0] + Rakamlar[2];
            Rakamlar[0] = Rakamlar[1] + Rakamlar[2] + Rakamlar[0];
            int Toplam3 = Rakamlar[0] + Rakamlar[2];
            // bu çalışmamızda kodların yukarıdan aşşağıya doğru sağdan sola doğru okunduğunu gördük, arapça gibi.

            // MessageBox.Show("İntToplam : " + İntToplam.ToString() + " | " + "StringToplam : " + StringToplam );
            //MessageBox.Show(İsimler[0] + "|" + İsimler[2]);
            //MessageBox.Show("İntToplam: " + Toplam);
            //MessageBox.Show("İntToplam: " + Toplam + " | " + Rakamlar[0]);
            MessageBox.Show("İntToplam: " + Toplam2 + " | " + Rakamlar[0] + "|" + Toplam3);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // == eşitse
            // != eşit değilse

            // bool OrnekBoolDegisken = false;
            bool OrnekBoolDegisken = true;
            int Rakam = 5;
            string yazi = "Remzi";
            if (yazi == "Bahadır")
            {

                MessageBox.Show("Yazı: Bahadır eşitse");

            }
            else if (yazi == "Numan")
            {
                MessageBox.Show("Yazı: Numan eşitse");
            }
            else
            {
                MessageBox.Show("ikisinede eşit değil");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int i = 0;
            int[] Rakamlarlistesi = new int[15];
            List<int> Rakamlarlistesi2 = new List<int>();
            Rakamlarlistesi2.Add(2);
            Rakamlarlistesi2.Add(12);
            Rakamlarlistesi2.Add(17);
            Rakamlarlistesi2.Add(431);
            Rakamlarlistesi2.Add(584);
            string Yazilarbutunu = "";
            int[] İntlist = new int[5];
            int a = 2;
            İntlist[0] = a;
            İntlist[1] = 11;
            İntlist[2] = 12;
            İntlist[3] = 13;
            İntlist[4] = 14;

            for (i = 0; i < İntlist.Count(); i++)
            {
                if (i < İntlist.Count() - 1)
                {
                    MessageBox.Show((İntlist[i] + İntlist[i + 1]).ToString());
                }
                else
                    MessageBox.Show(İntlist[i].ToString());

                //MessageBox.Show(İntlist[i].ToString());
            }


            //for ( i = 0; i <= 31; i +=7)

            //Rakamlarlistesi2.Add(i);
            //MessageBox.Show("şuan ki i:" + i.ToString());                

            // MessageBox.Show("Rakamlarlistesi2 count: " + Rakamlarlistesi2.Count().ToString());
            // MessageBox.Show(Rakamlarlistesi2[Rakamlarlistesi2.Count() - 1].ToString());
            //MessageBox.Show("fordan Çıktı");
            // for ( i = 0; i < Rakamlarlistesi2.Count(); i++)

            //Yazilarbutunu += i.ToString();
            //MessageBox.Show("yazılarımızın toplamı: " + Yazilarbutunu);
            //MessageBox.Show("i nin şuanki değeri: " + i.ToString());
            //MessageBox.Show("liste sırasındaki numara: " + Rakamlarlistesi2[i].ToString());

            MessageBox.Show("fordan çıktı");
            Application.Exit();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random randomsayılar = new Random();
            int[] sayilar = new int[10];
            for (int i = 0; i < 10; i++)
            {
                sayilar[i] = randomsayılar.Next(0, 255);
                //MessageBox.Show("Sayı: " + sayilar[i].ToString());   hehe buda foreachsiz benim kodum :)
            }
            MessageBox.Show("fordan çıktı");
            foreach (int sayi in sayilar)
            {
                MessageBox.Show("Sayı: " + sayi.ToString());
            }
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random yenirandom = new Random();
            int yenirandomsayi = 11;
            int kaç_kere_döndü_ = 0;
            //Random baho = new Random();
            // int[] bahonun_inti = new int[200];
            //while (yenirandomsayi > 10)
            //{
            //    yenirandomsayi = yenirandom.Next(0, 20000);
            //    kaç_kere_döndü_++;
            //    //bahonun_inti = baho.Next(, 200);

            //}
            while (true)
            {
                yenirandomsayi = yenirandom.Next(0, 20000);
                kaç_kere_döndü_++;
                if (yenirandomsayi < 10)
                    break;
            }
            //MessageBox.Show("toplam dönüş: " + (bahonun_inti[bahonun_inti.count() - 1].ToString());
            // bu yöntemle bir piyango oyunu yapılabilir.
            MessageBox.Show("toplam dönüş: " + kaç_kere_döndü_.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int Ogrencinotu = 5;
            int Ogrencidevamsızlık = 13;

            if (Ogrencidevamsızlık > 10)
            {
                MessageBox.Show("Öğrenci devamsızlıktan kaldı");


            }
            else
            {
                switch (Ogrencinotu)
                {

                    case 1:
                        MessageBox.Show("Öprenci kaldı");
                        break;
                    case 2:
                        MessageBox.Show("Öğrenci geçti");
                        break;
                    case 3:
                        MessageBox.Show("öğrenci orta not adlı");
                        break;
                    case 4:
                        MessageBox.Show("öğrenci iyi not aldı");
                        break;
                    case 5:



                        MessageBox.Show("Öğrenci çok iyi not aldı");
                        break;

                    default:
                        MessageBox.Show("hatalı değer girdiniz");
                        break;
                }
            }

            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bahomethod();


        }

        public void Bahomethod()  // değer döndürmeyen method

        {
            int orneksayi = 5;
            string bahadr = "Bahadır";

            MessageBox.Show(bahadr + " " + orneksayi.ToString());

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // int donendeger = degerdonduren();
            //string donendeger = stringdonduren();
            //MessageBox.Show("dönen değer " + donendeger);
            MessageBox.Show(stringdonduren());
            MessageBox.Show(donenlist()[0]);

        }
        public int degerdonduren()
        {
            int ornekint = 5;
            return ornekint;


        }
        public string stringdonduren()
        {
            string ders = "Csharp öğreniyorum";


            return ders;
        }
        public List<string> donenlist()
        {
            List<string> donenlistim = new List<string>();
            donenlistim.Add("numan");
            donenlistim.Add("sedat");
            return donenlistim;


        }

        private void button9_Click(object sender, EventArgs e)
        {
            // int gelendeğer = parametrealanmethod(5, 10, "numan");
            //MessageBox.Show(gelendeğer.ToString());            
            MessageBox.Show("toplama: " + parametrealanmethod(5, 10, "toplama").ToString());
            MessageBox.Show("çıkarma: " + parametrealanmethod(5, 10, "çıkarma").ToString());
            MessageBox.Show("çarpma: " + parametrealanmethod(5, 10, "çarpma").ToString());
            MessageBox.Show("bölme: " + parametrealanmethod(5, 10, "bölme").ToString());
            MessageBox.Show("tanımlanmamış değer: " + parametrealanmethod(5, 10, "asdfas").ToString());
            MessageBox.Show("6.09.2021");
            int baho = parametrealanmethod(10, 60, "bölme");
            MessageBox.Show("intetanımlı bölme: " + baho.ToString());
            Application.Exit();
        }

        public int parametrealanmethod(int sayi1, int sayi2, string YapilacakIslem)  // List<string> liste tarzında listte tanımlayabiliriz.
        {
            int Islemsonucu = 0;
            switch (YapilacakIslem)
            {
                case "toplama":
                    Islemsonucu = sayi1 + sayi2;
                    break;
                case "çıkarma":
                    Islemsonucu = sayi2 - sayi1;
                    break;
                case "çarpma":
                    Islemsonucu = sayi1 * sayi2;
                    break;
                case "bölme":
                    Islemsonucu = sayi2 / sayi1;
                    break;
                default:
                    break;
            }
            // int Toplamdeger = sayi1 + sayi2;
            // return Toplamdeger;
            // return sayi1 + sayi2;
            return Islemsonucu;


        }

        private void button10_Click(object sender, EventArgs e)
        {
            parametrealmayanmethod();

        }
        public void parametrealmayanmethod()
        {
            //List<string> kisiler = new List<string>();
            //kisiler.Add("Numan");
            //kisiler.Add("ali");
            //kisiler.Add("veli");
            //kisiler.Add("ayşe");
            //kisiler.Add("Hilal <3 ");
            //int yas = yashesapla(2001); 
            //string isim = isimbul(kisiler,4);
            //MessageBox.Show("Eğitmenin ismi: " + isim + " " + "Eğitmenin yaşı: " + yas.ToString());
            //MessageBox.Show("Eğitmenin ismi: " + isim + " " + "Eğitmenin yaşı: " + yashesapla(2001).ToString());
            IsimOlustur();
            MessageBox.Show("kaç tane isim var: " + kisiler.Count().ToString());
        }
        public int yashesapla(int doğumtarihi)
        {
            return 2020 - doğumtarihi;
        }
        public string isimbul(List<string> isimlist, int kisiId)
        {
            return isimlist[kisiId];
        }
        List<string> kisiler = new List<string>();

        public void IsimOlustur()
        {
            Random random2 = new Random();
            string[] DataIsimler = new string[10];
            DataIsimler[0] = "numam";
            DataIsimler[1] = "bahadır";
            DataIsimler[2] = "elif";
            DataIsimler[3] = "hilal";
            DataIsimler[4] = "buket";
            DataIsimler[5] = "emirhan";
            DataIsimler[6] = "furkan";
            DataIsimler[7] = "açelya";
            DataIsimler[8] = "ayşe";
            DataIsimler[9] = "mehmet";
            kisiler.Clear();    //  her seferinde 20 isim ekliyor listeye.  sadece 20 isimde kalmasını istiyorsak...
            for (int i = 0; i < 20; i++)
            {
                kisiler.Add(DataIsimler[random2.Next(0, 9)]);  // = " int rakam = random2.Next(0,9) 
            }                                                  // =  " kisiler.Add(DataIsimler[rakam]);  aynı ifadedir.



        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<string> liststringornek = new List<string>(); // list ramde çok yer kaplar.
            List<int> listintornek = new List<int>();
            string[] liststringornek2 = new string[10];
            int[] listintornek2 = new int[10];  // 10 elemanlı liste
            DictionaryMethod();
            Application.Exit();

        }

        public void DictionaryMethod()
        {
            Dictionary<int, string> DicOrnek = new Dictionary<int, string>();
            Dictionary<string, List<string>> DicOrnek2 = new Dictionary<string, List<string>>(); //ramde az yer kaplar. çünkü ıd numaraları yani int değerler liste içinde sıralıdır.
            Dictionary<int, Dictionary<int, string>> DicOrnek3 = new Dictionary<int, Dictionary<int, string>>();
            DicOrnek.Add(3, "bahadır 14");
            DicOrnek.Add(7, "emre");     //key numaraları sıralı olmak zorunda değil.

            List<string> denemelistdic = new List<string>();
            denemelistdic.Add("bahadır aksakal");
            DicOrnek2.Add("bahadır", denemelistdic);
            DicOrnek3.Add(2, DicOrnek);
            Dictionary<int, string> kurtarma = DicOrnek3[2];
            List<string> gelenlist = DicOrnek2["bahadır"];  // dic ornek 2 yi çalıştırıp denemelistdic e "bahadır" indexini (kryini atıyoruz.) ve daha sonra bu satırdaki kodumuz denemelistdic e eklenmiş olan bahadır aksakal stringini gelenlist in 0. elemanı olarak  gelenliste ekliyor.

            MessageBox.Show("dic 1: " + DicOrnek[3].ToString());
            MessageBox.Show("dic ornek 3: " + kurtarma[7].ToString());
            MessageBox.Show("dic ornek 2 nin içinden liste çağırma: " + gelenlist[0].ToString());

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[,] ornekStringlist = new string[10, 5];
            //ornekStringlist[0, 0] = "bahadr";
            //ornekStringlist[0, 1] = "veli";
            //ornekStringlist[0, 2] = "ahmet";
            //ornekStringlist[1, 2] = "levent";
            //ornekStringlist[8, 1] = "rana";
            MessageBox.Show(ornekStringlist[8, 1]);  //  atanan sayılar altta olduğundan suan listenin içi boş.
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 5; a++)
                {
                    ornekStringlist[i, a] = "birinci sıra: " + i + " " + "ikinci sıra: " + a;

                }

            }

            MessageBox.Show(ornekStringlist[4, 3]);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Ornekclass ornekclass = new Ornekclass();
            ornekclass.denemeIntDegisken = 15;
            ornekclass.denemestrindegisken = "Bahadır";
            MessageBox.Show(ornekclass.denemeIntDegisken.ToString());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Ornek_prob ornek_Prob = new Ornek_prob();
            ornek_Prob.yas = 24;
            ornek_Prob.Isim = "bahadır";
            Ornek_prob ornek_Prob2 = new Ornek_prob
            {
                Isim = "erivan",
                yas = 99,
            };
            MessageBox.Show(ornek_Prob2.Isim);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            List<Aile> Aileler = new List<Aile>();
            List<string> ErkekIsimler = new List<string>();
            ErkekIsimler.Add("Remzi");
            ErkekIsimler.Add("Kaan");
            ErkekIsimler.Add("Ali");
            ErkekIsimler.Add("Mehmet");
            ErkekIsimler.Add("Bahadır");

            List<string> KadinIsimler = new List<string>();
            KadinIsimler.Add("Hilal");
            KadinIsimler.Add("Ayşe");
            KadinIsimler.Add("Fatma");
            KadinIsimler.Add("Alya");
            KadinIsimler.Add("Maya");
            Random _Cocuksayisi = new Random();
            Random AileGelirix = new Random();
            Random IsimRandom = new Random();

            for (int i = 0; i < 25; i++)
            {
                Aile OrnekAile = new Aile
                {
                    AnneAdi = KadinIsimler[IsimRandom.Next(0, 5)],
                    BabaAdi = ErkekIsimler[IsimRandom.Next(0, 5)],
                    CocukSayisi = _Cocuksayisi.Next(0, 7),
                    AileGeliri = AileGelirix.Next(3000, 50000).ToString(),


                };
                Aileler.Add(OrnekAile);
            }

            Aile Aile1 = new Aile
            {
                AnneAdi = "Ebru",
                BabaAdi = "Taner",
                CocukSayisi = 3,
                AileGeliri = "14000",
            };

            Aile Aile2 = new Aile
            {
                AnneAdi = "Nigar",
                BabaAdi = "Aysenem's father",
                CocukSayisi = 1,   // mantıklı karar.
                AileGeliri = "999999"  // normalde ınt değer olan sayılarımı string türünde yazdım çünkü classımda string olarak tanımladım.
            };
            Aileler.Add(Aile1);
            Aileler.Add(Aile2);
            // MessageBox.Show(Aileler[1].AileGeliri);  // değer zaten string olduğu için artık basına to string yazmaya gerek yok,
            Console.WriteLine(Aileler);
            //MessageBox.Show("Anne adı: " + Aileler[7].AnneAdi + " " +
            //                "Baba adı: " + Aileler[7].BabaAdi + " " +
            //                "Aile geliri: " + Aileler[7].AileGeliri.ToString() + " " +
            //                "Çocuk Sayısı: " + Aileler[7].CocukSayisi);
            //for (int i = 0; i < 25; i++)
            //{
            //    MessageBox.Show("Anne adı: " + Aileler[i].AnneAdi + " " +
            //                "Baba adı: " + Aileler[i].BabaAdi + " " +
            //                 Aileler[i].AileGeliri.ToString() + " " +
            //                "Çocuk Sayısı: " + Aileler[i].CocukSayisi);
            //}
            Random Ailegostergesi = new Random();
            for (int i = 0; i < 5; i++)
            {
                int aileNumarası = Ailegostergesi.Next(0, 24);
                MessageBox.Show("Anne adı: " + Aileler[aileNumarası].AnneAdi + " " +
                            "Baba adı: " + Aileler[aileNumarası].BabaAdi + " " +
                             Aileler[aileNumarası].AileGeliri.ToString() + " " +
                            "Çocuk Sayısı: " + Aileler[aileNumarası].CocukSayisi);
            }
            Application.Exit();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            InterfaceGiris interfaceGiris = new InterfaceGiris();
            interfaceGiris.VarlikEkle(new Insan());  // yasa 2. yol altta
            Insan insan = new Insan
            {
                Yas = 20,
                Isim = "Bahadır",
                Meslek = "Bilgisayar Mühendisi",

            };
            Kopek kopek = new Kopek();
            kopek.Isim = "Karabaş";
            kopek.Yas = 13;
            kopek.Ayaksayisi = 4;
            //ınterfaceGiris.VarlikEkle(new Insan 
            //{
            //    Yas = 20,  
            //    Isim = "Bahadır",

            //});       ------>  3. yol  good luck :)  
            interfaceGiris.VarlikEkle(insan);  //  kısmadı çünkü insanı new insan olarak tanımladım.
            //interfaceGiris.VarlikEkle(new Kopek);  // parantez içinde IVARLIK tanımlı olduğundan varlık olan her şeyi parametre olarak yollayabiliriz.  
            interfaceGiris.VarlikEkle(new Horoz());
            interfaceGiris.VarlikEkle(kopek);
            interfaceGiris.VarlikEkle(new Bitki());
            foreach (var varlik in interfaceGiris.Varliklar)   // VAR  değişkeni her şeydir hem string hem int hem class hem prop hem interface hem list.. ..
            { //MessageBox.Show(varlik.Isim);  dediğimiz zaman sırayla isimleri yazar.
                if (varlik is Insan)   // eğer varlık bir insansa.... yap.
                {
                    MessageBox.Show("bu varlık bir insan");  // 2 kere demesinin sebebi yukarıda iki kere farklı şekillerde insanı ekledim
                } else if (varlik is IHayvan)
                {
                    MessageBox.Show("bu varlık bir hayvan ");
                    if (varlik is Horoz)
                        MessageBox.Show("bu varlık bir hayvan ve türü horoz ");
                    else if (varlik is Kopek)
                        MessageBox.Show("bu varlık bir hayvan ve türü köpek ");

                }
                else if (varlik is Bitki)
                {
                    MessageBox.Show("bu varlık bir bitki ");
                }


            }

        }


        private void button17_Click(object sender, EventArgs e)
        {
            EnumInsan _EnumInsan = new EnumInsan();
            _EnumInsan.Adi = "Bahadır";
            _EnumInsan.Yasi = 20;
            _EnumInsan.Meslegi = Meslekler.Yazilimci;
            if (_EnumInsan.Meslegi == Meslekler.Marangoz)
            {
                MessageBox.Show("Bu kişi marangoz");
            }
            else if (_EnumInsan.Meslegi == Meslekler.Yazilimci)
            {
                MessageBox.Show("Bu kişi Yazılımcı");
            }
            Application.Exit();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Insan1 ornek = new Insan1();
            ornek.setIsim("Bahadır Ahmet");  // ismi setledik artık string Isim = Bahadır Ahmet
            ornek.getIsim(); //  String ismi getliyorum yani çağırıyorum  kısacası Bahadır Ahmet yazıcak.
            ornek.Yas = 20;
            MessageBox.Show(ornek.getIsim() + " | " + "Yaşı: " + ornek.Yas.ToString());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            List<string> Isimler = new List<string>();
            Isimler.Add("Hilal");
            Isimler.Add("Ayşe");
            Isimler.Add("Fatma");
            Isimler.Add("Alya");
            Isimler.Add("Maya");
            Insan YeniInsan = new Insan();
            YeniInsan.Isim = "Levent";
            YeniInsan.Yas = 18;
            ekranda_goster(YeniInsan);
            ekranda_goster("ali");
            ekranda_goster(900);
            ekranda_goster(Isimler);

        }
        public void ekranda_goster<T>(T ekranda_gosterilecek)  // T = generic ifade demektir  önceden paramatreyi string , int gibi tanımlardık. ama generic ifade yani T de içerisinin ne olduğu yani paratetreyi bilmiyoruz.
        {
            if (ekranda_gosterilecek is string)
            {
                MessageBox.Show("string: " + ekranda_gosterilecek.ToString());
            }
            else if (ekranda_gosterilecek is int)
            {
                MessageBox.Show("İnt: " + ekranda_gosterilecek.ToString());
            }
            else if (ekranda_gosterilecek is Insan)
            {
                MessageBox.Show("Insan: ");

                MessageBox.Show("Adı: " + (ekranda_gosterilecek as Insan).Isim + " | " + "Yaşı: " + (ekranda_gosterilecek as Insan).Yas.ToString());
            }
            else if (ekranda_gosterilecek is List<string>)  // List<T> = herhangibir listeyse. 
            {
                MessageBox.Show("List<>string: ");
                foreach (string isim in ekranda_gosterilecek as List<string>)
                {
                    MessageBox.Show(isim);
                }

            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            Constructor constructorornek = new Constructor();
            Constructor constructorornek2 = new Constructor(2);
            Constructor constructorornek3 = new Constructor("ali", "veli");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Method1("xBahadırx");
            DEFmethod("ByKing");
            DEFmethod();   // NORMALDE BUNU YAPTIĞIMIZDA DEĞER GİRMEMİZİ İSTER VE KIZAR.
            DEFmethod2(20);
            DEFmethod2(20, "Excalibur");
        }
        public void Method1(string Isim)
        {
            MessageBox.Show(Isim);

        }
        public void DEFmethod(string Isim = "Abuzer")
        {

            MessageBox.Show(Isim);
        }
        public void DEFmethod2(int yas, string Isim = "Leyla")  // default parametre girildikten sonra normal parametre yazılamaz, normal parametre default parametreden önce yazılmalıdır.
        {

            MessageBox.Show(yas + " | " + Isim);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int sayi1 = 20;   // ref te  bir değer almalı ama out ta değer almasada olur
            int sayi2 = 30;
            MessageBox.Show(Hesapla(ref sayi1, sayi2).ToString());
            MessageBox.Show(sayi1.ToString()); // sayi1 üstte hala 20 olarak kaldı bunuda değiştirmek istiyorsak ref değeri girmeliyiz.
            MessageBox.Show(Hesapla2(out sayi1 , sayi2).ToString());
         }// eskiden 20 idi suan 100 veriyor 2. messagebox
        public int Hesapla(ref int asdfs, int sayi2)  // üstte tanımladığım int sin sen diyorum kendi başına adın aynı olsada artık farklı bir int değilsin. = REf
        {
            asdfs = 100;   // BU DEĞERİ ATAMASAMDA SAYİ1 20 YE TANIMLI OLDUĞUNDAN VE  SAYİ 1 , ASDFS İ RFERANS ALDIĞINDAN SORUN OLMAZ
            return asdfs + sayi2;
            
        }
        public int Hesapla2(out int edr , int sayi2) 
        {
            edr = 900;
            return edr + sayi2;
        
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Hesap(4,5);
            Hesap(5, 90, 100);
        }
        public  void Hesap(int sayi1, int sayi2)   // aynı isimden iki tane methot kullandım ve kızmadı çünkü her methodun bir imzası vardır ve bu izmların başlayış ve bitişini altta göstericem.
        {//  üsttekinin kod imzası * void Hesap(int sayi1, int sayi2) 
            int Toplam = sayi1 + sayi2;
            MessageBox.Show(Toplam.ToString());
        }
        public void Hesap(int sayi1, int sayi2, int sayi3)
        {  // üsttekinin kod imzası * void Hesap(int sayi1, int sayi2, int sayi3)
            int Toplam = sayi1 + sayi2 + sayi3;
            MessageBox.Show(Toplam.ToString());
        }
   
        private void button24_Click(object sender, EventArgs e)
        {// demin her sayı eklemek istediğimizde uzun uzun yaptık şiimdi paramsla kestirme yol :)
            Hesap(234, 34, 243, 24, 24, 2, 42, 4, 24, 234, 24, 3, 65, 657, 5, 876, 87, 9, 23, 14, 36);
            Hesap(1,2);   // params çalışmadı 
            Hesap(1, 2, 3);  // demekki bir method ne kadar özelse o kadar öncelikli işleme girer 
        }
        public void Hesap(params int[] sayilar)   // params ifadesi aynı önceki derslerdeki default parametre gibi en sona yazılır.
        {                                         
            MessageBox.Show(sayilar.Sum().ToString());  // ---> sum  , int[] in içinde bulunan bir fonksiyondur bütün listedeki sayıları toplar
            MessageBox.Show("sum olan params method çalıştı");
        }
    }
}


