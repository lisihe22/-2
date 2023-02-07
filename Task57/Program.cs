
bool checkElement(int[] array, int number)
{
    foreach (int element in array)
    {
        if (number == element)
            return false;
    }
    return true;
}

int FillMatrix(int[,] matrix, int[] HelpArray)
{
  int k = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      int number = new Random().Next(1, 11);
      matrix[i, j] = number;
      if (checkElement(HelpArray, number) == true)
      {
        HelpArray[k] = number;
        k++;
      }
    }
  }
  return k;
}

void ScreenMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}

void ReleaseMatrix(int[,] matrix, int[] array, int count)
{
    for (int k = 0; k < count; k++)
    {
        int countUnieq = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (array[k] == matrix[i, j])
                    countUnieq++;
            }
        }
        Console.WriteLine($"Число {array[k]} встречается {countUnieq} раз");
    }
}

Console.Clear();
Console.Write("Ведите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[] HelpArray = new int[size[0] * size[1]];
int k = FillMatrix(matrix, HelpArray);
ScreenMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix, HelpArray, k);
