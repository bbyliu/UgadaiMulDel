using System;

namespace MyProject3Prigramm
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителй числа");
            Console.WriteLine("4. Выйти из программы");

            while (true)
            {
                char numb;

                Console.WriteLine("Выберите операцию: ");


                numb = Convert.ToChar(Console.ReadLine());
                if (numb == '4')
                {
                    Environment.Exit(0);
                }

                if (numb == '1')
                {
                    Ugadai();
                }

                if (numb == '2')
                {
                    Mul();
                }

                if (numb == '3')
                {
                    Del();
                }

            }

            static void Ugadai()
            {
                Console.WriteLine("Угадай число от 0 до 100");
                Random rnd = new Random();
                int guess = rnd.Next(1, 100);

                for (int i = 0; i < 100; i++)
                {
                    int enter = Convert.ToInt32(Console.ReadLine());
                    if (enter < guess)
                    {
                        Console.WriteLine("Нужно больше");
                    }
                    if (enter > guess)
                    {
                        Console.WriteLine("Нужно меньше");
                    }
                    else if (enter == guess)
                    {
                        Console.WriteLine("Угадал!");
                        break;
                    }
                }
            }

            static void Mul()
            {
                int[,] tab = new int[10, 10];

                for (int i = 1; i < tab.GetLength(0); i++)
                {
                    for (int j = 1; j < tab.GetLength(1); j++)
                    {
                        tab[i, j] = i * j;
                    }
                }
                for (int i = 1; i < tab.GetLength(0); i++)
                {
                    Console.WriteLine();
                    for (int j = 1; j < tab.GetLength(1); j++)
                    {
                        Console.Write("{0,3}", tab[i, j]);
                    }
                }
                Console.WriteLine();
            }

            static void Del()
            {
                bool d = true;
                while (d)
                {
                    int a;
                    Console.WriteLine("Введите число: ");
                    a = Convert.ToInt32(Console.ReadLine());

                    if (true)
                    {
                        for (int i = 1; i <= a; i++)
                        {
                            if (a % i == 0)
                            {
                                Console.Write(i + "\t");
                            }

                        }
                        Console.WriteLine();
                        Console.WriteLine("Чтобы выйти напиши 'выход'");
                    }
                    if (Console.ReadLine().Equals("выход"))
                    {
                        d = false;
                    }
                }
            }
        }

    }

}