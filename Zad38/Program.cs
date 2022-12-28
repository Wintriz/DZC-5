// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[5];
double max = 0;
double min = 0;
double diff = 0;
for (int i = 0; i < array.Length; i++)
{

    array[i] = new Random().Next(1, 101);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];


    }
    min = array[i];
    if (array[i] < min)
    {
        min = array[i];



    }


}
Console.Write("Максимальное число: ");
Console.WriteLine(max);
Console.Write("Минимальное число: ");
Console.WriteLine(min);
diff = max - min;
Console.Write("Разница между числами: ");
Console.WriteLine(diff);