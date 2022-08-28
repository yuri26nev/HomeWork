/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Доп. задча: Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

Console.Clear();
Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine("0, 7, 8, -2, -2 -> 2");
Console.WriteLine("1, -7, 567, 89, 223-> 3");
Console.WriteLine("Для продолжения нажми любую клавишу.");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Введите числа в консоль, используя разделитель пробел или запятую. ");
Console.Write($"\n И я посчитаю сколько чисел больше 0 вы ввёли.\n --> ");
string InputText = Console.ReadLine(); // в переменную типа string записываем строку с пробелом или запятой в качестве разделителя
string[] Text = InputText.Split(' ', ','); // в созданный массив типа string используя матод split заполняем 
int Sum = 0;
for (int i = 0; i < Text.Length; i++)
{
    int Namber = Int16.Parse(Text[i]);
    if (Namber > 0) Sum++;
}
Console.WriteLine("Введено чисел больше 0: " + Sum);
Console.WriteLine("\n Для продолжения нажми любую клавишу.");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями \n y = k1 * x + b1, y = k2 * x + b2;\n значения b1, k1, b2 и k2 задаются пользователем. \n b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)");
Console.WriteLine("\n Для продолжения нажми любую клавишу.");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Уровнение для первой прямой y = k1 * x + b1");
Console.Write($"\nВведите коэффициент k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"\nВведите коэффициент b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Уровнение для второй прямой y = k2 * x + b2");
Console.Write($"\nВведите коэффициент k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"\nВведите коэффициент b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write($"\nТочка пересечения прямых: ({(b2-b1)/(k1-k2)};{(k1*(b2-b1))/(k1-k2)+b1})");