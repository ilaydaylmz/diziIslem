/**************************************************************************************************************************************************************************
**                                                        SAKARYA ÜNİVERSİTESİ 
**                                               BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                                     BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                                                   NESNEYE DAYALIPROGRAMLAMA DERSİ 
**                                                       2020-2021 BAHAR DÖNEMİ
**
**                                                    ÖDEV NUMARASI...............:2
**                                                    ÖĞRENCİ ADI.................:İLAYDA YILMAZ
**                                                    ÖĞRENCİ NUMARASI............:B201210057
**                                                    DERSİN ALINDIĞI GRUP.........:1 C GRUBU
**
**************************************************************************************************************************************************************************/
using System;

namespace ndp_ödev2_soru1
{
     public class BenimString     //BenimString adında public bir class oluşturdum.
    {
        public void ElemanSayisi()   //public void ElemanSayisi isimli bir metot oluşturdum.
        {
            string metin;            //string türünden metin isimli bir değişken tanımladım.
            Console.WriteLine("eleman sayısını bulmak istediğiniz metni giriniz:");        //kullanıcıdan eleman sayısını bulmak için metn girmesini istedim.
            metin = Console.ReadLine();       //girilen metni metin isimli string türünden değişkene atadım.
            int s = 0;                 //int türünden s isimli bir değişken tanımladım.
            for (int i = 1; i < metin.Length; i++)      //0 dan metin uzunluğu kadar bir bir artan for döngüsü kurdum.
            {
                if (metin[i] == ' '||metin[i]=='.')      //metnin herhangi bir elemanı boşluk ya da nokta ise doğru olan if bloğu kurdum.
                {
                    s++;   //if bolğu çalışırsa sayacı bir artırdım.
                }
            }
            Console.WriteLine("girilen nesnedeki eleman sayısı:"+ s); //ekrana s'i yazdırdım.
        }

        public void Birlestir() //public void Birlestir isimli bir metot oluşturdum.
        {
            string n1;   //string türünden n1 tanımladım.
            string n2;   //string türünden n2 tanımladım.
            Console.WriteLine("birleştirilecek ilk nesneyi giriniz:");  //kullanıcıdan nesne girmesini istedim.
            n1 = Console.ReadLine();   //girilen nesneyi n1'e atadım.
            Console.WriteLine("birlestirilecek ikinci nesneyi giriniz:");   //kullanıcıdan ikinci nesneyi girmesini istedim.
            n2 = Console.ReadLine();   // girilen nesney n2'ye atadım.
            Console.WriteLine("girilen nesnelerin birleştirilmiş hali:" + n1 + n2);  //n1+n2 'yi ekrana yazdırdım.
        }

        public void ArayaGir()  //public void ArayaGir isimli metot oluşturdum.
        {
            string metin;      //metin isimli string değişken tanımladım.
            string eklenen;    //eklenen isimli string değişken tanımladım.
            int indis;         //indis isimli int değişken tanımladım.
            Console.WriteLine("metini giriniz:");    //kullanıcıdan metin girmesini istedim.
            metin = Console.ReadLine();     //girilen metni mtin değişkenine atadım.
            Console.WriteLine("eklemek istediğiniz kelimeyi giriniz:");      //kullanıcıdan kelime girmesini istedim.
            eklenen = Console.ReadLine();           //girilen kelimeyi eklenen değişkenine atadım.
            Console.WriteLine("kelimeyi yerleştirmek istediğiniz indisi giriniz:");         //indis girlmesini istedim.
            indis = Convert.ToInt32(Console.ReadLine());         //indis değerini okumasını sağladım.
            for(int i=0;i<metin.Length;i++)       //0 dan metin uzunluğu kadar bir bir artan for döngüsü kurdum.
            {
                if(i==indis)       //i indise eşit olursa doğru olan if bloğu kurdum.
                {
                    Console.Write(metin[i]+eklenen);       //metinin i.harfi ve eklenen'i yazdırdım.
                }
                else         //i ile indis eşit olmadığı zaman çalışır.
                {
                    Console.Write(metin[i]);         //metinin i.harfini yazdırır.
                }
            }
            Console.ReadLine();
        }

        public void DegerAl()    //public void DegerAl isimli metot oluşturdum.
        {
            string metin;  //metin isimli string bir değişken tanımladım.
            int deger;     //değer isimli int değişken tanımladım.
            int indis;     //indis isimli int değişken tanımladım.
            Console.WriteLine("metni giriniz:");     //kullanıcıdan metin girmesini istedim.
            metin = Console.ReadLine();      //girilen metni metin isimli değişkene atadım.
            Console.WriteLine("değer giriniz:");      //değer girilmesini istedim.
            deger = Convert.ToInt32(Console.ReadLine());    //değerin okunmasını sağladım.
            Console.WriteLine("indis giriniz:");         //indis girilmesini istedim.
            indis = Convert.ToInt32(Console.ReadLine());    //indisin okunmasını sağladım.
            for(int i=deger;i<deger+indis;i++)    //indis kadar tekrar eden for döngüsü kurdum.
            {
                Console.Write(metin[i]);    //metinin i. elamnını ekrana yazdırdım.
            }
            Console.ReadLine();
        }

        public void DiziyeAyır()   //public void DiziyeAyır isimli metod oluşturdum.
        {
            string metin;    //metin isimli string değişken tanımladım.
            char karakter;    //karakter isimli char değişken tanımladım.
            Console.WriteLine("diziye ayırmak istediğiniz metni giriniz:");    //kullanıcıdan metin girmesini istedim.
            metin=Console.ReadLine();    //metini metin değişkenine atadım.
            Console.WriteLine("karakter giriniz:");      //karakter girilmesini istedim.
            karakter = Convert.ToChar(Console.ReadLine());  //karakter değişkenine atadım.
            for(int i=0;i<metin.Length;i++)    //metin uzunluğu kadar tekrar eden for döngüsü kurdum.
            {
                if(metin[i]==karakter)   //metinin i. elemanı karaktere eşitse çalışan if bloğu kurdum.
                {
                    Console.WriteLine(); //alt satıra geçilmesini sağladım.
                }
                else  //metinin i. elemanı karaktere eşit olmadığı zaman okunur.
                {
                    Console.Write(metin[i]);  //metinin i. elemanını yazdırdım.
                }
            }
            Console.ReadLine();
        }

        public void DegerIndis()     // public void DegerIndis isimli metot tanımladım.
        {
            string metin;      //metin isimli string değişken tanımladım.
            string aranan;      //aranan isimli string değişken tanımladım.
            Console.WriteLine("metini giriniz:");  //metin girilmesini istedim.
            metin = Console.ReadLine();   // girilen metni metin isimli string değişkene atadım.
            Console.WriteLine("aranacak kelimeyi giriniz:");   //kelime girilmesini istedim.
            aranan = Console.ReadLine();     //kelimeyi aranan isimli string değişkene atadım.
            int metin_uzunluk = metin.Length;     //metinin uzunluğunu metin_uzunluk isimli int değişkene atadım.
            int aranan_uzunluk = aranan.Length;    //arananın uzunluğunun aranan_uzunluk isimli int değişkene atadım.
            int indis = metin.IndexOf(aranan);          //indexof ile aranan kelimenin indisini buldum.
            Console.WriteLine("Kelime " + aranan + " indis: " + indis);  //kelimeyi ve indisi ekrana yazdırdım.
        }

        public void SıralaAZ()    //public void sıralaAZ isimli metod oluşturdum.
        {
            string metin;      //metin isimli string değişken tanımladım.
            Console.WriteLine("a'dan z'ye sıralamak istediğiniz metni giriniz:");     //kullanıcıdan metin girilmesini istedim.
            metin = Console.ReadLine();     //girilen metni metin değişkenine atadım.
            metin = metin.ToLower();    //metinde büyük harf varsa küçük harfe çevrilmesini sağladım.
            String karakterler = "abcdefghijklmnopqrstuvwxyz";  
            int[] count = new int[karakterler.Length];
            for (int i = 0; i < metin.Length; i++)     //metinin uzunluğu kadar tekrar eden for döngüsü kurdum.
            {
                int index = karakterler.IndexOf(metin[i]);
                if (index < 0)
                    continue;
                else
                {
                    count[index]++;
                }
            }
           for (int i = 0; i < count.Length; i++)       //sayac kadar tekrar eden for döngüsü kurudm.
            {
                if (count[i] < 1)
                    continue;
                else
                {
                    Console.WriteLine(karakterler[i] + " " + count[i]); // sıraladığım harflerin kaç tane olduğunu yazdırdım
                }
            }
        }

        public void SıralaZA() //public void sırala za isimli bir metod oluşturdum.
        {
            string metin; //metin isimli string bir değişken tanımladım.
            Console.WriteLine("z'den a'ya sıralamak istediğiniz metni giriniz:"); //kullanıcıdan metin girmesini istedim.
            metin = Console.ReadLine(); //girilen metni metin değişkenine atadım.
            metin = metin.ToLower();//metindeki büyük harfleri küçük harfe çevrilmesini sağladım.
            String karakterler = "zyxwvutsrqponmlkjihgfedcba";
            int[] count = new int[karakterler.Length];
            for (int i = 0; i < metin.Length; i++) //metin uzunluğu kadar tekrar eden for döngüsü kurdum.
            {
                int index = karakterler.IndexOf(metin[i]);
                if (index < 0)
                    continue;
                else
                {
                    count[index]++;
                }
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] < 1)
                    continue;
                else
                {
                    Console.WriteLine(karakterler[i] + " " + count[i]); //tersten sıraladığım harflerin kaç tane olduğunu yazdırdım.
                }
            }
        }

        public void TersCevir()   //public void TersCevir isimli metot oluşturdum.
        {
            String metin;    //metin isimli string değişken tanımladım.
            Console.WriteLine("Tersten Yazılacak Metni Giriniz:");    //metin girilmesini istedim.
            metin = Console.ReadLine();   //metin değişkenine girilen metni atadım.
            for (int i = 0; i <= metin.Length - 1; i++)  //metin uzunluğu kadar tekrar edilmesini sağlayan for döngüsü kurdum.
            {
                Console.Write(metin[metin.Length - i - 1]); //ekrana yazdırdım.
            }
            Console.ReadLine();

        }

     }
    class Program
    {
        static void Main(string[] args)
        {
            BenimString benim = new BenimString();    //BenimString sınıfından benim isimli nesne türettim.
            benim.ElemanSayisi();  //eleman sayısı metodunu çağırdım. 
            benim.Birlestir();  // birleştir metodunu çağırdım.
            benim.ArayaGir();   //araya gir metodunu çağırdım.
            benim.DegerAl();   // değer al metodunu çağırdım.
            benim.DiziyeAyır();  //diziye ayır metodunu çağırdım.
            benim.DegerIndis();  //değer indis metodunu çağırdım.
            benim.SıralaAZ();  //sırala AZ metodunu çağırdım.
            benim.SıralaZA(); //sırala ZA metodunu çağırdım.
            benim.TersCevir();  //ters çevir metodunu çağırdım.
        }
    }
}
