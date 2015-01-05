using System;

    class Program
    {
        static void Main()
        {
            string s = "madam";
            string reverse = "";
            for (int i = 4; i >= 0; i--)
            {
                reverse = reverse + s[i];

            }
            if (s == reverse)
            {
              Console.WriteLine("madam is a palindrome");
            }
            else
            {
                Console.WriteLine("not a plalindrome");
               
            }
            Console.ReadLine();
        }
    }

