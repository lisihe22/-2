   
    void CalcNum(int m)
{
    int n = 0;
    int count = 0;
        for (int i = 1; i <= m; i++)
    {
            Console.Write($"Введите число {i}: ");
            n = Convert.ToInt32(Console.ReadLine());
        if (n == 0)
            count++;
    }
            Console.Write($" \n Количество чисел равных 0: {count} ");
}
    Console.Write($"Введите количество чисел: ");
    int n = Convert.ToInt32(Console.ReadLine());
CalcNum(n);