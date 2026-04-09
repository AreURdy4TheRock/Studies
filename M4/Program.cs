using static System.Runtime.InteropServices.JavaScript.JSType;

namespace M4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A = "A";
            string B = "B";
            bool C = A != B;
            //Console.WriteLine(C);
            //AbXy();
            //IfElse();

            //Console.WriteLine(Ternar(6, 7));
            //SwitchColor();

            // NumberSum();
            //ReverceName();
            //ArraySort();
            //ArraySum();
            //ZubArray();
            TwoArray();
        }
        static void  AbXy()
        {
            int A = 1;
            int B = 2;
            double X = 1.2;
            double Y = 2.0;
            bool c = (A < B) | (X > Y);
            Console.WriteLine(c);
        }
        static void IfElse()
        {
            var a = 1;
            var b = 2;

            if (a != b)
            {
                Console.WriteLine("Условие верно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            }
        }
        static int Ternar(int a, int b)
        {
            var c = a != b ? a+b : 0;
            return c;
        }

        static void SwitchColor()
        {
            Console.WriteLine("Введите свой любимий цвет на английском языке");
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Итерация {0}", i);
                string testString = Console.ReadLine();
                switch (testString)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is red!");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your color is yellow!");
                        break;
                }
            }
        }
        static void NumberSum()
        {
            Console.WriteLine("Введите число");
            int sum = 0;
            while (true)
            {
                var number = Convert.ToInt32(Console.ReadLine());
                if (number < 0)
                {
                    continue;
                }
                else if (number == 0)
                {
                    break;
                }
                sum += number;
            }
            Console.WriteLine("Итоговая сумма " + sum);
        }
        static void ReverceName()
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Ваше имя наоборот:");
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }
        }

        static void ArraySort()
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            var sortArr = new int[arr.Length];
            int sorted = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1;  j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        sorted = arr[i];
                        arr[i] = arr[j];
                        arr[j] = sorted;
                    }
                }
                sortArr[i] = sorted;
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        static void ArraySum()
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            Console.WriteLine("Сумма всех элементов массива = " + sum);
        }

        static void ZubArray()
        {
            int[][] array = new int[3][];
            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };
            foreach(int item in array[0])
            {
                Console.Write(item + " ");
            }
            foreach (int item in array[1])
            {
                Console.Write(item + " ");
            }
            foreach (int item in array[2])
            {
                Console.Write(item + " ");
            }
        }

        static void TwoArray()
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int sum = 0;
            foreach (int item in arr)
            {
                if (item > 0)
                {  
                    sum+= item; 
                }
            }
            Console.WriteLine("Сумма всех положительных чисел двумерного массиа = " + sum);
        }
    }
}
