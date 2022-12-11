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

string [] CreateArrayOfShortString (string[] TextArray, int count)
{
int newcount = 0;
string[] ArrayofShortString = new string [count];
for (int i = 0; i < TextArray.Length; i++)
{
    if(TextArray[i].Length<=3)
    {
        ArrayofShortString[newcount] = TextArray[i];
        newcount++;
    }
}
return ArrayofShortString;
}

void PrintArray(string[] TextArray)
{
foreach (var item in TextArray)
{
    Console.Write(item + " ");
}
}

Console.Write("Введите количество элементов:\t ");
int arrayLenght = int.Parse(Console.ReadLine()??"0");
string[] ArrayofString = GetTextFromUser(arrayLenght);
int newArrayLength = GetNewArrayLength(ArrayofString);
string [] newArray = CreateArrayOfShortString(TextArray: ArrayofString,count: newArrayLength);

Console.Write("Получился вот такой массив строк: ");
PrintArray(ArrayofString);
Console.WriteLine();
Console.WriteLine("Массив строк с количеством элементов <=3: ");
PrintArray(newArray);