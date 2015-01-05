using System;
class Program
    {
      static void Main()
      {
          try
          {
              Console.WriteLine("enter a odd number");
              int number = int.Parse(Console.ReadLine());
              if (number % 2 != 0)
              {
                  for (int i =1; i <=number; i =i+2)
                  {
                      for (int c = 0; c <i; c=c+1)
                      {
                          Console.Write("*");
                      }

                      Console.WriteLine();
                  }

                  for (int i = number-2; i>0; i = i - 2)
                  {
                      for (int c = i; c > 0; c=c-1)
                      {
                          Console.Write("*");
                      }

                      Console.WriteLine();
                  }
              }
              else
              {
                  Console.WriteLine("invalid input");
              }
          }
          catch(FormatException)
          {
              Console.WriteLine("please enter an odd number");
          }
          finally
          {
              Console.ReadLine();
          }    
     }   
    }

