// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int[] array)
{
    Random rnd = new Random();
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

int NumberOfEven(int[] massif)
{
    int count = 0;
    int lenMas = massif.Length;
    for (int i = 0; i < lenMas; i++)
    {
        if (massif[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
        if (i < array.Length - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i]);
    Console.WriteLine(" ]");
}

int[] array = new int[7];
FillArray(array);
PrintArray(FillArray(array));
Console.WriteLine("Количество четных чисел в массиве: " + NumberOfEven(array));

