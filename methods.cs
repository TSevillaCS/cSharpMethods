using System;

namespace cSharpMethods
{
    class Program
    {
        //Method to add two numbers
        static int Addition(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            //print out the method, adding two numbers
            Console.WriteLine(Addition(10,15));
        }
    }
}
