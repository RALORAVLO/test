using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            New2 s =new New2(x =>
            {
                x.Age = 5;

            });
            Console.ReadLine();
         

        }

        
    }
}
