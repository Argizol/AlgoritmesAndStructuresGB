int[] arr = new int[100];
//заполняем массив случайными числами
Random rd = new Random();
for (int i = 0; i < arr.Length; ++i)
{
    arr[i] = rd.Next(1, 101);
}
System.Console.WriteLine("The array before sorting:");
foreach (int x in arr)
{
    System.Console.Write(x + " ");
}
//сортировка
Algoritmes.Lesson2.PyramidSort(arr, arr.Length);

System.Console.WriteLine("\n\nThe array after sorting:");
foreach (int x in arr)
{
    System.Console.Write($"{x} +  ");
}
System.Console.WriteLine("\n\nPress the <Enter> key");
System.Console.ReadLine();