using System.Diagnostics.CodeAnalysis;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BrovinII.Sprint3.Task4.V20.Lib
{
    public class DataService : ISprint3Task5V28
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double y = 0;
            for (int i = startValue1; i <= stopValue1; i++) {
                for (int j = startValue2; j <= stopValue2; j++) {
                    y += Math.Pow(j, x) / Math.Sin(j);
                }
            }
            return Math.Round(y,3);
        }
    }
}
