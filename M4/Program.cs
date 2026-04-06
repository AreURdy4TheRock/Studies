namespace M4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A = "A";
            string B = "B";
            bool C = A != B;
            Console.WriteLine(C);
            AbXy();
            IfElse();

            Console.WriteLine(Ternar(6, 7));
            SwitchColor();
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
            string testString = Console.ReadLine();
            if (testString == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Your color is red");
            }
            else if (testString == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Your color is green");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Your color is cyan");
            }
        }
    }
}
