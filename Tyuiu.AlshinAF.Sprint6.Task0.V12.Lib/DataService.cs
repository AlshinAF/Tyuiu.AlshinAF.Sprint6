using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AlshinAF.Sprint6.Task0.V12.Lib
{
    public class DataService : ISprint6Task0V12
    {
        public double Calculate(int x)
        {
            double y = x;
            double res = Math.Round((y * y + 1) / (Math.Sqrt(4 * y * y - 3)), 3);
            return res;
        }
    }
}
