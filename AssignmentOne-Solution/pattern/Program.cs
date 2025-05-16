namespace pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter the number to use:");
            int Number =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width:");
            int width = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= width; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(Number);
                }
                Console.WriteLine("\n");
            }

        }
    }
}
