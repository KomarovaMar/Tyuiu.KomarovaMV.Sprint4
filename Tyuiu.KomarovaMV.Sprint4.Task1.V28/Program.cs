using Tyuiu.KomarovaMV.Sprint4.Task1.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт#4                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                           *");
        Console.WriteLine("* Задание #1                                                                 *");
        Console.WriteLine("* Вариант #28                                                                *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                    *");
        Console.WriteLine("*Дан одномерный целочисленный массив на 10 элементов заполненный значениями  *");
        Console.WriteLine("*с клавиатуры в диапазоне от 2 до 6 подсчитать произведение нечетных         *");
        Console.WriteLine("элементов массива.                                                           *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*                                                                            *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("Введите длину массива:");
        int v = Convert.ToInt32(Console.ReadLine());
        int[] ints = new int[v];
        for (int i = 0; i < ints.Length; i++)
        {
            Console.WriteLine("Введите эллемент массива "+i+":");
            ints[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine(ds.Calculate(ints));
    }
}