using System;
class Program
    {
        static void Main()
        {
            int f1 = 1; int f2 = 1; int f3 = 0;
            Console.Write(f1 + " ");
            Console.Write(f2 + " ");
            for (int i = 1; i <=7; i++)
            {
                f3 = f1 + f2;
                Console.Write(f3 + " ");
                f1=f2;
                f2 = f3;
            }
            Console.ReadLine();
        }
    }

