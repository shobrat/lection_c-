// Считать с консоли строку, состоящую из цифр и латинских букв.
// Сформировать массив, состоящий из цифр этой строки.
// Пример abc123def06g => [1, 2, 3, 0, 6]
// Рекомендации: Разделить логику алгоритма на функции
// Память под массив выделять необходимого размера
// (не больше чем, количество элементов)


Console.WriteLine("Введите набор из цифр и латинских букв");
string numletters = Console.ReadLine();


static char[] StringToCharArray(string str)
{
    char[] charsArray = new char[str.Length];

    for (int i = 0; i < charsArray.Length; i++)
    {
        charsArray[i] = str[i];
    }
    return charsArray;
}

void PrintArray(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

string GetDigitsFromString(string s)
{
    string numbers = "";
    foreach (char e in s)
    {
        if (char.IsAsciiDigit(e) == true)
        {
            numbers = numbers + e;
        }
    }
    return numbers;
}

string digits = GetDigitsFromString(numletters);
string digits2 = digits;

char[] chars = StringToCharArray(digits2);
PrintArray(chars);