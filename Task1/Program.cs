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
            Descipline d2 = new Descipline(d);
            DesciplineArray dArr = new DesciplineArray(d, d2);
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

            Console.WriteLine(d <= d2);
            
           


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
