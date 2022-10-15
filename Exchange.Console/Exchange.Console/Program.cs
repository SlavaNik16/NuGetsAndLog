using System;
using Exchange.Core;
namespace Exchange.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var exchange = new ExchangeCore(65.11m);
            var result =  exchange.Cal(70); 
            Console.WriteLine($"{result:C2}");

        }
    }
}
