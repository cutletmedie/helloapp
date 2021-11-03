using System;

namespace HelloApp
{
    class Program
    {
        static void GreetBlack()
        {
            Console.WriteLine("hello black");
        }

        static void GreetWhite()
        {
            Console.WriteLine("hello white");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");
            GreetWhite();
            GreetBlack();
        }
    }
}
