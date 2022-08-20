/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Clear();
Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.\n [345, 897, 568, 234] -> 2.");
Console.WriteLine("\n Введите число которое определит размер массива:");
int Size = Convert.ToUInt16(Console.ReadLine());

int[] FillingArrayRnd(int ArraySize, int MinRnd, int MaxRnd) // заполняет массив случайными числами 
{
    int[] Array = new int[ArraySize];
    for (int i = 0; i < ArraySize; i++)
    {
        Array[i] = new Random().Next(MinRnd, MaxRnd);
    }
    return Array;

}
int[] MyArray = FillingArrayRnd(Size, 100, 999);
Console.WriteLine($"\n Массив созданный по вашиму условию выглядит так: \n  {string.Join(" ", MyArray)}");
Console.WriteLine("Количество четных чисел равна " + SumEvenNumber(MyArray));
int SumEvenNumber(int[] Array)
{
    int Sum = 0;

    for (int i = 0; i < Array.Length; i++)
        if (Array[i] % 2 == 0)
        {
            Sum++;
        }
    return Sum;
}

Console.WriteLine("\n Для продолжения нажми любую клавишу.");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. \n[3, 7, 23, 12] -> 19 \n[-4, -6, 89, 6] -> 0");
Console.WriteLine("\nВведите число которое определит размер массива:");
int Size2 = Convert.ToUInt16(Console.ReadLine());

int[] MyMassiv = FillingArrayRnd(Size2, -100, 100);
Console.WriteLine($"\n Массив созданный по вашиму условию выглядит так: \n  {string.Join(" ", MyMassiv)}");
int SumMassiv = 0;
for (int i = 0; i <Size2; i = i + 2)
{
    SumMassiv = SumMassiv + MyMassiv[i] ;
}
Console.WriteLine(" Сумма четных чисел равна:" + SumMassiv);
Console.WriteLine("\n Для продолжения нажми любую клавишу.");
Console.ReadKey();

Console.Clear();
Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. \n [3 7 22 2 78] -> 76");
Console.WriteLine("\nВведите число которое определит размер массива:");
int Size3 = Convert.ToUInt16(Console.ReadLine());
int[] Array_3 = FillingArrayRnd(Size3, -100, 100);
Console.WriteLine($"\n Массив созданный по вашиму условию выглядит так: \n  {string.Join(" ", Array_3)}");
int Min = Array_3[0];
int Max = Array_3[0];
for (int i = 1; i < Size3; i++)
{
    if (Array_3[i] < Min)
    {
        Min = Array_3[i];
    }
    if (Array_3[i] > Max)
    {
        Max = Array_3[i];
    }
}
Console.WriteLine("Разница между максимальным и минимальным равна:" + (Max - Min));

