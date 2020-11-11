using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Написать метод подсчета количества цифр числа.
 * Солянкин Антон
 * 
*/
class Task_2
{
    public int CountOfDigits(int num)
    {
        return $"{Math.Abs(num)}".Length;
    }

}