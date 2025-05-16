namespace Task6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter a binary number: ");
            int binary = Convert.ToInt32(Console.ReadLine());
            int decimalNumber = 0;
            int power = 0;

            // Determine number of digits
            int temp = binary;
            int digits = 0;
            for (; temp > 0; digits++)
            {
                temp /= 10;
            }

            // Calculate decimal value
            temp = binary;
            for (int i = 0; i < digits; i++)
            {
                int digit = temp % 10;
                if (digit != 0 && digit != 1)
                {
                    Console.WriteLine("Invalid binary number.");
                    return;
                }
                decimalNumber += digit * (int)Math.Pow(2, i);
                temp /= 10;
            }

            Console.WriteLine($"Decimal equivalent: {decimalNumber}");
        }

    }
}
