//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Console.WriteLine("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a nimber of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
int range = InputNumbers("Input diapazon from 1 to ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

Console.WriteLine($"array: ");
OrderArrayLines(array);
WriteArray(array);

void OrderArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            if (array[i, k] < array[i, k + 1])
            {
            int temp = array[i, k + 1];
            array[i, k + 1] = array[i, k];
            array[i, k] = temp;
            }
        }
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
*/
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
Console.WriteLine("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a nimber of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
int range = InputNumbers("Input diapazon from 1 to ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
Console.WriteLine($"{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");

int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i,j];
    }
    return sumLine;
}
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
*/

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int m = InputNumbers("Input a number of rows in first matrix: ");
int n = InputNumbers("Input number of columns in first matrix: ");
int k = InputNumbers("Input a number of rows in second matrix: ");
int p = InputNumbers("Input a number of columns in second matrix: ");
int range = InputNumbers("Input diapazon from 1 to ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"First matrix:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"Second matrix:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матрицы:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
        int sum = 0;
        for (int k = 0; k < firstMartrix.GetLength(1); k++)
        {
            sum += firstMartrix[i,k] * secomdMartrix[k,j];
        }
        resultMatrix[i,j] = sum;
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}
void WriteArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
*/
//Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
    sqareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
    else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
    else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
    else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
        {
        if (array[i,j] / 10 <= 0)
        Console.Write($" {array[i,j]} ");

        else Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}