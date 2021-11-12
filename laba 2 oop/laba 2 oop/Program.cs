using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace laba_2_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool b;
            short sh = 1;
            string str, str1;
            int asdas = (int)9.25;
            //    NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            //    {
            //        NumberDecimalSeparator = ".",
            //    };


            Console.WriteLine("Ввод и вывод всех возможных примитивных типов данных");
           
            //5 неявного приведения
            long l1 = sh;
            int s = sh;
            float fl = sh;
            double db = sh;
            decimal dc = sh;
            //Выполнить упаковку и распаковку значимых типов
            object Obj = a;
            int a1 = (int)Obj;
            Console.WriteLine($"{Obj}+{a1}");
            //работа с неявно типизированной переменной.
            var HelloWorld = "Hello World";
            Console.WriteLine(HelloWorld.GetType());
            //Продемонстрируйте пример работы с Nullable переменной
            int? n = 5;
            int? n1 = null;
            n = null;
            /*Определите переменную типа var и присвойте ей любое 
            значение.Затем следующей инструкцией присвойте ей значение
            другого типа. Объясните причину ошибки.*/
            //HelloWorld = 1;
            //Объявите строковые литералы. Сравните их.
            string hello = "World";
            string world = "World";
            Console.WriteLine(String.Compare(hello, world));
            /*Создайте три строки на основе String. Выполните: сцепление, 
            копирование, выделение подстроки, разделение строки на слова, 
            вставки подстроки в заданную позицию, удаление заданной 
            подстроки.Продемонстрируйте 
            интерполирование строк.*/
            String aa = "aa";
            String bb = "bb";
            String cc = "cc";
            Console.WriteLine(String.Concat(aa, bb));
            Console.WriteLine(String.Copy(aa));
            Console.WriteLine(HelloWorld.Substring(3));
            string[] str2 = HelloWorld.Split(' ');
            Console.WriteLine(str2[0]);
            Console.WriteLine(str2[1]);
            Console.WriteLine(HelloWorld.Insert(3, aa));
            Console.WriteLine(HelloWorld.Remove(4));
            Console.WriteLine($"{hello}+{world}");
            /*Создайте пустую и null строку. Продемонстрируйте 
            использование метода string.IsNullOrEmpty.Продемонстрируйте
            что еще можно выполнить с такими строками*/
            string fake = "";
            string fake1 = null;

            Console.WriteLine(String.IsNullOrEmpty(fake1));
            Console.WriteLine(String.IsNullOrEmpty(bb));
            Console.WriteLine(String.Concat(fake, bb));
            Console.WriteLine(String.Compare(fake1, hello));
            /*Создайте строку на основе StringBuilder. Удалите определенные 
            позиции и добавьте новые символы в начало и конец строки.*/
            StringBuilder sb = new StringBuilder("hello");
            sb.Remove(0, 3);
            sb.Append(true);
            sb.Insert(0, "true");
            Console.WriteLine(sb);
            /*Создайте целый двумерный массив и выведите его на консоль в 
            отформатированном виде (матрица)*/
            int[,] num = { { 1, 2, 3 }, { 3, 4, 5 } };
            int rows = num.GetUpperBound(0) + 1;
            int colomns = num.Length;
            for (int i = 0; i < rows; i++)
            {
                for (int ii = 0; ii < colomns / rows; ii++)
                {
                    Console.Write($"{num[i, ii]} ");
                }
                Console.WriteLine();
            }
            /*Создайте одномерный массив строк. Выведите на консоль его 
            содержимое, длину массива. Поменяйте произвольный элемент 
            (пользователь определяет позицию и значение).*/
            string[] str3 = { "firts", "second", "third" };
            for (int i = 0; i < str3.Count(); i++)
            {
                Console.WriteLine($"{str3[i]} ");
            }
            Console.WriteLine(str3.Length);
            int pos = Convert.ToInt32(Console.ReadLine());
            string str4 = Console.ReadLine();
            str3[pos] = str4;
            for (int i = 0; i < str3.Count(); i++)
            {
                Console.WriteLine($"{str3[i]} ");
            }
            /*Создайте ступечатый (не выровненный) массив вещественных 
            чисел с 3-мя строками, в каждой из которых 2, 3 и 4 столбцов 
            соответственно. Значения массива введите с консоли.*/
            double[][] wesh = new double[3][];
            wesh[0] = new double[2];
            wesh[1] = new double[3];
            wesh[2] = new double[4];
            for (int i = 0; i < wesh.Length; i++)
            {
                Console.WriteLine($"работа с {i}-ой строкой:");
                for (int j = 0; j < wesh[i].Length; j++)
                {
                    wesh[i][j] = Convert.ToDouble(Console.ReadLine());

                }
            }
            /*Создайте неявно типизированные переменные для хранения 
            массива и строки.*/
            var array = new object[0];
            var arr = "ZXC(да, я даун)";
            //Задайте кортеж из 5 элементов с типами int, string, char, string, ulong.
            (int age, string name, char klass, string surname, ulong middle) person = (17, "Billy", 'S', "Herrington", (ulong)4.2);
            //Выведите кортеж на консоль целиком и выборочно.
            Console.WriteLine(person.ToString());
            Console.WriteLine(person.age + person.name);
            Console.WriteLine(person.surname);
            Console.WriteLine(person.middle);
            //Выполните распаковку кортежа в переменные
            string name = person.name;
            //Сравните два кортежа
            (int age, string name) pers = (14/*y/o*/, "cockold");
            Console.WriteLine(Tuple.Equals(person, pers));
            /*Создайте локальную функцию в main и вызовите ее. Формальные параметры функции – массив 
            целых и строка.Функция должна вернуть кортеж, содержащий: 
            максимальный и минимальный элементы массива, сумму элементов
            массива и первую букву строки.*/
            int[] mass1 = { 1, 2, 3, 4, 0, 10 };
            (int, int, int, char) LocalFunction(int[] mass, string str5)
            {
                return (mass.Max(), mass.Min(), mass.Sum(), str5[0]);
            }
            var result = LocalFunction(mass1, HelloWorld);
            Console.WriteLine(result.ToString());
            Console.ReadLine();
            /*Определите две локальные функции. 
            Разместите в одной из них блок checked, в котором определите
            переменную типа int с максимальным возможным значением
            этого типа.Во второй функции определите блок unchecked с
            таким же содержимым.Вызовите две функции.Проанализируйте результат.*/
            int maxIntValue = 2147483647;
            int CheckedMethod()
            {
                int z = 0;
                try
                {
                    z = checked(maxIntValue + 10);
                }
                catch (System.OverflowException e)
                {
                    Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
                }

                return z;
            }

            int UncheckedMethod()
            {
                int z = 0;
                try
                {
                    z = maxIntValue + 10;
                }
                catch (System.OverflowException e)
                {
                    Console.WriteLine("UNCHECKED and CAUGHT:  " + e.ToString());
                }
                return z;
            }
            Console.WriteLine("\nCHECKED output value is: {0}",
                              CheckedMethod());
            Console.WriteLine("UNCHECKED output value is: {0}",
                              UncheckedMethod());

        }
    }
}
