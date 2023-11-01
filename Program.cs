using System.Globalization;

string[] strArr = new string[4] { "Hello", "2", "world", ":-)" };
int count = 0;
int Size (array)
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

string[] Selection(array, arrSelect)
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
}