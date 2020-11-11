using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Реализовать метод проверки логина и пароля. 
 * На вход подается логин и пароль. 
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу: 
 * пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
 * Солянкин Антон
 * 
*/
class Task_4
{
    public void Run()
    {
        byte atemptsCount = 3;

        string correctLogin = "root";
        string correctPassword = "GeekBrains";

        bool success = false;

        for(int i = 0; i < atemptsCount; i++)
        {
            Console.WriteLine($"Попытка {i + 1}");

            string login = Ask("Введите логин");
            string password = Ask("Введите пароль");

            success = login == correctLogin && password == correctPassword;

            if(success)
            {
                Console.WriteLine($"Поздравляю, вы прошли аутентификацию!");
                break;
            }
        }

        if (!success)
        {
            Console.WriteLine($"Количество попыток исчерпано");
        }
    } 

    string Ask(string message)
    {
        Console.Write($"{message}: ");
        return Console.ReadLine();
    }
}