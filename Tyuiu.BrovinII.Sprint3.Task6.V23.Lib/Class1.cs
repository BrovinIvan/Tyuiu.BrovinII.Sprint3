using System.Diagnostics.CodeAnalysis;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BrovinII.Sprint3.Task4.V20.Lib
{
    public class DataService : ISprint3Task6V23
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int c = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
            }
            return c;
        }
    }
}
