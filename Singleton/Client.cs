using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;

namespace DesignPatterns.Singleton
{
    public static class Client
    {

        public static void Run()
        {
            var singletons = new Singleton[10];
            var notAllEqual = false;

            Parallel.For(0, 10, (i) =>  singletons[i] = Singleton.GetInstance());
            
            for (var i = 0; i < singletons.Length - 1; i++)
            {
                if (singletons[i] != singletons[i+1])
                {
                    notAllEqual = true;
                    break;
                }
            }

            if (notAllEqual)
            {
                Console.WriteLine("More than one objects of Singleton have been created.");
            }
            else
            {
                Console.WriteLine("Only one object of Singleton has been created.");
            }
        }
    }
}