using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class ApplicationLicense
    {
        public ApplicationLicense(string trial,string keyNumber,string pro)
        {
            if (trial != "" && keyNumber != "" && pro != "") AllowPro();
            else if (keyNumber!="") AllowCommon();
            else if (trial!="") AllowTrial();
            else Console.WriteLine("go away");
        }
        public void AllowTrial()
        {
            Console.WriteLine("Триальній режим");
        }
        public void AllowCommon()
        {
            Console.WriteLine("Бесплатная версия");
        }
        public void AllowPro()
        {
            Console.WriteLine("Платная версия");
        }
    }
}
