using System;
using System.Collections.Generic;

namespace Samples._4.Enumerators
{
    public class EnamerableFromArray
    {
        public void InitEnumerable()
        {
            IEnumerable<int> enumerator =  new int[] {1,2,3,4};

            foreach (var val in enumerator)
            {
                Console.WriteLine(val.ToString());
            }
        }
    }
}
