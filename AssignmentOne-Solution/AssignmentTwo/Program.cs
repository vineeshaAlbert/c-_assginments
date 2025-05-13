namespace AssignmentTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //get the distance value
            Console.Write("Enter the distance:");
            int distance = Convert.ToInt32(Console.ReadLine());
            //get the time value
            Console.Write("Enter the time:");
            int time = Convert.ToInt32(Console.ReadLine());
            //calcluate the speed
            int speed = distance / time;
            double speedmiles = distance * 0.621371;
            //display the result
            Console.WriteLine($"The speed in killometer per hour is: {speed}");
            Console.WriteLine($"The speed in miles per hour is: {speedmiles}");
        }
    }
}
