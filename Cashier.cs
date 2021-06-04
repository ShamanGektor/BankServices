using System;
using System.Collections.Generic;
using System.Text;

namespace BankServices
{
    class Cashier
    {
        private Cash cash = new Cash();

        public void GiveCredit()
        {
            Credit newcredit = new Credit();
            Console.WriteLine("Введите данные кредита клиента: ");
            newcredit.setNumber(Convert.ToInt32(Console.ReadLine()));
            newcredit.setBody(Convert.ToDouble(Console.ReadLine()));
            newcredit.setPercent(Convert.ToDouble(Console.ReadLine()));
            newcredit.setData(Convert.ToDateTime(Console.ReadLine()));
            newcredit.setPeriod(Convert.ToInt32(Console.ReadLine()));
            ClientProfile.getInstance().Add(newcredit);
        }

        public void TakeMoney(int number, double body)
        {
            Deposit contribution = (Deposit)ClientProfile.getInstance().FindContribution(number);
            CurrencyQuantity money;
            money.e = contribution.getCurrencyType();
            money.quantity = body;
            cash.AcceptMoney(money);
            ClientProfile.getInstance().EditContribution(number, body);
        }

        public void GiveMoney(int number, double body)
        {
            Contribution contribution = ClientProfile.getInstance().FindContribution(number);
            if (contribution.getBody() >= body)
            {
                CurrencyQuantity w;
                w.quantity = body;
                w.e = type.Rubbles;
                if (cash.GiveMoney(w))
                {
                    ClientProfile.getInstance().EditContribution(number, -body);
                }
                else
                {
                    Console.WriteLine("Error: недостаточно средств в кассе");
                    Console.ReadKey();
                }
            }

        }

        public void Exchenged()
        {
            CurrencyQuantity money;
            CurrencyQuantity money1;
            Console.WriteLine("Введите данные для обмена: ");
            money.quantity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Валюта принятия: 1-Рубли, 2 -Доллары: ");
            char symbol = Console.ReadKey().KeyChar;
            if (!Convert.ToBoolean(symbol.CompareTo('1')))
            {
                money.e = type.Rubbles;
            }
            else
            {
                money.e = type.Dollar;
            }
            Console.WriteLine("Валюта выдачи: 1-Рубли, 2 -Доллары: ");
            symbol = Console.ReadKey().KeyChar;
            if (!Convert.ToBoolean(symbol.CompareTo('1')))
            {
                money1.e = type.Rubbles;
            }
            else
            {
                money1.e = type.Dollar;
            }
            money1.quantity = 0;
            cash.Exchange(money, money1);
        }
    }
}
