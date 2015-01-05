using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    public delegate void mydelegate(int a,int b);
    class Program
    {
        static void add(int a,int b)
        {
            Console.WriteLine("sum is"+(a+b));
        }
        static void Main()
        {
            mydelegate obj = new mydelegate(add);
            obj(10,20);
        }
    }
}
