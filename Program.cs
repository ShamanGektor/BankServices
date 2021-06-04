using System;

namespace BankServices
{
    public enum type
    {
        Rubbles,
        Dollar
    }
    public struct CurrencyQuantity
    {
        public type e;
        public double quantity;
    }

    class Program
    {
        public static Cashier cashier = new Cashier();

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
                else
                {
                    work.CashierWork();
                }
            }
        }
    }
}
