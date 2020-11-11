using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы 
 * и сообщает, нужно ли человеку похудеть, набрать вес или все в норме
 * Солянкин Антон
 * 
*/
class Task_5
{

    public void Run()
    {
        double imt = Imt();
        Console.WriteLine($"Индекс массы тела (ИМТ): {imt}");

        if(imt < 18.5)
        {
            Console.Write("Вам следует набрать вес");
        } else if (imt >= 25)
        {
            Console.Write("Вам следует похудеть");
        } else
        {
            Console.Write("Ваш вес в норме");
        }
    }

    double Imt()
    {
        Console.Write("Введите вес, кг: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите рост, см: ");
        double growth = Convert.ToInt32(Console.ReadLine()) / 100.0;

        return weight / Math.Pow(growth, 2);

    }
}