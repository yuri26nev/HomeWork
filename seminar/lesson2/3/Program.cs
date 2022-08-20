// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear(); // Clear the console 
Console.WriteLine("Введите цифру  обозначающую день недели от 1 до 7 и я покажу является этот день выходным ");
int namber = Convert.ToInt32(Console.ReadLine());
// create an array with the day
string[] day = { "Понедельнику", "Вторнику", "Среде", "Четвергу", "Пятнице", "Субботе", "Воскресенью" };
// namber check for conditions 
if (namber > 0 && namber < 8)
{
    if (namber == 6 || namber == 7)
    {
        Console.WriteLine("Веденное вами число " + namber + " соответствует " + day[namber - 1] + ". Это выходной");
    }
    else Console.WriteLine(" Веденное вами число  " + namber + " соответствует " + day[namber - 1] + ". Это рабочий день");
}
else
{
    Console.WriteLine("Введенное вами число " + namber + " не соответствует условию ввода.");
}