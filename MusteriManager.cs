using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Müşteri Eklendi.Hoşgeldiniz "+ musteri.Adi + " " + musteri.Cinsiyet);
        }
        
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi +" "+ musteri.Soyadi +" adlı müşteri silindi.");
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine("Müşteri Ad,Soyad,Yaşı: " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Yas);
        }
    }
}
