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
    }
}
