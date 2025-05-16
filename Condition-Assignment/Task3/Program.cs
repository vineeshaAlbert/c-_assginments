/*
 Write a C# program to read roll no, name and marks of 
three subjects and calculate the total, percentage and 
division 
 */

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get the value of rollno,name and 3 subject marks
            Console.Write("Enter the rollno:");
            String Rollno = Console.ReadLine();
            Console.Write("Enter the name:");
            String Name = Console.ReadLine();
            Console.Write("Enter the maths mark:");
            int maths = int.Parse(Console.ReadLine());
            Console.Write("Enter the physics mark:");
            int physics = int.Parse(Console.ReadLine());
            Console.Write("Enter the chemistry mark:");
            int chemistry = int.Parse(Console.ReadLine());
            //Calculate the total mark
            int total= maths + physics + chemistry;
            Console.WriteLine($"The Total mark:{total}");
            //Calculate the percentage
             decimal percentage = (total * 100) / 300;
            Console.WriteLine($"The percent:{percentage}");
            // give a grade based on conndition
            if (percentage <= 100 && percentage >= 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (percentage >= 60 && percentage < 80)
            {
                Console.WriteLine("Grade B");
            }
            else if (percentage >= 40 && percentage < 60)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Failed");
            }


        }
    }
}
