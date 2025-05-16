namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //set empty variable to choice
                int choice;
                do
                {
                    //display choice
                    Console.WriteLine("\n===== Simple Calculator =====");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice (1-5): ");

                    //get choice
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    //condition for calculation choice
                    if (choice >= 1 && choice <= 4)
                    {
                        //get first number
                        Console.Write("Enter first number: ");
                        double firstNumber = Convert.ToDouble(Console.ReadLine());

                        //get second number
                        Console.Write("Enter second number: ");
                        double secondNumber = Convert.ToDouble(Console.ReadLine());


                        switch (choice)
                        {
                            //addition
                            case 1:
                                Console.WriteLine($"Result = {firstNumber + secondNumber}");
                                break;

                            //subraction
                            case 2:
                                Console.WriteLine($"Result = {firstNumber - secondNumber}");
                                break;
                            //multiplication
                            case 3:
                                Console.WriteLine($"Result = {firstNumber * secondNumber}");
                                break;
                            //division
                            case 4:
                                //to handle zero in division
                                if (secondNumber != 0)
                                    Console.WriteLine($"Result = {firstNumber / secondNumber}");
                                else
                                    Console.WriteLine("Error: Division by zero is not allowed.");
                                break;
                        }
                    }
                    //handle exit the program
                    else if (choice == 5)
                    {
                        Console.WriteLine("Exiting calculator. Goodbye!");
                    }
                    else
                    {
                        //invalid choice 
                        Console.WriteLine("Invalid choice. Please choose between 1 and 5.");
                    }

                } while (choice != 5); //exiting the application 
            }
        }
    }

