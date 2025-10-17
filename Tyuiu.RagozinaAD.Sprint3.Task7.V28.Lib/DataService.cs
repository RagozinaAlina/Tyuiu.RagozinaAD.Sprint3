using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RagozinaAD.Sprint3.Task7.V28.Lib
{
    public class DataService : ISprint3Task7V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            double y;
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) 
                { 
                    valueArray[c++]=0; continue; 
                }
                y = (Math.Cos(2 * x) + (Math.Sin(x) / (x + 2.5)) + 2 * x);
                valueArray[c++] = Math.Round(y, 2);
            }
            return valueArray;
        }
    }
}

