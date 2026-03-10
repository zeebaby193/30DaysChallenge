

static int MyMethod(int x)
{
    return 5 + x;
}
Console.WriteLine(MyMethod(3));

static int MiMethod(int x, int y)
{
    return x + y;
}
int z = MiMethod(5, 3);
Console.WriteLine(z);

static int Square(int number)
{
    return number * number;
}
Console.WriteLine(Square(5));

static int Add(int a, int b)
{
    return a + b;
}
Console.WriteLine("Sum is " + Add(5, 3));


static int FindMax(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
Console.WriteLine(FindMax(10, 7));

static bool IsEven(int number)
{
    return number % 2 == 0;
}
Console.WriteLine(IsEven(8));
