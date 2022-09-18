// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

Console.Write("Введите количество строк в массиве (больше 1):");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество стобцов в массиве (больше 1):");
int columns = int.Parse(Console.ReadLine()); 

int [,] array = FillArray(rows,columns, 1, 10);

PrintArray(array);

int minSumRows = 0;
int sum = SumRowsNumbers(array, 0);

for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = SumRowsNumbers(array, i);
  if (sum > temp)
  {
    sum = temp;
    minSumRows = i;
  }
}

Console.WriteLine($"Наименьшая сумма элементов ({sum}) в строке {minSumRows + 1}.");

int SumRowsNumbers(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
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