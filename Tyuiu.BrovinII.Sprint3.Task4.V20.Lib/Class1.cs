using System.Diagnostics.CodeAnalysis;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BrovinII.Sprint3.Task4.V20.Lib
{
    public class DataService : ISprint3Task4V20
    {
        public double Calculate(int startValue, int stopValue)
        {
            double p = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                if (Math.Abs(Math.Cos(i) - i) < 0.000001)
                {
                    continue;
                }
                double x = (double)i / (Math.Cos(i) - i) + 2.5;
                p *= x;
            }
            return Math.Round(p, 3);
        }
    }
}
