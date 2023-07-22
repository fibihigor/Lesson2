/* Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Пример:
645 -> 5
78 -> третьей цифры нет
326743297 -> 6
*/

Console.Write("Введите число: ");
string number = Console.ReadLine();

char[] numberArray = number.ToCharArray();
if (numberArray.Length >= 3)
{
    Console.Write($"{number} -> {numberArray[2]}");
}
else
{
    Console.Write($"{number} -> третьей цифры нет");
}
