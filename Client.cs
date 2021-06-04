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

        }

        public void TopUpDeposit()
        {

        }
        public void MakeDeposit()
        {
            
        }

        public void TakeCredit()
        {
        
        }

        public void ShowProfile()
        {

        }
    }
}
