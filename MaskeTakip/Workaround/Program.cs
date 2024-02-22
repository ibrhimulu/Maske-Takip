using Business.Concrete;
using Entities.Concrete;
using System;

namespace $safeprojectname$
{
    class Program
    {
        static void Main(string[] args)
        {
            //Selamver(isim: "Rıdvan");
            //Selamver(isim: "Mert");
            //Selamver(isim: "Dağhan");
            //Selamver();

            //int sonuc = Topla(3, 5);

            //string[] ogrenciler = new string[3];
            //ogrenciler[0] = "Cemal";
            //ogrenciler[1] = "Hikmet";
            //ogrenciler[2] = "Halil";

            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine(ogrenciler[i]);
            //}

            Person person1= new Person();
            person1.FirstName = "İBRAHİM HALİL";
            person1.LastName = "ULUGERGER";
            person1.DateOfBirthYear = 2000;
            person1.NationalIdentity = 123;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }




        //static void Selamver(string isim = "isimsiz")
        //{
        //    Console.WriteLine("Merhaba" + " " + isim);
        //}

        //static int Topla(int sayi1, int sayi2)
        //{
        //    int sonuc = sayi1 + sayi2;
        //    Console.WriteLine("Toplam: " + sonuc);
        //    return sonuc;
        //}

    }
}


