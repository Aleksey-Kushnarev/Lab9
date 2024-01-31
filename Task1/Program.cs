using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
    internal class Program
    {
        public static int cDiscipline = 0;
        public static int cDisciplineArray = 0;
        static void Main(string[] args)
        {
            
            Console.WriteLine("****DISCIPLINE****\n");
            Console.WriteLine("====Создание экземпляров====");
            PrintCreating();

            Discipline example1 = new Discipline("Математика", 32, 12);
            Discipline example2 = new Discipline("История", 40, 20);
            cDiscipline += 2;
            Console.WriteLine("\n====Получение кредитов====");
            PrintGettingCredit(example1);

            try
            {
                Console.WriteLine("\n====Прибавление определенного числа часов====");
                example1 += 12;
                Console.WriteLine(example1 + " <= +12 Contant Hours");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("\n====Прибавление 2 часов, операция ++====");
                example1++;
                Console.WriteLine(example1 + " <= +2 Contant Hours (Операция ++)");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " <= Операция ++ выдала ошибку");
                Console.WriteLine();
            }
            
            Console.WriteLine("\n====Операции сравнения====");
            PrintComparison(example1, example2);

            Console.WriteLine("\n====Операции преобразования====");
            PrintConverting(example2);

            Console.WriteLine("\n\n****DISCIPLINE ARRAY****\n");
            Console.WriteLine("====Создание экземпляров====");
            DisciplineArray exampleArray = new DisciplineArray(example1);
            PrintCreatingArrays(example1, example2);

            Console.WriteLine("\n====Добавление элементов====");
            PrintAdditionElement(exampleArray, example2);

            Console.WriteLine("\n====Индексатор коллекции====");
            PrintOpportunitiesOfIndexes(exampleArray, example2);

            Console.WriteLine("\n====Глубокое копирование====");
            PrintDeepCopy(exampleArray);


            Console.WriteLine("\n====Найти средневзвешенное значение зачётных единиц по всем дисциплинам в массиве====");
            exampleArray.Add(example1);
            Console.WriteLine(exampleArray);
            CountAverageValue(exampleArray);


            Console.WriteLine($"Объектов создано {cDiscipline}\n Коллекций создано {cDisciplineArray}");
        }

        /// <summary>
        /// Вывод пункта Создание экземпляров (Discipline)
        /// </summary>
        public static void PrintCreating()
        {
            Discipline empty = new Discipline();
            Discipline withoutHours = new Discipline("Русский язык");
            Discipline withNegativeHours = new Discipline("Физика", -23, -12);
            Discipline normalDiscipline = new Discipline("Физкультура", 24, 92);
            Discipline copyNormalDiscipline = new Discipline(normalDiscipline);
            Console.WriteLine(empty + " <= конструктор без параметров");
            Console.WriteLine(withoutHours + " <= конструктор с одним параметром");
            Console.WriteLine(withNegativeHours + " <= конструктор с отрицательным числом часов");
            Console.WriteLine(normalDiscipline + " <= конструктор со всеми параметрами");
            Console.WriteLine(copyNormalDiscipline + " <= конструктор копирования");
            Console.WriteLine();
            copyNormalDiscipline.Name = "Литература";
            Console.WriteLine(normalDiscipline + " <= из него копировали");
            Console.WriteLine(copyNormalDiscipline + " <= копия, в ней поменяли данные");
        }

        /// <summary>
        /// Вывод пункта Получение кредитов
        /// </summary>
        /// <param name="example">Дисциплина, кредиты которой выводим</param>
        public static void PrintGettingCredit(Discipline example)
        {
            Console.WriteLine(example.ToString());
            Console.WriteLine($"Кредитов {example.CreditUnit} <= с помощью метода класса");
            Console.WriteLine($"Кредитов {GetCreditUnit(example)} <= с помощью статической функции");
        }

        /// <summary>
        /// Вывод пункта Сравнение
        /// </summary>
        /// <param name="example1">Первый элемент сравнения</param>
        /// <param name="example2">Второй элемент сравнения</param>
        public static void PrintComparison(Discipline example1, Discipline example2)
        {
            Console.WriteLine(example1.ToString());
            Console.WriteLine(example2.ToString());
            Console.WriteLine($"Сумма часов Математики => {example1.SumHours}");
            Console.WriteLine($"Сумма часов Истории => {example2.SumHours}");
            Console.WriteLine($"Математика({example1.SumHours}) > Истрия({example2.SumHours}) => {example1 > example2}");
            Console.WriteLine($"Математика({example1.SumHours}) < Истрия({example2.SumHours}) => {example1 < example2}");
            Console.WriteLine($"Математика({example1.SumHours}) == Истрия({example2.SumHours}) => {example1 == example2}");
            Console.WriteLine($"Математика({example1.SumHours}) != Истрия({example2.SumHours}) => {example1 != example2}");
            Console.WriteLine($"Математика({example1.SumHours}) >= Истрия({example2.SumHours}) => {example1 >= example2}");
            Console.WriteLine($"Математика({example1.SumHours}) <= Истрия({example2.SumHours}) => {example1 <= example2}");
        }

        /// <summary>
        /// Вывод пункта Преобразования
        /// </summary>
        /// <param name="example">Дисциплина, которую преобразовываем</param>
        public static void PrintConverting(Discipline example)
        {
            Console.WriteLine(example.ToString());
            Console.WriteLine($"!История = {!example} <= определение процентного соотношения самостоятельной работы к общему количеству часов," +
                              $" выделенных на дисциплину, результат – вещественное число от 0 до 100");
            Console.WriteLine($"\nПреобразование в int количество пар (Contact Hours / 2)");
            Console.WriteLine(example);
            Console.WriteLine("Происходит неявно");

            Console.WriteLine($"\nПреобразование в double Доля аудиторных часов от всех часов");
            Console.WriteLine((double)example);
            Console.WriteLine("Происходит явно");
        }

        /// <summary>
        /// Вывод пункта Создание экземпляров (DisciplineArray)
        /// </summary>
        public static void PrintCreatingArrays(Discipline example1, Discipline example2)
        {
            DisciplineArray emptyArray = new DisciplineArray();
            DisciplineArray rndArray = new DisciplineArray(4);
            DisciplineArray manualArray = new DisciplineArray(example1, example2);
            Console.WriteLine(emptyArray + " <= Пустоая коллекция, конструктор без параметров\n");
            Console.WriteLine(rndArray + " <= Заполненная случайными значениями коллекция, конструктор с одним параметром\n");
            Console.WriteLine(manualArray + " <= Заполненная вручную коллекция, конструктор с массивом элементов");
        }

        /// <summary>
        /// Вывод пункта Добавление элемента
        /// </summary>
        /// <param name="exampleArray">Коллекция, в которую добавляем</param>
        /// <param name="example2">Элемент, который добавляем</param>
        private static void PrintAdditionElement(DisciplineArray exampleArray, Discipline example2)
        {
            Console.WriteLine(exampleArray + "До добавления\n");
            exampleArray.Add(example2);
            Console.WriteLine(exampleArray + "После добавления");
        }

        /// <summary>
        /// Вывод пункта Индексатор коллекции
        /// </summary>
        /// <param name="exampleArray">Коллекция, с которой работаем</param>
        /// <param name="example2">Элемент, на который будем изменять</param>
        private static void PrintOpportunitiesOfIndexes(DisciplineArray exampleArray, Discipline example2)
        {
            try
            {
                Console.WriteLine(exampleArray[0].ToString());
                exampleArray[0] = example2;
                Console.WriteLine(exampleArray[0] + " <= Изменение первого элемента коллекции");
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine(exampleArray[2].ToString());
                exampleArray[2] = example2;
                Console.WriteLine(exampleArray[2] + " <= Изменение первого элемента коллекции");
            }
            catch (Exception e)
            {
                Console.WriteLine(e + " <= Сообщение об ошибке");
            }

        }

        /// <summary>
        /// Вывод пункта Глубокое копирование
        /// </summary>
        /// <param name="exampleArray">Коллекция, которую копируем</param>
        private static void PrintDeepCopy(DisciplineArray exampleArray)
        {
            DisciplineArray newArray = (DisciplineArray)exampleArray.Clone();
            Console.WriteLine(exampleArray + "Первоначальная коллекция\n");
            Console.WriteLine(newArray + "Скопированная коллекция\n");
            exampleArray[0] = new Discipline();
            Console.WriteLine(exampleArray + "Первоначальная изменненая коллекция\n");
            Console.WriteLine(newArray + "Скопированная коллекция\n");
        }
        static void CountAverageValue(DisciplineArray dArr)
        {
            float res = 0.0f;
            foreach (Discipline x in dArr)
            {
                res += x.CreditUnit;
            }

            res /= dArr.Length;
            Console.WriteLine(res);
        }

        static int GetCreditUnit(Discipline dis)
        {
            return dis.SumHours / 38;
        }
    }
}
