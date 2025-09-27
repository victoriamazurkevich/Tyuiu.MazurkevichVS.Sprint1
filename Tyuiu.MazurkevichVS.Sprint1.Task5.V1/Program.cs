using Tyuiu.MazurkevichVS.Sprint1.Task5.V1.Lib;

{
    DataService ds = new DataService();
    Console.Title = "Спринт #1 | Выполнила: Мазуркевич В. С. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
    Console.WriteLine("* Задание #5                                                              *");
    Console.WriteLine("* Вариант #1                                                              *");
    Console.WriteLine("* Выполнила: Мазуркевич Виктория Сергеевна | РППб-25-1                    *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая решает следующую задачу: Найти расстояние   *");
    Console.WriteLine("* между двумя точками с заданными координатами (x, y).                    *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
    Console.WriteLine("***************************************************************************");

    double x1;
    double y1;
    double x2;
    double y2;

    Console.WriteLine("Введите значение для X1:");
    x1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение для Y1:");
    y1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение для X2:");
    x2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение для Y2:");
    y2 = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    double res = ds.DistanceBetweenDots(x1, y1, x2, y2);
    Console.WriteLine(res);
    Console.ReadLine();
}
