using System;

class Program
{
    static void Main()
    {
        Console.Write("Kaç adet sayı girmek istiyorsunuz?: ");

        // Kullanıcıdan adet bilgisini 
        if (int.TryParse(Console.ReadLine(), out int adet))
        {
            // Toplam ve Ortalama hesaplamak için gerekli değişkenleri tanımlıyoruz
            int toplam = 0;

            for (int i = 1; i <= adet; i++)
            {
                Console.Write($"{i}. : Sayıyı giriniz: ");
                // Kullanıcıdan sayıyı alıyoruz
                if (int.TryParse(Console.ReadLine(), out int sayi))
                {
                    // Girilen sayıyı toplam değişkenine ekliyoruz
                    toplam += sayi;
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
                    // Geçersiz giriş işe  geri alır.
                    i--;
                }
            }

            // Ortalamayı hesaplayıp ekrana yazdırıyoruz
            double ortalama = toplam / adet;
            Console.WriteLine($"Girilen sayıların toplamı: {toplam}");
            // Toplamı
            Console.WriteLine($"Girilen sayıların ortalaması: {ortalama}");
            // Ortalaması 
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen bir tam sayı girin.");
        }

        Console.ReadLine();
    }
}
