using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Task_1
{
    public void Run()
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите фамилию: ");
        string sirname = Console.ReadLine();

        Console.Write("Введите возраст: ");
        byte age = Convert.ToByte(Console.ReadLine());

        Console.Write("Введите рост, см: ");
        byte height = Convert.ToByte(Console.ReadLine());

        Console.Write("Введите вес, кг: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Вывод с помощью конкатенации
        Console.WriteLine(
            "Имя: " + name + ", " + 
            "Фамилия: " + sirname + ", " +
            "Возраст: " + age + ", " +
            "Рост: " + height + ", " +
            "Вес: " + weight);

        // Форматированный вывод
        Console.WriteLine("Имя: {0:G}, Фамилия: {1:G}, Возраст: {2:G}, Рост: {3:G}, Вес: {4:G}", 
            name, sirname, age, height, weight);

        // Вывод со знаком $
        Console.WriteLine($"Имя: {name}, Фамилия: {sirname}, Возраст: {age}, Рост: {height}, Вес: {weight}");

        Console.ReadKey();
    }
}