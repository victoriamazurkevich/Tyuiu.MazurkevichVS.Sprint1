﻿using Tyuiu.MazurkevichVS.Sprint1.Task0.V10.Lib;

{
    DataService ds = new DataService();
    Console.Title = "Спринт #1 | Выполнила: Мазуркевич В. С. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
    Console.WriteLine("* Задание #0                                                              *");
    Console.WriteLine("* Вариант #10                                                             *");
    Console.WriteLine("* Выполнила: Мазуркевич Виктория Сергеевна | РППб-25-1                    *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, вычисляющую выражение (3 / 6 - 4) * 3               *");
    Console.WriteLine("* и печатает результат на экране.                                         *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* (3 / 6 - 4) * 3                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine(ds.Calculate());

    Console.ReadLine();
}