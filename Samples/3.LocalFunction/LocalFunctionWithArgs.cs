using System;

namespace Samples._3.LocalFunction
{
    public class LocalFunctionWithArgs
    {
        public void CallLocalFuncWithArgs()
        {
            LocalFunctionWithArgs("test");

            void LocalFunctionWithArgs(string arg) 
                => Console.WriteLine(arg);
        }
    }
}
