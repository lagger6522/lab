using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3OOP
{
    partial class Date
    {
        static private int _numbers;
        readonly int _ID;
        const int ye = 2021;
        private int _day = -1;
        public int day
        {
            get
            {
                return _day;
            }
            set
            {
                if (value > 0 || value < 32)
                {
                    _day = value;
                }
                else
                {
                    Console.WriteLine("Превышено допустимое значение номера дня, установлен номер дня = 31");
                    _day = 31;
                }
            }
        }
        private int _year;
        private int _month = -1;
        public int month
        {
            get
            {
                return _month;
            }
            private set
            {
                if (value > 0 && value < 13)
                {
                    _month = value;
                }
                else
                {
                    Console.WriteLine("Превышено допустимое значение номера месяца, установлен номер месяца = 12");
                    _month = 12;
                }
            }
        }
        public Date(int Day, int Month, int year)
        {
            _numbers++;
            var datetime = new Random();
            day = Day;
            month = Month;
            _year = year;
            _ID = (int)(_day * Math.E + _month * Math.PI + _year * datetime.Next(10,99));
        }
        public Date(int Day, int year = 2021)
        {
            _numbers++;
            var datetime = new Random();
            day = Day;
            Console.WriteLine("Пожалуйста, введите месяц");
            month = Convert.ToInt32(Console.ReadLine());
            _year = year;
            _ID = (int)(_day * Math.E + _month * Math.PI + _year * datetime.Next(0, 100));
        }
        public Date Create()
        {
            Date date = new Date();
            return date;
        }
        private Date()
        {
            _numbers++;
            var datetime = new Random();
            Console.WriteLine("Пожалуйста, введите день");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите месяц");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите год");
            _year = Convert.ToInt32(Console.ReadLine());
            _ID = (int)(_day * Math.E + _month * Math.PI + _year * datetime.Next(0, 100));
        }
        static Date()
        {
            Console.WriteLine("Вы создали объект дата");
        }
        
        ~Date()
        {
            Console.WriteLine("Объект уничтожен");
        }
        public void printc()
        {
            Console.WriteLine($"{this.day}/{this.month}/{this._year}");
        }
        public void prints()
        {
            string[] mas = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            Console.WriteLine($"{this.day} {mas[this.month - 1]} {this._year} года");
        }
        public void SomeDayLater(ref int NumbersOfDays)
        {
            NumbersOfDays++;
            _day = _day + NumbersOfDays;
            if(_day>31)
            {
                _month++;
                _day = _day - 31;
            }
        }
        static public string InfoAboutClass()
        {
            return $"Class name is Date, numbers of objects are {_numbers}";
        }
        public bool Search(int Year, out bool rc)
        {
            if (_year == Year)
                rc = true;
            else
                rc = false;
            return rc;
        }
        public bool SearchByDay(int Day)
        {
            if (_day == Day)
                return true;
            else
                return false;
        }
    }
}
