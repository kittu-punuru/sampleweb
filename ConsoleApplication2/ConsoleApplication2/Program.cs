using System;
public class person
{
    public string fname;
    public string lname;
    public string address;
}
public class student : person
{
    public int rollno;
    public string bname;
    public string addate;
    public int m1;
    public int m2;
    public int m3;
   public double percentage;
    public student(int rno, string fn, string ln,string bn, string ad)
    {
        rollno = rno;
        fname = fn;
        lname = ln;
        address = ad;
        bname=bn;
    }
        public void setmarks(int marks1, int marks2, int marks3)
        {
        m1 = marks1;
        m2 = marks2;
        m3 = marks3;
        }

    
    int calculatetotal()
    {
        return m1 + m2 + m3;
    }
    public void totalpercentage()
    {
        double percentage = calculatetotal() / 3.0;
    }
    public void displaystudentdata()
    {
        
        Console.WriteLine("student roll number is" + rollno);
       Console.WriteLine("student name is" + fname);
         Console.WriteLine("student name is" + lname);
        Console.WriteLine("student branch name is" + bname);
        Console.WriteLine("student admission number is" + addate);
        Console.WriteLine("student percentage is" + percentage);
    }
}

class Program
{
    public static void Main()
    {
        student s1 = new student( 101, "anil", "kumar", "ece","hyd");
          s1.setmarks(70,70,70);
        s1.totalpercentage();
        s1.displaystudentdata();
        Console.ReadLine();


    }

}






