
        void FillArray(int[] array)
{
             for (int i = 0; i < array.Length; i++)
                 array[i] = new Random().Next(-100, 101); // [-100, 100]
}

        void ReleaseArray(int[] array)
{
        int sum = 0;
             for (int i = 0; i < array.Length; i++)
    {
                if (i % 2 != 0)
                     sum = sum + array[i];
    }
        Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
FillArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);
