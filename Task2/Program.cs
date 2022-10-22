Console.Write("How many names to add: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] names = new string[n];
for(int i=0; i<names.Length; i++)
{
    Console.Write($"Enter name {i+1}: ");
    names[i] = Console.ReadLine();
}
System.Console.WriteLine("Names in array are:");
foreach(var item in names)
{
    Console.WriteLine(item);
}
