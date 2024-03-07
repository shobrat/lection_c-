
// string GetLettersFromString(string s)
// {
//     string letters = "";
//     foreach (char e in s)
//     {
//         if (char.IsAsciiLetter(e) == true)
//         {
//             letters = letters + e;
//         }
//     }
//     return letters;
// }

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

string str = Console.ReadLine();

string result = GetDigitsFromString(str);
Console.WriteLine(result);