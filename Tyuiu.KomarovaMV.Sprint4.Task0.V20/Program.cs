using Tyuiu.KomarovaMV.Sprint4.Task0.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт#4                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                           *");
        Console.WriteLine("* Задание #0                                                                 *");
        Console.WriteLine("* Вариант #20                                                                *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                    *");
        Console.WriteLine("*Дан одномерный целочисленный массив на 10 элементов заполненный статическими*");
        Console.WriteLine("* значениями в диапазоне от 0 до 9 подсчитать произведение четных элементов  *");
        Console.WriteLine(" массива.                                                                    *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*                                                                            *");
        Console.WriteLine("******************************************************************************");
        int[] m = new int[] { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
        for (int i = 0; i < m.Length; i++) { Console.WriteLine(m[i]); }
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine(ds.GetMultEvenArrEl(m));
    }
}