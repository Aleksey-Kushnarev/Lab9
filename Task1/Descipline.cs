using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Descipline
    {
        private string name;
        private int contactHours;
        private int selfHours;
        private int creditUnit;

        public Descipline(string name, int contactHours, int selfHours)
        {
            this.name = name;
            this.contactHours = contactHours;
            this.selfHours = selfHours;
            this.creditUnit = this.countCreditUnit();
        }
        public Descipline(string name)
        {
            this.name=name;
            this.contactHours = 0;
            this.selfHours = 0;
            this.creditUnit = this.countCreditUnit();
        }

        private int countCreditUnit()
        {
            int creditUnit = (this.selfHours + this.contactHours) / 38;
            return creditUnit;
        }

        /// <summary>
        /// определение процентного соотношения самостоятельной работы к общему количеству часов, выделенных на дисциплину, результат – вещественное число от 0 до 100 
        /// </summary>
        /// <param name="descipline1"></param>
        /// <param name="descipline2"></param>
        /// <returns></returns>

        public static double operator !(Descipline descipline)
        {
            double res = (descipline.selfHours) / 1.0 / (descipline.selfHours + descipline.contactHours) * 100;
            return res;
        }

        // Операции увеличения часов

        public static Descipline operator +(Descipline descipline, int hours)
        {
            if (descipline.selfHours - hours >= 0)
            {
                descipline.selfHours -= hours;
                descipline.contactHours += hours;
                return descipline;
            }
            else
            {
                Console.WriteLine("Error");
                return descipline;
            }
        }

        public static Descipline operator ++(Descipline descipline)
        {
            if (descipline.selfHours - 2 >= 0)
            {
                descipline.selfHours -= 2;
                descipline.contactHours += 2;
                return descipline;
            }
            else
            {
                Console.WriteLine("Error");
                return descipline;
            }
        }

        // Операции преобразования
        /// <summary>
        /// Доля аудиторных часов от всех часов
        /// </summary>
        /// <param name="descipline"></param>
        public static explicit operator double (Descipline descipline)
        {
            return (descipline.contactHours) / 1.0 / (descipline.selfHours + descipline.contactHours);
        }

        /// <summary>
        /// Количество аудиторных занятий
        /// </summary>
        /// <param name="descipline"></param>
        public static implicit operator int(Descipline descipline)
        {
            return (descipline.contactHours) / 2;
        }

        public static implicit operator string(Descipline descipline)
        {
            return $"Descipline {descipline.name} has {descipline.contactHours} contact hours and {descipline.selfHours} self hours.";
        }

        // Операции сравнения

        public static bool operator <(Descipline descipline1, Descipline descipline2)
        {
            bool res = descipline1.contactHours + descipline1.selfHours < descipline2.contactHours + descipline2.selfHours;
            return res;
        }
        public static bool operator >(Descipline descipline1, Descipline descipline2)
        {
            bool res = descipline1.contactHours + descipline1.selfHours > descipline2.contactHours + descipline2.selfHours;
            return res;
        }
        public static bool operator <=(Descipline descipline1, Descipline descipline2)
        {
            bool res = descipline1.contactHours + descipline1.selfHours <= descipline2.contactHours + descipline2.selfHours;
            return res;
        }
        public static bool operator >=(Descipline descipline1, Descipline descipline2)
        {
            bool res = descipline1.contactHours + descipline1.selfHours >= descipline2.contactHours + descipline2.selfHours;
            return res;
        }
        public static bool operator ==(Descipline descipline1, Descipline descipline2)
        {
            bool res = descipline1.contactHours + descipline1.selfHours == descipline2.contactHours + descipline2.selfHours;
            return res;
        }

        
        public static bool operator !=(Descipline descipline1, Descipline descipline2)
        {
            bool res = descipline1.contactHours + descipline1.selfHours != descipline2.contactHours + descipline2.selfHours;
            return res;
        }

        public int getCreditUnit()
        {
            return this.creditUnit;
        }


        public override string ToString()
        {
            return $"{selfHours + contactHours}";
        }

    }
}
