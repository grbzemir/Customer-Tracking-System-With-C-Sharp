using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Tracking_System_With_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Musteri musteri1 = new Musteri(); // musteri1 objesini oluşturduk.
            musteri1.Id = 1;
            musteri1.Adi = "Furkan";
            musteri1.Soyadi = "Yalçin";
            musteri1.TcNo = "54538042742";
            musteri1.TelefonNo = "05425610012";
            musteri1.Adres = "Antalya";

            Musteri musteri2 = new Musteri(); // musteri2 objesini oluşturduk.
            musteri2.Id = 2;
            musteri2.Adi = "Eren Efe";
            musteri2.Soyadi = "Yildiz";
            musteri2.TcNo = "12267132732";
            musteri2.TelefonNo = "05535453254";
            musteri2.Adres = "Ankara";

            Musteri musteri3 = new Musteri(); // musteri3 objesini oluşturduk.
            musteri3.Id = 3;
            musteri3.Adi = "Emircan";
            musteri3.Soyadi = "Gürbüz";
            musteri3.TcNo = "54442425152";
            musteri3.TelefonNo = "05435235325";
            musteri3.Adres = "Istanbul/Esenyurt";

            Musteri musteri4 = new Musteri(); // musteri4 objesini oluşturduk.
            musteri4.Id = 4;
            musteri4.Adi = "Bilge";
            musteri4.Soyadi = "uzun";
            musteri4.TcNo = "22612264244";
            musteri4.TelefonNo = "0535456553";
            musteri4.Adres = "Istanbul/Yalova";

            Musteri[] Musteriler = new Musteri[] {musteri1, musteri2, musteri3, musteri4 }; // Musteriler dizisini oluşturduk.

            foreach(Musteri m in Musteriler) // Musteriler dizisini foreach ile döndürdük.

            {

                Console.WriteLine("-------------");
                Console.WriteLine("Müşteri Bilgileri");
                Console.WriteLine(m.Id);
                Console.WriteLine(m.Adi);
                Console.WriteLine(m.Soyadi);
                Console.WriteLine(m.TcNo);
                Console.WriteLine(m.TelefonNo);
                Console.WriteLine(m.Adres);
                Console.WriteLine("-------------");


            }

            Console.WriteLine("===================MusteriManagerSecuritySystemControler====================");

            if(musteri1.Id == musteri4.Id)

            {

                Console.WriteLine("Müşteri Id'leri Aynıdır");
            }

            else

            {

                Console.WriteLine("Müşteri Id'leri Farklıdır");
            }

            if(musteri1.Adi == musteri4.Adi)

            {

                Console.WriteLine("Müşteri Adları Aynıdır");
            }

            else

            {

                Console.WriteLine("Müşteri Adları Farklıdır");
            }

            if(musteri1.Soyadi == musteri4.Soyadi)

            {

                Console.WriteLine("Müşteri Soyadları Aynıdır");
            }

            else

            {

                Console.WriteLine("Müşteri Soyadları Farklıdır");
            }

            if(musteri1.TcNo == musteri4.TcNo)

            {

                Console.WriteLine("Müşteri Tc Numaraları Aynıdır");
            }

            else

            {

                Console.WriteLine("Müşteri Tc Numaraları Farklıdır");
            }

            if(musteri1.TelefonNo == musteri4.TelefonNo)

            {

                Console.WriteLine("Müşteri Telefon Numaraları Aynıdır");
            }

            else

            {

                Console.WriteLine("Müşteri Telefon Numaraları Farklıdır");
            }

            if(musteri1.Adres == musteri4.Adres)

            {

                Console.WriteLine("Müşteri Adresleri Aynıdır");

            }

            else

            { 

                Console.WriteLine("Müşteri Adresleri Farklıdır");

            }

            Console.WriteLine("==================================================");


            MusteriManager musteriManager = new MusteriManager(); // musteriManager objesini oluşturduk. 

            Console.WriteLine("==============");
            Console.WriteLine("Müşteri Ekleme");
            musteriManager.Ekle(musteri1); // musteriManager objesinin içindeki Ekle fonksiyonunu çağırdık.
            musteriManager.Ekle(musteri2); 
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            Console.WriteLine("==============");

            Console.WriteLine("==============");
            Console.WriteLine("Müşteri Silme");
            musteriManager.Sil(musteri1); // musteriManager objesinin içindeki Sil fonksiyonunu çağırdık.
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
            musteriManager.Sil(musteri4);
            Console.WriteLine("==============");

            Console.WriteLine("==============");
            Console.WriteLine("Müşteri Listeleme");
            musteriManager.Listele(musteri1);  // musteriManager objesinin içindeki Listele fonksiyonunu çağırdık.
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
            musteriManager.Listele(musteri4);
            Console.WriteLine("==============");

            Console.WriteLine("==============");
            Console.WriteLine("Müşteri Güncelleme");
            musteriManager.Guncelle(musteri1);  // musteriManager objesinin içindeki Guncelle fonksiyonunu çağırdık.
            musteriManager.Guncelle(musteri2);
            musteriManager.Guncelle(musteri3);
            musteriManager.Guncelle(musteri4);
            Console.WriteLine("==============");

            
            
            Console.ReadKey();

        }


    }


}
