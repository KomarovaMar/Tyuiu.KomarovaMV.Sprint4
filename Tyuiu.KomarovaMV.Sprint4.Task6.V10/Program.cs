using Tyuiu.KomarovaMV.Sprint4.Task6.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт#4                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                           *");
        Console.WriteLine("* Задание #6                                                                 *");
        Console.WriteLine("* Вариант #10                                                                *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                    *");
        Console.WriteLine("*Дан строковый массив данных, используя класс Array, выведите элементы       *");
        Console.WriteLine("*массива, длина которых меньше 7 символов.                                   *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*                                                                            *");
        string[] i = { "Театр", "Кино", "Музей", "Парк", "Зоопарк", "Концерт", "Выставка" };
        for (int j = 0; j < i.Length; j++) { Console.Write($"{i[j]}\t"); } Console.WriteLine();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        string[] res=ds.Calculate(i);
        for (int j = 0;j < res.Length; j++) {Console.Write($"{res[j]}\t"); } Console.WriteLine();
    }
}