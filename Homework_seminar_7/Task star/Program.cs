// Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.
// III -> 3
// LVIII -> 58
// MCMXCIV -> 1994

Dictionary<char, int> romanNumbersDictionary = new()
{
    { 'I', 1 },
    { 'V', 5 },
    { 'X', 10 },
    { 'L', 50 },
    { 'C', 100 },
    { 'D', 500 },
    { 'M', 1000 }
};

int ConvertRomanToArabic(string roman)
{
    int sum = 0;
    for (int i = 0; i < roman.Length; i++)
    {
        char currentRomanChar = roman[i];
        romanNumbersDictionary.TryGetValue(currentRomanChar, out int num);
        if (i + 1 < roman.Length && romanNumbersDictionary[roman[i + 1]] > romanNumbersDictionary[currentRomanChar])
        {
            sum -= num;
        }
        else
        {
            sum += num;
        }
    }
    return sum;
}

Console.WriteLine("Введите число римскими цифрами: ");
string roman = Console.ReadLine();

int arabic = ConvertRomanToArabic(roman);
Console.WriteLine($"{arabic}");