using System.Globalization;


int Size (string[] array)
{
    int count = 0;
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

string[] strArr = new string[4] { "Hello", "2", "world", ":-)" };
int count = Size(strArr);
string[] SelectArr = new string[count];
Selection(strArr, SelectArr);
PrintArray(SelectArr);
