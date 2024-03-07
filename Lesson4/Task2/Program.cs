// Создать двумерный массив, состоящий из целых чисел. Вывести на экран "интересные"
// (интересные - числа сумма которых четная) элементы массива

int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

int[,] matrix = CreateMatrix(3, 4);

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

ShowMatrix(matrix);
//Console.WriteLine();

//Console.WriteLine(" => ");

foreach (int e in matrix)
{
    if (IsInteresting(e) == true)
    {
        Console.Write($" {e} ");
    }
}


bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);

    if (sumOfDigits % 2 == 0) return true;

    else return false;
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}


