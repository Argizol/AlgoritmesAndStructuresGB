using Lesson1;

var linklist = new MyLinkedList<int>();
linklist.Add(1);
linklist.Add(2);
linklist.Add(3);
linklist.Add(4);
linklist.Add(5);
foreach (int link in linklist) Console.WriteLine(link);

Console.WriteLine();

linklist.Reverse();

foreach (int link in linklist) Console.WriteLine(link);

Console.ReadLine();