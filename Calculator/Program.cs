using BusinessLogic;
using System;
using System.Numerics;
using System.Threading.Channels;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userEntry, firstNumber, secondNumber, exit = "Exit";
            decimal Result;

            do
            {
                Console.WriteLine("Welcome To My Calculator:\n" +
                    "Select One Of The Options:\n" +
                    "1. Add Two Numbers\n" +
                    "2. Substract Two Numbers\n" +
                    "3. Multiply Two Numbers\n" +
                    "4. Divide Two Numbers\n" +
                    "5. Power Of A Number\n" +
                    "6. The Square Root Of A Number\n");

                Console.WriteLine("Please Enter Your Selection:");
                userEntry = Console.ReadLine();
                while (userEntry == "" || userEntry == "")
                {
                    Console.WriteLine("Please Enter A Number.");
                    userEntry = Console.ReadLine();
                }
                CheckNumberAndConvertIfPossible(userEntry);

                switch (userEntry)
                {
                    case "1":
                        Console.Write("Enter The First Number: ");
                        firstNumber = Console.ReadLine();
                        Console.Write("Enter The Second Number: ");
                        secondNumber = Console.ReadLine();
                        Result = Calculator.AddNumbers(CheckNumberAndConvertIfPossible(firstNumber), CheckNumberAndConvertIfPossible(secondNumber));
                        Console.WriteLine($"\n{firstNumber} + {secondNumber} = {Result}\n");
                        break;

                    case "2":
                        Console.Write("Enter The First Number: ");
                        firstNumber = Console.ReadLine();
                        Console.Write("Enter The Second Number: ");
                        secondNumber = Console.ReadLine();
                        Result = Calculator.SubNumbers(CheckNumberAndConvertIfPossible(firstNumber), CheckNumberAndConvertIfPossible(secondNumber));
                        Console.WriteLine($"\n{firstNumber} - {secondNumber} = {Result}\n");
                        break;

                    case "3":
                        Console.Write("Enter The First Number: ");
                        firstNumber = Console.ReadLine();
                        Console.Write("Enter The Second Number: ");
                        secondNumber = Console.ReadLine();
                        Result = Calculator.MultiplyNumbers(CheckNumberAndConvertIfPossible(firstNumber), CheckNumberAndConvertIfPossible(secondNumber));
                        Console.WriteLine($"\n{firstNumber} * {secondNumber} = {Result}\n");
                        break;

                    case "4":
                        Console.Write("Enter The First Number: ");
                        firstNumber = Console.ReadLine();
                        Console.Write("Enter The Second Number: ");
                        secondNumber = Console.ReadLine();
                        Result = Calculator.DivideNumbers(CheckNumberAndConvertIfPossible(firstNumber), CheckNumberAndConvertIfPossible(secondNumber));
                        Console.WriteLine($"\n{firstNumber} / {secondNumber} = {Result}\n");
                        break;

                    case "5":
                        Console.Write("Enter The Base Number: ");
                        firstNumber = Console.ReadLine();
                        Console.Write("Enter The Power Number: ");
                        secondNumber = Console.ReadLine();
                        Result = Calculator.ToThePowerOf(CheckNumberAndConvertIfPossible(firstNumber), CheckNumberAndConvertIfPossible(secondNumber));
                        Console.WriteLine($"\n{firstNumber} ^ {secondNumber} = {Result}\n");
                        break;

                    case "6":
                        Console.Write("Enter A Number: ");
                        firstNumber = Console.ReadLine();
                        Result = Calculator.SquareRoot(CheckNumberAndConvertIfPossible(firstNumber));
                        Console.WriteLine($"\nThe Square Root Of {firstNumber} = {Result}\n");
                        break;
                    case "Exit":
                    case "exit":
                        Console.WriteLine("\nThank You For Using My Calculator, Exiting...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nPlease Enter A Valid Input.\n");
                        break;
                }
            } while (userEntry != exit);
        }
        public static decimal CheckNumberAndConvertIfPossible(string number)
        {
            if ((number.CompareTo("Exit") != 0) && (number.CompareTo("exit") != 0))
            {
                try
                {
                    Convert.ToDecimal(number);
                }
                catch (Exception e)
                {
                    throw new InvalidInputException("Invalid Entry, Please Enter A Valid Number.", e); //I wanted to handle it and make the application restart, couldn't do it
                }
                return Convert.ToDecimal(number);
            }
            else
            {
                return 0;
            }
        }
    }
}