using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RagozinaAD.Sprint3.Task6.V4.Lib
{
    public class DataService : ISprint3Task6V4
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int count = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                count += (Calculate(x));
            }
            return count;
        }
        public int Calculate(int x)
        {
            int count = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    if (i > 9)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}