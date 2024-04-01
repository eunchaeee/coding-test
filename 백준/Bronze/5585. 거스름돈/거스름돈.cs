int change = 1000 - int.Parse(Console.ReadLine());
int[] coinSet = new int[] { 500, 100, 50, 10, 5, 1 };
int count = 0;
for (int i = 0; i < coinSet.Length; i++)
{
    count += change / coinSet[i];
    change %= coinSet[i];
}
Console.WriteLine(count);