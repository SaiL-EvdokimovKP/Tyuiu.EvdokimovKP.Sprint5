using Tyuiu.EvdokimovKP.Sprint5.Task7.V3.Lib;
using System.IO;
DataService ds = new DataService();
Console.WriteLine("****************************************************************************************************");
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:                                                                                    ");
Console.WriteLine("****************************************************************************************************");

string path = @"C:\Users\evdok\source\repos\Tyuiu.EvdokimovKP.Sprint5\DataSprint5\InPutDataFileTask7V3.txt";
string path2 = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V3.txt" });

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("****************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
Console.WriteLine("****************************************************************************************************");

path2 = ds.LoadDataAndSave(path);
Console.WriteLine(path2);
Console.ReadKey();