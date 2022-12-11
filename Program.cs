string [] GetTextFromUser (int length)
{
string[] array = new string [length];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i+1} элемент массива: ");
    array[i] = (Console.ReadLine()??"0");
}
return array;
}