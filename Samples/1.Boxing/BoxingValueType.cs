using System;

namespace Samples._1.Boxing
{
    public class BoxingValueType
    {
        public void WriteToConsole()
        {
            var i = 10;

            Console.WriteLine("i = {0}", i);
            Console.WriteLine($"i = {i}");
            Console.WriteLine("i = {0}", i.ToString());
        }
    }
}
