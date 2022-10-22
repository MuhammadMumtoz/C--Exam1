System.Console.Write("Enter the power for 2: ");
var N = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(N);
int sum = 1;
int power = 1;
for (int i = 1; i <= N; i++)
{
    power *= 2;
    sum = sum + power;
}
// System.Console.WriteLine(power);
System.Console.WriteLine($"The sum of the first {N} power of 2 is {sum}");

