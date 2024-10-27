using Tyuiu.KomarovaMV.Sprint4.Task7.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт#4                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                           *");
        Console.WriteLine("* Задание #7                                                                 *");
        Console.WriteLine("* Вариант #20                                                                *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                    *");
        Console.WriteLine("*Дана строка из одноразрядных цифр \"357951248632587\". Преобразуйте ее в      *");
        Console.WriteLine("*матрицу 5 на 3 и подсчитайте произведение четных чисел.                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*                                                                            *");
        string x = "357951248632587";
       
        int n = 5;
        int m = 3;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{int.Parse(x.Substring(i*m+j, 1))}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine(ds.Calculate(n, m,x));
    } 
}