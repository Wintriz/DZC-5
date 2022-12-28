// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = new int[10];
int odd = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int i = 1; i < array.Length; i += 2)
{
    odd = odd + array[i];

}
Console.Write("Сумма элементов на нечетных позициях: ");
Console.Write(odd);


