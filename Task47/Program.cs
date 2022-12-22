// Задача 47: Задайте двумерный массив размером m x n,
// заполненый случайными вещественными числами.

Console.WriteLine("Введите колличество строк: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int num2 = Convert.ToInt32(Console.ReadLine());

double[,] arrDouble = new double[ num1, num2 ];

Random random = new Random();

for (int i = 0; i < arrDouble.GetLength(0); i++)
{
    for (int j = 0; j < arrDouble.GetLength(1); j++)
    {
        arrDouble[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        Console.Write(arrDouble[i, j] + " ");
    }
    Console.WriteLine();
}
