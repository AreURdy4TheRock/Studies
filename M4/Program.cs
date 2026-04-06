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
    }
}
