// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();

Console.Write("количество строк в массиве : ");
int rows = int.Parse(Console.ReadLine());

Console.Write("количество столбцов в массиве : ");
int columns = int.Parse(Console.ReadLine());

int [,] array = FillArray(rows,columns, 1, 10);

Console.WriteLine("Базовый массив : ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Измененный массив : ");
ChangeArray(array);
PrintArray(array);

void ChangeArray(int[,] filledArray)
{
  for (int i = 0; i < filledArray.GetLength(0); i++)
  {
      for (int j = 0; j < filledArray.GetLength(1); j++)
    {
       for (int count = 0; count < filledArray.GetLength(1) - 1; count++)
      {
        if (array[i, count] < array[i, count + 1])
        {
          int temp = array[i, count + 1];
          array[i, count + 1] = array[i, count];
          array[i, count] = temp;
        }
    }
  }
}
}


int [,] FillArray(int rows, int columns, int min, int max)
{
    int [,] array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++){
            array[i,j] = new Random().Next(min,max + 1);
        }
    return array;
}

void PrintArray(int [,] filledArray)
{
    for(int i = 0; i < filledArray.GetLength(0); i++)
    {
        for(int j = 0; j < filledArray.GetLength(0); j++)
        {
            Console.Write(filledArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}