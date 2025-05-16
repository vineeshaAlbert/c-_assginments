/*
 Write a C# program to read the age of a candidate and 
determine whether it is eligible for casting his/her own 
vote
 */

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Hello, World!");
            // get the canitidate age
            Console.Write("Entern the candidate age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            // Check the condition and display the output
            if (age >= 18)
            {
                Console.WriteLine("The candidate is eligible for vote.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for vote.");
            }
        }
    }
}
