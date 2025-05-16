/*
 Write a C# program to find the eligibility of admission for 
a professional course based on the following criteria: 
Marks in Maths >=65 
Marks in Phy >=55 
Marks in Chem>=50 
Total in all three subject >=180 
or 
Total in Math and Subjects >=140
 */

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!"
            //Get input values ferom user
            Console.Write("Enter the maths mark:");
            int maths = int.Parse(Console.ReadLine());
            Console.Write("Enter the physics mark:");
            int physics = int.Parse(Console.ReadLine());
            Console.Write("Enter the chemistry mark:");
            int chemistry = int .Parse(Console.ReadLine());
            //calculate total
            int total = maths + physics + chemistry;
            int subtotal = physics + chemistry;
            //check the condition and display
            if (maths >= 65 && physics >= 55 && chemistry >= 50 || total >= 180 || subtotal >= 140)
            {
                Console.WriteLine("Eligible for admission");
            }
            else
            {
                Console.WriteLine("Not Eligible for admission");
            }


        }
    }
}
