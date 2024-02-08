// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

string letter = "Hello!";
char[] CharArr(string word)
{
    char[] arr = new char[word.Length];
    for (int i = 0; i < word.Length; i++)
    {
        arr[i] = word[i];
    }
    return arr;
}

Console.WriteLine($"{string.Join(",",CharArr(letter))}");