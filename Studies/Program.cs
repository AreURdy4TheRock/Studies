namespace Studies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Артём";
            int myAge = 32;
            const bool myPet = false;
            double sizeLeg = 39.5;

            Console.WriteLine("Меня зовут {0}", myName);
            Console.WriteLine("Мне {0} года", myAge);

            if (myPet)
            {
                Console.WriteLine("У меня есть питомец");
            }
            else Console.WriteLine("У меня нет питомца");

            Console.WriteLine("Мой размер ноги {0}", sizeLeg);
        }
    }
}
