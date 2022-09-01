/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void Next()
{
    Console.WriteLine("\n Для продолжения нажми любую клавишу.");
    Console.ReadKey();
    Console.Clear();
}

Console.Clear();
Console.WriteLine("Задайте двухмерный массив размером M*N \nи Я заполню его случайными вещественными числами.");
Console.Write("Введите число М:");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[M, N];
void CreateArrayDouble(double[,] array)
{

    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
            array[i, j] = Math.Round(array[i, j], 2);
            Console.Write($" " + array[i, j]);
        }
        Console.WriteLine("");
    }
}

CreateArrayDouble(array);
Next();

/*
Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы этого 
элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
Console.WriteLine("Привет, ввидете число от 0 до 9 и Я найду индекс этого числа \nв массиве заполненным случайными числами \n");
Console.Write("Ведите число -> ");
int namber = int.Parse(Console.ReadLine());
int[,] MyArray = new int[5, 5];
bool test = true;
string conclusion = ($"Число {namber} не найдено в массиве");
void FillingArrayRnd(){
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        MyArray[i, j] = new Random().Next(0, 10);
        Console.Write($" " + MyArray[i, j]);
        test = true;

    }
    Console.WriteLine("");

}
}
FillingArrayRnd();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (MyArray[i, j] == namber)
        {
            conclusion = ($"Число {namber} находится в массиве по адресу [{i + 1},{j + 1}]  ");
            Console.WriteLine(conclusion);
            test= false;
        }
    }
}
if (test == true) { Console.WriteLine(conclusion); }
Next();

Console.WriteLine("Программа создает двумерный массив из целых случайных чисел. \nИ найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine("Массив из целых случайных чисел :");
FillingArrayRnd();
Console.Write("Среднее арифметическое каждого столбца: ");
double summa = 0;
for (int j = 0; j < 5; j++)
{
    for (int i = 0; i < 5; i++)
    {
        summa = summa + MyArray[i,j];

    }
    Console.Write(Math.Round(summa,2)/5+"; ");

}
Next();
