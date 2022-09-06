/*
Все задачи выполнить без циклов, исключительно с помощью рекурсии
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/
void Next()
{
    Console.WriteLine("\n Для продолжения нажми любую клавишу.");
    Console.ReadKey();
    Console.Clear();
}
Console.Clear();
Console.WriteLine("Ввидите числа N и M и Я покажу все натуральные числа от N до M");
Console.Write("Ввидите число N -->");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите число M -->");
int M = Convert.ToInt32(Console.ReadLine());
int module = 1;
if (N > M) { module = -1; }
Console.Write($"\nЧисла : {N}");
void Print(){
if (N != M)
{N = N + module;
    Console.Write($",{N}");
    Print();
}
}
Print();
Next();
Console.WriteLine("Ввидите числа N и M и Я найду сумму всех натуральных чисел от N до M");
Console.Write("Ввидите число N -->");
int NamberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите число M -->");
int namberTwo = Convert.ToInt32(Console.ReadLine());
int sum = NamberOne;
int moduleTwo = 1;
if (NamberOne > namberTwo) { moduleTwo = -1; }
Console.Write($"\nЧисла : {NamberOne}");
void PrintSum(){
if (NamberOne != namberTwo)
{NamberOne = NamberOne + moduleTwo;
sum = sum +NamberOne;
    Console.Write($",{NamberOne}");
    PrintSum();
}
}
PrintSum();
Console.WriteLine($"\nСумма число равна :{sum}");
Next();
int function(int m, int n)
{
    if (m < 0 || n < 0)
        throw new Exception("Неправильный ввод");
    if (m == 0)
        return n + 1;
    if ((m != 0) && (n == 0))
        return function(m - 1, 1);
    return function(m - 1, function(m, n - 1));
}
Console.WriteLine("Программа вычисления функции Аккермана с помощью рекурсии.");
Console.WriteLine($" при m=2,n=3 -> {function(2, 3)}"); 
Console.WriteLine($" при m=3,n=3 -> {function(3, 3)}"); 
Next();
