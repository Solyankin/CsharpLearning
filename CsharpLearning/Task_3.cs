using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Task_3
{
    public void Run()
    {
        Console.WriteLine("Введите координаты первой точки");

        Console.Write("x: ");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("y: ");
        int y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координаты второй точки");

        Console.Write("x: ");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("y: ");
        int y2 = Convert.ToInt32(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($"Растояние между двумя точками: {distance:N}");

        Console.ReadKey();
    } 
}
