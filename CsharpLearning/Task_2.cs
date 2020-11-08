using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Task_2
{
    public void Run()
    {
        Console.Write("Введите вес, кг: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите рост, см: ");
        double growth = Convert.ToInt32(Console.ReadLine()) / 100.0;

        double imt = weight / Math.Pow(growth, 2);


        Console.WriteLine($"индекс массы тела (ИМТ): {imt:N1}");

        Console.ReadKey();

    }
}