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
            ReverceName();
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
    }
}
