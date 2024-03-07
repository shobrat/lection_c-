

int n = 10;
// int[] arr = new int[n];

int i = 0;

void FillArray(int[] arr)
{
    while (i < n)
    {
        arr[i] = i + 2;
        i++;
    }
}

void PrintArray(int[] arr)
{
    int i = 0;
    while (i < n)
    {
        Console.Write($"{arr[i]} ");
        i++;
    }

}

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
FillArray(array);
PrintArray(array);



// int sum = GetSumOfElements(int[] arr, int i, int sum);
// {
//     i = 0;
//     sum = 0;
//     while (i < n)
//     {
//         sum = sum + arr[i];
//     }

// }

// int product = GetProductOfElements(int[] arr, int i);
// {
//      i = 0;
//     product = 1;
//     while (i < n)
//     {
//         product = product + arr[i];
//     }  
// }

// Console.WriteLine(sum);