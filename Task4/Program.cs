// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

Console.Write("Введите размерность массива : ");

Console.WriteLine();

Console.Write("A : ");
int a = int.Parse(Console.ReadLine());
Console.Write("B : ");
int b = int.Parse(Console.ReadLine());
Console.Write("C : ");
int c = int.Parse(Console.ReadLine());

int [,,] array = new int [a, b, c];
FillArray(array);
PrintArray(array);

void FillArray (int [,,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0;
  for (int a = 0; a < array.GetLength(0); a++)
  {
    for (int b = 0; b < array.GetLength(1); b++)
    {
      for (int c = 0; c < array.GetLength(2); c++)
      {
        array[a, b, c] = temp[count];
        count++;
      }
    }
  }
}

void PrintArray(int [,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
             for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write( $"{array[i,j,k]}({i},{j},{k}); ");
            }
            Console.WriteLine();
        }
    }
}