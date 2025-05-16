namespace task2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int originalNum = num;
            int sum = 0;

            // Count number of digits
            int digits = num.ToString().Length;

            // Temporary variable to extract digits
            int temp = num;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }

            if (sum == originalNum)
                Console.WriteLine($"{originalNum} is an Armstrong number.");
            else
                Console.WriteLine($"{originalNum} is not an Armstrong number.");
        }

    }
}
