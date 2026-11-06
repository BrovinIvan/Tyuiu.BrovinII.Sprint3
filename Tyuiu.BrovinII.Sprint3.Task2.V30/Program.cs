using Tyuiu.BrovinII.Sprint3.Task2.V30.Lib;

namespace Tyuiu.BrovinII.Sprint3.Task2.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Спринт 3");
            Console.WriteLine("Вариант 30");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Выполнил Бровин Иван Ильич / ПКТБ-26-1");
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите начало");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат: " + ds.GetMultiplySeries(x, y, z));
        }
    }
}
