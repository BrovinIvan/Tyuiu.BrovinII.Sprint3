using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BrovinII.Sprint3.Task0.V24.Lib
{
    public class DataService : ISprint3Task0V24
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double val = 1;
            for (int i = startValue; i <= stopValue; i++) {
                double term = Math.Pow(3 / (i + Math.Pow(value, -i)), 2);
                val *= term;
            }
            return Math.Round(val,3);
        }
    }
}
