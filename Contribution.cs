using System;
using System.Collections.Generic;
using System.Text;

namespace BankServices
{
    class Contribution
    {
        private int number;
        private double body;
        private double percent;

        public void setNumber(int newnumber)
        {
            number = newnumber;
        }

        public void setBody(double newbody)
        {
            body = newbody;
        }

        public void setPercent(double newpercent)
        {
            percent = newpercent;
        }

        public int getNumber()
        {
            return number;
        }

        public double getBody()
        {
            return body;
        }

        public double getPercent()
        {
            return percent;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Номер: {number}");
            Console.WriteLine($"Тело: {body}");
            Console.WriteLine($"Процент: {percent}");
        }
    }
}
