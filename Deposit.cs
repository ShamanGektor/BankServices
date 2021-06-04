using System;
using System.Collections.Generic;
using System.Text;

namespace BankServices
{
    class Deposit:Contribution
    {
        private type currencytype;

        public void setCurrencyType(type newtype)
        {
            currencytype = newtype;
        }

        public type getCurrencyType()
        {
            return currencytype;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Тип: {currencytype}");
        }

    }
}
