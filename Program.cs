// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double[,] CreateRandArr()
{
    Console.Write("Input a quantity of rows (m): ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of colums (n): ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minVal: ");
    double minVal = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input a maxVal: ");
    double maxVal = Convert.ToDouble(Console.ReadLine());

    double[,] arr = new double[rows, colums];

    Random random = new Random();

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
        {
            double matrix = minVal + random.NextDouble() * (maxVal - minVal);
            arr[i, j] = Math.Round(matrix, 2);
        }
    return arr;
}
void PrintArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + " ");

        Console.WriteLine();
    }
}
double[,] arr = CreateRandArr();
PrintArr(arr);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// (1; 7) -> такого числа в массиве нет
/*
int[,] CreateRandArr()
{
    Console.WriteLine();
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minVal: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maxVal: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] arr = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            arr[i, j] = new Random().Next(minVal, maxVal + 1);
    return arr;
}
void WriteArr(int[,] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}
void GetCoordinate(int[,] arr)
{
    Console.WriteLine();
    Console.Write("Input the thirst coordinate: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the second coordinate: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a >= 0 && a < arr.GetLength(0) && b >= 0 && b < arr.GetLength(1))
    {
        int elem = arr[a, b];
        Console.Write($"({a},{b}) -> {elem}");
    }
    else Console.Write($"({a},{b}) -> An element was not found at the given coordinates :(");
    Console.WriteLine();

}
int[,] arr = CreateRandArr();
WriteArr(arr);
GetCoordinate(arr);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
int[,] CreateArr()
{
    Console.WriteLine();
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    int[,] arr = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write($"your element on possition {i + 1}x{j + 1}: ");
            arr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return arr;
}

void WriteArr(int[,] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

void getSum(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        double average = Math.Round(sum / arr.GetLength(0), 2);
        Console.WriteLine($"AVG of colomn {j + 1}: {average}");
            //другое оформление ответа
            //     if (j != 0)
            //     {
            //         result += "; ";
            //     }
            //     result += average.ToString();
            // }

            // Console.WriteLine($"AVG of each coloms: {result});
        
    }
}
int[,] arr = CreateArr();
WriteArr(arr);
getSum(arr);

*/