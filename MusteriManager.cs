using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Tracking_System_With_C_Sharp
{
    internal class MusteriManager

    {

        public void Ekle(Musteri musteri) // musteri parametresi ile MusteriManager class'ına erişim sağladık.

        {

            Console.WriteLine("Müşteri Eklendi : " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Id + " " + musteri.TcNo + " " + musteri.TelefonNo + " " + musteri.Adres);
        }

        public void Sil(Musteri musteri)

        {

            Console.WriteLine("Müşteri Silindi : " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Id + " " + musteri.TcNo + " " + musteri.TelefonNo + " " + musteri.Adres);
        }

        public void Listele(Musteri musteri)

        {

            Console.WriteLine("Müşteri Listelendi : " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Id + " " + musteri.TcNo + " " + musteri.TelefonNo + " " + musteri.Adres);
        }

        public void Guncelle(Musteri musteri)

        {

            Console.WriteLine("Müşteri Güncellendi : " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Id + " " + musteri.TcNo + " " + musteri.TelefonNo + " " + musteri.Adres);

        }

    }
}

