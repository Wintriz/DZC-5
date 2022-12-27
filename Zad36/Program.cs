// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = new int[4];
// int odd = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 11);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 1)
    {
        // odd = odd + array[i];
        Console.Write(array[i] + " ");
    }

}

// Console.Write("Сумма элементов на нечетных позициях: ");

