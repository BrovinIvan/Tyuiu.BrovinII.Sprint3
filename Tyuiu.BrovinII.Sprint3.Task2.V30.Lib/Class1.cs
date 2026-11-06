using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BrovinII.Sprint3.Task2.V30.Lib
{
    public class DataService : ISprint3Task2V30
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double p = 1;
            do
            {
                p *= ((value * value) * startValue) + 2.0;
                startValue++;
            }while (startValue <= stopValue);
            return Math.Round(p, 3);
        }
    }
}
