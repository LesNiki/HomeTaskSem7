// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// //m = 3, n = 4.
// //0,5 7 -2 -0,2
// //1 -3,3 8 -9,9
// //8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// double[,] matrix = new double[rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(-10,10); // от 0 до 10
//         matrix[i, j]=matrix[i, j]+new Random().NextDouble(); //прибавляем случайное от 0 до 1
//         matrix[i, j] = Math.Round(matrix[i, j], 1); // округляем до десятых, т.к. иначе много цифр после запятой
//         Console.Write(matrix[i, j] + "\t"); // выводим через знак табуляции, иначе матрица кривая
//     }
//     Console.WriteLine();
// }


// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// //Например, задан массив:
// //1 4 7 2
// //5 9 2 3
// //8 4 2 4
// //17 -> такого числа в массиве нет

// Console.WriteLine("Введите количество строк"); 
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] matrix = new int[rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(10);
        
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();
// Console.WriteLine("Введите номер строки искомого элемента");
// int rowsReceive = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца искомого элемента");
// int columnsReceive = Convert.ToInt32(Console.ReadLine());

// if (rowsReceive <= matrix.GetLength(0) && columnsReceive <= matrix.GetLength(1))
// {
//     Console.Write("Искомый элемент: ");
//     Console.WriteLine(matrix[rowsReceive - 1, columnsReceive - 1]);
// }
// else
// {
//     Console.WriteLine("Такого элемента нет");
// }

// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// //Например, задан массив:
// //1 4 7 2
// //5 9 2 3
// //8 4 2 4
// //Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double avrg = 0;
int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avrg += matrix[i, j];
    }
    avrg = avrg / matrix.GetLength(0);
    Console.Write($"Среднее арифметическое столбца {j+1}: ");
    Console.WriteLine(Math.Round((avrg),2));
    avrg = 0;
}