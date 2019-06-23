using System;
using System.Collections.Generic;

namespace Samples._2.Lambda
{
    public class LambdaRewriteLocalVariable
    {
        public void CallWithRewriteLocalVariable()
        {
            int i = 10;
            int n = 0;
            System.Action action = () => Console.WriteLine($"i = {i}");
            i++;
            n++;
            Console.WriteLine($"i = {i}");

            foreach (var item in GetItems())
            {
                Console.WriteLine(item);
            }

        }

        public static IEnumerable<string> GetItems()
            => new List<string>() { "item 1", "item 2", "item 3" };
    }


}


