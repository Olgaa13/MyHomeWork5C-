// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
//  максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// int size = 9;
Double[] solid = new double[9];
DoubMassif(solid);
PrintDoubMassif(solid);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Math.Round(MinMaxDiff(solid), 2)}");

void DoubMassif(double[] solid)
{
    Random rand = new Random();
    int leng = solid.Length;
    for (int i = 0; i < leng; i++)
    {
        solid[i] = rand.Next(-10, 11) + rand.NextDouble();
    }
}

double MinMaxDiff(double[] solid)
{
    double min = solid[0];
    double max = solid[0];
    double diff = 0;
    int leng = solid.Length;
    for (int i = 1; i < leng; i++)
    {
        if (solid[i] < min)
        {
            min = solid[i];
        }
        else if (solid[i] > max)
        {
            max = solid[i];
        }
    }
    
    { diff = max - min; }
    return diff;
}
void PrintDoubMassif(double[] solid)
{
    Console.Write("Массив [");
    int leng = solid.Length;
    for (int i = 0; i < leng; i++)
    {
        if (i < leng - 1)
            Console.Write(Math.Round(solid[i], 2) + ", ");
        else
            Console.Write(Math.Round(solid[i], 2));
    }
    Console.WriteLine("]");
}

