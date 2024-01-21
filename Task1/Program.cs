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
            Descipline d = new Descipline("math", 56, 24);
            Descipline d2 = new Descipline("rus", 58, 24);
            Descipline d3 = new Descipline("IT", 24, 56);
            int t = d.getCreditUnit();

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
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
