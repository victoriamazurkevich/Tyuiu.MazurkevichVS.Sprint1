﻿using Tyuiu.MazurkevichVS.Sprint1.Task1.V17.Lib;

{
    DataService ds = new DataService();
    Console.Title = "Спринт #1 | Выполнила: Мазуркевич В. С. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                *");
    Console.WriteLine("* Задание #1                                                              *");
    Console.WriteLine("* Вариант #17                                                             *");
    Console.WriteLine("* Выполнила: Мазуркевич Виктория Сергеевна | РППб-25-1                    *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
    Console.WriteLine("* вычисляет результат по формуле x*y*(5-x) и печатает его на экране.      *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
    Console.WriteLine("***************************************************************************");

    double x, y;

    Console.WriteLine("Введите значение Х:");
    x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение Y:");
    y = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine(ds.Calculate(x, y));

    Console.ReadLine();
}