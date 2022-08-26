var set = new int[] { 15, 12, -6, 8, -9, 12, 0 };
Console.WriteLine($"До сортировки");
foreach (int n in set)
    Console.Write(n + " ");
int temp = 0;
int perest = 0;
for (int j = 0; j <= set.Length - 2; j++)
{
    for (int i = 0; i <= set.Length - 2; i++)
    {
        if (set[i] > set[i + 1])
        {
            perest++;

            temp = set[i + 1];
            set[i + 1] = set[i];
            set[i] = temp;
        }
    }
}

Console.WriteLine();
Console.WriteLine("Сортировка по возрастанию:");
foreach (int n in set)
    Console.Write(n + " ");
Console.WriteLine();
Console.Write("Операций по обмену элементов выполнено: " + perest);
int per = 0;
for (int j = 0; j <= set.Length - 2; j++)
{
    for (int i = 0; i <= set.Length - 2; i++)
    {
        if (set[i] < set[i + 1])
        {
            per++;

            temp = set[i + 1];
            set[i + 1] = set[i];
            set[i] = temp;
        }
    }
}
Console.WriteLine();
Console.WriteLine("Сортировка по убыванию:");
foreach (int n in set)
    Console.Write(n + " ");
Console.WriteLine();
Console.Write("Операций по обмену элементов выполнено: " + per);