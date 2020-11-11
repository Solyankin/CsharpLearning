using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * С клавиатуры вводятся числа, пока не будет введен 0. 
 * Подсчитать сумму всех нечетных положительных чисел.
 * Солянкин Антон
 * 
*/
class Task_3
{
    public void Run()
    {
        Console.WriteLine("Подсчет суммы всех нечетных положительных чисел");

        decimal num = GetNum();
        decimal sum = 0;

        while (num != 0)
        {
            if(num > 0 && num % 2 == 0)
            {
                sum += num;
            }
            num = GetNum();
        }

        Console.WriteLine($"Сумма всех нечетных положительных чисел равна {sum}");
    }

    decimal GetNum()
    {
        Console.Write("Введите число: ");
        return Convert.ToDecimal(Console.ReadLine());
    } 
}