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
            Descipline d = new Descipline("math", 20, 80);
            Console.WriteLine((double)d);
            Descipline d3 = new Descipline();
            DesciplineArray dArr = new DesciplineArray(d);
            dArr.Add(d3);
            Console.WriteLine(dArr);
            d.Name = "abc";
           /* try
            {
                Console.WriteLine(dArr[3].ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }*/

            try
            {
                dArr[5] = d;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            
           


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
