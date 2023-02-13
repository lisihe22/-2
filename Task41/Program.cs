
Console.Write("Введите колличество элементов: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
        count++; // count = count + 1;
}
Console.WriteLine($"Результат: {count}");