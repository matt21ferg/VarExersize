using System;

namespace VarExersize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "matt";
            int age = 20;
            char intial = 't';
            bool married = false;
            if (married == true)
            {
                name = "MR.matt";
            }
            double whieght = 200.6;
            decimal hight = 129.52m;
            Console.WriteLine($"Hi my name is {name} I'm { age} years old and my midlle intial is {intial}!"!);

            Console.WriteLine($"I am {whieght} pounds and{hight}inches tall! ");


        }
    }
}
