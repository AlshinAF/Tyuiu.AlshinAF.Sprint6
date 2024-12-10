using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AlshinAF.Sprint6.Task3.V19.Lib
{
    public class DataService : ISprint6Task3V19
    {
        public int[,] Calculate(int[,] matrix)
        {
            var rows = Enumerable.Range(0, 5).Select(i => (row: i, value: matrix[i, 4])).ToArray();

            // Sort the tuples based on the 5th column values.
            Array.Sort(rows, (a, b) => a.value.CompareTo(b.value));

            // Create a new matrix with sorted rows.
            int[,] sortedMatrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sortedMatrix[i, j] = matrix[rows[i].row, j];
                }
            }

            return sortedMatrix;

        }
    }
}
