using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AlshinAF.Sprint6.Task3.V19.Lib
{
    public class DataService : ISprint6Task3V19
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] fifthColumn = new int[5];
            for (int i = 0; i < 5; i++)
            {
                fifthColumn[i] = matrix[i, 4];
            }

            // Sort the fifth column
            Array.Sort(fifthColumn);

            // Update the fifth column in the matrix
            for (int i = 0; i < 5; i++)
            {
                matrix[i, 4] = fifthColumn[i];
            }

            return matrix;

        }
    }
}
