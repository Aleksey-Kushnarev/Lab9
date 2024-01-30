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

        
        public int Length
        {
            get { return desciplines.Length;}
          
        }

        public DesciplineArray()
        {
            this.desciplines = Array.Empty<Descipline>();
        }

        public DesciplineArray(params Descipline[] numbers)
        {
            this.desciplines = new Descipline[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                this.desciplines[i] = new Descipline(numbers[i].Name, numbers[i].ContactHours, numbers[i].SelfHours);
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



        public void Add(Descipline descipline)
        {
            Descipline[] newArr = new Descipline[desciplines.Length + 1];
            for (int i = 0; i < desciplines.Length; i++)
            {
                newArr[i] = new Descipline(desciplines[i].Name, desciplines[i].ContactHours, desciplines[i].SelfHours);
            }

            newArr[newArr.Length - 1] = descipline;
            desciplines = newArr;
        }


        /// <summary>
        /// Вывод коллекции
        /// </summary>
        /// <returns>Строку для вывода</returns>
        public override string ToString()
        {
            string res ="";
            foreach (Descipline element in desciplines)
            {
                res += element + "\n";
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
                return desciplines[i];
            }
            set
            {
                desciplines[i] = new Descipline(value);
            }
        }


        public object Clone()
        {
            return new DesciplineArray(desciplines);
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
