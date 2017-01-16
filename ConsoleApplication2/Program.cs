using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] x)
        {
            int k; //переменная для учета простоты числа. если 1 то число не простое если 0 то оно по умалчанию простое
            for (int j = 0; j < x.Length; j++) //пробегаемся по всей строке, находя числа
            {
                k = 0; 
                for (int i = 2; i < int.Parse(x[j]); i++) //пробегаемся от 2 до числа меньше искомого на 1
                {
                    if (int.Parse(x[j]) % i == 0) { k = 1; } //если наше число делится на числа меньше него самого без остатка, то оно не простое
                }
                if (k == 0) { Console.WriteLine(x[j]);} //если делится на всех меньше себя с остатком, то оно простое, выводим на консоль
              
            }
        }
    }
}
