using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            clsFuncExecution objfun = new clsFuncExecution();
            string retVal = objfun.funcexecution(args[0], args[1]);
            Console.Write(retVal);
            Console.Read();
        }

    }



}


