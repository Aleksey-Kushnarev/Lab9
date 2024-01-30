using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Task1
{
    public class Descipline
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

        public Descipline(Descipline descipline)
        {
          
          Name = descipline.Name;
          ContactHours = descipline.ContactHours;
          SelfHours = descipline.SelfHours;
        }


        public Descipline(string name, int contactHours, int selfHours)
        {
            Name = name;
            ContactHours = contactHours <= 0 ? 0 : contactHours;
            SelfHours =  selfHours <= 0 ? 0 : selfHours;
        }
        public Descipline(string name)
        {
            Name=name;
            ContactHours = 0;
            SelfHours = 0;
        }

        public Descipline()
        {
            Name = "default";
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
            double res = (descipline.SelfHours) / 1.0 / descipline.SumHours * 100;
            return res;
        }

        // Операции увеличения часов

        public static Descipline operator +(Descipline descipline, int hours)
        {
            if (descipline.SelfHours - hours < 0)
            {
                throw new Exception("SelfHours must be greater than 0");
            }

            descipline.ContactHours += hours;
            descipline.SelfHours -= hours;
            return descipline;
        }

        public static Descipline operator ++(Descipline descipline)
        {
            if (descipline.SelfHours - 2 < 0)
            {
                throw new Exception("SelfHours must be greater than 0");
            }
            descipline.ContactHours += 2;
            descipline.SelfHours -= 2;
            return descipline;
        }

        // Операции преобразования
        /// <summary>
        /// Доля аудиторных часов от всех часов
        /// </summary>
        /// <param name="descipline"></param>
        public static explicit operator double (Descipline descipline)
        {
            return (descipline.ContactHours) / 1.0 / descipline.SumHours;
        }

        /// <summary>
        /// Количество аудиторных занятий
        /// </summary>
        /// <param name="descipline"></param>
        public static implicit operator int(Descipline descipline)
        {
            return (descipline.ContactHours) / 2;
        }


        // Операции сравнения

        public static bool operator <(Descipline descipline1, Descipline descipline2)
        {
            bool res = descipline1.SumHours < descipline2.SumHours;
            return res;
        }
        public static bool operator >(Descipline descipline1, Descipline descipline2)
        {
            bool res = descipline1.SumHours > descipline2.SumHours;
            return res;
        }
        public static bool operator <=(Descipline descipline1, Descipline descipline2)
        {
            bool res = descipline1.SumHours <= descipline2.SumHours;
            return res;
        }
        public static bool operator >=(Descipline descipline1, Descipline descipline2)
        {
            bool res = descipline1.SumHours >= descipline2.SumHours;
            return res;
        }
        public static bool operator ==(Descipline descipline1, Descipline descipline2)
        {
            bool res = descipline1.SumHours == descipline2.SumHours;
            return res;
        }


        
        public static bool operator !=(Descipline descipline1, Descipline descipline2)
        {
            bool res = descipline1.SumHours != descipline2.SumHours;
            return res;
        }



        public override string ToString()
        {
            return $"Descipline {this.Name} has {this.ContactHours} Contact hours and {this.SelfHours} Self hours.";
        }

    }
}
