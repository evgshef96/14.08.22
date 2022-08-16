// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

void PoweredNumber(int number, int power)
{
   int count = 0;
   int poweredNumber = 1;
   for(count = 0; count < power; count++)
   {
      poweredNumber *= number;
   }
   Console.WriteLine(poweredNumber);
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень: ");
int power = int.Parse(Console.ReadLine()!);
PoweredNumber(number,power);