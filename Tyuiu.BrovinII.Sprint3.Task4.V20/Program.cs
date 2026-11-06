using Tyuiu.BrovinII.Sprint3.Task4.V20.Lib;

namespace Tyuiu.BrovinII.Sprint3.Task4.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Спринт 3");
            Console.WriteLine("Вариант 20");
            Console.WriteLine("Задание 4");
            Console.WriteLine("Выполнил Бровин Иван Ильич / ПКТБ-26-1");
            Console.WriteLine("Введите начало");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат: " + ds.Calculate(x, y));
        }
    }
}
