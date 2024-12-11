using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AlshinAF.Sprint6.Task4.V19.Lib
{
    public class DataService : ISprint6Task4V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len]; //создаём массив с указанной длиной
            double y;
            int count = 0; //индекс массива
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Sin(x)-2) == 0)
                {
                    y = 0;
                    valueArray[count] = y; //присваиваем значение в массив с индексом count
                    count++;
                }
                else
                {
                    y = Math.Round((5*x+2.5) / (Math.Sin(x) - 2) +2, 2);
                    valueArray[count] = y; //присваиваем значение в массив с индексом count
                    count++;
                }
            }
            return valueArray;
        }
    }
}
