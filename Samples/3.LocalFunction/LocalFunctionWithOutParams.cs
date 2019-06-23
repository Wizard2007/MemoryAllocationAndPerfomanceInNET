using System;

namespace Samples._3.LocalFunction
{
    public class LocalFunctionWithOutParams
    {
        public void CallLocalFunc(int arg)
        {
            LocalFuncWithOutParams();

            void LocalFuncWithOutParams()
            {
                arg = arg + 10;
                Console.WriteLine(arg);
            }
        }
    }
}
