using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Descipline d = new Descipline("math", 54, 24);
            Descipline d2 = new Descipline("rus", 58, 24);
            Descipline d3 = new Descipline("IT", 24, 56);
            Console.WriteLine(d3.CreditUnit);
            int t = d.GetCreditUnit();

            Console.WriteLine((string)d);
            Console.WriteLine(t); // Вывод зачетных единиц
            Console.WriteLine(!d); // Соотношение самостоятельной работы ко всей работе в %
            Console.WriteLine($"{d} < {d2} {d < d2}");
            Console.WriteLine($"{d} > {d2} {d > d2}");
            Console.WriteLine($"{d3} == {d} {d == d3}");
            Console.WriteLine($"{d} != {d3} {d != d3}");
            Console.WriteLine((string)d3);
            d3 += 32;
            Console.WriteLine((string)d3);
            double a = (double)d3;
            int b = d3;

            DesciplineArray dArr = new DesciplineArray(d, d2, d3);
            DesciplineArray dArrC = (DesciplineArray)dArr.Clone();
            dArrC[2] = new Descipline("qwe", 24, 23); 
            Console.WriteLine(dArr);
            
            Console.WriteLine(dArrC);


            Console.ReadLine();
        }


        static void CountAverageValue(DesciplineArray dArr)
        {
            float res = 0.0f;
            foreach (Descipline x in dArr)
            {
                res += x.CreditUnit;
            }

            res /= dArr.Length;
            Console.WriteLine(res);
        }
    }
}
