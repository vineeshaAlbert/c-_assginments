namespace task1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Enter the limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            // Upper half
            for (int i = 1; i <= limit; i++)
            {
                // Print spaces
                for (int j = 1; j <= limit - i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars (odd numbers: 1, 3, 5...)
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // Lower half
            for (int i = limit - 1; i >= 1; i--)
            {
                // Print spaces
                for (int j = 1; j <= limit - i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }
}
