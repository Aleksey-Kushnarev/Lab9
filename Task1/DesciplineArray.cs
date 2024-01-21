using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
    internal class DesciplineArray
    {
        Descipline[] desciplines;
        int Length;
        public DesciplineArray(int length)
        {
            this.desciplines = new Descipline[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                Descipline descipline = new Descipline($"descipline №{i + 1}", rnd.Next(100), rnd.Next(100));
                this.desciplines[i] = descipline;
            }
        }

       /* public static DesciplineArray Copy(DesciplineArray arr)
        {
            Descipline[] newArr = new Descipline[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            return newArr;
        }*/
    }
}
