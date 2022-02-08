using System;
namespace tip_donusmalari
{
    class Program
    {
        static void Main(string[] args)
        {
        short s = 2;
        byte b = 6;
        Console.WriteLine(s);
        Console.WriteLine(b);
        int i = b;
        short s1 = b;
        long l = 35;
        int i2 = (int)l;
        Console.WriteLine(i);
        Console.WriteLine(s1);
        Console.WriteLine(l);
        Console.WriteLine(i2);
        Console.WriteLine("---------------------");

        string t = "Merhaba";
        string t1 = "35";
        float f = 5.35f;
        Console.WriteLine(t);
        Console.WriteLine(t1);
        Console.WriteLine(f);
        string f1 = f.ToString();
        Console.WriteLine(f1);
        object o = t + t1 + f;
        Console.WriteLine(o);
        


        }
    }
}

