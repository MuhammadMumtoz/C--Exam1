Console.Write("Enter the length of array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
for (int i = 0; i < n; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
int counter=1;
for (int i = 0; i < n-1; i++)
{
    if (numbers[i] != numbers[i + 1])
    {
        counter++;
    }
}

System.Console.WriteLine(counter);