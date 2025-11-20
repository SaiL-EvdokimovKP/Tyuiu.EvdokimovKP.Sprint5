using Tyuiu.EvdokimovKP.Sprint5.Task2.V19.Lib;
DataService ds = new DataService();
Console.WriteLine("********************************************************************");
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:                                                    ");
Console.WriteLine("********************************************************************");
int[,] matrix = new int[3, 3];

Console.WriteLine("Введите значения: ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Введите {i},{j} элементов массива: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine();
Console.WriteLine("\nМассив: ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine("********************************************************************");
Console.WriteLine("РЕЗУЛЬТАТ:                                                          ");
Console.WriteLine("********************************************************************");
string res = ds.SaveToFileTextData(matrix);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();