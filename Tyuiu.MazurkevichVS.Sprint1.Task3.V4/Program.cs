using Tyuiu.MazurkevichVS.Sprint1.Task3.V4.Lib;

{
    DataService ds = new DataService();
    Console.Title = "Спринт #1 | Выполнила: Мазуркевич В. С. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
    Console.WriteLine("* Задание #3                                                              *");
    Console.WriteLine("* Вариант #4                                                              *");
    Console.WriteLine("* Выполнила: Мазуркевич Виктория Сергеевна | РППб-25-1                    *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу вычисления стоимости покупки, состоящей из           *");
    Console.WriteLine("* нескольких тетрадей и такого же количества обложек к ним.               *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
    Console.WriteLine("***************************************************************************");
    double priceNotebook = 2.75;
    double priceCover = 0.5;
    int quantity;
    Console.WriteLine("Введите количество комплектов:");
    quantity = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    double res = ds.PurchaseAmount(priceNotebook, priceCover, quantity);
    double rounded_res = Math.Round(res, 3);
    Console.WriteLine("Стоимость покупки: " + rounded_res);
    Console.ReadLine();
}
