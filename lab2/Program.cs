using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "Hello World";//Ссылочный
            int i = 1; //Значимый 
            bool b; //Значимый
            b = true;
            int i1 = i;//Значимый
            double d = 4.20 + i1;//Значимый
            float f = default(float);//Значимый
        }
    }
}
