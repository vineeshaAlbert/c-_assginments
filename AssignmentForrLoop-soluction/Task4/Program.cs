namespace Task4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int first = 0, second = 1, next;

            Console.WriteLine("Fibonacci Series:");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(first + " ");
                next = first + second;
                first = second;
                second = next;
            }
        }

    }
}
