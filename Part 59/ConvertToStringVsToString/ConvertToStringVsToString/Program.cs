using System;
public class MainClass
{
    public static void Main()
    {
        Customer C1 = null;
         Console.WriteLine(C1.ToString());
       // Console.WriteLine(Convert.ToString(C1));

        Console.ReadLine();
    }
}
public class Customer
{
    public string Name { get; set; }
}