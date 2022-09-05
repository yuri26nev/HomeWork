/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
void WriteArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillingArrayRnd(int[,]Array)
{
   for (int i = 0; i < Array.GetLength(0); i++)
  {
    for (int j = 0; j < Array.GetLength(1); j++)
    {
      Array[i, j] = new Random().Next(10);
    }
  }
}

void sortingArray(int[,] array)
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

void Next()
{
    Console.WriteLine("\n Для продолжения нажми любую клавишу.");
    Console.ReadKey();
    Console.Clear();
}
Console.Clear();
Console.WriteLine("Программа создает двухмерный массивю.\nЗаполняет его случайными вещественными числами.\nПосле заполнения упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.Write("Введите число N и будет создан массив [N,N]-->");
int namber = Convert.ToInt16(Console.ReadLine());
int[,] MyArray = new int[namber, namber];
FillingArrayRnd(MyArray);
WriteArray(MyArray);
Console.WriteLine ("\n Отсортированный массив");
sortingArray(MyArray);
WriteArray(MyArray);
Next();

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с
наименьшей суммой элементов: 1 строка
*/
Console.WriteLine("Программа создает двухмерный массивю.\nЗаполняет его случайными вещественными числами.\nПосле находить строку с наименьшей суммой элементов.");
Console.Write("Введите число N и будет создан массив [N,N]-->");
int n = Convert.ToInt16(Console.ReadLine());
int[,] NewArray = new int[n, n];
FillingArrayRnd(NewArray);
WriteArray(NewArray);
int minSumLine = 0;
int sumLine = SumLineElements(NewArray, 0);
for (int i = 1; i < NewArray.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(NewArray, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\nCтрокa {minSumLine+1} -  с наименьшей суммой элементов ");


int SumLineElements(int[,] NewArray, int i)
{
  int sumLine = NewArray[i,0];
  for (int j = 1; j < NewArray.GetLength(1); j++)
  {
    sumLine += NewArray[i,j];
  }
  return sumLine;
}
Next();
/*----------------------------------------------------------------
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Write("Введите число N и будет созданы два массива [N,N]-->");
int p = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Первый массив выглядит так:");
int[,] FirstMassive  = new int[p, p];
FillingArrayRnd(FirstMassive);
WriteArray(FirstMassive);
Console.WriteLine("Второй массив выглядит так:");
int[,] SecondMassive = new int[p, p];
FillingArrayRnd(SecondMassive);
WriteArray(SecondMassive);

int[,] MultiplicationMassive = new int[p,p];

MultiplyMatrix(FirstMassive, SecondMassive,MultiplicationMassive);
Console.WriteLine($"\nПроизведение первого и второго массива:");
WriteArray(MultiplicationMassive);

void MultiplyMatrix(int[,] FirstMassive, int[,] SecondMassive, int[,] MultiplicationMassive)
{
  for (int i = 0; i < MultiplicationMassive.GetLength(0); i++)
  {
    for (int j = 0; j <MultiplicationMassive.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < FirstMassive.GetLength(1); k++)
      {
        sum += FirstMassive[i,k] * SecondMassive[k,j];
      }
      MultiplicationMassive[i,j] = sum;
    }
  }
}
Next();
Console.WriteLine("Программа создаст трехмерный массив из неповторяющихся двухзначных чисел.\nИ выводит массив на экран с индексом каждого элемента.");
Console.WriteLine("\n Для продолжения нажми любую клавишу.");
Console.ReadKey();
int[,,] massiv= new int [2,2,2];

  int[] temp = new int[massiv.GetLength(0) * massiv.GetLength(1) * massiv.GetLength(2)];
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
  for (int x = 0; x < massiv.GetLength(0); x++)
  {
    for (int y = 0; y < massiv.GetLength(1); y++)
    {
      for (int z = 0; z < massiv.GetLength(2); z++)
      {
        massiv[x, y, z] = temp[count];
        count++;
      }
    }
  }

 for (int i = 0; i < massiv.GetLength(0); i++)
  {
    for (int j = 0; j < massiv.GetLength(1); j++)
    {


      for (int k = 0; k < massiv.GetLength(2); k++)
      {
        Console.Write( $"{massiv[i,j,k]}({i},{j},{k}); ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
  Next();