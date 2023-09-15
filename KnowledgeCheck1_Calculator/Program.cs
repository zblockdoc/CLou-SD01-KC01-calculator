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
                    Console.WriteLine("Enter 2 integers to add");
                    var addNumber1 = Console.ReadLine();
                    var addNumber2 = Console.ReadLine();

                    if (int.TryParse(addNumber1, out int addNumOne) && int.TryParse(addNumber2, out int addNumTwo))
                    {
                        Console.Write($"{addNumber1} + {addNumber2} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    var subtractNumber1 = Console.ReadLine();
                    var subtractNumber2 = Console.ReadLine();

                    if (int.TryParse(subtractNumber1, out int subNumOne) && int.TryParse(subtractNumber2, out int subNumTwo))
                    {
                        Console.Write($"{subtractNumber1} - {subtractNumber2} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter 2 numbers to multiply");
                    var multiplyNumber1 = Console.ReadLine();
                    var multiplyNumber2 = Console.ReadLine();

                    if (double.TryParse(multiplyNumber1, out double mulNumOne) && double.TryParse(multiplyNumber2, out double mulNumTwo))
                    {
                        double result = calculator.Multiply(mulNumOne, mulNumTwo);
                        Console.WriteLine($"{multiplyNumber1} * {multiplyNumber2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not a valid number");
                    }
                    break;


                case "4":
                    Console.WriteLine("Enter 2 integers to divide"); // Changed the input message
                    var divideNumber1 = Console.ReadLine();
                    var divideNumber2 = Console.ReadLine();

                    if (int.TryParse(divideNumber1, out int divNumOne) && int.TryParse(divideNumber2, out int divNumTwo))
                    {
                        Console.Write($"{divideNumber1} / {divideNumber2} = "); // Changed the operator
                        if (divNumTwo == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                        }
                        else
                        {
                            Console.Write(calculator.Divide(divNumOne, divNumTwo)); // Corrected the method call
                        }
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}
