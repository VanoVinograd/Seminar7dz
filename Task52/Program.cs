// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите колличество строк: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int[,] arrInt = new int[ num1, num2 ];

var random = new Random();

for (int i = 0; i < arrInt.GetLength(0); i++)
{
    for (int j = 0; j < arrInt.GetLength(1); j++)
    {
        arrInt[i, j] = random.Next(0, 100);
        Console.Write($"{arrInt[i, j]} ");
    }
    Console.WriteLine();
}

Console.Write("Среднее арифметическое каждого столбца: ");
Console.WriteLine();

for (int j = 0; j < arrInt.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arrInt.GetLength(0); i++)
    {
        sum += arrInt[i, j];
    }
    Console.Write($"{sum / arrInt.GetLength(0)}  ");
}
