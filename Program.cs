List <int> zahlen = new List<int>();

zahlen.Add(1);
zahlen.Add(2);
zahlen.Add(3);
zahlen.Add(4);


for (int i = 0; i < zahlen.Count; i++)
{
    Console.WriteLine($"Die Zahlen {i+1} + {i+1} ergeben {(i+1)+(i+1)}");

}
