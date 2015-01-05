using System;
class customer
{
    int cno;
    string cname;
    double balance;
  static string bname;
  static string baddress;
    static customer()
    {
        bname="icici";
        baddress="hyderabad";

    }
    customer(int i, string s, double d)
    {
        cno = i;
        cname = s;
        balance = d;
    }
    void deposit(double amt)
    {
        balance = balance + amt;
    }
    void withdraw(double amt)
    {
        balance = balance - amt;
    }
    static void displaybankdata()
    {
        Console.WriteLine(bname);
        Console.WriteLine(baddress);
    }
    void displaycustomerdata()
    {
        Console.WriteLine(cno);
        Console.WriteLine(cname);
        Console.WriteLine(balance);
    }
        static void Main()
        {
            customer.displaybankdata();
            customer s1 = new customer(101, "anil", 5000);
            customer s2 = new customer(102, "sunil", 4000);
            s1.deposit(2000);
            s2.withdraw(1000);
            s1.displaycustomerdata();
            s2.displaycustomerdata();
        }
    
}
