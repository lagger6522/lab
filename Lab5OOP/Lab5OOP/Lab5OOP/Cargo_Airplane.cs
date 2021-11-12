using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5OOP
{
    sealed class Cargo_Airplane: Aviation, Interface
    {
        private int Carrying_Capacity;
        public int _Carrying_Capacity
        {
            get
            {
                return Carrying_Capacity;
            }
            set
            {
                if(value>0)
                {
                    Carrying_Capacity = value;
                }
                else
                {
                    Console.WriteLine("Установлена грузоподъёмность 200 тонн");
                    Carrying_Capacity = 200;
                }
            }
        }
        public Cargo_Airplane():base()
        {
            Console.WriteLine("Введите грузоподъёмность самолёта");
            _Carrying_Capacity = Convert.ToInt32(Console.ReadLine());
            type = "Грузовой";
        }
        public override string ToString()
        {
            return "Тип: " + type + ".\n" +
                "Размах крыла: " + _Wingspan + ".\n" +
                "Грузоподъёмность: " + _Carrying_Capacity + ".\n";
        }
        void Interface.Location(string loc)
        {
            Console.WriteLine("Самолёт находится в " + loc + " (int)");
        }
        void Interface.Fly(string from,string to)
        {
            Console.WriteLine($"Самолёт летит из {from} в {to} (int)");
        }
    }
}
