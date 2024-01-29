using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
    public class DesciplineArray : IEnumerable, IEnumerator, ICloneable
    {
        Descipline[] desciplines;
        private int index = -1;

        Descipline[] Desciplines
        {
            get=>this.desciplines;
            set => this.desciplines = value;

        }
        
        public int Length
        {
            get { return desciplines.Length;}
            set { desciplines = new Descipline[value]; }
        }

        public DesciplineArray()
        {

        }

        public DesciplineArray(params Descipline[] numbers)
        {
            this.desciplines = new Descipline[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                this.desciplines[i] = numbers[i];
            }
        }

        /// <summary>
        /// Заполнение случайными числами
        /// </summary>
        /// <param name="length">Длина массива</param>
        public DesciplineArray(int length)
        {
            this.desciplines = new Descipline[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                Descipline descipline = new Descipline($"descipline #{i + 1}", rnd.Next(100), rnd.Next(100));
                this.desciplines[i] = descipline;
            }
        }

        /// <summary>
        /// Вывод коллекции
        /// </summary>
        /// <returns>Строку для вывода</returns>
        public override string ToString()
        {
            string res ="";
            foreach (var VARIABLE in desciplines)
            {
                res += VARIABLE + "\n";
            }

            return res;
        }

        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="i">Индекс элемента</param>
        /// <returns>Значение элемента с индексом i</returns>
        public Descipline this[int i]
        {
            get
            {
                try
                {
                    return desciplines[i];
                }
                catch { return null; }
            }
            set
            {
                try
                {
                    desciplines[i] = value;
                }
                catch {
                    Console.WriteLine("Error! Index out of range!");
                }
            }
        }


        public object Clone()
        {
            return new DesciplineArray(Desciplines);
        }


        public static DesciplineArray Copy(DesciplineArray arr)
        {
            DesciplineArray newArr = new DesciplineArray();
            newArr.Length = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            return newArr;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        // Реализуем интерфейс IEnumerator
        public bool MoveNext()
        {
            if (index == desciplines.Length - 1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }


        public void Reset()
        {
            index = -1;
        }

        public object Current
        {
            get
            {
                return desciplines[index];
            }
        }
    }
}
