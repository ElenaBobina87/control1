using System.Globalization;

string[] strArr = new string[4] { "Hello", "2", "world", ":-)" };
int count = 0;
int Size (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] Selection(string[] array, string[] arrSelect)
{
     int count = 0;
     for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrSelect[count] = array[i];
            count++;
        }
    }
    return arrSelect;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}