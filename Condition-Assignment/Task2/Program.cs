/*
 Write a C# program to accept a coordinate point in an XY 
coordinate system and determine in which quadrant the 
coordinate point lies. 
 */


namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Hello, World!");
            //Get the value of x
            Console.Write("Enter the value of x:");
            int x =int.Parse(Console.ReadLine());
            //Get the value of y
            Console.Write("Enter the value of y:");
            int y =int.Parse(Console.ReadLine());
            //check both value are positive display first quadrant
            if (x > 0 && y > 0)
            {
                Console.WriteLine("It is First Quadrant.");
            }
            //check x is postive y is negative display second quadrant
            else if(x > 0 && y < 0)
            {
                Console.WriteLine("It is Second Quadrant.");
            }
            //check both are negative disply third quadrant
            else if(x < 0 && y < 0)
            {
                Console.WriteLine("It is Third Quadrant.");

            }
            //check x and y display the fouth Quadrant
            else
            {
                Console.WriteLine("It is Fourth Quadrant.");
            }
        }
    }
}
