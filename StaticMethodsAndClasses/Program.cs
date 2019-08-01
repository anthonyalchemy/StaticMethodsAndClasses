using System;

namespace StaticMethodsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //static method is a method belongs to class itself 

            Console.WriteLine(Math.Sqrt(144)); //math belongs to c# so dont have to create instance of math class 

            UsefulTools.SayHi("Mike");//static method being called 

         
            


            Console.ReadLine();
        }
    }
}
