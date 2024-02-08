// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

string str = "Hello!";

int CarrArr (string word)
{
    string vowels = "aeiouy";
    int a = 0;
    for (int i = 0; i < word.Length; i++)
    {
        if(vowels.Contains(word[i]))
            a++;
    }
return a;
}
Console.WriteLine(CarrArr(str));