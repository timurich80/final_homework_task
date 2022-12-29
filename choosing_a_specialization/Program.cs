string[] array = new string[4] { "hello", "2", "world", ":-)" };
string[] resultArray = new string[array.Length];
Func(array, resultArray);
PrintArray(resultArray);

void Func(string[] arr, string[] result)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[j] = arr[i];
            j++;
        }
    }
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}  ");
    }
}