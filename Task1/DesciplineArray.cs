using System;
using System.Collections;

namespace Task1
{
    public class DisciplineArray : IEnumerable, IEnumerator, ICloneable
    {
        Discipline[] Disciplines;
        private int index = -1;

        
        public int Length
        {
            get { return Disciplines.Length;}
          
        }

        /// <summary>
        /// Создание пустой коллекции
        /// </summary>
        public DisciplineArray()
        {
            Program.cDisciplineArray++;
            this.Disciplines = Array.Empty<Discipline>();
        }

        /// <summary>
        /// Создание коллекции с данными
        /// </summary>
        /// <param name="numbers">Дисциплины, которое нужно включить в коллекцию</param>
        public DisciplineArray(params Discipline[] numbers)
        {
            Program.cDisciplineArray++;
            this.Disciplines = new Discipline[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                this.Disciplines[i] = new Discipline(numbers[i].Name, numbers[i].ContactHours, numbers[i].SelfHours);
            }
        }

        /// <summary>
        /// Заполнение случайными числами
        /// </summary>
        /// <param name="length">Длина массива</param>
        public DisciplineArray(int length)
        {
            Program.cDisciplineArray++;
            this.Disciplines = new Discipline[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                Discipline Discipline = new Discipline($"Discipline #{i + 1}", rnd.Next(100), rnd.Next(100));
                this.Disciplines[i] = Discipline;
            }
        }

        /// <summary>
        /// Добавление элемента в конец коллекции
        /// </summary>
        /// <param name="discipline">Элемент, который добавляем</param>
        public void Add(Discipline discipline)
        {
            Discipline[] newArr = new Discipline[Disciplines.Length + 1];
            for (int i = 0; i < Disciplines.Length; i++)
            {
                newArr[i] = new Discipline(Disciplines[i].Name, Disciplines[i].ContactHours, Disciplines[i].SelfHours);
            }

            newArr[newArr.Length - 1] = discipline;
            Disciplines = newArr;
        }


        /// <summary>
        /// Вывод коллекции
        /// </summary>
        /// <returns>Строку для вывода</returns>
        public override string ToString()
        {
            string res ="";
            foreach (Discipline element in Disciplines)
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
        public Discipline this[int i]
        {
            get
            {
                return Disciplines[i];
            }
            set
            {
                Disciplines[i] = new Discipline(value);
            }
        }

        public object Clone()
        {
            return new DisciplineArray(Disciplines);
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        // Реализуем интерфейс IEnumerator
        public bool MoveNext()
        {
            if (index == Disciplines.Length - 1)
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
                return Disciplines[index];
            }
        }
    }
}
