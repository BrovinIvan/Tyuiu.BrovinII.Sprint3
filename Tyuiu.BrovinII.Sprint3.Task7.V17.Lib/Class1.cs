using System.Diagnostics.CodeAnalysis;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BrovinII.Sprint3.Task4.V20.Lib
{
    public class DataService : ISprint3Task7V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            if ((stopValue-startValue+1)<=0) return new double[0];
            double[] result = new double[stopValue-startValue+1];
            int i = 0;
            for (int x = startValue; x <= stopValue; x++) {
                if (x == (-1.7))
                {
                    result[i] = 0;
                }
                else {
                    double y = (Math.Sin(x) / (x + 1.7)) - (Math.Cos(x) * 4 * x) - 6;
                    result[i] = Math.Round(y,2);
                }
                i++;
            }
            return result;
        }
    }
}
