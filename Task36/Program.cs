// Задача 36: Задайте одномерный массив, заполненный случайными
//  числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arrr = new int[6];
Random rdm = new Random();
for (int i = 0; i < arrr.Length; i++)
{
    arrr[i] = rdm.Next(-10, 101);
}

int sum = 0;
for (int i = 1; i < arrr.Length; i += 2)
{
    sum = sum + arrr[i];
}
Console.Write("[ ");
for (int i = 0; i < arrr.Length; i++)
{
    if (i < arrr.Length - 1)

        Console.Write(arrr[i] + ", ");
    else
    {
        Console.Write(arrr[i]);
    }
}

Console.WriteLine(" ]");
Console.WriteLine();
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum);