using Tyuiu.MazurkevichVS.Sprint1.Task4.V14.Lib;

{
    DataService ds = new DataService();
    Console.Title = "Спринт #1 | Выполнила: Мазуркевич В. С. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Class Math                                                        *");
    Console.WriteLine("* Задание #4                                                              *");
    Console.WriteLine("* Вариант #14                                                             *");
    Console.WriteLine("* Выполнила: Мазуркевич Виктория Сергеевна | РППб-25-1                    *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
    Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
    Console.WriteLine("***************************************************************************");

    double x;
    double y;

    Console.WriteLine("Введите значение для X:");
    x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение для Y:");
    y = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    double res = ds.Calculate(x, y);
    Console.WriteLine(res);
    Console.ReadLine();
}
