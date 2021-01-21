using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+" isimli müşteri eklendi...:" );
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " isimli müşteri listelendi...:");
        }
        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+" isimli müşteri güncelledi...:");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+" isimli müşteri silindi...:");
        }

    }
}
