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
            Console.WriteLine("Введите данные договора:");
            Contract newcontract = new Contract();
            Console.WriteLine("ID ");
            newcontract.setID(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Имя файла ");
            newcontract.setFileName(Console.ReadLine());
            Console.WriteLine("Тип ");
            newcontract.setType(Console.ReadLine());
            ListOfContract.getInstance().Add(newcontract);
        }

        public void GetFromDeposit()
        {
            Console.WriteLine("Введите номер депозита для снятия: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сумму: ");
            double body = Convert.ToDouble(Console.ReadLine());
            Program.cashier.GiveMoney(number, body);
        }

        public void TopUpDeposit()
        {
            Console.WriteLine("Введите номер депозита для снятия: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сумму: ");
            double body = Convert.ToDouble(Console.ReadLine());
            Program.cashier.TakeMoney(number, body);
        }

        public void MakeDeposit()
        {
            Deposit newdeposit = new Deposit();
            Console.WriteLine("Введите данные депозита: ");
            Console.WriteLine("Номер ");
            newdeposit.setNumber(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Тело депозита ");
            newdeposit.setBody(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Процент ");
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
            Console.WriteLine("Номер ");
            newcredit.setNumber(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Тело кредита ");
            newcredit.setBody(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Процент ");
            newcredit.setPercent(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Дату открытия ");
            newcredit.setData(Convert.ToDateTime(Console.ReadLine()));
            Console.WriteLine("Период ");
            newcredit.setPeriod(Convert.ToInt32(Console.ReadLine()));
            ClientProfile.getInstance().Add(newcredit);
        }

        public void ShowProfile()
        {
            ClientProfile.getInstance().ShowList();
        }
    }
}
