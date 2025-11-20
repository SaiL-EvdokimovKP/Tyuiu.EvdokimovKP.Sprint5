using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.EvdokimovKP.Sprint5.Task2.V19.Lib
{
    public class DataService : ISprint5Task2V19
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string combine = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            FileInfo fileinfo = new FileInfo(combine);
            bool fileExist = fileinfo.Exists;

            if (fileExist)
            {
                File.Delete(combine);
            }
            int[,] mtrx = new int[3, 3];

            int rows = matrix.GetUpperBound(0) + 1; /// строки кол-во
            int columns = matrix.GetUpperBound(1) + 1; /// столбцы кол-во
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1) /// если не последний столбец
                    {
                        str = str + matrix[i, j] + ";"; /// разделение значение с помощью " ; "
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }
                if (i != rows - 1) /// если не последняя строка
                {
                    File.AppendAllText(combine, str + Environment.NewLine); /// добавляем весь текст, если строка не последняя, ввести данные в новую строку
                }
                else 
                {
                    File.AppendAllText(combine, str);
                }
                str = ""; /// обнуляем переменную
            }
            return combine; /// возвращаем путь к файлу
        }
    }
}
