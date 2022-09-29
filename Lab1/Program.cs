using System;


namespace ConsoleApp1
{
    class Program
    {
        static void CalculatingRadiusKnowingLength()
        {
            Console.WriteLine("Task 1.13...\n\nInput length: ");
            String length = Console.ReadLine();
            Console.WriteLine("\nRadius of the circle with length " + length + " = " + double.Parse(length) / (2 * Math.PI));
            Console.ReadLine();
        }
        static void ComparingThreeDigitNumber()
        {
            Console.WriteLine("Task 2.13...\n");
            int first_digit, second_digit, third_digit;
            do
            {
                Console.WriteLine("\nCorrect input >=0 and <=9. First digit should be >=1 \nInput first digit: ");
                first_digit = int.Parse(Console.ReadLine());
                Console.WriteLine("\nInput second digit: ");
                second_digit = int.Parse(Console.ReadLine());
                Console.WriteLine("\nInput third digit: ");
                third_digit = int.Parse(Console.ReadLine());
            } while (!((first_digit) >= 1 && (second_digit | third_digit) >= 0 && (first_digit | second_digit | third_digit) <= 9));
            Console.WriteLine("You entered " + first_digit + second_digit + third_digit);
            if (first_digit > third_digit)
            {
                Console.WriteLine(first_digit + " > " + third_digit);
            }
            else if (first_digit < third_digit)
            {
                Console.WriteLine(first_digit + " < " + third_digit);
            }
            else
            {
                Console.WriteLine(first_digit + " = " + third_digit);
            }
            Console.ReadLine();
        }
        static void IsXYonCoordinateSystem()
        {
            int x, y;
            Console.WriteLine("Task 3.13...\nInput x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Input y: ");
            y = int.Parse(Console.ReadLine());
            if (((x >= 0 && x <= 70) && y == 0) || (y == x && x >= 0 && x <= 70) || (x == 70 && y >= 0 && y <= 70))
            {
                Console.WriteLine("Your point is on the edge of the shaded area");
            }
            else if (x >0 && x <70 && y<x && y>0)
            {
                Console.WriteLine("Your point is on the shaded area");
            }
            else
            {
                Console.WriteLine("Your point is NOT on the shaded area");
            }
            Console.ReadLine();
        }
        static void ConvertingTestMark()
        {
            int test_mark;
            Console.WriteLine("Task 4.13...\nInput your test mark: ");
            test_mark = int.Parse(Console.ReadLine());
            switch (test_mark)
            {
                case int n when (n >= 90 && n <= 100): Console.WriteLine("\nExcellent result! You've got " + test_mark + "!"); break;
                case int n when (n >= 70 && n <= 89): Console.WriteLine("\nGood result! You've got " + test_mark + "!"); break;
                case int n when (n >= 50 && n <= 69): Console.WriteLine("\nSatisfying result. You've got " + test_mark); break;
                case int n when (n < 50): Console.WriteLine("\nUnsatisfying result. You've got " + test_mark + "!"); break;
                default: Console.WriteLine("\nYou entered a wrong number...Try again"); break;
            }
            Console.ReadLine();
        }
        static void SquareSumOfTwoNumbers()
        {
            double first_number, second_number;
            Console.WriteLine("Task 5.13...\nInput first number: ");
            first_number = double.Parse(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            second_number = double.Parse(Console.ReadLine());
            Console.WriteLine("Squaring the sum of two numbers. The Result is... " + Math.Pow(first_number + second_number, 2) + " !");
            Console.ReadLine();
        }
        static void CalculatingTheExpression()
        {
            double x, y;
            Console.WriteLine("Task 6.13...\nInput x: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Input y: ");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Result is... " + (((y * y + 4) / (x * x + 2 * x + 5)) + 1) * x);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\tLab 1\nThere are tasks with numbers 1.13, 2.13, 3.13, 4.13, 5.13, 6.13\nChoose the one you want to start:");
                String task_number = Console.ReadLine();
                switch (task_number)
                {
                    case "1.13": CalculatingRadiusKnowingLength(); break;
                    case "2.13": ComparingThreeDigitNumber(); break;
                    case "3.13": IsXYonCoordinateSystem(); break;
                    case "4.13": ConvertingTestMark(); break;
                    case "5.13": SquareSumOfTwoNumbers(); break;
                    case "6.13": CalculatingTheExpression(); break;
                    default: Console.WriteLine("You've chosen a wrong number. There is no such a task"); Console.ReadLine(); break;

                }

            }
        }
    }
}
