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
int extent (int A,int B){
    int rezalty = A;
    for (int i = 1; i < B ; i++)
    {        rezalty = rezalty*A;
    Console.WriteLine(i+"="+rezalty);
    }
return rezalty;
 }

Console.WriteLine("input namber A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input namber B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат " + A + "^" + B + "="+ extent(A,B));

