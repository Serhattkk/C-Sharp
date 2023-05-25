using System;

namespace deneme
{
    class program
    {
        static void Main(string[] args)
        {
            string durum;

            Console.ForegroundColor = ConsoleColor.Magenta;


            Console.SetCursorPosition(30, 10);
            Console.WriteLine("Pencere Açık/Kapalı Rutini-");
            Console.ReadKey();
            Console.SetCursorPosition(30, 12);
            Console.WriteLine("Pencere Açık Mı?(Y/N)");
            Console.SetCursorPosition(30, 14);
            durum = Console.ReadLine();
            Console.Clear();
            if (durum == "Y")
            {
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("Pencere Açık");
                Console.ReadKey();
                Console.Clear();
            }
            else if (durum == "y")
            {
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("Pencere Açık");
                Console.ReadKey();
                Console.Clear();
            }
            else if (durum == "N")
            {
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("Pencere Kapalı");
                Console.ReadKey();
                Console.Clear();
            }
            else if (durum == "n")
            {
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("Pencere Kapalı");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!");
            }


            Console.SetCursorPosition(30, 14);
          


        }
    }
}
