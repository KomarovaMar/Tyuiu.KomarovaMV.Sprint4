using Tyuiu.KomarovaMV.Sprint4.Task3.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Random rnd = new Random();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт#4                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                           *");
        Console.WriteLine("* Задание #3                                                                 *");
        Console.WriteLine("* Вариант #22                                                                *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                    *");
        Console.WriteLine("*Дан двумерный целочисленный массив 5 на 5 элементов, заполненный            *");
        Console.WriteLine("*статическими значениями в диапазоне от 4 до 9. Найдите максимальный элемент *");
        Console.WriteLine(" в первой строке массива                                                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*                                                                            *");
        Console.WriteLine("******************************************************************************");
        int[,] x = new int[,] { { 4, 4, 7, 8, 9 }, { 9, 5, 9, 7, 8 }, { 7, 4, 9, 4, 6 }, { 4, 4, 7, 4, 4 }, { 4, 5, 8, 6, 7 } };
        int rows = x.GetUpperBound(0) + 1;
        int cols = x.Length / rows;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{ x[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine(ds.Calculate(x));

    }
}