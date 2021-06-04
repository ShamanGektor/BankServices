using System;
using System.Collections.Generic;
using System.Text;

namespace BankServices
{
    class Work
    {
        public void ManagerWork()
        {
            char symbol;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1-Просмотр договоров");
                Console.WriteLine("2-Просмотр с фильтрами");
                Console.WriteLine("3-Подтвердить по ID");
                Console.WriteLine("4-Редактировать договор");
                Console.WriteLine("5-Удалить по ID");
                Console.WriteLine("6-Выход из системы");
                symbol = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (symbol)
                {
                    case '1':
                        Program.person.ShowListContracts();
                        Console.ReadKey();
                        break;
                    case '2':
                        Program.person.ShowtModifiedListContracts();
                        Console.ReadKey();
                        break;
                    case '3':
                        Program.person.ConfirmContract();
                        break;
                    case '4':
                        Program.person.EditContract();
                        break;
                    case '5':
                        Program.person.DeclineContract();
                        break;
                    case '6':
                        return;
                        break;
                }
            }
        }

        public void ClientWork()
        {


            char symbol;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1-Создать договор");
                Console.WriteLine("2-Снять с депозита");
                Console.WriteLine("3-Пополнить депозит");
                Console.WriteLine("4-Открыть депозит");
                Console.WriteLine("5-Просмотр профиля");
                Console.WriteLine("6-Взять кредит");
                Console.WriteLine("7-Выход из системы");
                symbol = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (symbol)
                {
                    case '1':
                        Program.profile.CreateContract();
                        break;
                    case '2':
                        Program.profile.GetFromDeposit();
                        break;
                    case '3':
                        Program.profile.TopUpDeposit();
                        break;
                    case '4':
                        Program.profile.MakeDeposit();
                        break;
                    case '5':
                        Program.profile.ShowProfile();
                        Console.ReadKey();
                        break;
                    case '6':
                        Program.profile.TakeCredit();
                        break;
                    case '7':
                        return;
                        break;
                }

            }
        }
    }
}
