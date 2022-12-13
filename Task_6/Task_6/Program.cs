int m = int.Parse(Console.ReadLine());
int[] array = new int[m];
int k = 0;
for (int i = 0; i < m; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] > 0)
    {
        k++;
    }
}
Console.WriteLine();
Console.WriteLine(k);