using System;
using System.Collections.Generic;
using System.Text;

namespace BankServices
{
    class ClientProfile
    {
        private List<Contribution> list = new List<Contribution>();

        private static ClientProfile instance;

        public static ClientProfile getInstance()
        {
            if (instance == null)
                instance = new ClientProfile();
            return instance;
        }
        public void Add(Contribution contribution)
        {
            list.Add(contribution);
        }

        public void ShowList()
        {
            foreach (Contribution i in list)
            {
                i.Show();
            }
        }

        public bool EditContribution(int number, double body)
        {
            Contribution cont = list.Find(x => x.getNumber() == number); ;

            if (body > 0)
            {
                cont.setBody(cont.getBody() + body);
                return true;
            }

            if (cont.getBody() >= (-body))
            {
                cont.setBody(cont.getBody() + body);
                if (cont.getBody() == 0)
                {
                    list.Remove(cont);
                }
                return true;
            }
            else
            {
                Console.WriteLine("Error");
                Console.ReadKey();
                return false;
            }
        }

        public Contribution FindContribution(int number)
        {
            return list.Find(x => x.getNumber() == number);
        }

        public void DeleteContribution(Contribution cont)
        {
            list.Remove(cont);
        }
    }
}
