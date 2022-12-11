// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void PrintArray(string[] strArray)
{
    for (int i = 0; i < strArray.Length; i++)
    {
        if (i > 0) Console.Write($", ");

        Console.Write($"\"{strArray[i]}\"");
    }

    Console.WriteLine();
}

string[] GetArrayOf3OrLessSimbols(string[] strArray)
{
    string temp = string.Empty;

    for (int i = 0; i < strArray.Length; i++)
    {
        if (strArray[i].Length <= 3)
        {
            if (!string.IsNullOrEmpty(temp)) temp += "<separator>";

            temp += strArray[i];
        }
    }

    if (string.IsNullOrEmpty(temp))
    {
        return null;
    }
    else
    {
        return temp.Split("<separator>");
    }
}

Console.Clear();

//string[] initialArray = new string[] { "hello", "2", "world", ":-)" };
//string[] initialArray = new string[] { "1234", "1567", "-2", "computer science" };
string[] initialArray = new string[] { "Russia", "Denmark", "Kazan" };

Console.WriteLine("Initial array:");
PrintArray(initialArray);

Console.WriteLine();

Console.WriteLine("Result array:");
string[] resulArray = GetArrayOf3OrLessSimbols(initialArray);

if (resulArray is null)
{
    Console.WriteLine("The array does NOT contain elements with number of symbols less or equal 3");
}
else
{
    PrintArray(resulArray);
}