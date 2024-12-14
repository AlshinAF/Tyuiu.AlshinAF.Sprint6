using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AlshinAF.Sprint6.Task7.V1.Lib
{
    public class DataService : ISprint6Task7V1
    {
        public int[,] GetMatrix(string path)
        {
            // Считываем строки из файла
            var lines = File.ReadAllLines(path);
            // Создаем матрицу, основываясь на количестве строк и столбцов
            int rows = lines.Length;
            int cols = lines[0].Split(',').Length;
            int[,] matrix = new int[rows, cols];

            // Заполняем матрицу и изменяем значения второго столбца
            for (int i = 0; i < rows; i++)
            {
                var values = lines[i].Split(',');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                    // Если это второй столбец и значение отрицательное, заменяем на 1
                    if (j == 1 && matrix[i, j] < 0)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }

            return matrix;


        }
    }
}
