//Fundamentals Project - Hafta 3
using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Kullanıcıya program seçeneklerini sunuyoruz
            Console.WriteLine("Hangi programı çalıştırmak istersiniz?");
            Console.WriteLine("1 - Rastgele Sayı Bulma Oyunu");
            Console.WriteLine("2 - Hesap Makinesi");
            Console.WriteLine("3 - Ortalama Hesaplama");
            Console.WriteLine("Çıkmak için 0 tuşlayınız.");

            // Kullanıcının seçimini alıyoruz
            int secim = Convert.ToInt32(Console.ReadLine());

            // Kullanıcı seçimine göre ilgili programı çalıştırıyoruz
            switch (secim)
            {
                case 1:
                    RastgeleSayiBulmaOyunu();
                    break;
                case 2:
                    HesapMakinesi();
                    break;
                case 3:
                    OrtalamaHesaplama();
                    break;
                case 0:
                    // Çıkış durumunda mesaj yazdırıyoruz
                    Console.WriteLine("Programdan çıkılıyor...");
                    return;
                default:
                    // Geçersiz bir seçim yapılırsa uyarı veriyoruz
                    Console.WriteLine("Geçersiz seçim! Lütfen 1, 2, 3 veya 0 tuşlayınız.");
                    break;
            }
        }
    }

    static void RastgeleSayiBulmaOyunu()
    {
        // Rastgele sayı oluşturmak için Random sınıfını kullanıyoruz
        Random random = new Random();
        int hedefSayi = random.Next(1, 101); // 1 ile 100 arasında bir sayı seçiliyor
        int kalanHak = 5; // Kullanıcının tahmin hakkı

        Console.WriteLine("1 ile 100 arasında bir sayı tahmin edin.");

        // Kullanıcının tahminlerini almak için bir döngü kullanıyoruz
        while (kalanHak > 0)
        {
            Console.Write("Tahmininiz: ");
            int tahmin = Convert.ToInt32(Console.ReadLine());

            // Kullanıcı doğru tahmin yaparsa oyunu bitiriyoruz
            if (tahmin == hedefSayi)
            {
                Console.WriteLine("Tebrikler! Doğru tahmin.");
                return;
            }
            // Kullanıcı daha küçük bir tahmin yaptıysa ipucu veriyoruz
            else if (tahmin < hedefSayi)
            {
                Console.WriteLine("Daha yüksek bir sayı tahmin edin.");
            }
            // Kullanıcı daha büyük bir tahmin yaptıysa ipucu veriyoruz
            else
            {
                Console.WriteLine("Daha düşük bir sayı tahmin edin.");
            }

            // Her yanlış tahminde kalan hak bir azalır
            kalanHak--;
            Console.WriteLine($"Kalan hak: {kalanHak}");
        }

        // Kullanıcı tahmin hakkını doldurursa doğru sayıyı gösteriyoruz
        Console.WriteLine($"Üzgünüm, tahmin hakkınız bitti. Doğru sayı: {hedefSayi}");
    }

    static void HesapMakinesi()
    {
        // Kullanıcıdan birinci sayıyı alıyoruz
        Console.Write("Birinci sayıyı giriniz: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        // Kullanıcıdan ikinci sayıyı alıyoruz
        Console.Write("İkinci sayıyı giriniz: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        // Kullanıcıdan yapmak istediği işlemi alıyoruz
        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: +, -, *, /");
        string islem = Console.ReadLine();

        double sonuc;

        // Kullanıcının seçimine göre işlemi gerçekleştiriyoruz
        switch (islem)
        {
            case "+":
                sonuc = sayi1 + sayi2;
                Console.WriteLine($"Sonuç: {sonuc}");
                break;
            case "-":
                sonuc = sayi1 - sayi2;
                Console.WriteLine($"Sonuç: {sonuc}");
                break;
            case "*":
                sonuc = sayi1 * sayi2;
                Console.WriteLine($"Sonuç: {sonuc}");
                break;
            case "/":
                // Bölme işleminde sıfıra bölme kontrolü yapıyoruz
                if (sayi2 == 0)
                {
                    Console.WriteLine("Hata: Sıfıra bölme yapılamaz.");
                }
                else
                {
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine($"Sonuç: {sonuc}");
                }
                break;
            default:
                // Geçersiz bir işlem yapılırsa uyarı veriyoruz
                Console.WriteLine("Geçersiz işlem! Lütfen +, -, * veya / seçiniz.");
                break;
        }
    }

    static void OrtalamaHesaplama()
    {
        // Kullanıcıdan birinci ders notunu alıyoruz
        Console.Write("Birinci ders notunu giriniz: ");
        double not1 = Convert.ToDouble(Console.ReadLine());

        // Notun geçerliliğini kontrol ediyoruz
        if (not1 < 0 || not1 > 100)
        {
            Console.WriteLine("Hata: Birinci not 0-100 arasında olmalıdır.");
            return;
        }

        // Kullanıcıdan ikinci ders notunu alıyoruz
        Console.Write("İkinci ders notunu giriniz: ");
        double not2 = Convert.ToDouble(Console.ReadLine());

        if (not2 < 0 || not2 > 100)
        {
            Console.WriteLine("Hata: İkinci not 0-100 arasında olmalıdır.");
            return;
        }

        // Kullanıcıdan üçüncü ders notunu alıyoruz
        Console.Write("Üçüncü ders notunu giriniz: ");
        double not3 = Convert.ToDouble(Console.ReadLine());

        if (not3 < 0 || not3 > 100)
        {
            Console.WriteLine("Hata: Üçüncü not 0-100 arasında olmalıdır.");
            return;
        }

        // Ortalama hesaplama işlemi
        double ortalama = (not1 + not2 + not3) / 3.0;
        Console.WriteLine($"Ortalama: {ortalama:F2}");

        // Harf notunu belirleme
        if (ortalama >= 90)
        {
            Console.WriteLine("Harf Notu: AA");
        }
        else if (ortalama >= 85)
        {
            Console.WriteLine("Harf Notu: BA");
        }
        else if (ortalama >= 80)
        {
            Console.WriteLine("Harf Notu: BB");
        }
        else if (ortalama >= 75)
        {
            Console.WriteLine("Harf Notu: CB");
        }
        else if (ortalama >= 70)
        {
            Console.WriteLine("Harf Notu: CC");
        }
        else if (ortalama >= 65)
        {
            Console.WriteLine("Harf Notu: DC");
        }
        else if (ortalama >= 60)
        {
            Console.WriteLine("Harf Notu: DD");
        }
        else if (ortalama >= 55)
        {
            Console.WriteLine("Harf Notu: FD");
        }
        else
        {
            Console.WriteLine("Harf Notu: FF");
        }
    }
}
