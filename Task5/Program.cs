Console.Write("Enter the length of array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
for (int i = 0; i < n; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

var min = numbers[0];
int start = 0;
for (int i = 0; i < n; i++)
{
    if (min > numbers[i])
    {
        min = numbers[i]; start = i;
    }
}

// System.Console.WriteLine(min);
// System.Console.WriteLine(start);

var max = numbers[0];
int end = 0;
for (int i = 0; i < n; i++)
{
    if (max < numbers[i])
    {
        max = numbers[i]; end = i;
    }
}

// System.Console.WriteLine(max);
// System.Console.WriteLine(end);
if (start <= end)
{
    for(int i=start; i<=end; i++)
    {
        Console.Write(numbers[i]+" ");
    }
}
else
{
    for(int i=end; i<=start; i++)
    {
        Console.Write(numbers[i]+" ");
    }
}