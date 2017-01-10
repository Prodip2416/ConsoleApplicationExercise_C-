using System;
namespace StringVsTextStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //string userStr = "Try to ";
            //userStr += "Learning ";
            //userStr += "C# ";
            //userStr += "Console ";
            //userStr += "Application.";

            //StringBuilder userStr = new StringBuilder("Try to ");
            //userStr.Append("Learning ");
            //userStr.Append("C# ");
            //userStr.Append("Console ");
            //userStr.Append("Application.");

            string userStr = string.Empty;
            for(int i = 0; i <= 1000; i++)
            {
                userStr += i.ToString() + " ";
            }

            Console.WriteLine(userStr);
            Console.ReadLine();
        }
    }
}
