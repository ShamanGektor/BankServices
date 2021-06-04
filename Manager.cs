using System;
using System.Collections.Generic;
using System.Text;

namespace BankServices
{
    class Manager
    {
        public void ShowListContracts()
        {
            ListOfContract.getInstance().GetList();
        }

        public void ShowtModifiedListContracts()
        {
            Console.WriteLine("Введите фильтры для просмотра: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            string type = Console.ReadLine();
            string status = Console.ReadLine();
            ListOfContract.getInstance().GetModifiedList(ID, type, status);
        }

        public void ConfirmContract()
        {
            Console.WriteLine("Введите ID подтверждаемого договора: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            ListOfContract.getInstance().EditContract(ID, "", "", "Confirm");
        }

        public void DeclineContract()
        {
            Console.WriteLine("Введите ID удаляемого договора: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            ListOfContract.getInstance().DeleteContract(ID);
        }

        public void EditContract()
        {
            Console.WriteLine("Введите данные для изменения: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            string type = Console.ReadLine();
            string filename = Console.ReadLine();
            ListOfContract.getInstance().EditContract(ID, filename, type, "Edit");
        }
    }
}
