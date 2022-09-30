﻿using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: "); // вывод на экран строки с просьбой пользователя ввести своё имя.
            string name = Console.ReadLine(); // присвоение лок.переменной "name" ,с указанным ранее именем,строковый тип "string".
            Console.Write("Введите возраст: "); // вывод на экран строки с просьбой пользователя ввести свой возраст.
            int age = Convert.ToInt32(Console.ReadLine()); // присвоение лок.переменной "age" ,с указанным ранее возрастом, целый тип "int".
            Console.Write("Введите рост: "); // вывод на экран строки с просьбой пользователя ввести свой рост.
            double height = Convert.ToDouble(Console.ReadLine()); // присвоение лок.переменной "height", с указанным ранее ростом, вещественный тип "double".
            Console.Write("Введите размер зарплаты: "); // вывод на экран строки с просьбой пользователя ввести размер зарплаты.
            decimal salary = Convert.ToDecimal(Console.ReadLine()); // присвоение лок.переменной "salary", с указанным ранее размером зарплаты, финансовый тип "decimal".
            Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height} м Зарплата: {salary}$"); // вывод на экран имени, возраста, роста и зарплаты с указанными выше данными.
            Console.ReadKey(); // ожидание нажатия пользователем любой клавиши для закрытия консоли.
        }
    }
}