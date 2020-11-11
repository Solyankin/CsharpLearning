using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Lesson_2
{   static void Main()
    {
        Console.Write("Минимамальное число: ");
        Console.WriteLine(new Task_1().Min(0, -1, 1));
        Console.WriteLine();

        Console.WriteLine("Количество цифр в числе: ");
        Console.WriteLine(new Task_2().CountOfDigits(987654321));
        Console.WriteLine();

        new Task_3().Run();
        Console.WriteLine();

       
        new Task_4().Run();
        Console.WriteLine();
        
        new Task_5().Run();
        Console.WriteLine();

        Console.ReadKey();
       
    }
}