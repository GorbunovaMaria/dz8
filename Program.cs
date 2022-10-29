/* Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
/*
int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)   //cтроки/столбцы
{
    int[,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
    newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void Show2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)    //строки
    {
    for (int j = 0; j < array.GetLength(1); j++)   //столбцы
      {
      Console.Write (array [i,j] + " ");
      }
    Console.WriteLine();
    }
}

int [,] SortElements(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i, j] > array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
};

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray (m,n,min,max);
Show2DArray(myArray);
myArray = SortElements(myArray);
Console.WriteLine();
Show2DArray(myArray);*/

/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
/*
int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)   //cтроки/столбцы
{
    int[,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
    newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void Show2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)    //строки
    {
    for (int j = 0; j < array.GetLength(1); j++)   //столбцы
      {
      Console.Write (array [i,j] + " ");
      }
    Console.WriteLine();
    }
}

int ArrayRow (int[,] array)
{
    int minSum = 0;
    int minRow = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            temp = temp + array[i, j];
        }
        if (minSum > temp || i == 0)
        {
            minSum = temp;
            minRow = i;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов {minRow} строка");
    return minRow;
};

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray (m,n,min,max);
Show2DArray(myArray);
Console.WriteLine();
ArrayRow(myArray);*/

/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:*/

/*
int n = 4;
int[,] Matrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
  Matrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

void ShowArray (int[,] array)
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
ShowArray(Matrix);*/