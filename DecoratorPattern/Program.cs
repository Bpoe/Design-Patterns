using System;
using System.IO;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LowercaseTextReader reader = new LowercaseTextReader(new StreamReader("d:\\test.txt"));
            string foo = reader.ReadLine();
            Console.WriteLine(foo);
            Console.Read();
        }
    }
}
