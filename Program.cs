using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri kisi1 = new Musteri();
            kisi1.Adi = "Hasan Yiğit";
            kisi1.Soyadi = "Çetin";
            kisi1.Yas = 18;
            kisi1.Cinsiyet = "Bey";

            Musteri kisi2 = new Musteri();
            kisi2.Adi = "Muhammet Ali";
            kisi2.Soyadi = "Şahal";
            kisi2.Yas = 18;
            kisi2.Cinsiyet = "Bey";

            Musteri kisi3 = new Musteri();
            kisi3.Adi = "Yüksel";
            kisi3.Soyadi = "Şahal";
            kisi3.Yas = 52;
            kisi3.Cinsiyet = "Hanım";

            MusteriManager musterimanager = new MusteriManager();

            Musteri[] musteriler = new Musteri[] {kisi1,kisi2,kisi3 };

            foreach (var kisi in musteriler)
            {
                musterimanager.Ekle(kisi);
                musterimanager.Delete(kisi);
                musterimanager.List(kisi);
            }

            
        }
    }
}
