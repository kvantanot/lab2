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

            byte[] bytes = { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9, 0xF8 };
            long longFromBytes = ((long)bytes[0] << 56) + ((long)bytes[1] << 48) + ((long)bytes[2] << 40) + ((long)bytes[3] << 32) + ((long)bytes[4] << 24) + ((long)bytes[5] << 16) + ((long)bytes[6] << 8) + (long)bytes[7];

            String number = "-559038737";
            int numFromString;
            if (int.TryParse(number, out numFromString))
            {
                Console.WriteLine(numFromString);
            }

            String input = Console.ReadLine();
            foreach(char c in input)
            {
                Console.WriteLine("{0:x}, {0}", (int) c);
            }
        }
    }
}
