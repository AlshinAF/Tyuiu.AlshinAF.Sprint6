using System.ComponentModel.DataAnnotations;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AlshinAF.Sprint6.Task5.V30.Lib
{
    public class DataService : ISprint6Task5V30
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)

        {
            
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }

            }
            double[] numsArray = new double[len];
            int index = 0;
            using (StreamWriter reader = new StreamWriter(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }

            }
            numsArray = numsArray.Where(va1 => va1 >= 2 && va1 <= 7).ToArray();
            return numsArray;

        }
    }
}
