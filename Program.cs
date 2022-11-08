using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Пианино октавы и переключение");
        ccc();
    }
    static void ccc()
    {
        int[] one = new int[12] { 3270, 3460, 3670, 3880, 4120, 4360, 4620, 4900, 5190, 5500, 5820, 6170 };
        int[] two = new int[12] { 6540, 6930, 7340, 7770, 8240, 8730, 9250, 9800, 10300, 11000, 11600, 12300 };

        while (true)
        {

            ConsoleKeyInfo x = Console.ReadKey();


            if (x.Key == ConsoleKey.F1)
            {
                oct(one);
            }
            if (x.Key == ConsoleKey.F2)
            {
                oct(two);
            }
        }
    }
    static void oct(int[] x)
    {
        ConsoleKeyInfo i = Console.ReadKey();
        while (i.Key != ConsoleKey.Escape)
        {
            if (i.Key == ConsoleKey.Q)
            {
                Console.Beep(x[0], 400);
            }
            if (i.Key == ConsoleKey.W)
            {
                Console.Beep(x[1], 400);
            }
            if (i.Key == ConsoleKey.E)
            {
                Console.Beep(x[2], 400);
            }
            if (i.Key == ConsoleKey.R)
            {
                Console.Beep(x[3], 400);
            }
            if (i.Key == ConsoleKey.T)
            {
                Console.Beep(x[4], 400);
            }
            if (i.Key == ConsoleKey.Y)
            {
                Console.Beep(x[5], 400);
            }
            if (i.Key == ConsoleKey.U)
            {
                Console.Beep(x[6], 400);
            }
            if (i.Key == ConsoleKey.I)
            {
                Console.Beep(x[7], 400);
            }
            if (i.Key == ConsoleKey.O)
            {
                Console.Beep(x[8], 400);
            }
            if (i.Key == ConsoleKey.P)
            {
                Console.Beep(x[9], 400);
            }
            if (i.Key == ConsoleKey.A)
            {
                Console.Beep(x[10], 400);
            }
            if (i.Key == ConsoleKey.S)
            {
                Console.Beep(x[11], 400);
            }
            i = Console.ReadKey();
        }
    }

}