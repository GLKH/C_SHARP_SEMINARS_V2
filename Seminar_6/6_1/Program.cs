// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание:
// Конструктор строки вида string(char []) не использовать.
// Пример:
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

char[] chars = new char[] { 'a', 'b', 'c', 'd' };
string result = " ";
foreach (char i in chars)
{
    result = result + i;
}
Console.WriteLine(result);
