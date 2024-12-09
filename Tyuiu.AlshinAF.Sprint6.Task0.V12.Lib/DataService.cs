using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AlshinAF.Sprint6.Task0.V12.Lib
{
    public class DataService : ISprint6Task0V12
    {
        public double Calculate(int x)
        {
            
            double res = Math.Round((x * x + 1) / (Math.Sqrt(4 * x * x - 3)));
            return res;
        }
    }
}
