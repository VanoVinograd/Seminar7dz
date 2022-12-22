// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите номер строки: ");
int x = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine()) - 1;

int line = 3;
int column = 4;

Random random = new Random();
int[,] arr = new int[line, column];
Console.WriteLine("Заданный массив: ");

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(-100, 99);
        Console.Write("{0} ", arr[i, j]);
    }

    Console.WriteLine();
}

if (x < 0 | x > arr.GetLength(0) - 1 | y < 0 | y > arr.GetLength(1) - 1)
{
    Console.WriteLine("Такой позиции в массиве нет  ");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[x, y]);
}
