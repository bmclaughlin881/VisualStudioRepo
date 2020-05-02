using System;
// Namesace
namespace NumberGuesser
{
    //MainClass
    class Program
    {
        // Entry point for the appliacation
        static void Main(string[] args)
        {
            string name = "Brian Mc Laughlin";
            int age = 35;
            //Code start here
            Console.WriteLine("Hello " + name + "!" + " You are " + age + "!");
            Console.WriteLine("Hello {0} ! You are {1} !", name, age);
        }
    }
}
