using System;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    PerformOperation("add", calculator);
                    break;

                case "2":
                    PerformOperation("subtract", calculator);
                    break;

                case "3":
                    PerformOperation("multiply", calculator);
                    break;

                case "4":
                    PerformOperation("divide", calculator);
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }

        // Method to perform an operation and handle common logic
        static void PerformOperation(string operation, Calculator calculator)
        {
            Console.WriteLine($"Enter 2 numbers to {operation}");
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();

            if (int.TryParse(number1, out int num1) && int.TryParse(number2, out int num2))
            {
                switch (operation)
                {
                    case "add":
                        Console.Write($"{number1} + {number2} = ");
                        Console.Write(calculator.Add(num1, num2));
                        break;

                    case "subtract":
                        Console.Write($"{number1} - {number2} = ");
                        Console.Write(calculator.Subtract(num1, num2));
                        break;

                    case "multiply":
                        Console.Write($"{number1} * {number2} = ");
                        Console.Write(calculator.Multiply(num1, num2));
                        break;

                    case "divide":
                        Console.Write($"{number1} / {number2} = ");
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                        }
                        else
                        {
                            Console.Write(calculator.Divide(num1, num2));
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }
    }
}
