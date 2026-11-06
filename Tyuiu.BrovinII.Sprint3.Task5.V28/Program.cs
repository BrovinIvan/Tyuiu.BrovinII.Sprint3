using Tyuiu.BrovinII.Sprint3.Task4.V20.Lib;

namespace Tyuiu.BrovinII.Sprint3.Task4.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Спринт 3");
            Console.WriteLine("Вариант 28");
            Console.WriteLine("Задание 5");
            Console.WriteLine("Выполнил Бровин Иван Ильич / ПКТБ-26-1");
            Console.WriteLine("Введите x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите начало");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите начало 2");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец 2");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат: " + ds.GetSumSumSeries(x, y,z,d,a));
        }
    }
}
