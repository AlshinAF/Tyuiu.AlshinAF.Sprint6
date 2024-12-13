using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AlshinAF.Sprint6.Task6.V18.Lib
{
    public class DataService : ISprint6Task6V18
    {
        public string CollectTextFromFile(string path)
        {
            string str = "";
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(str) && line.Contains("n"))
                    {
                        resStr = resStr + " " + line;

                    }

                }

            }
            return resStr;
        }
    }
}
