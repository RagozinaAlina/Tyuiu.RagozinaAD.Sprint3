using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RagozinaAD.Sprint3.Task3.V12.Lib
{
    public class DataService : ISprint3Task3V12
    {
        public int GetMaxCharCount(string value, char item)
        {
            int maxCount = 0;
            int count = 0;

            foreach (char c in value)
            {
                if (c == item)
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                    count = 0;
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
            }

            return maxCount;
        }
    }
}