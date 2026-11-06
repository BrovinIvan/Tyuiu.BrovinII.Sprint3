using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BrovinII.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {
        public int ConvertStringToInt(string value)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in value) {
                if (char.IsDigit(c))
                {
                    sb.Append(c);
                }
            }
            return int.Parse(sb.ToString());
        }
    }
}
