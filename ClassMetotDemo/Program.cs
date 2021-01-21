using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() { Id = 1, KategoriId = 2, TCKimlikNo = 54564654646, VergiNo = 5464654, Adi = "Mehmet", Soyadi = "OKAY" };

            Musteri musteri2 = new Musteri() { Id = 2, KategoriId = 1, TCKimlikNo = 544257557646, VergiNo = 5475754, Adi = "Ahmet", Soyadi = "YILMAZ" };

            Musteri musteri3 = new Musteri() { Id = 3, KategoriId = 2, TCKimlikNo = 62256, VergiNo = 3269454, Adi = "Ayşe", Soyadi = "TÜTÜNCÜOĞLU" };

            Musteri musteri4 = new Musteri() { Id = 4, KategoriId = 2, TCKimlikNo = 56466545456, VergiNo = 87891, Adi = "Erdem", Soyadi = "KOÇYİĞİT" };

            Musteri musteri5 = new Musteri() { Id = 5, KategoriId = 2, TCKimlikNo = 58496454564, VergiNo = 15616, Adi = "Deniz", Soyadi = "ERBULAK" };

            Musteri[] musteriler ={ musteri1, musteri2, musteri3, musteri4, musteri5 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id : "+musteri.Id);
                Console.WriteLine("Müşteri Kategori Id : "+musteri.KategoriId);
                Console.WriteLine("Müşteri TC Kimlik Numarası : "+musteri.TCKimlikNo);
                Console.WriteLine("Müşteri Vergi Numarası : "+musteri.VergiNo);
                Console.WriteLine("Müşteri Adı : "+musteri.Adi);
                Console.WriteLine("Müşteri Soyadı : "+musteri.Soyadi);
                Console.WriteLine("********************************************************");
                
            }

        }
    }
}
