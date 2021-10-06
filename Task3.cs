using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Task3
{
    class b
    {
        public string name = "BOb";
        public string surname = "Pylypenko";
        public int age = 23;
        public virtual void LogData()
        {
            Debug.Write(name);
            Debug.Write(surname);
            Debug.Write(age);
        }
    }
    class b1 : b
    {
        public bool hasFamily = true;
        public override void LogData()
        {
            Debug.Write(hasFamily);
        }
    }
    class b2 : b
    {
        public string telephone = "050666070707070";
        public override void LogData()
        {
            Debug.Write(telephone);
        }
    }
    class b3 : b
    {
        public string email = "retroHTML222.gmail.com@";
        public override void LogData()
        {
            Debug.Write(email);
        }
    }
}
