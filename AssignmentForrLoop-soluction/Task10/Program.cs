namespace Task10
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int height = 8;
            int width = 5;

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    // Top of 'A'
                    if (row == 0 && (col == 1 || col == 2 || col == 3))
                        Console.Write("*");
                    // Middle horizontal bar of 'A'
                    else if (row == 3)
                        Console.Write("*");
                    // Vertical sides of 'A'
                    else if ((col == 0 || col == 4) && row != 0)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

    }
}
