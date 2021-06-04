using System;
using System.Collections.Generic;
using System.Text;

namespace BankServices
{
    class Cash
    {
        private CurrencyQuantity[] list = new CurrencyQuantity[2];

        public Cash()
        {
            list[0].e = type.Rubbles;
            list[0].quantity = 1000;
            list[1].e = type.Dollar;
            list[1].quantity = 1000;
        }

        public bool Exchange(CurrencyQuantity take, CurrencyQuantity give)
        {
            for (int i = 0; i < 2; i++)
            {
                if (list[i].e == take.e)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (list[j].e == give.e)
                        {
                            if (list[j].quantity >= take.quantity * 1.2)
                            {
                                list[i].quantity += take.quantity;
                                list[j].quantity -= take.quantity * 1.2;
                                return true;
                            }
                            else return false;
                        }
                    }
                }
            }
            return false;
        }

        public bool GiveMoney(CurrencyQuantity v)
        {
            for (int i = 0; i < 2; i++)
            {
                if (list[i].e == v.e)
                {
                    if (list[i].quantity >= v.quantity)
                    {
                        list[i].quantity -= v.quantity;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public void AcceptMoney(CurrencyQuantity v)
        {
            for (int i = 0; i < 2; i++)
            {
                if (list[i].e == v.e)
                {
                    list[i].quantity += v.quantity;
                }
            }
        }
    }
}
