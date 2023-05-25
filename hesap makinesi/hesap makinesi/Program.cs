while (true)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;

    Console.WriteLine("Hesap makiwnesine hoş geldiniz");
    Console.WriteLine("1) Toplama\n2) Çıkarma\n3) Çarpma\n4) Bölme\n5) Üs Alma\n6) Kök Alma\n7) Çıkış");
    string secim = Console.ReadLine();
    Console.Clear();
    if (secim == "7")
    {
        Console.WriteLine("Çıkış Yapılıyor...");
        Console.ReadKey();
        break;
    }
    else
    {
        if (secim == "5")
        {
            Console.WriteLine("Taban Sayı:");
            string taban = Console.ReadLine();
            int taban_int = Convert.ToInt32(taban);
            Console.WriteLine("Üs Sayı");
            string us = Console.ReadLine();
            int us_int = Convert.ToInt32(us);

            Console.Clear();

            int hesap_us = (int)Math.Pow(taban_int, us_int); // Math.Pow üs alma fonsiyonudur
            Console.WriteLine("Sonuç: " + hesap_us);
            Console.ReadKey();
            Console.Clear();
        }
        else if (secim == "6")
        {
            Console.WriteLine("Sayı");
            string kok_sayı = Console.ReadLine();
            int kok_sayı_int = Convert.ToInt32(kok_sayı);
            
            Console.Clear();

            int hesap_kok = (int)Math.Sqrt(kok_sayı_int);
            Console.WriteLine("Sonuç: " + hesap_kok);
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("1.Sayı");
            string sayi_1 = Console.ReadLine();
            int sayi_1_int = Convert.ToInt32(sayi_1);
            Console.WriteLine("2.Sayı");
            string sayi_2 = Console.ReadLine();
            int sayi_2_int = Convert.ToInt32(sayi_2);

            Console.Clear();

            if (secim == "1")
            {
                int hesap_toplama = (sayi_1_int + sayi_2_int);
                Console.WriteLine("Sonuç: " + hesap_toplama);
                Console.ReadKey();
                Console.Clear();
            }
            else if (secim == "2")
            {
                int hesap_cıkarma = (sayi_1_int - sayi_2_int);
                Console.WriteLine("Sonuç: " + hesap_cıkarma);
                Console.ReadKey();
                Console.Clear();
            }
            else if (secim == "3")
            {
                int hesap_carpma = (sayi_1_int * sayi_2_int);
                Console.WriteLine("Sonuç: " + hesap_carpma);
                Console.ReadKey();
                Console.Clear();
            }
            else if (secim == "4")
            {
                int hesap_bolme = (sayi_1_int / sayi_2_int);
                Console.WriteLine("Sonuç: " + hesap_bolme);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}   


