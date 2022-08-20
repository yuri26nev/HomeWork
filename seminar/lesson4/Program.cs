// Начиная с этого семинара обязательно используем функции в решении!
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int extent (int A,int B)
{
    int rezalty = A;
    for (int i = 1; i < B ; i++)
    {        rezalty = rezalty*A;
       }
return rezalty;
 }

Console.WriteLine("Программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("Ввидите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bвидите число В");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат " + A + "^" + B + "="+ extent(A,B));

Console.WriteLine("Для продолжения нажми любую клавишу.");
Console.ReadKey();

Console.Clear();
Console.WriteLine("Программа принимает на вход число и выдаёт сумму цифр в числе.");
Console.Write("Введите число N: ");
int Data = Convert.ToInt32(Console.ReadLine());

int SumNumber(int Data)
{

    int counter = Convert.ToString(Data).Length;
    int calculation = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        calculation = Data - Data % 10;
        result = result + (Data - calculation);
        Data = Data / 10;
    }
    return result;
}

int sumNumber = SumNumber(Data);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

Console.WriteLine("Для продолжения нажми любую клавишу.");
Console.ReadKey();

Console.Clear();
Console.WriteLine("Привет, данная программа задаёт массив из 8 элементов, заполняет его случайными числами и выводит их на экран.");
Console.WriteLine("Для запуска программы нажми любую клавишу.");
Console.ReadKey();
int [] numbers = new int[8];
for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write("["+ Method (i) + "], ");
 }
int Method (int a)
{
    return numbers[a];
}
Console.ReadKey (); 