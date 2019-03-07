using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOD_via_Rekursia
{
    class Program
    {
        static void Main()
        {
            /*Написать рекурсивный алгоритм нахождения наибольшего общего делителя двух чисел.

        Начальные данные: два натуральных числа на двух строчках
        Вывод результата: одно число - наибольший общий делитель данных чисел*/


            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());
            Console.WriteLine(NOD(num1, num2));
        }

        static long NOD(long num1, long num2)
        {
            if (num1 < num2 && num2 % num1 == 0)
                return num1;
            if (num2 < num1 && num1 % num2 == 0)
                return num2;
            return (num1 > num2) ? NOD(num1 % num2, num2) : NOD(num2 % num1, num1);

        }
    }
}
