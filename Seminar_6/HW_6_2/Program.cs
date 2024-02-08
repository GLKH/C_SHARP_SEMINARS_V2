// Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные
// Пример
// “aBcD1ef!-” => “abcd1ef!-”


string str = "aBcD1ef!-";
Console.WriteLine(str.ToLower());



// Решение от школы:

// public static void Main(string[] args)
// {
// // Входная строка со смешанными буквами обоих регистровstring input = "aBcD1ef!-";
// // Преобразование всех заглавных букв в строчные
// string result = input.ToLower();
// // Вывод результата
// Console.WriteLine(result);
// }