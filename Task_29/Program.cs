// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();


int[] RandomNumbersArray(int size)
{
    int[] numbersArray = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        numbersArray[i] = rnd.Next();
    } 
    return numbersArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int size = 8;
int[] array = RandomNumbersArray(size);
PrintArray(array);
