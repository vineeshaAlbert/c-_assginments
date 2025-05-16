﻿namespace Task5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int original = num;
            int reversed = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }

            if (original == reversed)
                Console.WriteLine($"{original} is a palindrome number.");
            else
                Console.WriteLine($"{original} is not a palindrome number.");
        }

    }
}
