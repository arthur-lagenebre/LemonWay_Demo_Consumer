using System;

namespace WebService_Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci(10)");

            Demo.DemoSoapClient webService = new Demo.DemoSoapClient();

            Console.WriteLine(webService.Fibonacci(10));

            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }
}
