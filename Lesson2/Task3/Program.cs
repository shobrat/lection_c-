int n = 10;
int[] array = {2, -3, 4, -5, 6, 7, 3, 9, 1, -2};
int i = 0;

while (i < n)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;

}