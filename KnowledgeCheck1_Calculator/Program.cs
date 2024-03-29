using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    int addNumber1 = 0;
                    int addNumber2 = 0;

                    try
                    {
                        UserInputHelper.PromptForTwoNumbers(ref addNumber1, ref addNumber2);
                    }
                    catch
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }

                        Console.Write($"{addNumber1} + {addNumber2} = ");
                        Console.Write(calculator.Add(addNumber1, addNumber2));

                        Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    int subtractNumber1 = 0;
                    int subtractNumber2 = 0;

                    try
                    {
                        UserInputHelper.PromptForTwoNumbers(ref subtractNumber1, ref subtractNumber2);
                    }
                    catch
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter 2 intrgers to muiltply");
                    int multiplyNumber1 = 0;
                    int multiplyNumber2 = 0;

                    try
                    {
                        UserInputHelper.PromptForTwoNumbers(ref multiplyNumber1, ref multiplyNumber2);
                    }
                    catch
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    int divideNumber1 = 0;
                    int divideNumber2 = 0;

                    try
                    {
                        UserInputHelper.PromptForTwoNumbers(ref divideNumber1, ref divideNumber2);
                    }
                    catch
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}