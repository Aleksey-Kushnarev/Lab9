using System;

namespace Task1
{
    public class Discipline
    {
        public string Name
        {
            get;
            set;
        }

        public int ContactHours
        {
            get;
            set;
        }

        public int SelfHours
        {
            get;

            set;

        }

        public int CreditUnit
        {
            get => (SelfHours + ContactHours) / 38;
        }

        public int SumHours
        {
            get => SelfHours + ContactHours;
        }

        public Discipline(Discipline discipline)
        { 
            Program.cDiscipline++; 
            Name = discipline.Name; 
            ContactHours = discipline.ContactHours; 
            SelfHours = discipline.SelfHours;
        }


        public Discipline(string name, int contactHours, int selfHours)
        {
            Program.cDiscipline++;
            Name = name;
            ContactHours = contactHours <= 0 ? 0 : contactHours;
            SelfHours =  selfHours <= 0 ? 0 : selfHours;
        }
        public Discipline(string name)
        {
            Program.cDiscipline++;
            Name =name;
            ContactHours = 0;
            SelfHours = 0;
        }

        public Discipline()
        {
            Program.cDiscipline++;
            Name = "default";
            ContactHours = 0;
            SelfHours = 0;
        }

        /// <summary>
        /// определение процентного соотношения самостоятельной работы к общему количеству часов, выделенных на дисциплину, результат – вещественное число от 0 до 100 
        /// </summary>
        /// <param name="discipline"></param>
        /// <returns></returns>

        public static double operator !(Discipline discipline)
        {
            double res = (discipline.SelfHours) / 1.0 / discipline.SumHours * 100;
            return res;
        }

        // Операции увеличения часов

        public static Discipline operator +(Discipline discipline, int hours)
        {
            if (discipline.SelfHours - hours < 0)
            {
                throw new Exception("ERROR! SelfHours must be greater than 0");
            }

            discipline.ContactHours += hours;
            discipline.SelfHours -= hours;
            return discipline;
        }

        public static Discipline operator ++(Discipline discipline)
        {
            if (discipline.SelfHours - 2 < 0)
            {
                throw new Exception("ERROR! SelfHours must be greater than 0");
            }
            discipline.ContactHours += 2;
            discipline.SelfHours -= 2;
            return discipline;
        }

        // Операции преобразования
        /// <summary>
        /// Доля аудиторных часов от всех часов
        /// </summary>
        /// <param name="discipline"></param>
        public static explicit operator double (Discipline discipline)
        {
            return (discipline.ContactHours) / 1.0 / discipline.SumHours;
        }

        /// <summary>
        /// Количество аудиторных занятий
        /// </summary>
        /// <param name="discipline"></param>
        public static implicit operator int(Discipline discipline)
        {
            return (discipline.ContactHours) / 2;
        }

        // Операции сравнения

        public static bool operator <(Discipline discipline1, Discipline discipline2)
        {
            bool res = discipline1.SumHours < discipline2.SumHours;
            return res;
        }
        public static bool operator >(Discipline discipline1, Discipline discipline2)
        {
            bool res = discipline1.SumHours > discipline2.SumHours;
            return res;
        }
        public static bool operator <=(Discipline discipline1, Discipline discipline2)
        {
            bool res = discipline1.SumHours <= discipline2.SumHours;
            return res;
        }
        public static bool operator >=(Discipline discipline1, Discipline discipline2)
        {
            bool res = discipline1.SumHours >= discipline2.SumHours;
            return res;
        }
        public static bool operator ==(Discipline discipline1, Discipline discipline2)
        {
            bool res = discipline1.SumHours == discipline2.SumHours;
            return res;
        }

        public static bool operator !=(Discipline discipline1, Discipline discipline2)
        {
            bool res =  discipline1.SumHours != discipline2.SumHours;
            return res;
        }

        public override string ToString()
        {
            return $"Discipline {this.Name} has {this.ContactHours} Contact hours and {this.SelfHours} Self hours.";
        }

    }
}
