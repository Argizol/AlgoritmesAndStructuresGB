using Lesson1;

int[] arr = new int[100];
//заполняем массив случайными числами
Random rd = new Random();
for (int i = 0; i < arr.Length; ++i)
{
    arr[i] = rd.Next(1, 101);
}

Console.WriteLine("The array before sorting:");

foreach (int x in arr)
{
    System.Console.Write($"{x} +  ");
}

//сортировка
Lesson2.PyramidSort(arr, arr.Length);

Console.WriteLine("\n\nThe array after sorting:");

foreach (int x in arr)
{
    Console.Write($"{x} +  ");
}
Console.WriteLine("\n\nPress any key to end programm");
Console.ReadKey(true);