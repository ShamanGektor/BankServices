using System;

namespace BankServices
{
    class Program
    {

        public static Client profile = new Client();
        static void Main(string[] args)
        {
            Work work = new Work();
            while (true)
            {
                Console.WriteLine("Зайти клиентом: 1\nЗайти менеджером: 2\nЗайти кассиром: 3");
                char symbol = Console.ReadKey().KeyChar;
                if (!Convert.ToBoolean(symbol.CompareTo('1')))
                {
                    work.ClientWork();
                }
            }
        }
    }
}
