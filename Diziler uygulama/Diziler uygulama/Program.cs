int[] dizi1 = new int[10];
int[] dizi2 = new int[10];
int[] dizi3 = new int[10];
int[] dizi4 = { 15, 27, 48, 19, 8, 68, 45, 23, 59, 56 };

for (int i = 0; i < 10; i++)
{
    dizi1[i] = 7;
}

for (int a = 0; a < 10; a++)
{
    Console.WriteLine(a + ". elemanı giriniz: ");
    dizi2[a] = Convert.ToInt32(Console.ReadLine());
    System.Threading.Thread.Sleep(200);

}
for (int b = 0; b < 10; b++)
{
    int toplam = dizi1[b] + dizi2[b] + dizi4[b];
    dizi3[b] = toplam;
}

Console.Clear();

for (int c = 0; c < 10; c++)
{
    if (dizi3[c] > 70 )
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("C'nin" + c + ". elemanı: " + dizi3[c]);
        System.Threading.Thread.Sleep(1000);
        Console.Clear();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("C'nin" + c + ". elemanı: " + dizi3[c]);
        System.Threading.Thread.Sleep(1000);
        Console.Clear();
    }
}