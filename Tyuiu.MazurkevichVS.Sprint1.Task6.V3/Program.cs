using Tyuiu.MazurkevichVS.Sprint1.Task6.V3.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #1 | Выполнила: Мазуркевич В. С. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Работа со строками класс String                                   *");
    Console.WriteLine("* Задание #6                                                              *");
    Console.WriteLine("* Вариант #3                                                              *");
    Console.WriteLine("* Выполнила: Мазуркевич Виктория Сергеевна | РППб-25-1                    *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
    Console.WriteLine("* Напечатать строку, составленную из последних литер всех слов.           *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
    Console.WriteLine("***************************************************************************");

    string value;
    value = Convert.ToString(Console.ReadLine());
    


    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    string res = ds.LastLetterWord(value);
    Console.WriteLine(res);
    Console.ReadLine();
}
