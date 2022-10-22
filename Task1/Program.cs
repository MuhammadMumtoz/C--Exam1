int FindMinimum(int a, int b, int c, int d)
{
    if(a<=b && a<=c && a<=d)
    {
        return a;
    }
    else if(b<=a && b<=c && b<=d)
    {
        return b;
    }
    else if(c<=a && c<=b && c<=d)
    {
        return c;
    }
    else if(d<=a && d<=b && d<=c)
    {
        return d;
    }
    else
    {
        return a;
    }
}
Console.WriteLine(FindMinimum(2, 2, 2, 2));