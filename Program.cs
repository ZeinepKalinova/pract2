using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practika02
{
    internal class Program
    {
        static void Exmpl035()
        {
            Console.WriteLine("Введите свое имя: ");
            string firstname = Console.ReadLine();

            Console.WriteLine("Введите свою фамилию: ");
            string lastname = Console.ReadLine();

            Console.WriteLine("Введите свое очество: ");
            string middlename = Console.ReadLine();

            Console.WriteLine("Приветствую тебя - " + lastname + " " + firstname + " " + middlename);
        }

        static void Exmpl045()
        {
            int x = 0, y = 0, z = 0;
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();







            if (Int32.TryParse(a, out x) == false || Int32.TryParse(b, out y) == false || Int32.TryParse(c, out z) == false)
            {
                Console.WriteLine("Введите корекные число");
            }
            else
            {
                //x = Convert.ToInt32(a);
                //y = Convert.ToInt32(b);
                //z = Convert.ToInt32(c);


                Console.WriteLine("Ответ: " + (x + y + z));
            }


        }

        static void Exmpl01()
        {
            int a = 10;
            int b = 20;
            int c = 30;

            Console.WriteLine($"{a}  {b}  {c}");
        }
        static void Exmpl02()
        {
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);
        }
        static void Exmpl03()
        {
            int cm = 245;
            int m = cm / 100;

            Console.WriteLine($"Число полных метров: {m}");
        }
        static void Exmpl04()
        {
            int days = 234;
            int weeks = days / 7;

            Console.WriteLine($"Полных недель прошло: {weeks}");
        }
        static void Exmpl05()
        {
            int number = 36;

            int tens = number / 10;
            int ones = number % 10;
            int sum = tens + ones;
            int product = tens * ones;

            Console.WriteLine($"Число десятков: {tens}");
            Console.WriteLine($"Число единиц: {ones}");
            Console.WriteLine($"Сумма цифр: {sum}");
            Console.WriteLine($"Произведение цифр: {product}");
        }
        static void Exmpl06()
        {
            bool A = true;
            bool B = false;
            bool C = false;

            bool resultA = A || B;

            bool resultB = A && B;

            bool resultC = B || C;

            Console.WriteLine($"A или B: {resultA}");
            Console.WriteLine($"A и B: {resultB}");
            Console.WriteLine($"B или C: {resultC}");
        }
        static void Exmpl07()
        {
            double radius = 5.0;
            double side = 6.0;

            double areaCircle = Math.PI * radius * radius;
            double areaSquare = side * side;

            if (areaCircle > areaSquare)
            {
                Console.WriteLine("Площадь круга больше.");
            }
            else if (areaCircle < areaSquare)
            {
                Console.WriteLine("Площадь квадрата больше.");
            }
            else
            {
                Console.WriteLine("Площади равны.");
            }
        }
        static void Exmpl08()
        {
            double volume1 = 1000;
            double mass1 = 500;

            double volume2 = 800;
            double mass2 = 400;

            double density1 = mass1 / volume1;
            double density2 = mass2 / volume2;

            if (density1 > density2)
            {
                Console.WriteLine("Плотность первого тела больше.");
            }
            else if (density1 < density2)
            {
                Console.WriteLine("Плотность второго тела больше.");
            }
            else
            {
                Console.WriteLine("Плотности равны.");
            }
        }
        static void Exmpl09()
        {
            double resistance1 = 10.0;
            double voltage1 = 12.0;

            double resistance2 = 15.0;
            double voltage2 = 10.0;

            double current1 = voltage1 / resistance1;
            double current2 = voltage2 / resistance2;

            if (current1 < current2)
            {
                Console.WriteLine("Меньший ток протекает по первому участку.");
            }
            else if (current1 > current2)
            {
                Console.WriteLine("Меньший ток протекает по второму участку.");
            }
            else
            {
                Console.WriteLine("Токи равны на обоих участках.");
            }
        }
        static void Exmpl10a()
        {
            //a
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Exmpl10b()
        {
            //b
            Console.Write("Введите значение b (b > 10): ");
            int b = int.Parse(Console.ReadLine());

            for (int i = 10; i <= b; i++)
            {
                int square = i * i;
                Console.WriteLine(square);
            }
        }
        static void Exmpl10c()
        {
            //c
            Console.Write("Введите значение a (a < 50): ");
            int a = int.Parse(Console.ReadLine());

            for (int i = a; i <= 50; i++)
            {
                int cube = i * i * i;
                Console.WriteLine(cube);
            }
        }
        static void Exmpl10d()
        {
            //d
            Console.Write("Введите значение a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение b (b > a): ");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Exmpl01();
            Exmpl02();
            Exmpl03();
            Exmpl04();
            Exmpl05();
            Exmpl06();
            Exmpl07();
            Exmpl08();
            Exmpl09();
            Exmpl10a();
            Exmpl10b();
            Exmpl10c();
            Exmpl10d();

            Console.ReadKey();
        }
    }
}

