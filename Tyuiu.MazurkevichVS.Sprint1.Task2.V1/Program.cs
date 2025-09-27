using Tyuiu.MazurkevichVS.Sprint1.Task2.V1.Lib;

{
    DataService ds = new DataService();
    Console.Title = "Спринт #1 | Выполнила: Мазуркевич В. С. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
    Console.WriteLine("* Задание #2                                                              *");
    Console.WriteLine("* Вариант #1                                                              *");
    Console.WriteLine("* Выполнила: Мазуркевич Виктория Сергеевна | РППб-25-1                    *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
    Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
    Console.WriteLine("***************************************************************************");

    int x;
    Console.WriteLine("Введите значение для X:");
    x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    double rounded_x = Math.Round(ds.ConvertKmToM(x), 3);
    Console.WriteLine(rounded_x);

    Console.ReadLine();
}