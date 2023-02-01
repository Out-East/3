using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Пианино");
        ccc();
    }
    static void ccc()
    {
        int[] Pervaya = new int[12] { 262, 294, 330, 349, 392, 440, 494, 523, 587, 659, 698, 784 };
        int[] Vtoraya = new int[12] { 524, 587, 661, 698, 784, 880, 988, 1047, 1175, 1319, 1397, 1568 };

        while (true)
        {
            ConsoleKeyInfo x = Console.ReadKey();

            if (x.Key == ConsoleKey.F1)
            {
                octave(Pervaya);
            }
            if (x.Key == ConsoleKey.F2)
            {
                octave(Vtoraya);
            }
        }
    }
    static void octave(int[] Noty)
    {
        ConsoleKeyInfo i = Console.ReadKey();
        while (i.Key != ConsoleKey.Escape)
        {
            if (i.Key == ConsoleKey.A)
            {
                Console.Beep(Noty[0], 400);
            }
            if (i.Key == ConsoleKey.B)
            {
                Console.Beep(Noty[1], 400);
            }
            if (i.Key == ConsoleKey.C)
            {
                Console.Beep(Noty[2], 400);
            }
            if (i.Key == ConsoleKey.D)
            {
                Console.Beep(Noty[3], 400);
            }
            if (i.Key == ConsoleKey.E)
            {
                Console.Beep(Noty[4], 400);
            }
            if (i.Key == ConsoleKey.F)
            {
                Console.Beep(Noty[5], 400);
            }
            if (i.Key == ConsoleKey.G)
            {
                Console.Beep(Noty[6], 400);
            }
            if (i.Key == ConsoleKey.H)
            {
                Console.Beep(Noty[7], 400);
            }
            if (i.Key == ConsoleKey.I)
            {
                Console.Beep(Noty[8], 400);
            }
            if (i.Key == ConsoleKey.J)
            {
                Console.Beep(Noty[9], 400);
            }
            if (i.Key == ConsoleKey.K)
            {
                Console.Beep(Noty[10], 400);
            }
            if (i.Key == ConsoleKey.L)
            {
                Console.Beep(Noty[11], 400);
            }
            i = Console.ReadKey();
        }
    }
}