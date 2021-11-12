using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5OOP
{
    class Aviation: Transport
    {
        private string Type;
        public override string type
        {
            get => Type;
            set
            {
                Type = value;
            }
        }
        private int Wingspan;
        public int _Wingspan
        {
            get
            {
                return Wingspan;
            }
            set
            {
                if(value>0)
                {
                    Wingspan = value;
                }
                else
                {
                    Wingspan = 10;
                }
            }
        }
        public Aviation()
        {
            Console.WriteLine("Введите размах крыла");
            _Wingspan = Convert.ToInt32(Console.ReadLine());
        }
        public override void Location(string loc)
        {
            Console.WriteLine("Самолёт находится в " + loc + " (abs)");
        }
        public override void Fly(string from, string to)
        {
            Console.WriteLine($"Самолёт летит из {from} в {to} (abs)");
        }
    }
}
