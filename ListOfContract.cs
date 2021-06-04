using System;
using System.Collections.Generic;
using System.Text;

namespace BankServices
{
    class ListOfContract
    {
        private static ListOfContract instance;

        private List<Contract> list = new List<Contract>();
        public static ListOfContract getInstance()
        {
            if (instance == null)
                instance = new ListOfContract();
            return instance;
        }


        public void Add(Contract contract)
        {
            list.Add(contract);
        }

        public void GetList()
        {
            foreach (Contract i in list)
            {
                Console.WriteLine($"Номер: {i.getID()}");
                Console.WriteLine($"Название файла: {i.getFileName()}");
                Console.WriteLine($"Тип: {i.getType()}");
                Console.WriteLine($"Статус: {i.getStatus()}");
            }
        }

        public void GetModifiedList(int ID, string type, string status)
        {
            foreach (Contract i in list)
            {
                if (ID < i.getID() && !Convert.ToBoolean(String.Compare(i.getType(), type)) && !Convert.ToBoolean(String.Compare(i.getStatus(), status)))
                {
                    Console.WriteLine($"Номер: {i.getID()}");
                    Console.WriteLine($"Название файла: {i.getFileName()}");
                    Console.WriteLine($"Тип: {i.getType()}");
                    Console.WriteLine($"Статус: {i.getStatus()}");
                }
            }
        }

        public void EditContract(int ID, string filename, string type, string status)
        {
            Contract i = list.Find(x => x.getID() == ID);
            i.setFileName(filename);
            i.setType(type);
            i.setStatus(status);
        }

        public void DeleteContract(int ID)
        {
            list.Remove(list.Find(x => x.getID() == ID));
        }
    }
}
