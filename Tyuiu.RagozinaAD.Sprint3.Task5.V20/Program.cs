using Tyuiu.RagozinaAD.Sprint3.Task5.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнила: Рагозина А.Д | АСОиУБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнила: Рагозина А.Д | АСОиУБ-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Написать программу,                                                     *");
        Console.WriteLine("* которая вычисляет произведение ряда по формуле, при х=5                 *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДВННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 5;
        int startValue1 = 1;
        int startValue2 = 1;
        int stopValue1 = 3;
        int stopValue2 = 6;

        Console.WriteLine("Переменная x = " + x);
        Console.WriteLine("Старт шага первой суммы ряда = " + startValue1);
        Console.WriteLine("Конец шага первой суммы ряда= " + stopValue1);
        Console.WriteLine("Старт шага второй суммы ряда = " + startValue2);
        Console.WriteLine("Конец шага второй суммы ряда= " + stopValue2);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
        Console.ReadKey();

    }
}

