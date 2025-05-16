namespace Task7
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the rows: ")
            int rows = Convert.ToInt32(Console.ReadLine()); //get rows from input

            for (int i = 1; i <= rows; i++)
            {
                // Print increasing characters from A
                for (int j = 0; j < i; j++)
                {
                    Console.Write((char)('A' + j) + " ");
                }

                // Print decreasing characters
                for (int j = i - 2; j >= 0; j--)
                {
                    Console.Write((char)('A' + j) + " ");
                }

                Console.WriteLine();
            }

        }
    }
}