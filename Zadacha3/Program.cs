/* Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.*/

Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int []array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 1000);
}
Print(array, size);

void Print(int[] array, int size)
{
    int i = 0;
    while (i < size)
    {
        Console.Write(array[i] + " ");
        i++;
    }
}

