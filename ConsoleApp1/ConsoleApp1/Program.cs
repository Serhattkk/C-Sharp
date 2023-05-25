using System.Collections.Generic;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            string userdata1 = "Mehmet Yaman, 25, Hatay";
            string userdata2 = "Canan Dilek, 19, KahramanMaraş";

            List<string> kullanıcılar = new List<string>();
            kullanıcılar.Add(userdata1);
            kullanıcılar.Add(userdata2);

            Console.WriteLine("Sistemdeki Kayıtlı Kişileri Göremek İçin = 1\nYeni Kişi Eklemek İçin = 2");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                foreach (var liste in kullanıcılar)
                {
                    Console.WriteLine(liste);
                }
                Console.ReadKey();
            }
            else if (secim == "2")
            {
                Console.WriteLine("Ad:");
                string ad = Console.ReadLine();
                ad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ad);
                Console.WriteLine("Soyad:");
                string soyad = Console.ReadLine();
                soyad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(soyad);
                Console.WriteLine("Yaş:");
                string yas = Console.ReadLine();
                yas = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(yas);
                Console.WriteLine("Şehir:");
                string sehir = Console.ReadLine();
                sehir = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(sehir);

                string userdata3 = (ad + " " + soyad + ", " + yas + ", " + sehir);
                kullanıcılar.Add(userdata3);
                foreach (var liste in kullanıcılar)
                {
                    Console.WriteLine(liste);
                }
                Console.ReadKey();
            }


        }
    }
}