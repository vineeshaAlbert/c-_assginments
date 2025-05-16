namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int choice;
                do
                {
                    //display choice
                    Console.WriteLine("\n===== Area Calculator =====");
                    Console.WriteLine("1. Area of Circle");
                    Console.WriteLine("2. Area of Rectangle");
                    Console.WriteLine("3. Area of Triangle");
                    Console.WriteLine("4. Area of Square");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice (1-5): ");

                    //get choice
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            //to get the area of circle
                            Console.Write("Enter radius of the circle: ");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            double circleArea = Math.PI * radius * radius;
                            Console.WriteLine("Area of Circle = " + circleArea);
                            break;

                        case 2:
                            //to get the rectrangle area
                            Console.Write("Enter length of the rectangle: ");
                            double length = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter width of the rectangle: ");
                            double width = Convert.ToDouble(Console.ReadLine());
                            double rectangleArea = length * width;
                            Console.WriteLine("Area of Rectangle = " + rectangleArea);
                            break;

                        case 3:
                            //to get the triangle area
                            Console.Write("Enter base of the triangle: ");
                            double baseT = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter height of the triangle: ");
                            double heightT = Convert.ToDouble(Console.ReadLine());
                            double triangleArea = 0.5 * baseT * heightT;
                            Console.WriteLine("Area of Triangle = " + triangleArea);
                            break;

                        case 4:
                            //to get area of square
                            Console.Write("Enter side of the square: ");
                            double side = Convert.ToDouble(Console.ReadLine());
                            double squareArea = side * side;
                            Console.WriteLine("Area of Square = " + squareArea);
                            break;

                        case 5:
                            //to exit the program
                            Console.WriteLine("Exiting program....... Thank you!!!!!");
                            break;

                        default:
                            //if invalid choice
                            Console.WriteLine("Invalid choice! Please enter a number from 1 to 5.");
                            break;
                    }
                } while (choice != 5);
        }
    }
}
