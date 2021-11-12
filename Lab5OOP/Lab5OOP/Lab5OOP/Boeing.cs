using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5OOP
{
    class Boeing: Passenger_Plane, Interface

    {
        public string Model { get; set; }

        public Boeing():base()
        {
            Console.WriteLine("Введите модель самолёта");
            Model = Console.ReadLine();
        }
        public override string ToString()
        {
            return "Тип: " + type + ".\n" +
                "Модель: " + Model + ".\n" +
                "Размах крыла: " + _Wingspan + ".\n" +
                "Количество пассажиров: " + _NumberOfPassangers + ".";
        }
        public override int GetHashCode()
        {
            int sum = 137;
            sum += type.GetHashCode();
            sum += Model.GetHashCode();
            sum += _Wingspan.GetHashCode();
            sum += _NumberOfPassangers.GetHashCode();
            return sum;
        }
        public override bool Equals(object obj)
        {
            if(obj.GetType()!=GetType())
            {
                return false;
            }
            else
            {
                if(obj.GetHashCode()!=GetHashCode())
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        void Interface.Location(string loc)
        {
            Console.WriteLine("Самолёт находится в " + loc + " (int)");
        }
        void Interface.Fly(string from, string to)
        {
            Console.WriteLine($"Самолёт летит из {from} в {to} (int)");
        }
    }
}
