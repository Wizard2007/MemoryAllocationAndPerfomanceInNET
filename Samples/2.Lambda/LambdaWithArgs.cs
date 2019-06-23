using System;

namespace Samples._2.Lambda
{
    public class LambdaWithArgs
    {
        public void CreateLambdaWithArgs()
        {
            Action<int> l = (int i) => Console.WriteLine($"i = {i}");
        }
    }
}
