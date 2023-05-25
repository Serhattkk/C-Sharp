using System.Reflection.Metadata;
while (true)
{
    Console.WriteLine("Merhaba, Düzgün Çokgende Açı Hesaplamaya Hoşgeldiniz!");
    Console.WriteLine("Çokgeninin Kenar Sayısını Giriniz.");
    string kenar = Console.ReadLine();
    int kenar_int = Convert.ToInt32(kenar);
    Console.Clear();

    Console.WriteLine("1) İç Açı Hesapla\n2) Dış Açı Hesapla");
    string secim = Console.ReadLine();
    if (secim == "1")
    {
        int ic_acı = ((kenar_int - 2)/(kenar_int)*180);
        Console.WriteLine("Çokgenin Bir İç Açısı: " + ic_acı);
        Console.ReadKey();
        break;
    }
    else if (secim == "2")
    {
        int dıs_acı = (360 / kenar_int);
        Console.WriteLine("Çokgenin Bir Dış Açısı");
        Console.ReadKey();
        break;
    }
    else
    {
        Console.WriteLine("Geçersiz Giriş");
        Console.ReadKey();
    }
}




/* 

// Ehliyet Sorgulma

Console.WriteLine("Ehliyet Sorgulama");
Console.ReadKey();
Console.WriteLine("Lütfen Size Sorulan Soruları Cevaplayınız");
Console.WriteLine("Adınız:");
string ad = Console.ReadLine();
Console.WriteLine("Yaşınız:");
string yas = Console.ReadLine();
int yas_int = Convert.ToInt32(yas);



if (yas_int < 18)
{
    Console.WriteLine("Merhaba " + ad + " Kriterlerin ehliyet almaya uygun değildir. :(");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Göz Kususuru Var Mı? Var İse 'Y' karakterini tuşlayınız Yok İse 'H' Harekterinin Tuşlayınız!");
    string kusur = Console.ReadLine();



    if ((kusur == "H") || (kusur == "h"))
    {
        if (yas_int >= 18)
        {
            Console.WriteLine("Merhaba " + ad + " Kriterlerin ehliyet almaya uygundur. :)");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Merhaba " + ad + " Kriterlerin ehliyet almaya uygun değildir. :(");
            Console.ReadKey();
        }

    }
    else if (kusur == "Y" || (kusur == "y"))
    {
        Console.WriteLine("Sol göz numaranız?");
        string sol_goz = Console.ReadLine();
        int int_sol_goz = Convert.ToInt32(sol_goz);
        Console.WriteLine("Sağ göz numaranız?");
        string sag_goz = Console.ReadLine();
        int int_sag_goz = Convert.ToInt32(sag_goz);

        int goz_ort = ((int_sol_goz + int_sag_goz) / 2);
        if (goz_ort >= 20)
        {
            Console.WriteLine("Merhaba " + ad + " Kriterlerin ehliyet almaya uygun değildir. ::(");
            Console.ReadKey();
        }
        else if (int_sag_goz == int_sag_goz)
        {
            Console.WriteLine("Merhaba " + ad + " Kriterlerin ehliyet almaya uygun değildir. :(");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Merhaba " + ad + " Kriterlerin ufak kusurlar ile ehliyet almaya uygundur. :)");
            Console.ReadKey();
        }
    }
}


//parola kontrol


for (int i = 5; i > 0; i--)
{

    string sys_username = "Herakles";
    string sys_password = "2950sk";

    Console.WriteLine("Sisteme Hoşgeldiniz");
    Console.WriteLine("Kullanıcı Adı:");
    Console.ReadKey();
    string username = Console.ReadLine();
    if ((username == "") || (username == " "))
    {
        Console.WriteLine("Geçersiz kullanıcı adı!");
        Console.ReadKey();
    }
    Console.WriteLine("Parola:");
    string password = Console.ReadLine();
    if ((password == "") || (password == " "))
    {
        Console.WriteLine("Geçersiz parola!");
        Console.ReadKey();
    }

    if ((sys_password == password) && (sys_username == username))
    {
        Console.WriteLine("Başarılı");
        Console.ReadKey();
        break;
    }
    else
    {
        Console.WriteLine("Kullanıcı adı veya parola hatalı!");
        Console.ReadKey();
        Console.Clear();
    }
    if (i == 0)
    {
        Console.WriteLine("Sistemden çıkılıyor");
        Console.ReadKey();
        Console.Clear();
    }
}


//not geçerliği


Console.WriteLine("Notunuz?");
string not = Console.ReadLine();
int not_int = Convert.ToInt32(not);

if (not_int >= 90)
{
    Console.WriteLine("A");
    Console.ReadKey();
}
else if (not_int >= 80 && not_int <= 89)
{
    Console.WriteLine("B");
    Console.ReadKey();
}
else if (not_int >= 70 && not_int <= 79)
{
    Console.WriteLine("C");
    Console.ReadKey();
}
else if (not_int >= 60 && not_int <= 69)
{
    Console.WriteLine("D");
    Console.ReadKey();
}
else if (not_int >= 50 && not_int <= 59)
{
    Console.WriteLine("E");
    Console.ReadKey();
}
else if (not_int < 50)
{
    Console.WriteLine("F");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Geçersiz Değer");
    Console.ReadKey();
}
"""
*/


