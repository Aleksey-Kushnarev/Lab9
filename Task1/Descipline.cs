using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Descipline
    {
        private string name;
        private int contactHours;
        private int selfHours;
        private int creditUnit;


        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }

        public int ContactHours
        {
            get => contactHours;

            set
            {
                contactHours = value >= 0 ? value : 0;
            }
        }

        public int SelfHours
        {
            get => selfHours;

            set
            {
                selfHours = value >= 0 ? value : 0;
            }
        }

        public int CreditUnit
        {
            get => (SelfHours + ContactHours) / 38;
        }

        public Descipline(string name, int contactHours, int selfHours)
        {
            Name = name;
            ContactHours = contactHours;
            SelfHours = selfHours;
        }
        public Descipline(string name)
        {
            Name=name;
            ContactHours = 0;
            SelfHours = 0;
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
        { try
            {
                return $"Descipline {descipline.name} has {descipline.contactHours} contact hours and {descipline.selfHours} self hours.";
            }
            catch (System.NullReferenceException e)
            {
                return "Error! Such descipline not found";
            }
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

        public int GetCreditUnit()
        {
            return CreditUnit;
        }


        public override string ToString()
        {
            return $"{selfHours + contactHours}";
        }

    }
}
