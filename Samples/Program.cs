using System;
using Samples._1.Boxing;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxingValueType = new BoxingValueType();
            boxingValueType.WriteToConsole();
            Console.ReadKey();
        }
    }
}
