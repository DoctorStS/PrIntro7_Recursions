int length = 10;
int [] nums = RandomCharGen(length);
PrintArray(nums);
PrintReversedArray(nums, length-1);

//Генерация случайного массива
int[] RandomCharGen (int length)
{
    int [] array = new int [length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}
/// Нормальная печать
void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
    Console.WriteLine();
}
/// Извращение печати массива
void PrintReversedArray(int[] arr, int j)
{
    if (j >= 0)
    {
        Console.Write($"{arr[j]} ");
        PrintReversedArray(arr, --j);
    }
}