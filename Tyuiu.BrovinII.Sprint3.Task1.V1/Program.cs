using Tyuiu.BrovinII.Sprint3.Task1.V1.Lib;

namespace Tyuiu.BrovinII.Sprint3.Task1.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Спринт 3");
            Console.WriteLine("Вариант 1");
            Console.WriteLine("Задание 1");
            Console.WriteLine("Выполнил Бровин Иван Ильич / ПКТБ-26-1");
            Console.WriteLine("Введите начало");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат: "+ds.GetMultiplySeries(x, y));

        }
    }
}
