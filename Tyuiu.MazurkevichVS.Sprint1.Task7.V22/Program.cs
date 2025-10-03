using Tyuiu.MazurkevichVS.Sprint1.Task7.V22.Lib;

DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("*                                                                         *");
Console.WriteLine("*                 ctg(x)                                                  *");
Console.WriteLine("* z = (1 - tan(x))        + cos(x - y)                                    *");
Console.WriteLine("*                                                                         *");

double x;
double y;

Console.WriteLine("Введите значение для Х");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение для Y");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double z = Math.Round(ds.Calculate(x, y), 3);
Console.WriteLine(z);
Console.ReadLine();
