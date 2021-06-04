using System;
using System.Collections.Generic;
using System.Text;

namespace BankServices
{
    class Contract
    {
        private int indentifier;
        private string filename;
        private string type;
        private string status;

        public Contract()
        {
            setStatus("Created");
        }
        public void setID(int i)
        {
            indentifier = i;
        }

        public void setFileName(string f)
        {
            filename = f;
        }

        public void setType(string t)
        {
            type = t;
        }

        public void setStatus(string s)
        {
            status = s;
        }

        public int getID()
        {
            return indentifier;
        }

        public string getFileName()
        {
            return filename;
        }

        public string getType()
        {
            return type;
        }

        public string getStatus()
        {
            return status;
        }
    }
}
