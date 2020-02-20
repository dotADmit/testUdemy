using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace testUdemy
{
    class Program

    {
        static void Main(string[] args)
        {











            Console.ReadLine();




        }
        static void Task7()
        {
            string userLogin = "johnsilver";
            string userPassword = "qwerty";

            string result = "";
            int counter = 0;

            while (true)
            {
                Console.Clear();
                Console.Write("Enter login: ");
                string login = Console.ReadLine();
                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (userLogin == login && userPassword == password)
                {
                    result = "Enter the System";
                    break;
                }

                counter++;

                if (counter == 3)
                {
                    result = "The number of available tries have been exceeded.";
                    break;
                }
            }

            Console.WriteLine(result);
        }
        static void Task6()
        {
            Console.Write("Введите число, факториал которого необходимо вычислить: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write($"Result: {Factorial(number)}");
        }
        static int Factorial(int number)
        {
            if (number == 1)
                return 1;

            return number * Factorial(number - 1);
        }
        static void Task5()
        {
            Console.WriteLine(
                    "Введите не более 10 целых положительных чисел.\n"
                  + "Если вы ввели достаточное количество чисел нажмите 0.");

            int res = 0;

            int counter = 0;

            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                    break;
                if (num % 3 == 0)
                {
                    res += num;
                    counter++;
                }

            }

            Console.WriteLine("Cреднее значение целых положительных чисел кратных трём: " + res / counter);
        }
        static void Task4()
        {
            Console.Write("Введите количество чисел Фибоначчи: ");
            int nums = int.Parse(Console.ReadLine());

            int[] numsArray = new int[nums];

            if (nums > 1)
            {
                numsArray[0] = 0;
                numsArray[1] = 1;

                for (int i = 2; i < nums; i++)
                {
                    numsArray[i] = numsArray[i - 1] + numsArray[i - 2];
                }
            }
            else
            {
                numsArray[0] = 0;
            }

            foreach (var item in numsArray)
            {
                Console.Write(item + " ");
            }
        }
        static void Task3()
        {
            Console.WriteLine("Введите Вашу Фамилию: ");
            string sername = Console.ReadLine();
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height in meters: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your weight: ");
            double weight = double.Parse(Console.ReadLine());
            double bodyMassIndex = weight / Math.Pow(height, 2);
            string fullName = sername + " " + name;
            Console.Clear();
            Console.WriteLine($@"Your profile:
Full Name: {fullName} 
Age: {age}
Weight: {weight}
Height: {height}
Body Mass Index: {bodyMassIndex}");

            Console.ReadLine();
        }
        static void Task2()
        {
            Console.Write("Введите стороны треугольника:\nСторона А: ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("Сторона В: ");
            double sideB = double.Parse(Console.ReadLine());

            Console.Write("Сторона C: ");
            double sideC = double.Parse(Console.ReadLine());

            double halfPer = (sideA + sideB + sideC) / 2;
            double sqrt = Math.Sqrt(halfPer * (halfPer - sideA) * (halfPer - sideB) * (halfPer - sideC));
            Console.WriteLine($"Площадь треугольника равна: {sqrt}");
            Console.ReadLine();

        }
        static void Task1()
        {
            Console.Write("Please, enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}.");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Enter two integers: ");
            int a = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Enter two integers: ");
            int b = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"You entered {a} and {b}.");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Values after exchange: {a} and {b}.");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Please, enter a number: ");
            string number = Console.ReadLine();
            Console.WriteLine($"In your number {number.Length} digits.");
        }

        static void Checked()
        {
            checked
            {
                uint x = uint.MaxValue;

                Console.WriteLine(x);

                x = x + 2;

                Console.WriteLine(x);

                x = x - 1;

                Console.WriteLine(x);
            }
        }
        static void StringBuilderDemo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Test ");
            sb.Append("a string");

            Console.WriteLine(sb);
        }

        static void DateDemo()
        {
            DateTime myDate = DateTime.Now;
            Console.WriteLine("Дата в формате d: {0:d}\nВ формате D: {0:D}", myDate);
            Console.WriteLine("Дата в формате f: {0:f}\nВ формате F: {0:F}", myDate);
            Console.WriteLine("Дата в формате g: {0:g}\nВ формате G: {0:G}", myDate);
            Console.WriteLine("Дата в формате m: {0:m}\nВ формате M: {0:M}", myDate);
            Console.WriteLine("Дата в формате r: {0:r}\nВ формате R: {0:R}", myDate);
            Console.WriteLine("Дата в формате o: {0:o}\nВ формате O: {0:O}", myDate);
            Console.WriteLine("Дата в формате s: {0:s}", myDate);
            Console.WriteLine("Дата в формате t: {0:t}\nВ формате T: {0:T}", myDate);
            Console.WriteLine("Дата в формате u: {0:u}\nВ формате U: {0:U}", myDate);
            Console.WriteLine("Дата в формате y: {0:y}\nВ формате Y: {0:Y}", myDate);
        }

    }
}
