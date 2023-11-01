using System.Globalization;

string[] strArr = new string[4] { "Hello", "2", "world", ":-)" };
int count = 0;
int Size (array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

