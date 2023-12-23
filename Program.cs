
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] initialArray = { "Hello", "2", "76", "world", ":-)" };
string[] filteredArray = FilterStrings(initialArray);

for (int i = 0; i < filteredArray.Length; i++)
{
    Console.Write(filteredArray[i]);

    if (i < filteredArray.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine(); 


string[] FilterStrings(string[] arr)
{
    int count = 0;

    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j].Length <= 3)
        {
            count++;
        }
    }

    string[] result = new string[count];
    int index = 0;

    for (int k = 0; k < arr.Length; k++)
    {
        if (arr[k].Length <= 3)
        {
            result[index] = arr[k];
            index++;
        }
    }

    return result;
}

