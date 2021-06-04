using System;
using System.Collections.Generic;
using System.Text;

namespace BankServices
{
    class Credit:Contribution
    {
        private DateTime dateIssue;
        private int period;

        public void setData(DateTime newdata)
        {
            dateIssue = newdata;
        }

        public void setPeriod(int newperiod)
        {
            period = newperiod;
        }

        public DateTime getData()
        {
            return dateIssue;
        }

        public int getPeriod()
        {
            return period;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Дата выдачи: {dateIssue}");
            Console.WriteLine($"Период: {period}");
        }
    }
}
