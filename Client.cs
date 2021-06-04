using System;
using System.Collections.Generic;
using System.Text;

namespace BankServices
{
    class Client
    {
        public void CreateContract()
        {
            Console.Clear();
            Console.WriteLine("Введите данные договора: ");
            Contract newcontract = new Contract();
            newcontract.setID(Convert.ToInt32(Console.ReadLine()));
            newcontract.setFileName(Console.ReadLine());
            newcontract.setType(Console.ReadLine());
            ListOfContract.getInstance().Add(newcontract);
        }

        public void GetFromDeposit()
        {
            Console.WriteLine("Введите номер депозита и сумму для снятия: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double body = Convert.ToDouble(Console.ReadLine());
            Program.cashier.GiveMoney(number, body);
        }

        public void TopUpDeposit()
        {
            Console.WriteLine("Введите номер депозита и сумму: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double body = Convert.ToDouble(Console.ReadLine());
            Program.cashier.TakeMoney(number, body);
        }

        public void MakeDeposit()
        {
            Deposit newdeposit = new Deposit();
            Console.WriteLine("Введите данные депозита: ");
            newdeposit.setNumber(Convert.ToInt32(Console.ReadLine()));
            newdeposit.setBody(Convert.ToDouble(Console.ReadLine()));
            newdeposit.setPercent(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Валюта депозита: 1-Рубли, 2 -Доллары: ");
            char symbol = Console.ReadKey().KeyChar;
            if (!Convert.ToBoolean(symbol.CompareTo('1')))
            {
                newdeposit.setCurrencyType(type.Rubbles);
            }
            else
            {
                newdeposit.setCurrencyType(type.Dollar);
            }
            ClientProfile.getInstance().Add(newdeposit);
        }

        public void TakeCredit()
        {
            Credit newcredit = new Credit();
            Console.WriteLine("Введите данные кредита: ");
            newcredit.setNumber(Convert.ToInt32(Console.ReadLine()));
            newcredit.setBody(Convert.ToDouble(Console.ReadLine()));
            newcredit.setPercent(Convert.ToDouble(Console.ReadLine()));
            newcredit.setData(Convert.ToDateTime(Console.ReadLine()));
            newcredit.setPeriod(Convert.ToInt32(Console.ReadLine()));
            ClientProfile.getInstance().Add(newcredit);
        }

        public void ShowProfile()
        {
            ClientProfile.getInstance().ShowList();
        }
    }
}
