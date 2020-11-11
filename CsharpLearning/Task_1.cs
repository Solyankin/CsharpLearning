using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Написать метод, возвращающий минимальное из трех чисел.
 * Солянкин Антон
 * 
*/

class Task_1
{

    public int Min(int a, int b, int c)
    {    
        return Math.Min(Math.Min(a, b), c);
    }

}
