using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace StaticMethodsAndClasses
{
    static class UsefulTools //will not be able to create an instance in the main method ie usefultools tools = new usefultools();
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello" + name);
        }
    }
}
