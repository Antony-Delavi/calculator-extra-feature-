using System;
using System.Diagnostics;

namespace SimpleCalculator{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Calculator \r\n2. Sheeps counter(Extra feature) \r\nType 1 or 2: ");
            char answer = char.Parse(Console.ReadLine());
            switch (answer) {
                case '1':
                Console.WriteLine("Which arithmetic operation do you want to use?(+, -, *, /): ");
                char charArithOperation = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter the first number:");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                double secondNumber = double.Parse(Console.ReadLine());

                Console.WriteLine("The result of the operation is: " + calculating(firstNumber, secondNumber, charArithOperation));
                    break;

                case '2':
                Console.WriteLine("How much sheeps you need?");
                int sheepsNeeded = int.Parse(Console.ReadLine());
                    sheepsss(sheepsNeeded);
                    break;                   
            }
        }

        public static double calculating(double num1, double num2, char arithmeticOperation)
        {
            switch (arithmeticOperation)
            {
                case '+':
                    return num1 + num2;
                    break;
                case '-':
                    return num1 - num2;
                    break;
                case '*':
                    return num1 * num2;
                    break;
                case '/':
                    return num1 / num2;
            }
            return 0.1f;
        }

        public static string sheepsss(int numberOfSheeps)
        {
            for (int i = 0; i < numberOfSheeps; i++)
            {
                Console.Write($"{i + 1} Sheeps... ");
            }
            return "";
        }
    }
}