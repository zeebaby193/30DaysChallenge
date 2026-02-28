
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}


for (int r = 5; r <= 50; r += 5)
{
    Console.WriteLine(r);
}

for (int l = 5; l > 0; l--)
{
    Console.WriteLine(l);
}

for (int m = 50; m >= 5; m = m - 5)
{
    Console.WriteLine(m);
}

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= 12; i++)
{
    Console.WriteLine(number * i);
}

