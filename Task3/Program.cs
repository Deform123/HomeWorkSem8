// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

Console.Write("количество строк в первой матрице : ");
int a = int.Parse(Console.ReadLine());

Console.Write("количество столбцов в первой матрице и строк во второй: ");
int b = int.Parse(Console.ReadLine());

Console.Write("количество столбцов во второй матрице : ");
int c = int.Parse(Console.ReadLine());

int [,] array = FillArray(a, b, 1, 10);
Console.WriteLine("Первая матрица : ");
PrintArray(array);

int [,] array2 = FillArray(b, c, 1, 10);
Console.WriteLine("Вторая матрица : ");
PrintArray(array2);

int[,] resultArray = new int[a,c];

ProductArray(array, array2, resultArray);
Console.WriteLine("Произведение первой и второй матриц : ");
PrintArray(resultArray);

void ProductArray(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        sum += firstArray[i,k] * secondArray[k,j];
      }
      resultArray[i,j] = sum;
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

void PrintArray(int [,] filledArray){
    for(int i = 0; i < filledArray.GetLength(0); i++)
    {
        for(int j = 0; j < filledArray.GetLength(0); j++)
        {
            Console.Write(filledArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}
