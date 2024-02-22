using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            //Vatandas vatandas1 = new Vatandas();

            //SelamVer(isim:"Engin");

            //SelamVer(isim: "İlker");

            //SelamVer(isim: "Murat");

            //SelamVer();


            //int sonuc = Topla(3,8);

            //Arrays

            //string ogrenci1 = "İlker";
            //string ogrenci2 = "Kerem";
            //string ogrenci3 = "Berkay";

            //string[] ogrenciler = new string[3];
            //ogrenciler[0] = "İlker";
            //ogrenciler[1] = "Kerem";
            //ogrenciler[2] = "Berkay";

            //ogrenciler = new string[4];
            //ogrenciler[3] = "Mehmet";

            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine(ogrenciler[i]);
            //}

            //string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            //string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            //sehirler2 = sehirler1;
            //sehirler1[0] = "Adana";

            //Console.WriteLine(sehirler2[0]);


            Person person1 = new Person();
            person1.FirstName = "İlker";
            person1.Lastame = "Kaya";
            person1.DateofBirthYear = 1997;
            person1.NationalIdentity = 356;



            Person person2 = new Person();
            person2.FirstName = "Murat";

            PttManager pttManager = new PttManager(new PersonManager());

            pttManager.GiveMask(person1);


            Console.ReadLine();

        }

        //static void selamver(string isim = "isimsiz")
        //{
        //    console.writeline("merhaba " + isim);
        //}

        //static int topla(int sayi1 = 5, int sayi2 = 10)
        //{
        //    int sonuc = sayi1 + sayi2;

        //    console.writeline("toplam : " + sonuc.tostring());

        //    return sonuc;
        //}

        //private static void degiskenler()
        //{
        //    string ad = "ilker";
        //    string soyad = "kaya";
        //    int dogumyili = 2002;
        //    long tcno = 12345678912;
        //    console.writeline(ad);
        //}
    }
    //public class vatandas
    //{
    //    public string ad { get; set; }
    //    public string soyad { get; set; }
    //    public int dogumyili { get; set; }
    //    public long tcno { get; set; }

    }

