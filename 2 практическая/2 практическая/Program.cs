namespace Metods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Введите комманду: ");
                Console.WriteLine("1) Игра: Угадай число.");
                Console.WriteLine("2) Таблица умножения.");
                Console.WriteLine("3) Все делители числа.");
                Console.WriteLine("4) Выход.");

                int a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Random();
                        break;
                    case 2:
                        tab();
                        break;
                    case 3:
                        del();
                        break;
                    case 4:
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Выбрана комманда которой нет.");
                        break;

                }
            }
        }

        static void Random()
        {
            Console.WriteLine("В этой игре вам надо найти рандомное число которое загадывает копьютер.");
            Console.WriteLine("Игра началась!!!");
            Random a = new Random();
            int b = a.Next(1, 100);
            bool done = false;
            while (!done)
            {
                Console.Write("Введите число: ");
                int c = int.Parse(Console.ReadLine());
                if (b < c)
                {
                    Console.WriteLine("Требую меньше.");
                }
                else if (b > c)
                {
                    Console.WriteLine("Требую больше.");
                }
                else
                {
                    Console.WriteLine("Верно!!!!");
                    done = true;
                }
            }

        }

        static void tab()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            int[,] arr = new int[10, 10];
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, };
            Console.Write("x/y |\t");
            for (int i = 0; i < arr1.Length; ++i)
            {
                Console.Write(arr1[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("---------------------------------------------------------------------");
            Console.WriteLine();

            for (int i = 1; i < arr.GetLength(0); ++i)
            {
                for (int j = 1; j < arr.GetLength(1);
                    ++j)
                {
                    int sum = i * j;

                    arr[i, j] = sum;
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine("\n\n");
            }



            Console.WriteLine("---------------------------------------------------------------------");

        }

        static void del()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.Write("Введите число: ");
            int i = int.Parse(Console.ReadLine());
            for (int a = 1; a <= i; a++)
            {
                if (i % a == 0) Console.WriteLine("{0} ", a);
            }
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}