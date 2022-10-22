Console.Write("Enter the length of array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
for (int i = 0; i < n; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
if (n % 2 == 0)
{
    for (int i = 0; i < n; i += 2)
    {
        int a;
        a = numbers[i];
        numbers[i] = numbers[i + 1];
        numbers[i + 1] = a;
    }
}
else
{
    for (int i = 0; i < n-1; i += 2)
    {
        int a;
        a = numbers[i];
        numbers[i] = numbers[i + 1];
        numbers[i + 1] = a;
    }
}

foreach (var item in numbers)
{
    System.Console.Write(item + " ");
}
