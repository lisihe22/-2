
void FillMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 11);
    }
  }
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

void ReleaseMatrix(int[,] matrix)
{
  int min = matrix[0, 0];
  int minIndexI = 0;
  int minIndexJ = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
     if (matrix[i, j] < min)
     {
      min = matrix[i, j];
      minIndexI = i;
      minIndexJ = j;
     }
    }
  } 
  Console.WriteLine($"min = {min}; [{minIndexI}, {minIndexJ}]");

  
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    if (i != minIndexI)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j != minIndexJ)
                Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
  }
}

Console.Clear();
Console.Write("Ведите размеры массива: ");
int [] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[ , ] matrix = new int[size[0], size[1]];
FillMatrix(matrix);
ScreenMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);