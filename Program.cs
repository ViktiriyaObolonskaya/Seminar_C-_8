


//----------Домашняя работа---------------

// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.


// Console.Write("Введите количество строк:");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов:");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// SortArray(array);
// Console.WriteLine();
// PrintArray(array);



// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.


// Console.Write("Введите количество строк:");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов:");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// Console.Write($"Строка с наименьшей суммой - {SumMinRow(array)}");


// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.


Console.Write("Введите количество строк 1 массива:");
int rowsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 1 массива:");
int columnsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк 2 массива:");
int rowsB = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 2 массива:");
int columnsB = int.Parse(Console.ReadLine()!);
if(columnsA != rowsB)
{
    Console.Write("Такие матрицы умножать нельзя.");
    return;
}


int[,] A = GetArray(rowsA, columnsA, 0, 10);
int[,] B = GetArray(rowsB, columnsB, 0, 10);

PrintArray(A);
Console.WriteLine();

PrintArray(B);
Console.WriteLine();

PrintArray(GetMatrix(A,B));


//------------Методы-----------

 int[,] GetArray(int n, int m, int min, int max)
{
    int[,] result = new int[n,m];
    for(int i = 0; i < n; i++){
        for(int j = 0; j < m; j++){
            result[i,j] = new Random().Next(min, max+1);
        }
    }
    return result;
}



void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]}");
        }
        Console.WriteLine();
    }
}


void SortArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int t = j + 1; t < array.GetLength(1); t++)
            {
                if(array[i,t] > array[i,j])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,t];
                    array[i,t] = temp;
                }
            }
        }
    }
         
}


int SumMinRow(int[,]array)
{
    int row = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum = minSum + array[0,i];
    }

    for(int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
         if(minSum > sum)
        {
            minSum = sum;
            row = i;
        }
    } 
    return row;
}


int[,] GetMatrix(int[,]arrayA, int[,]arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for(int i = 0; i < arrayA.GetLength(0); i++)
    {
       for (int j = 0; j < arrayB.GetLength(1); j++)
       {
        for (int k = 0; k < arrayA.GetLength(1); k++)
        {
            arrayC[i, j] +=arrayA[i, k] * arrayB[k, j];
        }
       } 
    }
    return arrayC;
}