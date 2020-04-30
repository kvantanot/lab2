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

            long l = i;
            float f1 = (float)d;
            byte bb = (byte)i;
            decimal dd = (decimal)d;
            double d1 = f;
            //float h = d Ошибка компиляции
            //Object o = "Stroka"; int io = (int)o; Ошибка исполнения

            Object o = 15; 
            int result = (int)o / 2 + (int) (5 * d); 
            //1 упаковка 1 разупаковка.

        }
    }
}
