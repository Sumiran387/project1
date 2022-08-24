using System;
class Hello
{
    static void Main()
    {
        int a, b, c;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = a + b;
        Console.WriteLine("Sum is= " + c);
        Console.ReadLine();
    }
}