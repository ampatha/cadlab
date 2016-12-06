using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorClient;

namespace CalculatorConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new CalculatorClientClient();
            var result = client.Math.Add(1, 2, "d9f6496e32534b1eb5b45e6f95ec31a6");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
