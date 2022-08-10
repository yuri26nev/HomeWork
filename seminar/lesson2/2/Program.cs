// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// 
// интересная штука tabnine, воспользуюсь им для закрепления англиского и поробую писать коменты на англиском.

Console.Clear(); // Clear screen
Console.WriteLine("Введите число, и я поробую угадать третью цифру этого число");     // print string "input namber" 
string namberText = Convert.ToString(Console.ReadLine());  // input namber in console and convert to string tape
// check number for hundredths
if (namberText.Length > 2)
{
    Console.WriteLine("Введенном вами числе " + namberText + " ,третья цифра это -> " + namberText[2]);
}
else
{
    Console.WriteLine("Введенном вами числе " + namberText + " ,третьей цифры нет ");
}

