using Tyuiu.BrovinII.Sprint3.Task3.V13.Lib;

namespace Tyuiu.BrovinII.Sprint3.Task2.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Спринт 3");
            Console.WriteLine("Вариант 13");
            Console.WriteLine("Задание 3");
            Console.WriteLine("Выполнил Бровин Иван Ильич / ПКТБ-26-1");
            Console.WriteLine("Введите строку");
            string x = Console.ReadLine();
            Console.WriteLine("Результат: " + ds.ConvertStringToInt(x));
        }
    }
}
