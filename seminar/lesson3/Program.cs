// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CheckingNumber(string number)
    {
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
    }

double Distance(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
                }
void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}
void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 1;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 



Console.Clear();
Console.WriteLine("Задача 19");
Console.WriteLine("Напишите програму, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine();
Console.WriteLine("Задача 21");
Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine();
Console.WriteLine("Задача 23");
Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.WriteLine();
Console.WriteLine("Введите номер задачи" );
int namber = int.Parse(Console.ReadLine()); 
Console.Clear();
if ( namber == 19 || namber==23 || namber == 21)
{
switch (namber)
{
    case 19:
    Console.WriteLine("Задача 19");
    Console.WriteLine(" Введите пятизначное число и я проверю является ли оно палиндромом.");
    string namberTask19 = (Console.ReadLine());
    if (namberTask19.Length == 5){
  CheckingNumber(namberTask19);
}
else Console.WriteLine("Введино не пятизначное число");

    break;
    case 21:
    Console.WriteLine("Задача 21");
    int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}
    double segmentLength =  Math.Round (Distance(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");

    break;
    case 23:
    Console.WriteLine("Задача 23");
    Console.Write("Введите число и я покажу таблицу кубов этого чисел ");
int cube = Convert.ToInt32(Console.ReadLine());
int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
    break;
}
}
else
{
Console.WriteLine("Вы ввели не правельное число");
}





// Console.ReadKey();
// Console.Clear(); // Clear
// Console.WriteLine("Введите число.");
// Console.ReadLine();

