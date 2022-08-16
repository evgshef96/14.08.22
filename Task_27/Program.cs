// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

void DigitsSum (int number)
{
    int sum = 0;
    int remainder = 0;
    int firstNumber = 0;
    for(sum = 0; number >= 10; number /= 10)
    {
        remainder = number % 10;
        sum += remainder;
            if(number >= 10 && number <= 99)
            firstNumber = number / 10;
    }
    int digitsSum = firstNumber + sum;
    Console.WriteLine(digitsSum);
}



Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
DigitsSum(number);


