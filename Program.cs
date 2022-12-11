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

int GetNewArrayLength(string[] TextArray)
{
int count = 0;
for (int i = 0; i < TextArray.Length; i++)
{
    if(TextArray[i].Length<=3)
    {
        count++;
    }
}
return count;
}